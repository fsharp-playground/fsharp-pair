
#r "packages/FSharp.Data/lib/net40/FSharp.Data.dll"
#I "packages/FSharp.Data/lib/net40"

open FSharp.Data

type Simple = JsonProvider<""" { "name":"Two", "age":24 } """>
let simple = Simple.Parse(""" { "name":"Three", "age":23 } """)
printfn "%A" simple.Age
printfn "%A" simple.Name

type Numbers = JsonProvider<""" [1, 2, 3, 3.14] """>
let nums = Numbers.Parse(""" [1.2, 45.1, 98.2, 5] """)
let total = nums |> Seq.sum
printfn "%A" total
let sorting = nums |> Seq.sort
printfn "%A" sorting

type Mixed = JsonProvider<"mixed.json">
let mixed = Mixed.Parse(""" [4, 5, "hello", "world" ] """)

mixed.Numbers |> Seq.sum |> printfn "%A"
mixed.Strings |> String.concat ", " |> printfn "%A"
