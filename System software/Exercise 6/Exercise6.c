/*
File:		Exercise6.c
Author:		Hanna Vohlonen
Description:	Binary numbers to decimals
*/

#include <stdio.h>
#include <string.h>
#include "Calculate.h"
#include "GetLength.h"

int main (int argc, char *argv[]) {

    int counter = 0;
    int index = 0;
    int commandLineIndex = 0;
    char collectedCommandLineArgument[40] = "";
    int vectorLength = 0;
    int wholeLength = 0;


    wholeLength = getLength(argc, argv);
 
    while(commandLineIndex < wholeLength)
    {
	for(counter = 1; counter < argc; counter++)
	{
    	    vectorLength = strlen(argv[counter]) - 1;
		
	    for(index=0; index <= vectorLength; index++)	
	    {
		if(argv[counter][index] - '0' > 1 || argv[counter][index] - '0' < 0)
		{
		    continue;
		}
		else
		{
		    collectedCommandLineArgument[commandLineIndex] = argv[counter][index]-'0';
		    commandLineIndex++;
		}
	    }
	}
    }

    calculate(wholeLength, collectedCommandLineArgument);

    return 0;

}