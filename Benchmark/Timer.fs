module Timer

let create() = 
    let sw = System.Diagnostics.Stopwatch.StartNew()
    fun () -> 
        sw.Elapsed
