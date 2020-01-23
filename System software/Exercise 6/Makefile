all: Exercise6

Exercise6: Exercise6.o Calculate.o GetLength.o
	gcc -Wall -Wextra -std=c11 -c Exercise6.c Calculate.c GetLength.c
	gcc Exercise6.o Calculate.o GetLength.o -o Exercise6

clean:
	$(RM) Exercise6
	$(RM) Exercise6.o Calculate.o GetLength.o
