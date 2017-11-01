#pragma once
#define LIB1_API _declspec(dllexport)

class LIB1_API HRectangular
{
private:
	double side1, side2;
public:
	HRectangular(double s1, double s2) :side1(s1), side2(s2) { };
	double computeArea();
};
