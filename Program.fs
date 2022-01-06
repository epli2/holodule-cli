open FSharp.Data
open FSharp.Json
open Parser
open Talents
open Argu
open System

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

type CliArguments =
    | Talent of name: string

    interface IArgParserTemplate with
        member s.Usage =
            match s with
            | Talent _ -> "出演タレントで絞り込みます。"

[<EntryPoint>]
let main args =
    let argParser =
        ArgumentParser.Create<CliArguments>(programName = "holodule-cli")

    let argParseResults =
        argParser.ParseCommandLine(inputs = args, raiseOnUsage = true)

    if argParseResults.IsUsageRequested then
        Console.WriteLine(argParser.PrintUsage())

    let selectedTalent =
        argParseResults.TryGetResult(CliArguments.Talent)

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
        |> Array.filter
            (fun schedule ->
                match selectedTalent with
                | Some (talent) -> schedule.memberNames |> List.contains talent
                | None -> true)
        |> Json.serialize
        |> printfn "%s"

        return 0
    }
    |> Async.RunSynchronously
