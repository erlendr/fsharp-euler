let fibs = (1I, 2I) |> Seq.unfold (fun (a, b) -> Some(a, (b, a + b) ) );;
let sum = Seq.takeWhile (fun x -> x < 4000000I) fibs |> Seq.filter(fun x -> x.IsEven) |> List.ofSeq |> List.fold (+) 0I

[<EntryPoint>]
let main argv = 
    printfn "%O" sum
    0