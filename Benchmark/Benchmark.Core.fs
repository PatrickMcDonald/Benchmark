module Benchmark.Core

let time iterations name f =
    let timer = Timer.create()

    for i = 1 to iterations do
        f()

    printfn "Time for %d iterations of %s: %A" iterations name (timer())
