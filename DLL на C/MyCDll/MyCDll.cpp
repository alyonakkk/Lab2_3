#include "MyCDll.h"
#include <stdio.h>

// https://stackoverflow.com/questions/13218824/how-to-write-a-dll-file-in-c

extern "C" __declspec(dllexport) double TheFunc(double x, double a, double b, double c )
{
    return (a*x*x + b) / c;
}

extern "C" __declspec(dllexport) char* FuncName()
{
    char c[16] = "y=(a*x^3 + b)/c";
    return c;
}