

#include "pch.h"
#include <iostream>
#include <cmath>
#include <math.h> 
#include <iomanip> // для манипулятора setprecision


double f(double x) // вычисляемая функция
{
	return 10 * x / 1 + pow(x, 2) - 2 * cos( 2 * x) + x;

}



double iterat(double x) 
{
	return x + 0.5*f

}

int main()
{
	double x;
	double eps;
	std::cout << "Enter starting value :\n";
	std::cin >> x;
	std::cout << "Enter error of approximation : \n";
	std::cin >> eps;
	for (double iteration = 1; eps < fabs(f(x)); ++iteration)
	{
		system("cls"); // очистка экрана консоли
		std::cout << "Iteration : " << setprecision (0) << iteration << "\n";
		if (df(x) == 0)
			break;
		std::cout << "x = " << x << "\n";
		std::cout << "Approximation" << approx << "\n";
		std::cout << "df(x) : " << df(x) << "\n";
		std::cout << " f(x)" << f(x) << "\n";
		x = approx(x);
	}

	return 0;
}




