using System;

namespace Bai16
{
    class Bai16
    {
        static void Main(string[] args)
        {
            // Khai báo m, n
            byte m, n;
            // Gọi hàm nhập m, n
            GetMN(out m, out n);
            Console.WriteLine($"Giá trị của m là: {m}");
            Console.WriteLine($"Giá trị của n là: {n}");

            // Khai báo mảng 2 chiều a
            int[,] a = new int[m, n];
            // Gọi hàm nhập giá trị cho mảng a
            InputArray2D(a);
            // In mảng a
            PrintArray2D(a);

            // Tính tổng các phần tử chia hết cho 2024
            int sum = SumDivisibleBy2024(a);
            Console.WriteLine($"Tổng các phần tử chia hết cho 2024 là: {sum}");
        }

        // Hàm đọc số nguyên 1 byte, không dấu, nằm trong khoảng 2 đến 10
        static byte GetByte1()
        {
            byte b;
            do
            {
                Console.Write("Nhập số nguyên 1 byte (2-10): ");
            } while (!byte.TryParse(Console.ReadLine(), out b) || b < 2 || b > 10);
            return b;
        }

        // Hàm đọc số nguyên 4 byte
        static int GetInt4()
        {
            int i;
            do
            {
                Console.Write("Nhập số nguyên 4 byte: ");
            } while (!int.TryParse(Console.ReadLine(), out i));
            return i;
        }

        // Hàm nhập giá trị cho mảng 2 chiều
        static void InputArray2D(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"Nhập phần tử a[{i},{j}]: ");
                    a[i, j] = GetInt4();
                }
            }
        }

        // Hàm in mảng 2 chiều
        static void PrintArray2D(int[,] a)
        {
            Console.WriteLine("Mảng 2 chiều a:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        // Hàm tính tổng các phần tử chia hết cho 2024
        static int SumDivisibleBy2024(int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] % 2024 == 0)
                    {