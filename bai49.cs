using System;

class Program
{
    static void Main()
    {
        // Khai báo các mảng để thử
        int[] intArray = { 3, 1, 4, 1, 5, 9 };
        uint[] uintArray = { 3, 1, 4, 1, 5, 9 };
        float[] floatArray = { 3.1f, 1.4f, 1.1f, 5.9f, 2.6f };
        double[] doubleArray = { 3.14, 2.71, 1.61, 0.57, 1.41 };

        // Khai báo biến dynamic để lưu giá trị nhỏ nhất
        dynamic min_value;

        // Gọi hàm với mảng số nguyên 4 byte và in ra giá trị nhỏ nhất
        min_value = FindMinValue(intArray);
        Console.WriteLine("Giá trị nhỏ nhất của mảng intArray: " + min_value.ToString());

        // Gọi hàm với mảng số nguyên 4 byte không dấu và in ra giá trị nhỏ nhất
        min_value = FindMinValue(uintArray);
        Console.WriteLine("Giá trị nhỏ nhất của mảng uintArray: " + min_value.ToString());

        // Gọi hàm với mảng số thực 4 byte và in ra giá trị nhỏ nhất
        min_value = FindMinValue(floatArray);
        Console.WriteLine("Giá trị nhỏ nhất của mảng floatArray: " + min_value.ToString());

        // Gọi hàm với mảng số thực 8 byte và in ra giá trị nhỏ nhất
        min_value = FindMinValue(doubleArray);
        Console.WriteLine("Giá trị nhỏ nhất của mảng doubleArray: " + min_value.ToString());
    }

    // Hàm static generic để tìm giá trị nhỏ nhất của mảng
    static T FindMinValue<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array không được rỗng");

        T minValue = array[0];

        foreach (T item in array)
        {
            if (item.CompareTo(minValue) < 0)
            {
                minValue = item;
            }
        }

        return minValue;
    }
}
