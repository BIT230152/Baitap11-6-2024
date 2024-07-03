using System;
using System.Text;

class Bai12
{
    static ushort ReadUshort()
    {
        ushort value;
        while (true)
        {
            if (ushort.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
        }
    }

    static void Main()
    {
        // Thiết lập encoding để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        
        Console.WriteLine($"  Giá trị của n: {n} ");
        ushort n = ReadUshort();
        long sum = 0;
        for (ushort i = 1; i <= n; i++)
        {
            sum += i * i;
        }

        Console.WriteLine($"Tổng bình phương các số từ 1 đến {n}: {sum}");
    }
}