let isMultipleOf3Or5 x = (x % 5 = 0) || (x % 3 = 0);;
let sum = [1 .. 999] |> List.filter(isMultipleOf3Or5) |> List.fold ( + ) 0;;

[<EntryPoint>]
let main argv = 
    printfn "%i" sum
    0