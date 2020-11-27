#ifndef _MyCDll_H_
#define _MyCDll_H_

#include <stdio.h>
#include <windows.h>

extern "C" __declspec(dllexport) double TheFunc(double x, double a, double b, double c);
extern "C" __declspec(dllexport) char* FuncName();

#endif