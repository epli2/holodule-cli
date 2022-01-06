module Parser

open FSharp.Data

let private getLink (node: HtmlNode) : string =
    match node.TryGetAttribute("href") with
    | Some (a) -> a.Value()
    | _ -> ""

let private getName (node: HtmlNode) : string =
    node.Descendants [ "div" ]
    |> Seq.find (fun x ->
        match x.TryGetAttribute("class") with
        | Some (x) -> x.Value().Contains("name")
        | _ -> false)
    |> HtmlNode.innerText
    |> fun x -> x.Replace(" ", "")

let private getStartTime (node: HtmlNode) : string =
    node.Descendants [ "div" ]
    |> Seq.find (fun x ->
        match x.TryGetAttribute("class") with
        | Some (x) -> x.Value().Contains("datetime")
        | _ -> false)
    |> HtmlNode.innerText
    |> fun x -> x.Replace(" ", "")

let private getImage (node: HtmlNode) : (string * list<string>) =
    let imgs =
        node.Descendants [ "img" ]
        |> Seq.choose (HtmlNode.tryGetAttribute "src")
        |> Seq.map HtmlAttribute.value
        |> Seq.toList
        
    let thumbnail = imgs.Item(1)
    let icons = imgs.GetSlice(Some(2), Some(imgs.Length))

    (thumbnail, icons)

let private getTitle (url: string) =
    async {
        let! html = HtmlDocument.AsyncLoad(url)

        return
            html.Descendants [ "title" ]
            |> Seq.item 0
            |> HtmlNode.innerText
            |> fun x -> x.Replace(" - YouTube", "")
    }

type ScrapedSchedule =
    { title: string
      day: string
      startTime: string
      name: string
      link: string
      thumbnail: string
      icons: list<string> }

let private toSchedule (html: HtmlNode, day: string) : Async<ScrapedSchedule> =
    async {
        let link = getLink html
        let! title = getTitle link
        let startTime = getStartTime html
        let name = getName html
        let (thumbnail, icons) = getImage html

        return
            { title = title
              day = day
              startTime = startTime
              name = name
              link = link
              thumbnail = thumbnail
              icons = icons }
    }

let getSchedules (html: HtmlDocument) : seq<Async<ScrapedSchedule>> =
    let mutable day = ""

    html.CssSelect("div#all div.container div.row")
    |> Seq.collect (fun x ->
        let newday =
            x.Descendants [ "div" ]
            |> Seq.tryFind (fun x ->
                match x.TryGetAttribute("class") with
                | Some (x) -> (x.Value() = "holodule navbar-text")
                | _ -> false)
            |> Option.map HtmlNode.innerText
            |> Option.map (fun x -> x.Replace(" ", ""))

        match newday with
        | Some (d) -> day <- d
        | _ -> ()

        x.Descendants [ "a" ]
        |> Seq.filter (fun x ->
            match x.TryGetAttribute("class") with
            | Some (x) -> (x.Value() = "thumbnail")
            | _ -> false)
        |> Seq.map (fun x -> (x, day)))
    |> Seq.distinct
    |> Seq.map toSchedule
