#include<iostream>
#include<iomanip>
using namespace std;
int main()
{
	int opt, sub_opt, range, num=1, num2;
	cout << "option 1 : half pyramid." << endl;
	cout << "option 2 : inverted half pyramid." << endl;
	cout << "option 3 : right oriented half pyramid." << endl;
	cout << "option 4 : right oriented inverted half pyramid." << endl;
	cout << "select option 1-4 :";
	cin >> opt;
	cout << "sub_option 1 : starik half pyramid." << endl;
	cout << "sub_option 2 : increasing number half pyramid." << endl;
	cout << "sub_option 3 : decreasing number half pyramid." << endl;
	cout << "sub_option 4 : starik inverted half pyramid." << endl;
	cout << "sub_option 5 : increasing number inverted half pyramid." << endl;
	cout << "sub_option 6 : decreasing number inverted half pyramid." << endl;
	cout << "sub_option 7 : starik right oriented half pyramid." << endl;
	cout << "sub_option 8 : incresing number right oriented half pyramid." << endl;
	cout << "sub_option 9 : decresing number right oriented half pyramid." << endl;
	cout << "sub_option 10 : starik right oriented inverted half pyramid." << endl;
	cout << "sub_option 11 : increasing number right oriented inverted half pyramid." << endl;
	cout << "sub_option 12 : decreasing number right oriented inverted half pyramid." << endl;
	cout << "select sub-option 1-12 :";
	cin >> sub_opt;
	cout << "enter range :";
	cin >> range;
	num2 = range;
	if (opt == 1)
		if (sub_opt == 1)
		{
			for (int a = 1; a <= range; a++)
			{
				for (int b = 1; b <= a; b++)
					cout << "*";
				cout << endl;
			}
		}
		if (sub_opt == 2)
		{
			for (int a = 1; a <= range; a++)
			{
				for (int b = 1; b <= a; b++)
					cout << num;
				++num;
				cout << endl;
			}
		}
		if (sub_opt == 3)
		{
			for (int a = 1; a <= range; a++)
			{
				for (int b = 1; b <= a; b++)
					cout << num2;
				--num2;
				cout << endl;
			}
		}
	
	else if (opt == 2)
		if (sub_opt == 4)
		{
			for (int c = 1; c <= range; c++)
			{
				for (int d = range; d >= c; d--)
					cout << "*";
				cout << endl;
			}
		}
		if (sub_opt == 5)
		{
			for (int c = 1; c <= range; c++)
			{
				for (int d = range; d >= c; d--)
					cout << num;
				++num;
				cout << endl;
			}
		}
		if (sub_opt == 6)
		{
			for (int c = 1; c <= range; c++)
			{
				for (int d = range; d >= c; d--)
					cout << num2;
				--num2;
				cout << endl;
			}
		}
	else if (opt == 3)
		if(sub_opt==7)
		{
			for (int e = 1; e <= range; e++)
			{
			for (int f = range - e; f > 0; f--)
			{
				cout << " ";
			}

			for (int g = 1; g <= e; g++)
			{
				cout << "*";
				cout << endl;
		}
		if (sub_opt == 8)
		{
			for (int e = 1; e <= range; e++)
			{
			for (int f = range - e; f > 0; f--)
			{
				cout << " ";
			}
			
			for (int g = 1; g <= e; g++)
			{
				cout << num;
				++num;
				cout << endl;
		}
		if (sub_opt == 9)
		{
			for (int e = 1; e <= range; e++)
			{
			for (int f = range - e; f > 0; f--)
			{
				cout << " ";
			}

			for (int g = 1; g <= e; g++)
			{
				cout << num2;
				--num2;
				cout << endl;
		}
	else if (opt == 4)
		if(sub_opt==10)
		{
			for (int x = 1; x <= range; x++)
			{
				for (int s = x; s > 1; s--)
				{
					cout << " ";
				}

				for (int z = range; z >= x; z--)
				{
					cout << "*";
				}
				cout << endl;
			}
		}
		if (sub_opt == 11)
		{
		for (int x = 1; x <= range; x++)
			{
				for (int s = x; s > 1; s--)
				{
					cout << " ";
				}
				for (int z = range; z >= x; z--)
				{
				cout << num;
				++num;
				}
				cout << endl;
			}
		}
		if (sub_opt == 12)
		{
		for (int x = 1; x <= range; x++)
			{
				for (int s = x; s > 1; s--)
				{
					cout << " ";
				}

				for (int z = range; z >= x; z--)
				{
					cout << num2;
					--num2;
				}
					cout << endl;
			}
		}
	system("pause>0");
}
