/*
File:		Collatz.c
Author: 	Hanna Vohlonen
Description:	Counts the length of the Collatz sequence from 2 to 10000.
*/

#include <stdio.h>
#include "Collatz.h"

int collatzCounter(int number);
int collatzLength();

int collatzCounter(int number) {
    int count = 0;
    while(number != 1) {
	if(number % 2 == 0) {
	    number /= 2;
      	} 
	else {
	    number = (3 * number) +1;
	}
 	count++;
    }
    return count;
}

int collatzLength () { 
    int counter = 0;
    int length = 0;
    for(counter = 2; counter <= 10000; counter++) {
        length = collatzCounter(counter) + 1;
    }
    return length;
}
