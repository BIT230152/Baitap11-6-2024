using System;
using System.Text;

class Bai13
{
    static byte ReadByte()
    {
        byte value;
        while (true)
        {
            if (byte.TryParse(Console.ReadLine(), out value) && value >= 2 && value <= 10)
                return value;
            Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại một số từ 2 đến 10.");
        }
    }

    static void Main()
    {
        // Thiết lập encoding để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        
        Console.WriteLine($"Giá trị của n: {n}");

        byte n = ReadByte();
    }

}