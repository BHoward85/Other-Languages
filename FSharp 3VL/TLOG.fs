// 3VL - for Rosettacode

type TLOG = class
	| FALSE = 0
	| MAYBE = 1
	| TRUE = 2
	
let AND x y =
	match (x,y) with
	| ( 1 , 1 ) -> TRUE
	| ( 0 , _ ) | ( _ , 0 ) -> FALSE
	| _ -> MAYBE