class Program
{
    static void Main()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Find the second largest element in a one-dimensional array.");
        Console.WriteLine("2. Sort a two-dimensional array in ascending order.");
        Console.WriteLine("3. Remove an element from a one-dimensional array by index.");
        Console.WriteLine("4. Find the sum of diagonal elements in a two-dimensional array.");
        
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            int[] array = { 5, 3, 9, 1, 8 };
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in array)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num < largest)
                {
                    secondLargest = num;
                }
            }

            Console.WriteLine("Second largest element is: " + secondLargest);
        }
        else if (choice == 2)
        {
            int[,] matrix = {
                { 5, 1, 7 },
                { 3, 8, 2 },
                { 4, 6, 9 }
            };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] flatArray = new int[rows * cols];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    flatArray[index] = matrix[i, j];
                    index++;
                }
            }

            for (int i = 0; i < flatArray.Length; i++)
            {
                for (int j = i + 1; j < flatArray.Length; j++)
                {
                    if (flatArray[j] < flatArray[i])
                    {
                        int temp = flatArray[i];
                        flatArray[i] = flatArray[j];
                        flatArray[j] = temp;
                    }
                }
            }

            index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = flatArray[index];
                    index++;
                }
            }

            Console.WriteLine("Sorted matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        else if (choice == 3)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Enter the index to remove:");
            int indexToRemove = int.Parse(Console.ReadLine());

            if (indexToRemove >= 0 && indexToRemove < array.Length)
            {
                int[] newArray = new int[array.Length - 1];
                int newIndex = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (i != indexToRemove)
                    {
                        newArray[newIndex] = array[i];
                        newIndex++;
                    }
                }

                Console.WriteLine("Array after removal:");
                foreach (int num in newArray)
                {
                    Console.Write(num + " ");
                }
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
        else if (choice == 4)
        {
            int[,] matrix = {
                { 2, 1, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int size = matrix.GetLength(0);
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine("Sum of diagonal elements is: " + sum);
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }
}
