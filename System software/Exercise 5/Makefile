all: Exercise5

Exercise5: Exercise5.o AddDecimal.o
	gcc -Wall -Wextra -std=c11 -c Exercise5.c AddDecimal.c
	gcc Exercise5.o AddDecimal.o -o Exercise5

clean:
	$(RM) Exercise5
	$(RM) Exercise5.o AddDecimal.o
