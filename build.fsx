#r "packages/Fake/tools/FakeLib.dll"
#I "packages/Fake/tools"

open Fake
open Fake.ProcessHelper
open System.Diagnostics

let run (src: string) =
    printfn "fsharpi %s" src
    Shell.Exec ("fsharpi", src) |> ignore

let go change = 
    printfn "%A" change
    run change.Name

Target "watch" (fun _ ->
    use watcher = !! "test*.fsx" |> WatchChanges (fun changes ->
            tracefn  "%A" changes
            go (changes |> Seq.head)
    )
    System.Console.ReadLine() |> ignore
    watcher.Dispose()
)

RunTargetOrDefault  "watch"
