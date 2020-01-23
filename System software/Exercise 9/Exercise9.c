/*
File:		Exercise9.c
Author:		Hanna Vohlonen
Description:	Finds the largest 3-digit palindrome and prints it and its factors
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int palindrome(char *palindromeNumbers);
int toString(char *palindromeNumbers, int result);
int toInt(char *palindromeNumbers);

int main() {
    char *palindromeNumbers = NULL;
    int firstNumber = 999;
    int secondNumber = 999;
    int result = 0;
    int newPalindrome = 0;
    int finalNumber = 0;

    int resultNumber1 = 0;
    int resultNumber2 = 0;

    palindromeNumbers = (char*) malloc(6);
    if(palindromeNumbers == NULL)
    {
	printf("Error! Memory allocation did not succeed.\n");
        return 0;
    }

    for(firstNumber = 999; firstNumber >= 100; firstNumber--)
    {
	for(secondNumber = 999; secondNumber >= 100; secondNumber--)
	{
	    result = firstNumber * secondNumber;

	    toString(palindromeNumbers, rs;

	    *palindromeNumbers = palindrome(palindromeNumbers);

	    newPalindrome = toInt(palindromeNumbers);
            
  	    if(newPalindrome > finalNumber)
	    {
		finalNumber = newPalindrome;
		resultNumber1 = firstNumber;
		resultNumber2 = secondNumber;
	    }
	}
    }

    printf("Largest palindrome number is %d\n\n", finalNumber);
    printf("Numbers are %d and %d\n", resultNumber1, resultNumber2);

    free(palindromeNumbers);

    return 0;
}
 

int palindrome (char *palindromeNumbers){

    char *newPalindromeNumbers = NULL; 

    newPalindromeNumbers = (char*)malloc(6);

    if(*(palindromeNumbers + 0) == *(palindromeNumbers + 5) && *(palindromeNumbers + 1) == *(palindromeNumbers + 4) 		&& *(palindromeNumbers + 2) == *(palindromeNumbers + 3))
    {
	newPalindromeNumbers = palindromeNumbers;
        return *newPalindromeNumbers;
    }

    return 0;
}


int toString(char *palindromeNumbers, int result) {

    sprintf(palindromeNumbers, "%d", result);

    return *palindromeNumbers;
}


int toInt(char *palindromeNumbers) {

    char *ptr = NULL;
    int integer = 0;
    integer = strtol(palindromeNumbers, &ptr, 10);

    return integer;
}
    

