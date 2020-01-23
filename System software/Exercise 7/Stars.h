/*
File:		Stars.h
Author:		Hanna Vohlonen
Description:	Contains the star struct array definitions
*/

#ifndef STARS_H
#define STARS_H

int stars();

struct star
{
    char name[30];
    char distance[10];
    char year[8];
};

struct star info[5];

#endif