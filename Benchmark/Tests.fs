module Tests

let verifySeqsEqual s1 s2 =
    match Seq.length s1, Seq.length s2 with
    | a,b when a <> b -> false
    | _ ->
        Seq.zip s1 s2 |> Seq.forall (fun (a,b) -> a = b)