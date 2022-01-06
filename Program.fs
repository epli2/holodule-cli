open FSharp.Data
open FSharp.Json
open Parser

[<Literal>]
let url = "https://schedule.hololive.tv/"

[<EntryPoint>]
let main args =
    async {
        let! html = HtmlDocument.AsyncLoad(url)

        getSchedules html
        |> Async.Parallel
        |> Async.RunSynchronously
        |> Json.serialize
        |> printfn "%s"

        return 0
    }
    |> Async.RunSynchronously
