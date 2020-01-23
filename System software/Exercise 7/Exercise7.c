/*
File:		Exercise7.c
Author:		Hanna Vohlonen
Description:	Uses howMany function and Stars.c to make a list of user input stars
*/

#include <stdio.h>
#include <string.h>
#include "Stars.h"

int main () {

    int howMany();

    int numberOfStars = 0;

    numberOfStars = howMany();

    stars(numberOfStars);

    return 0;

}

int howMany(){

    int numberOfStars = 0;

    printf("\nHow many stars you want to add (0-5)? ");
    scanf("%d", &numberOfStars);

    while(numberOfStars < 0 || numberOfStars > 5)
    {
   	printf("Invalid input. How many stars you want to add (0-5)? ");
    	scanf("%d", &numberOfStars);
    }
   
    printf("\n");

    return numberOfStars;
}