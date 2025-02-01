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

