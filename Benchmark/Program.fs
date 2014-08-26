[<EntryPoint>]
let main argv = 
    let arguments = Arguments.parse argv

    //Benchmark.Rev.run()

    Benchmark.Permute.run()

    printfn ""
    printf "Press any key to continue . . . "
    System.Console.ReadKey true |> ignore

    0 // return an integer exit code
