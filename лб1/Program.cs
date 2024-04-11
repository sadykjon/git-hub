using System;

namespace Example
{
    class Program
    {
        static void Main()
        {
            //// Заданное значение x
            //double x = 14.5;

            //// Точность E
            //double E = 1e-4;

            //// Инициализация переменной для хранения суммы
            //double sum = 0;

            //// Переменная для хранения значения текущего члена ряда
            //double term = 0;

            //// Переменная для хранения знака члена ряда
            //int sign = 1;

            //// Инициализация переменной для итерации (начинаем с нуля)
            //int n = 0;

            //// Пока значение текущего члена ряда больше заданной точности E
            //while (Math.Abs(term = (sign * x) / (2 * n + 1)) >= E)
            //{
            //    // Добавляем текущий член ряда к сумме
            //    sum += term;

            //    // Меняем знак для следующего члена ряда
            //    sign *= -1;

            //    // Увеличиваем n для следующего члена ряда
            //    n++;
            //}

            //// Вывод результата
            //Console.WriteLine($"Сумма ряда с точностью {E} для x = {x} равна {sum}");


            double x = 14.5;
            double s = 0;
            double term;
            int n = 0;

            do
            {
                term = Math.Pow(-1, n) * x / (2 * n + 1);
                s += term;
                n++;
            } while (Math.Abs(term) >= 1e-4);

            Console.WriteLine($"Значение s для x={x} с точностью E=10^-4: {s}");


            //double x = 14.5;
            //double s = -2.1118;
            //double term;
            //int n = 0;

            //do
            //{
            //    term = Math.Pow(-1, n) * Math.Pow(x, n) / (2 * n + 1);
            //    s += term;
            //    n++;
            //} while (Math.Abs(term) >= 1e-4);

            //Console.WriteLine($"Значение s для x={x} с точностью E=10^-4: {s}");

        }
    }
    }

