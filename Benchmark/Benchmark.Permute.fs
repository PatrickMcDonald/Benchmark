module Benchmark.Permute

open Benchmark.Core

let run() =
    let list = [1..1000]
    let bigList = [1..1000000]

    let mapIndex m i = (i + 50) % m

    time 30000 "List.permute" (fun () ->
        List.permute (mapIndex 1000) list |> ignore)

    time 30000 "Seq.permute" (fun () ->
        Seq.permute (mapIndex 1000) list |> Seq.iter ignore)

    time 10 "List.permute (bigList)" (fun () ->
        List.permute (mapIndex 1000000) bigList |> ignore)

    time 10 "Seq.permute (bigList)" (fun () ->
        Seq.permute (mapIndex 1000000) bigList |> Seq.iter ignore)

