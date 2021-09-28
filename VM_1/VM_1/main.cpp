#include<iostream>
#include <iomanip>
#include<cmath>


using namespace std;
double f(double x) //функция
{
	return pow(2.0, x) - 5 * pow(x, 2.0) + 10;
}
double df(double x) //первая производная
{
	return pow(2.0, x) * log(2.0) - 10 * x;
}
double dfdf(double x) //вторая производная
{
	return pow(2.0, x) * log(2.0) - 10;
}
double equivalent(double x) {
	return (x - (1 / df(x)) * f(x));
}
int metodNewton()
{
	int exit = 0, i = 0;//переменные для выхода и цикла
	double x0, xn;// вычисляемые приближения для корня
	double a, b, eps = 0.001;// границы отрезка и необходимая точность
	i = 0;
	cout << "Please input [a;b]\n";
	cin >> a >> b; // вводим границы отрезка, на котором будем искать корень
		cout << "\nCurrent epsilon: " << eps << endl;
		if (f(a) * dfdf(a) > 0) x0 = a; // для выбора начальной точки проверяем f(x0)*dfdf(x0) > 0 ?
		else x0 = b;
		xn = x0 - f(x0) / df(x0); // считаем первое приближение
		cout << ++i << "-th iteration = " << xn << "\n";
		while (fabs(x0 - xn) > eps) // пока не достигнем необходимой точности, будет продолжать вычислять
		{
		x0 = xn;
		xn = x0 - f(x0) / df(x0); // формула Ньютона
		cout << ++i << "-th iteration = " << xn << "\n";
		}
		cout << "Answer = " << xn << endl; // вывод вычисленного корня
		i = 0;
	return 0;
}
int metodIT()
{
	double x, s, xn;
	int i = 0;
	double eps;
	eps = 0.00001;
	cout << "Enter initial root value : "; cin >> x;
	s = x;
		do
		{
				xn = x;
				x = equivalent(x);
				cout << ++i << "-th iteration = " << x << "\n";
		}
		while (fabs(xn - x) > eps);
		i = 0;
	return 0;
}
int methodSEC()
{
	double x0, x1, x2, xn, a, b, eps, r, xn1;
	int i = 0;
	cout << "Please input [a;b]\n";
	cin >> a >> b;
	eps = 0.0001;
	if (f(a) * dfdf(a) > 0)
		x0 = a; // для выбора начальной точки проверяем f(x0)*dfdf(x0) > 0 ?
	else
		x0 = b;
	xn = x0 - f(x0) / df(x0); // считаем первое приближение
	cout << ++i << "-th iteration = " << xn << "\n";
	do {
		xn1 = xn - (((xn - x0) * f(xn)) / (f(xn) - f(x0)));
		x0 = xn;
		xn = xn1;
		cout << ++i << "-th iteration = " << xn << "\n";
	} while (fabs(xn - x0) > eps);
	return 0;
}
int main()
{
	int choice;
	cout << "Make choice: " << endl;
	cout << "1-Method Newtona" << endl;
	cout << "2-Method PROSTIH_ITERACII" << endl;
	cout << "3-Method SECKUSHEI" << endl;
	cout << "4-EXIT" << endl;
	cin >> choice;
	if (choice == 1) metodNewton();
	if (choice == 2) metodIT();
	if (choice == 3) methodSEC();
	else return 0;
}