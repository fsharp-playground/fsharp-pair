
module MyList = 
    // define operator
    let (>>>>) x y =
        y x

    let testOperator() = 
        let printA a = printfn "%A" a
        let even x = x % 2 = 0
        List.filter even [1;2;3] |> printA

        [1;2;3;4] |> List.filter even |> printA 

        1 >>>> (fun x -> x + x) |>  printA
        1 >>>> (fun x -> printfn "%A" x) |> printA 
        (>>>>) 1 (fun x -> x + x) |> printA
        (|>) (List.filter even [1;2;3;4]) printA

MyList.testOperator()


