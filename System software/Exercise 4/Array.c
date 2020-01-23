/*
File:		Array.c
Author: 	Hanna Vohlonen
Description:	Stores the length of Collatz sequences in an array
*/

#include <stdio.h>
#include "Array.h"

int collatzCounter(int number);
int collatzLength ();


int putIntoArray () {

    int array[10000] = {};
    int counter2 = 0; 
    int value = 0;
    int collatzSteps = 0; 
    int longestSequence = 0;

    for(counter2 = 2; counter2 <= 10000; counter2++) {
	array[counter2] = (collatzCounter(counter2)+1);
    }

    collatzSteps = array[0];

    for (value=1; value<10000; value++) {
	if(collatzSteps < array[value]) {
	    collatzSteps = array[value];
	}
    }

   
    while((longestSequence<10000) && (array[longestSequence] != collatzSteps)) longestSequence++;

    printf("Number: %d Length: %d\n", longestSequence, collatzSteps);

    return 0;
}