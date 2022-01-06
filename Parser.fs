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

let private getImage (node: HtmlNode) : (string * string) =
    let imgs =
        node.Descendants [ "img" ]
        |> Seq.choose (HtmlNode.tryGetAttribute "src")
        |> Seq.map HtmlAttribute.value
        |> Seq.toList

    (imgs.Item(1), imgs.Item(2))


let private getTitle (url: string) =
    async {
        let! html = HtmlDocument.AsyncLoad(url)

        return
            html.Descendants [ "title" ]
            |> Seq.item 0
            |> HtmlNode.innerText
            |> fun x -> x.Replace(" - YouTube", "")
    }

type Schedule =
    { Title: string
      Day: string
      StartTime: string
      Name: string
      Link: string
      Thumbnail: string
      Icon: string }

let private toSchedule (html: HtmlNode, day: string) : Async<Schedule> =
    async {
        let link = getLink html
        let! title = getTitle link
        let startTime = getStartTime html
        let name = getName html
        let (thumbnail, icon) = getImage html

        return
            { Title = title
              Day = day
              StartTime = startTime
              Name = name
              Link = link
              Thumbnail = thumbnail
              Icon = icon }
    }

let getSchedules (html: HtmlDocument) : seq<Async<Schedule>> =
    let items =
        html.CssSelect("div#all div.container div.row")
        |> Seq.filter (fun x ->
            x.Descendants [ "div" ]
            |> Seq.tryFind (fun x ->
                match x.TryGetAttribute("class") with
                | Some (x) -> (x.Value() = "holodule navbar-text")
                | _ -> false)
            |> Option.isSome)

    items
    |> Seq.collect (fun x ->
        let day =
            x.Descendants [ "div" ]
            |> Seq.find (fun x ->
                match x.TryGetAttribute("class") with
                | Some (x) -> (x.Value() = "holodule navbar-text")
                | _ -> false)
            |> HtmlNode.innerText
            |> fun x -> x.Replace(" ", "")

        x.Descendants [ "a" ]
        |> Seq.filter (fun x ->
            match x.TryGetAttribute("class") with
            | Some (x) -> (x.Value() = "thumbnail")
            | _ -> false)
        |> Seq.map (fun x -> toSchedule (x, day)))
