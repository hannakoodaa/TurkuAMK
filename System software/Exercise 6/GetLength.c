/*
File:		GetLength.c
Author:		Hanna Vohlonen
Description:	Calculates command line input's length
*/

#include <stdio.h>
#include <string.h>
#include "GetLength.h"

int getLength (int argc, char *argv[]) {

    int counter = 0;
    int vectorLength = 0;
    int wholeLength = 0;
    int index = 0;

    for(counter = 1; counter < argc; counter++)
    {
	vectorLength = strlen(argv[counter]);
	wholeLength = 1 + wholeLength + vectorLength;
	for(index=0; index <= vectorLength; index++)	
	{
	    if(argv[counter][index] - '0' > 1 || argv[counter][index] - '0' < 0)
	    {
		wholeLength = wholeLength - 1;
	    }
	}
    } 
    return wholeLength;
}