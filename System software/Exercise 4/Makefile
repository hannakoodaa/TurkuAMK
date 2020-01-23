all: Exercise4

Exercise4: Exercise4.o Collatz.o Array.o
	gcc -Wall -Wextra -std=c11 -c Exercise4.c Collatz.c Array.c
	gcc Exercise4.o Collatz.o Array.o -o Exercise4

clean: 
	$(RM) Exercise4
	$(RM) Exercise4.o Collatz.o Array.o
