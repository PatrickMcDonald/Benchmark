module Benchmark.Rev

open Benchmark.Core

let run() =

    let list = [1..1000]

    let bigList = [1..1000000]

    let bigSeq = seq {1..1000000}

    Tests.verifySeqsEqual [10..-1..1] (Seq.rev [1..10])
    Tests.verifySeqsEqual [9..-1..1] (Seq.rev [1..9])
    Tests.verifySeqsEqual [10..-1..1] (Seq.rev2 [1..10])
    Tests.verifySeqsEqual [9..-1..1] (Seq.rev2 [1..9])
    Tests.verifySeqsEqual [10..-1..1] (Seq.rev3 [1..10])
    Tests.verifySeqsEqual [9..-1..1] (Seq.rev3 [1..9])
    Tests.verifySeqsEqual [10..-1..1] (Seq.rev4 [1..10])
    Tests.verifySeqsEqual [9..-1..1] (Seq.rev4 [1..9])


    time 10000 "List.rev" (fun () ->
        List.rev list
        |> Seq.iter ignore
        |> ignore)

    time 10000 "Seq.rev" (fun () ->
        Seq.rev list
        |> Seq.iter ignore
        |> ignore)

    time 10000 "Seq.rev4" (fun () ->
        Seq.rev4 list
        |> Seq.iter ignore
        |> ignore)

    printfn ""

    let twoList = [1; 2]

    time 1000000 "List.rev [1..2]" (fun () ->
        List.rev twoList
        |> Seq.iter ignore
        |> ignore)

    time 1000000 "Seq.rev [1..2]" (fun () ->
        Seq.rev twoList
        |> Seq.iter ignore
        |> ignore)

    time 1000000 "Seq.rev4 [1..2]" (fun () ->
        Seq.rev4 twoList
        |> Seq.iter ignore
        |> ignore)

    printfn ""

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

    time 10 "Seq.rev4 (bigList)" (fun () ->
        Seq.rev4 bigList
        |> Seq.iter ignore
        |> ignore)

    time 10 "Seq.rev3 (bigList)" (fun () ->
        Seq.rev3 bigList
        |> Seq.iter ignore
        |> ignore)

    printfn ""

    time 10 "Seq.rev (bigSeq)" (fun () ->
        Seq.rev bigSeq 
        |> Seq.iter ignore
        |> ignore)

    time 10 "Seq.rev4 (bigSeq)" (fun () ->
        Seq.rev4 bigSeq
        |> Seq.iter ignore
        |> ignore)

    time 10 "Seq.rev3 (bigSeq)" (fun () ->
        Seq.rev3 bigSeq
        |> Seq.iter ignore
        |> ignore)
