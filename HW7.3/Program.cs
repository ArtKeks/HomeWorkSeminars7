void ArrayFromEnd(int[] arr, int index)
        {
            if (index >= 0)
            {
                Console.Write($"{arr[index]}");
                if (index > 0) 
                {
                    Console.Write(", "); 
                }
                ArrayFromEnd(arr, index - 1);
            }
            
            
        }
            int[] myArray = { 77, 56, 3, -2, 11 };

            Console.WriteLine("Элементы массива, начиная с конца:");
            Console.Write("[");
            ArrayFromEnd(myArray, myArray.Length - 1);
             Console.Write("]");