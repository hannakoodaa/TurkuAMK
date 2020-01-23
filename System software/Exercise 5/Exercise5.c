/*
File: 		Exercise.c
Author: 	Hanna Vohlonen
Description: 	Reads numbers from file Numbers.txt and then uses addDecimal
*/

#include <stdio.h>
#include "AddDecimal.h"

int main () {

    int numberArray[100][50] = {};
    int rowIndex = 0;
    int columnIndex = 0;
    int testArray[5][5] = 
    { 
	{2, 3, 7, 5, 0},
	{4, 9, 8, 2, 1},
	{1, 3, 7, 2, 4},
	{5, 9, 8, 1, 2},
	{3, 7, 1, 7, 2}
    };

    FILE *filePointer = NULL;
    filePointer = fopen("Numbers.txt", "r");    
    for (rowIndex = 0; rowIndex < 100; rowIndex++)
    {
	for (columnIndex = 0; columnIndex < 50; columnIndex++)
	{
            fscanf(filePointer, "%1d", &numberArray[rowIndex][columnIndex]);
	}
    }
    fclose(filePointer);
    

    int rowsNumberArray = sizeof(numberArray)/sizeof(numberArray[0]);
    int columnsNumberArray = sizeof(numberArray[0])/sizeof(numberArray[0][0]);

    int rowsTestArray = sizeof(testArray)/sizeof(testArray[0]);
    int columnsTestArray = sizeof(testArray[0])/sizeof(testArray[0][0]);


    addDecimal(rowsNumberArray, columnsNumberArray, numberArray);

    addDecimal(rowsTestArray, columnsTestArray, testArray);

    return 0;
}