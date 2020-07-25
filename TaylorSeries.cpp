
#include <iostream>

const int max = 10;

int main()
{
	setlocale(LC_ALL, "RUS");
	double x;
	std::cout << "Необходим начальный аргумент ряда Тейлора: \n";
	std::cin >> x;
	double func = 1;
	double Summ = func;
	for (int n = 1; n <= max; ++n)
	{
		func = pow(-1, n)*pow(x, 2 * n + 1) / (2 * n + 1); //функция
		Summ += func; //сохраняю сумму
		std::cout << "Сумма равна: " << Summ << std::endl;

	}
	
	return 0;
}
