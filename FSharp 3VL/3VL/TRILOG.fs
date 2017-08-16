// 3VL with ERROR bit - for Rosettacode

type TLOG =
    | FALSE = 0
    | MAYBE = 1
    | TRUE = 2
    | ERROR = -1

let AND x y =
    match (x,y) with
    | ( 2 , 2 ) -> TLOG.TRUE
    | ( 0 , _ ) | ( _ , 0 ) -> TLOG.FALSE
    | _ -> TLOG.MAYBE

let OR x y =
    match (x,y) with
    | ( 2 , _ ) | ( _ , 2 ) -> TLOG.TRUE
    | ( 1 , 0 ) | ( 0 , 1 ) | ( 1 , 1 ) -> TLOG.MAYBE
    | _ -> TLOG.FALSE

let NOT x =
    match x with
    | 2 -> TLOG.FALSE
    | 0 -> TLOG.TRUE
    | _ -> TLOG.MAYBE

let IMP x y =
    match (x,y) with
    | ( _ , 2 ) | ( 0 , _ ) -> TLOG.TRUE
    | ( 1 , 1 ) | ( 1 , 0 ) | ( 2 , 1 ) -> TLOG.MAYBE
    | ( 2 , 0 ) -> TLOG.FALSE
    | _ -> TLOG.ERROR

let EQU x y =
    match (x,y) with
    | ( 2 , 2 ) | ( 0 , 0 ) -> TLOG.TRUE
    | ( 1 , _ ) | ( _ , 1 ) -> TLOG.MAYBE
    | ( 0 , 2 ) | ( 2 , 0 ) -> TLOG.FALSE
    | _ -> TLOG.ERROR

open System
let main() =
    // And set
    printfn "\nAND SET\n"
    printfn "True and True : %A" (AND 2 2)
    printfn "Maybe and True : %A" (AND 1 2)
    printfn "True and Maybe : %A" (AND 2 1)
    printfn "Maybe and Maybe : %A" (AND 1 1)
    printfn "False and Maybe : %A" (AND 0 1)
    printfn "False and True : %A" (AND 0 2)
    printfn "True and False : %A" (AND 2 0)
    printfn "Maybe and False : %A" (AND 1 0)
    printfn "False and False : %A" (AND 0 0)
    // Or set
    printfn "\nOR SET\n"
    printfn "True or True : %A" (OR 2 2)
    printfn "Maybe or True : %A" (OR 1 2)
    printfn "True or Maybe : %A" (OR 2 1)
    printfn "Maybe or Maybe : %A" (OR 1 1)
    printfn "False or Maybe : %A" (OR 0 1)
    printfn "False or True : %A" (OR 0 2)
    printfn "True or False : %A" (OR 2 0)
    printfn "Maybe or False : %A" (OR 1 0)
    printfn "False or False : %A" (OR 0 0)
    // Imp set
    printfn "\nIF THEN SET\n"
    printfn "if True then True : %A" (IMP 2 2)
    printfn "if Maybe then True : %A" (IMP 1 2)
    printfn "if True then Maybe : %A" (IMP 2 1)
    printfn "if Maybe then Maybe : %A" (IMP 1 1)
    printfn "if False then Maybe : %A" (IMP 0 1)
    printfn "if False then True : %A" (IMP 0 2)
    printfn "if True then False : %A" (IMP 2 0)
    printfn "if Maybe then False : %A" (IMP 1 0)
    printfn "if False then False : %A" (IMP 0 0)
    // Equ set
    printfn "\nEQU SET\n"
    printfn "True == True : %A" (EQU 2 2)
    printfn "Maybe == True : %A" (EQU 1 2)
    printfn "True == Maybe : %A" (EQU 2 1)
    printfn "Maybe == Maybe : %A" (EQU 1 1)
    printfn "False == Maybe : %A" (EQU 0 1)
    printfn "False == True : %A" (EQU 0 2)
    printfn "True == False : %A" (EQU 2 0)
    printfn "Maybe == False : %A" (EQU 1 0)
    printfn "False == False : %A" (EQU 0 0)
    // Not set
    printfn "\nNOT SET\n"
    printfn "not True : %A" (NOT 2)
    printfn "not Maybe : %A" (NOT 1)
    printfn "not False : %A" (NOT 0)


    Console.ReadLine() |> ignore
main()