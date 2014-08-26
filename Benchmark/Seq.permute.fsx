#load "Seq.fs"

let list = [1..1000]

;;

#time "on"

;;

printfn "List.permute"

for i = 1 to 10000 do
    List.permute (fun i -> (i + 50) % 1000) list
    |> Seq.iter ignore
    |> ignore

;;

printfn "Seq.permute"

for i = 1 to 10000 do
    Seq.permute (fun i -> (i + 50) % 1000) list
    |> Seq.iter ignore
    |> ignore

;;

Seq.permute (fun _ -> 10) [0..9]
|> Seq.iter (printfn "%d")
