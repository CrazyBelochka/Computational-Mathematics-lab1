#include <iostream>
#include <math.h>
#define N 1000;

using namespace std;

//Сама функция
double func(double x)
{
	return ((1 + sqrt(x)) / ((1+ 4 * x) + (3 * x * x)));
}
//Проверка правила Рунге
bool provPravRunge(double Sh, double Shr, double epsilon, double r, double p)
{
	return (fabs(Sh - Shr) / (pow(r, p) - 1)) < epsilon;
}
//Метод левых прямоугольников
double leftRec(double epsilon, double r, double h, double a, double b)
{
	double Summ;
	Summ = 0;
	double x;
	x = a;
	while (x <= b) {
		Summ += func(x) * h;
		x += h;
	}

	h /= r;

	double SummR;
	SummR = 0;
	x = a;
	while (x <= b) {
		SummR += func(x) * h;
		x += h;
	}

	while (!provPravRunge(Summ, SummR, epsilon, r, 1)) //порядок точности равен 1
	{
		x = a;
		Summ = SummR;
		SummR = 0;
		h /= r;
		while (x <= b) {
			SummR += func(x) * h;
			x += h;
		}
	}
	cout << h;
	return SummR;
}
//Метод центральных прямоугольников
double middleRec(double epsilon, double r, double h, double a, double b)
{
	double Summ;
	Summ = 0;
	double x;
	x = (a+b)/2;
	while (x <= b) 
	{
		Summ += func(x) * h;
		x += h;
	}

	h /= r;

	double SummR;
	SummR = 0;
	x = (a + b) / 2;
	while (x <= b)
	{
		SummR += func(x) * h;
		x += h;
	}

	while (!provPravRunge(Summ, SummR, epsilon, r, 1)) //порядок точности равен 1
	{
		x = (a+a+h)/2;
		Summ = SummR;
		SummR = 0;
		h /= r;
		while (x <= b) {
			SummR += func(x) * h;
			x += h;
		}
	}
	cout << h;
	return SummR;
}


//Метод Ньютона-Котеса
double methNU_KT(double epsilon, double r, double h, double a, double b, int n)
{
		const double width = (b - a) / n;

		double trapezoidal_integral = 0;
		for (int step = 0; step < n; step++) {
			const double x1 = a + step * width;
			const double x2 = a + (step + 1) * width;

			trapezoidal_integral += 0.5 * (x2 - x1) * (func(x1) + func(x2));
		}
		cout << width;
		return trapezoidal_integral;
}

int main()
{
	setlocale(LC_ALL, "Russian");
	cout << "Введите начало интервала: ";
	double a;
	cin >> a;
	cout << "Введите конец интервала: ";
	double b;
	cin >> b;
	cout << "Введите необходимую точность расчета: ";
	double e;
	cin >> e;


	int n = 1000;
	double h = b - a;
	const double r = 2;

	double result;
	cout << "\nМетод левых прямоугольников:\nШаг = ";
	result = leftRec(e, r, h, a, b);
	cout << "\nРезультат: " << result << "\n";

	cout << "\nМетод центральных прямоугольников:\nШаг = ";
	result = middleRec(e, r, h, a, b);
	cout << "\nРезультат: " << result << "\n";

	cout << "\nМетод Ньютона-Котеса:\nШаг = ";
	result = methNU_KT(e, r, h, a, b, n);
	cout << "\nРезультат: " << result << "\n";



	return 0;
}

