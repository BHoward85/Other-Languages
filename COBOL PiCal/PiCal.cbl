 $ SET SOURCEFORMAT"FREE"
IDENTIFICATION DIVISION.
PROGRAM-ID. Lab4
AUTHOR. Brad Howard.
* Lab 4 in COBOL

DATA DIVISION.
WORKING-STORAGE SECTION.
77 Indexer		PIC 99.

77 FlipBit		PIC S9			VALUE -1.

77 PiValue		PIC 9V9(15)		VALUE 0.

77 NumberOfRuns PIC 9(8).

* END OF SECTION

PROCEDURE DIVISION.
Begin.
	DISPLAY "Enter a number more then 9"
	ACCEPT NumberOfRuns
	
	PERFORM VARYING Indexer FROM 0 BY 1 UNTIL Indexer = NumberOfRuns
		COMPUTE PiValue = PiValue + (4.0 / (1.0 + (2.0 * Indexer)) * FlipBit ** Indexer)
	END-PERFORM
	
	DISPLAY "Output: ", PiValue.
	
	STOP RUN.