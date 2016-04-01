#r "packages/Unquote/lib/net45/Unquote.dll"
#R "packages/Unquote/lib/net45/"

open Swensen.Unquote

let inline testEval expr expected =
    let result = expr |> eval
    result =! expected

testEval <@ 3 @> 5
testEval <@ 3 @> 5
testEval <@ 3 @> 5
testEval <@ 3 @> 5

