module Arguments

let parseInt s = System.Int32.Parse(s)

type Arguments =
    { Iterations : int }
    static member defaultArguments = { Iterations = 500000 }

let parse argv =
    let argn = Array.length argv

    let rec parse (argv : string []) i arguments =
        if i = argn then arguments
        else
            match argv.[i] with
            | "-i" ->
                if i > argn - 2 then failwithf "Expected a value after '-i' switch"
                parse argv (i + 2) { arguments with Iterations = parseInt argv.[i + 1] }
            | _ -> failwithf "Unknown paramter: %s" argv.[i]
    parse argv 0 Arguments.defaultArguments
