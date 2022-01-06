open FSharp.Data
open FSharp.Json
open Parser
open Talents

[<Literal>]
let url = "https://schedule.hololive.tv/"

let iconUrlToTalent (iconUrl: string) : Talent =
    List.append talents official
    |> List.tryFind (fun t -> t.icons |> List.contains iconUrl)
    |> Option.defaultValue dummyTalent

type Schedule =
    { title: string
      day: string
      startTime: string
      name: string
      link: string
      thumbnail: string
      memberNames: list<TalentName> }

[<EntryPoint>]
let main args =
    async {
        let! html = HtmlDocument.AsyncLoad(url)

        getSchedules html
        |> Async.Parallel
        |> Async.RunSynchronously
        |> Array.map
            (fun schedule ->
                { title = schedule.title
                  day = schedule.day
                  startTime = schedule.startTime
                  name = schedule.name
                  link = schedule.link
                  thumbnail = schedule.thumbnail
                  memberNames =
                      schedule.icons
                      |> List.map iconUrlToTalent
                      |> List.map (fun t -> t.name) })
        |> Json.serialize
        |> printfn "%s"

        return 0
    }
    |> Async.RunSynchronously
