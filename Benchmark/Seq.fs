module Seq

open System.Collections.Generic
open System.Collections

let mkSeq f = 
    { new IEnumerable<'U> with 
        member x.GetEnumerator() = f()
      interface IEnumerable with 
        member x.GetEnumerator() = (f() :> IEnumerator) }

let mkDelayedSeq (f: unit -> IEnumerable<'T>) = mkSeq (fun () -> f().GetEnumerator())

let rev (source:seq<'T>) =
    mkDelayedSeq (fun () ->
        source
        |> Array.ofSeq
        |> Array.rev
        :> seq<'T>)

let rev2 (source:seq<'T>) =
    mkDelayedSeq (fun () ->
        Seq.fold (fun s x -> x::s) [] source 
        :> seq<'T>)

let rev3 (source:seq<'T>) =
    let arr = Array.ofSeq source
    let arrn = Array.length arr

    seq {
        for i = arrn - 1 downto 0 do
            yield arr.[i]
    }
