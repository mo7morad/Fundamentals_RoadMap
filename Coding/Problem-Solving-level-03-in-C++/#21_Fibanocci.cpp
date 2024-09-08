#include <iostream>
#include <cstdlib>
#include <iomanip>
using namespace std;

void Fibonnaci(int Iterations){
    short prev1 = 1, prev2 = 0, fib = 0;
    for(short i = 0; i < Iterations; ++i){
        if (i == 0)
            cout << 1 << " ";
        fib = prev1 + prev2;
        cout << fib << " ";
        prev2 = prev1;
        prev1 = fib;
    }
}

int FibonnaciRecursion(int Iterations){
    if (Iterations == 0)
        return 0;
    if (Iterations == 1)
        return 1;
    return FibonnaciRecursion(Iterations - 1) + FibonnaciRecursion(Iterations - 2);
}

int main()
{
    int itr;
    cout << "Enter the number of iterations: ";
    cin >> itr;
    Fibonnaci(itr);
    cout << endl;
    cout << "Recursion:\n";
    for (int i = 1; i <= itr+1; ++i)
    {
        cout << FibonnaciRecursion(i) << " ";
    }
    return 0;
};

// Course Code

/*
#include<iostream>

using namespace std;

void PrintFibonacciUsingLoop(short Number) {
    int FebNumber = 0;
    int Prev2 = 0, Prev1 = 1;
    cout << "1   ";
    for (short i = 2; i <= Number; ++i) {
        FebNumber = Prev1 + Prev2;
        cout << FebNumber << "    ";
        Prev2 = Prev1;
        Prev1 = FebNumber;
    }
}

int main() {
    PrintFibonacciUsingLoop(10);
    system("pause>0");
    return 0;
}
*/