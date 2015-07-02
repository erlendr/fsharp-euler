let sum = [1 .. 999] |> List.filter(fun x -> (x % 5 = 0) || (x % 3 = 0)) |> List.fold ( + ) 0;;

[<EntryPoint>]
let main argv = 
    printfn "%i" sum
    0