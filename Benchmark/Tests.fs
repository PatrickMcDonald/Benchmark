module Tests

let verifySeqsEqual s1 s2 =
    match Seq.length s1, Seq.length s2 with
    | a,b when a <> b -> failwith "Sequences have different length"
    | _ ->
        Seq.zip s1 s2 |> Seq.iteri (fun i (a,b) -> if a <> b then failwithf "Sequences are different at index %d" i)
