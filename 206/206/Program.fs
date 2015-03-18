// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open System
open System.IO
open System.Text

let result current total operator =
    match operator |> Seq.toList with
    | '*' :: _ -> total * current
    | '/' :: _ -> total / current
    | '+' :: _ -> total + current
    | '-' :: _ -> total - current
    | _ -> 0

let calcAndPrint total oplist = 
    0

[<EntryPoint>]
let main argv = 
    let ops = Console.ReadLine().Split [|' '|]

    let startNum = (Console.ReadLine(), Console.ReadLine())

    

    0 // return an integer exit code
