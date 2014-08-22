#load "Seq.fs"

let list = [1..1000]

;;

#time "on"

;;

let x = 1

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

printfn "Seq.rev4"

for i = 1 to 100000 do
    Seq.rev4 list
    |> Seq.iter ignore
    |> ignore

;;

let twoList = [1; 2]

printfn "List.rev [1..2]"

for i = 1 to 1000000 do
    List.rev twoList
    |> Seq.iter ignore
    |> ignore

;;

printfn "Seq.rev [1..2]"

for i = 1 to 1000000 do
    Seq.rev twoList
    |> Seq.iter ignore
    |> ignore

;;

printfn "Seq.rev4 [1..2]"

for i = 1 to 1000000 do
    Seq.rev4 twoList
    |> Seq.iter ignore
    |> ignore


;;

#time "off"

;;
