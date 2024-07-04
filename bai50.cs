Trong C#, bạn có thể sử dụng suy luận kiểu (type inference) để tránh phải chỉ định kiểu dữ liệu rõ ràng khi gọi các phương thức generic. Khi trình biên dịch có thể suy ra kiểu dữ liệu từ ngữ cảnh, bạn không cần chỉ định kiểu dữ liệu tường minh.
Ví dụ, nếu bạn có một phương thức generic như sau:

public static T FindMin<T>(T[] array) where T : IComparable<T>
{
    if (array == null || array.Length == 0)
        throw new ArgumentException("Array cannot be null or empty.");
    
    T min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i].CompareTo(min) < 0)
        {
            min = array[i];
        }
    }
    return min;
}
```

Bạn có thể gọi phương thức này mà không cần chỉ định kiểu dữ liệu tường minh, như sau:


int[] intArray = { 3, 1, 4, 1, 5, 9 };
double[] doubleArray = { 3.1, 4.1, 5.9, 2.6, 5.3 };

int minInt = FindMin(intArray);
double minDouble = FindMin(doubleArray);
```

Trong ví dụ trên, trình biên dịch sẽ tự động suy ra kiểu dữ liệu `T` từ kiểu của mảng được truyền vào. Do đó, thay vì viết:


min_value = FindMin<int>(intArray); 
```

Bạn có thể viết:


min_value = FindMin(intArray);
```

và tương tự với các kiểu dữ liệu khác như `double`:


min_value = FindMin(doubleArray);
```

Điều này giúp mã nguồn trở nên ngắn gọn và dễ đọc hơn.
