module Tests

let verifySeqsEqual expected actual =
    match Seq.length expected, Seq.length actual with
    | e,a when e <> a -> failwithf "Sequences have different length. Expected: %A; Actual: %A" e a
    | _ ->
        Seq.zip expected actual |> Seq.iteri (fun i (e,a) -> if e <> a then failwithf "Sequences are different at index %d. Expected: %A; Actual: %A" i e a)
