using System;
using System.Text;

class Bai14
{
    static float ReadFloat()
    {
        float value;
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại một số thực.");
        }
    }

    static void Main()
    {
        // Thiết lập encoding để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        float x = ReadFloat();
        Console.WriteLine($"Giá trị của x: {x}");
    }
}