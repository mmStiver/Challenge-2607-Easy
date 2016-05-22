// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let places x = 
    match x with
    | st when (x % 10 = 1 && x % 100 <> 11) -> sprintf "%dst" x
    | nd when (x % 10 = 2 && x % 100 <> 12) -> sprintf "%dnd" x
    | rd when (x % 10 = 3 && x % 100 <> 13) -> sprintf "%drd" x
    | _ -> sprintf "%dth" x

let notYourPlace nth = 
    seq{ for n in 0 .. 100 do if n <> nth then yield n  }
        |> Seq.map(fun x -> places x)
        |> Seq.toList
    

[<EntryPoint>]
let main argv = 
    printfn "%A" (notYourPlace 5)

    System.Console.ReadKey() |> ignore
    0 // return an integer exit code
