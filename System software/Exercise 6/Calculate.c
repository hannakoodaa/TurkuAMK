/*
File:		Calculate.c
Author:		Hanna Vohlonen
Description:	Makes binary numbers, changes them into decimals and then either divides or multiplies with 2. 
		Also writes the output into a file.
*/

#include <stdio.h>
#include <string.h>
#include "Calculate.h"

void calculate (int wholeLength, char collectedCommandLineArgument[]) {

    int counter = 0;
    int binaryIndex = 0;
    int index = 0;
    int decimal = 0;
    int binary[8] = {};
  
    FILE *filePointer = NULL; 
    filePointer = fopen("Binary.txt", "w");

    fprintf(filePointer, "Exercise 6 - Learning command line arguments and file write\n\n");


    while (counter < wholeLength)
    {
	for (counter = 0; counter < wholeLength; counter++) 
	{
    	    binary[index] = collectedCommandLineArgument[counter];
	    index++;	
			
	    if (index == 8)
	    {
		fprintf(filePointer, "Original binary: ");
		
		for (int k = 0; k < 8; k++)
		{
		    fprintf(filePointer, "%d", binary[k]);
  		}
    
		if (binary[0] != 0)
		{
		    for(binaryIndex = 0; binaryIndex < 8; binaryIndex++)
		    {
			if(binary[binaryIndex]==0)
			{
			    binary[binaryIndex]=1;
			}
			else
			{	
			    binary[binaryIndex]=0;
			}
		    }

		    for(binaryIndex=7; binaryIndex>=0; binaryIndex--)
		    {
			if(binary[binaryIndex] == 0)
		    	{
		    	    binary[binaryIndex] =1;
			    break;
			}
			else if(binary[binaryIndex] == 1 && binary[binaryIndex-1] == 0)
			{
			    binary[binaryIndex] = 0;
			    binary[binaryIndex-1] = 1;
			    break;
			}
			else if(binary[binaryIndex] == 1 && binary[binaryIndex-1] == 1)
			{
			    while(binary[binaryIndex-1] != 0)
			    {
				binary[binaryIndex] = 0;
				binary[binaryIndex-1] = 0;
				counter--;
			    }

		    	    binary[binaryIndex-1] = 1;
			    break;
			}
		    }

		    decimal = 0;
		    for (binaryIndex = 1; binaryIndex < 8; binaryIndex++)
		    {
			decimal = decimal << 1 | binary[binaryIndex];
		    }
		    decimal = -decimal;
		
		    fprintf(filePointer, "\nDecimal: %d\n", decimal);
		    decimal >>= 1;
		    fprintf(filePointer, "Divided decimal: %d\n\n", decimal);	
							
		}
		else
		{
		    decimal = 0;
		    for (binaryIndex = 1; binary[binaryIndex] == 0 || binary[binaryIndex] == 1; binaryIndex++)
		    {
			decimal = (decimal<<1) | binary[binaryIndex];
		    }

		    fprintf(filePointer, "\nDecimal: %d\n", decimal);
		    decimal <<= 1;
		    fprintf(filePointer, "Multiplied decimal: %d\n\n", decimal);
		}		
		index = 0;
	    }
	} 
    }

    fclose(filePointer);
}