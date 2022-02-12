// BubbleSort.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

class Sort
{
    public:
        static int ascendingOrder(int arrayOfValues[], int arraySize)
        {
            int temp = 0;
            int pass = 0;

            for (int i = 0; i < arraySize; i++) 
            {
                for (int j = i + 1; j < arraySize; j++)
                {
                    if (arrayOfValues[j] < arrayOfValues[i])
                    {
                        temp = arrayOfValues[i];
                        arrayOfValues[i] = arrayOfValues[j];
                        arrayOfValues[j] = temp;
                    }
                }

                pass++;
            }

            return pass;
        }

        static int descendingOrder(int arrayOfValues[], int arraySize)
        {
            int temp = 0;
            int pass = 0;

            for (int i = arraySize - 1; i >= 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arrayOfValues[j] < arrayOfValues[i])
                    {
                        temp = arrayOfValues[i];
                        arrayOfValues[i] = arrayOfValues[j];
                        arrayOfValues[j] = temp;
                    }
                }

                pass++;
            }

            return pass;
        }
};

int main()
{
    std::cout << "Bubble Sort!\n";

    int pass = 0;
    int a[] = { 10,-2,0,14,43,25,18,1,5,45,-8 };
    int b[] = { 10,-2,0,14,43,25,18,1,5,45,100,-9,12 };

    int arrayASize = sizeof(a) / sizeof(a[0]);
    int arrayBSize = sizeof(b) / sizeof(b[0]);

    std::cout << "Input List A...\n";
    for (int i = 0; i < arrayASize; i++)
    {
        std::cout << a[i] << " ";
    }

    std::cout << "\nInput List B...\n";
    for (int i = 0; i < arrayBSize; i++)
    {
        std::cout << b[i] << " ";
    }

    Sort::ascendingOrder(a, arrayASize);
    Sort::descendingOrder(b, arrayBSize);

    std::cout << "\nOutput List A...\n";

    for (int i = 0; i < arrayASize; i++)
    {
        std::cout << a[i] << " ";
    }

    std::cout << "\nOutput List B...\n";

    for (int i = 0; i < arrayBSize; i++)
    {
        std::cout << b[i] << " ";
    }

    std::cout << "\nEnd\n";
}

