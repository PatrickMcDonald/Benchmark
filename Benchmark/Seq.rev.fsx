#load "Seq.fs"

let list = [1..1000]

;;

#time "on"

;;

printfn "List.rev"

for i = 1 to 100000 do
    List.rev list
    |> Seq.iter ignore
    |> ignore

;;

printfn "Seq.rev"

for i = 1 to 100000 do
    Seq.rev list
    |> Seq.iter ignore
    |> ignore

;;

#time "off"

;;