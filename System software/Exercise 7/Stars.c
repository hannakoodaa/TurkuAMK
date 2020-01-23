/*
File:		Stars.c
Author:		Hanna Vohlonen
Description:	Asks user inputs and adds data to the Stars struct array
*/

#include <stdio.h>
#include "Stars.h"

int stars(int numberOfStars) {

    int listStars(int numberOfStars);

    int counter = 0;

    fgets(info[counter].name, 30, stdin);
    for(counter = 0; counter < numberOfStars; counter++)
    {
	printf("Enter the name of the star: "); 
	fgets(info[counter].name, 30, stdin);
    
    	while(info[counter].name[0] == ' ' || info[counter].name[0] == '\n')
    	{
	    printf("Invalid input, use at least one character. Enter the name of the star: "); 
	    fgets(info[counter].name, 30, stdin);
    	}
        
      	printf("Enter distance from Earth: ");
     	fgets(info[counter].distance, 10, stdin);

	if(info[counter].distance[0] == '1' || info[counter].distance[0] == '2' || info[counter].distance[0] == '3' 		|| info[counter].distance[0] == '4' || info[counter].distance[0] == '5' || info[counter].distance[0] == '6' 		|| info[counter].distance[0] == '7' || info[counter].distance[0] == '8' || info[counter].distance[0] == '9');
	
	else if(info[counter].distance[0] == '0' && info[counter].distance[1] == '.');

	else 
	{
	    printf("The entered value is 0 or not a number, distance from Earth is not available\n");
	    info[counter].distance[0] = 'N';
	    info[counter].distance[1] = '/';
	    info[counter].distance[2] = 'A';
	    info[counter].distance[3] = '\n';
	}
	
    	printf("Enter discovery year: ");
    	fgets(info[counter].year, 8, stdin);
	
	if(info[counter].year[0] == '1' || info[counter].year[0] == '2' || info[counter].year[0] == '3' ||     	          info[counter].year[0] == '4' || info[counter].year[0] == '5' || info[counter].year[0] == '6' ||     	          info[counter].year[0] == '7' || info[counter].year[0] == '8' || info[counter].year[0] == '9')
	{
	    printf("\n");
	    continue;
	}
	else if(info[counter].year[0] == '0')
	{
	    printf("\n");
	    continue;
	}
	else 
	{
	    printf("The entered value is not a number, discovery year not available\n");
	    info[counter].year[0] = 'N';
	    info[counter].year[1] = '/';
	    info[counter].year[2] = 'A';
	    info[counter].year[3] = '\n';
	}

      	printf("\n");
	
    }

    listStars(numberOfStars);

    return 0;

}


int listStars(int numberOfStars){

    int counter = 0;

    printf("*** List of stars you entered ***\n\n");
    if(numberOfStars == 0)
    {
	printf("The list is empty\n");
    }
    for(counter = 0; counter < numberOfStars; counter++)
    {
	printf("Name: %s", info[counter].name);
	printf("Distance: %s", info[counter].distance);
	printf("Discovery: %s", info[counter].year);
	printf("\n");
    }

    return 0;
}