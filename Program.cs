using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //#1
            int size = 5;
            int[] arrayA = new int[size];

            int size1 = 3, size2 = 4;
            double[,] arrayB = new double[size1, size2];

            Console.WriteLine("Введите числа");
            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayA[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    arrayB[i, j] = (double)random.Next(100) / 10;
                }
            }

            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.Write(arrayA[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    Console.Write(arrayB[i, j] + " ");
                }
                Console.WriteLine();
            }

            int arrayAMax = arrayA.Max();

            int arrayBMaxFirstIndex = 0, arrayBMaxSecondIndex = 0;
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    if (arrayB[arrayBMaxFirstIndex, arrayBMaxSecondIndex] < arrayB[i, j])
                    {
                        arrayBMaxFirstIndex = i;
                        arrayBMaxSecondIndex = j;
                    }
                }
            }
            double arrayBMax = arrayB[arrayBMaxFirstIndex, arrayBMaxSecondIndex];

            Console.WriteLine("Максимальный элемент в первом массиве - " + arrayAMax + ", во втором массиве - " + arrayBMax);

            int arrayAMin = arrayA.Min();

            int arrayBMinFirstIndex = 0, arrayBMinSecondIndex = 0;
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    if (arrayB[arrayBMinFirstIndex, arrayBMinSecondIndex] > arrayB[i, j])
                    {
                        arrayBMinFirstIndex = i;
                        arrayBMinSecondIndex = j;
                    }
                }
            }
            double arrayBMin = arrayB[arrayBMinFirstIndex, arrayBMinSecondIndex];

            Console.WriteLine("Минимальный элемент в первом массиве - " + arrayAMin + ", во втором массиве - " + arrayBMin);

            int arrayAElementsSum = 0;
            double arrayBElementsSum = 0;

            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayAElementsSum += arrayA[i];
            }

            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    arrayBElementsSum += arrayB[i, j];
                }
            }

            Console.WriteLine("Cумма всех элементов 2х массивов - " + (arrayAElementsSum + arrayBElementsSum));


            int arrayAElementsMult = 1;
            double arrayBElementsMult = 1;

            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayAElementsMult *= arrayA[i];
            }

            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    arrayBElementsMult *= arrayB[i, j];
                }
            }

            Console.WriteLine("Произведение всех элементов 2х массивов - " + (arrayAElementsSum + arrayBElementsSum));


            int arrayAEvenElementsSum = 0;
            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] % 2 == 0)
                {
                    arrayAEvenElementsSum += arrayA[i];
                }
            }

            Console.WriteLine("Сумма четных элементов первого массива - " + arrayAEvenElementsSum);

            double arrayBOddElementsSum = 0;
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    if (j % 2 != 0)
                    {
                        arrayBOddElementsSum += arrayB[i, j];
                    }
                }
            }

            Console.WriteLine("Сумма элементов в нечетных столбцах второго массива - " + arrayBOddElementsSum);

            Console.WriteLine("Нажмите enter для продолжения");
            Console.ReadLine();

            //#2 
            Console.Clear();
            int sizeM = 5;
            int sizeN = 7;

            int[] arrayM = new int[sizeM];
            int[] arrayN = new int[sizeN];

            for (int i = 0; i < arrayM.Length; i++)
            {
                arrayM[i] = random.Next(100);
            }
            for (int i = 0; i < arrayN.Length; i++)
            {
                arrayN[i] = random.Next(100);
            }
            Console.WriteLine("1й массив: ");
            for (int i = 0; i < arrayM.Length; i++)
            {
                Console.Write(arrayM[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("2й массив: ");
            for (int i = 0; i < arrayN.Length; i++)
            {
                Console.Write(arrayN[i] + " ");
            }
            int thirdArrSize = 0;
            bool isIncreased = false;
            for (int i = 0; i < arrayM.Length; i++)
            {
                for (int j = 0; j < arrayN.Length; j++)
                {
                    if (arrayM[i] == arrayN[j])
                    {
                        if (i != 0)
                        {
                            bool isOk = true;
                            for (int k = 0; k < i; k++)
                            {
                                if (arrayN[k] == arrayM[i])
                                {
                                    isOk = false;
                                    break;
                                }
                            }
                            if (isOk)
                            {
                                thirdArrSize++;
                            }
                        }
                        else
                        {
                            if (!isIncreased)
                            {
                                thirdArrSize++;
                                isIncreased = true;
                            }
                        }
                    }
                }
            }

            isIncreased = false;
            int[] thirdArray = new int[thirdArrSize];

            for (int i = 0, q = 0; i < arrayM.Length; i++)
            {
                for (int j = 0; j < arrayN.Length; j++)
                {
                    if (arrayM[i] == arrayN[j])
                    {
                        if (i != 0)
                        {
                            bool isOk = true;
                            for (int k = 0; k < i; k++)
                            {
                                if (arrayN[k] == arrayM[i])
                                {
                                    isOk = false;
                                    break;
                                }
                            }
                            if (isOk)
                            {
                                thirdArray[q] = arrayM[i];
                                q++;
                            }
                        }
                        else
                        {
                            if (!isIncreased)
                            {
                                thirdArray[q] = arrayM[i];
                                q++;
                                isIncreased = true;
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("3й массив: ");
            for (int i = 0; i < thirdArray.Length; i++)
            {
                Console.Write(thirdArray[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите Enter для продолжения");
            Console.ReadLine();

            //#3
            Console.Clear();
            Console.WriteLine("Введите строку");
            char[] userString = Console.ReadLine().ToCharArray();
            String sourceString = new String(userString);
            Array.Reverse(userString);
            String reversedString = new String(userString);

            sourceString = sourceString.ToLower();
            reversedString = reversedString.ToLower();

            sourceString.Replace(" ", String.Empty);
            reversedString.Replace(" ", String.Empty);

            if (sourceString == reversedString)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
            Console.WriteLine("Нажмите Enter для продолжения");
            Console.ReadLine();


            //#4
            Console.Clear();
            Console.WriteLine("Введите строку");
            string enteredString = Console.ReadLine();
            string[] splittedString = enteredString.Split(' ');
            Console.WriteLine("Количество слов в строке: " + splittedString.Length);
            Console.WriteLine("Нажмите Enter чтобы продолжить");
            Console.ReadLine();

            //#5
            Console.Clear();
            int rowsArrayFive = 5, colsArrayFive = 5;
            int[,] arrayFiveByFive = new int[rowsArrayFive, colsArrayFive];

            for (int i = 0; i < rowsArrayFive; i++)
            {
                for (int j = 0; j < colsArrayFive; j++)
                {
                    arrayFiveByFive[i, j] = random.Next(-100, 100);
                }
            }

            for (int i = 0; i < rowsArrayFive; i++)
            {
                for (int j = 0; j < colsArrayFive; j++)
                {
                    Console.Write(arrayFiveByFive[i, j] + " ");
                }
                Console.WriteLine();
            }

            int arrayFiveByFiveMaxFirstIndex = 0, arrayFiveByFiveMinFirstIndex = 0;
            int arrayFiveByFiveMaxSecondIndex = 0, arrayFiveByFiveMinSecondIndex = 0;

            for (int i = 0; i < rowsArrayFive; i++)
            {
                for (int j = 0; j < colsArrayFive; j++)
                {
                    if (arrayFiveByFive[arrayFiveByFiveMaxFirstIndex, arrayFiveByFiveMaxSecondIndex] < arrayFiveByFive[i, j])
                    {
                        arrayFiveByFiveMaxFirstIndex = i;
                        arrayFiveByFiveMaxSecondIndex = j;
                    }
                }
            }

            for (int i = 0; i < rowsArrayFive; i++)
            {
                for (int j = 0; j < colsArrayFive; j++)
                {
                    if (arrayFiveByFive[arrayFiveByFiveMinFirstIndex, arrayFiveByFiveMinSecondIndex] > arrayFiveByFive[i, j])
                    {
                        arrayFiveByFiveMinFirstIndex = i;
                        arrayFiveByFiveMinSecondIndex = j;
                    }
                }
            }
            int sumOfArrayElements = 0;

            if (arrayFiveByFiveMaxSecondIndex < arrayFiveByFiveMinSecondIndex)
            {
                int tmp = arrayFiveByFiveMaxSecondIndex;
                arrayFiveByFiveMaxSecondIndex = arrayFiveByFiveMinSecondIndex;
                arrayFiveByFiveMinSecondIndex = tmp;
            }

            if (arrayFiveByFiveMaxFirstIndex < arrayFiveByFiveMinFirstIndex)
            {
                int tmp = arrayFiveByFiveMaxFirstIndex;
                arrayFiveByFiveMaxFirstIndex = arrayFiveByFiveMinFirstIndex;
                arrayFiveByFiveMinFirstIndex = tmp;
            }
            for (int i = arrayFiveByFiveMinFirstIndex; i < arrayFiveByFiveMaxFirstIndex; i++)
            {
                int lowerBoundForSecondIndex = 0, upperBoundForSecondIndex = colsArrayFive;
                if (i == arrayFiveByFiveMinFirstIndex)
                {
                    lowerBoundForSecondIndex = arrayFiveByFiveMinSecondIndex;
                }
                if (i == arrayFiveByFiveMaxFirstIndex - 1)
                {
                    upperBoundForSecondIndex = arrayFiveByFiveMaxSecondIndex;
                }

                for (int j = lowerBoundForSecondIndex; j < upperBoundForSecondIndex; j++)
                {
                    sumOfArrayElements += arrayFiveByFive[i, j];
                }
            }
            Console.WriteLine("Минимальный элемент " + arrayFiveByFive[arrayFiveByFiveMinFirstIndex, arrayFiveByFiveMinSecondIndex]);
            Console.WriteLine("Максимальный элемент " + arrayFiveByFive[arrayFiveByFiveMaxFirstIndex, arrayFiveByFiveMaxSecondIndex]);
            Console.WriteLine("Сумма элементов между минимальным и максимальным элементами " + sumOfArrayElements);
            Console.WriteLine("Нажмите enter чтобы выйти");
            Console.ReadLine();
        }
    }
}