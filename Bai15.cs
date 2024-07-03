using System;
using System.Text;

class Bai15
{
    static byte ReadByte2to10()
    {
        byte value;
        while (true)
        {
            if (byte.TryParse(Console.ReadLine(), out value) && value >= 2 && value <= 10)
                return value;
            Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập một số nguyên từ 2 đến 10.");
        }
    }

    static float ReadFloat()
    {
        float value;
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập một số thực.");
        }
    }

    static float[] ReadFloatArray(byte n)
    {
        float[] array = new float[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            array[i] = ReadFloat();
        }
        return array;
    }

    static void Main()
    {
        // Thiết lập encoding để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        
        Console.WriteLine("Giá trị của n: {n}\n");
        byte n = ReadByte2to10();
        float[] a = new float[n];
        a = ReadFloatArray(n);

        Console.WriteLine("Mảng a:");
        foreach (float value in a)
            Console.WriteLine(value);
    }
}