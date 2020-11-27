#include "MyCppDll.h"
#include "pch.h"
#include <string>

extern "C" __declspec(dllexport) double TheFunc(double x)
{
    return x / 21;
}

extern "C" __declspec(dllexport) char * FuncName()
{
    char c[7] = "y=x/21";
    return c;
}