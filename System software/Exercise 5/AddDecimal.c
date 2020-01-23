/* 
File: 		AddDecimal.c
Author: 	Hanna Vohlonen
Description: 	Adds decimal numbers
*/

#include <stdio.h>
#include "AddDecimal.h"


void addDecimal (int rows, int columns, int array[rows][columns]) {

    int sum = 0;
    int carry = 0;
    int columnIndex = 0;
    int rowIndex = 0;
    int place = 0;
    int numberIndex = 0;
    int firstNumber = 0;
    char secondNumber = '0';
    char number[100] = "";
    char sumArray[10] = "";
    

    for (columnIndex = columns - 1; columnIndex >= 0; columnIndex--)
    {
	sum = 0;
	for (rowIndex = 0; rowIndex <= rows - 1; rowIndex++)
	{
	    sum = sum + arr[rowIndex][columnIndex];
	}
	
	carry = firstNumber;
	
	sum = sum + carry;
	
	if (sum < 10)
	{
	    sumArray[columnIndex] = sum;
	}

	else 
	{
	    firstNumber = sum;
 	    place = 0;
	    while (sum)
	    {
	    	number[place] = sum%10;
                sum /= 10;
	    	place++;
	    }	    
	   
	    secondNumber = number[0];	
	    sumArray[columnIndex] = secondNumber;

	    if (firstNumber <= 100)
	    {	    	
		firstNumber = number[1];
		carry = firstNumber;
 	    } 

	    else 
	    {
		firstNumber = (firstNumber - secondNumber) / 10;
	    	carry = firstNumber;
	    }
	}
    }

    printf("%d", firstNumber);
    for (numberIndex = 0; numberIndex <= columns - 1; numberIndex++)
    {
	printf("%d", sumArray[numberIndex]);
    }

    printf("\n");

}

