[<EntryPoint>]
let main argv = 
    let arguments = Arguments.parse argv

    let list = [1..1000]

    let bigList = [1..1000000]

    let bigSeq = seq {1..1000000}

    let time iterations name f =
        let timer = Timer.create()

        for i = 1 to iterations do
            f()

        printfn "Time for %d iterations of %s: %A" iterations name (timer())


    Tests.verifySeqsEqual [10..-1..1] (Seq.rev [1..10])
    |> printfn "rev: %A"
    Tests.verifySeqsEqual [10..-1..1] (Seq.rev2 [1..10])
    |> printfn "rev2: %A"
    Tests.verifySeqsEqual [10..-1..1] (Seq.rev3 [1..10])
    |> printfn "rev3: %A"

    printfn "%A" <| Seq.rev (seq {1..10})
    printfn "%A" <| Seq.rev2 (seq {1..10})
    printfn "%A" <| Seq.rev3 (seq {1..10})


    time 100000 "List.rev" (fun () ->
        List.rev list
        |> Seq.iter ignore
        |> ignore)

    time 100000 "Seq.rev" (fun () ->
        Seq.rev list
        |> Seq.iter ignore
        |> ignore)

    (*
    time 100000 "Seq.rev3" (fun () ->
        Seq.rev3 list
        |> Seq.iter ignore
        |> ignore)
    *)

    time 10 "List.rev (bigList)" (fun () ->
        List.rev bigList
        |> Seq.iter ignore
        |> ignore)

    time 10 "Seq.rev (bigList)" (fun () ->
        Seq.rev bigList 
        |> Seq.iter ignore
        |> ignore)

    time 10 "Seq.rev3 (bigList)" (fun () ->
        Seq.rev3 bigList
        |> Seq.iter ignore
        |> ignore)

    time 10 "Seq.rev (bigSeq)" (fun () ->
        Seq.rev bigSeq 
        |> Seq.iter ignore
        |> ignore)

    time 10 "Seq.rev3 (bigSeq)" (fun () ->
        Seq.rev3 bigSeq
        |> Seq.iter ignore
        |> ignore)

    printfn ""
    printf "Press any key to continue . . . "
    System.Console.ReadKey true |> ignore

    0 // return an integer exit code
