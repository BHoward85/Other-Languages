module pi
open System

let cal num =
    4.0 / (1.0 + (2.0 * num)) * (-1.0 ** num)

let push num =
    num + 1.0

let rec findpi pi num = 
    match num with
    | 200000000.0 -> pi
    | _ -> findpi (pi + cal num) (push num)
    
let total = findpi 0.0 0.0
printfn "%1.14F" total;

let main() =
    Console.ReadLine() |> ignore
main()