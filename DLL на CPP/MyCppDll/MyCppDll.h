#ifndef _MyCppDll_H_
#define _MyCppDll_H_


extern "C" __declspec(dllexport) double TheFunc(double x);
extern "C" __declspec(dllexport) char* FuncName();

#endif
