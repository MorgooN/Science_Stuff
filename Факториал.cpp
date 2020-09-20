

#include <iostream>


void printBinary(int x)
{
	if (x == 0)
		return;

	printBinary(x / 2);

	std::cout << % 2;
}

int main()
{
	int x;
	std::cout << "enter a integer";
	std::cin >> x;

	printBinary(x);
	return 0;
}