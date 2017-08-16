program Pi
	implicit none
	
	double precision :: piVal
	integer :: flipBit, numberOfRuns, idex
	character :: goAgain
	
	goAgain = 'y'
	
	do while (goAgain == 'y')
		piVal = 0
		flipBit = -1
		numberOfRuns = 0
		
		print *, ' enter in the number of runs: '
		read(*,*), numberOfRuns
		
		do idex = 0, numberOfRuns
			piVal = piVal + (4.0 / (1.0 + (2.0 * idex)) * (flipBit ** idex))
		end do
		
		print '(f40.30)', piVal
		print *, ' go agian? '
		read(*,*), goAgain
	end do

end program