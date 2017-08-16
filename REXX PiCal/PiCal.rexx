/* main */
say "5: " find(5)
say "10: " find(10)
say "100: " find(100)
say "1000: " find(1000)
say "10000: " find(10000)
say "100000: " find(100000)
say "1000000: " find(1000000)
say "10000000: " find(10000000)
say "50000000: " find(50000000)
exit

find : parse arg a
flipbit = 1
pi = 0.0
index = 0

do index = 0 to a
	pi = pi + (4.0 / (1.0 + (2.0 * index)) * flipbit)
	flipbit = flipbit * (-1)
end
return pi