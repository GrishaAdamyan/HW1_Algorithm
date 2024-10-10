using System;

class Program
{
    static void RecursiveSelectionSort(int[] arr, int n, int index = 0)
    {
        if (index == n)
            return;

        int minIndex = index;
        for (int j = index + 1; j < n; j++)
        {
            if (arr[j] < arr[minIndex])
                minIndex = j;
        }

        if (minIndex != index)
        {
            int temp = arr[minIndex];
            arr[minIndex] = arr[index];
            arr[index] = temp;
        }

        RecursiveSelectionSort(arr, n, index + 1);
    }
    class Queue
    {
        private int[] elements;
        private int front;
        private int rear;
        private int max;

        public Queue(int size)
        {
            elements = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }
        public void Enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                elements[++rear] = item;
                Console.WriteLine($"Inserted {item}");
            }
        }
        public int Dequeue()
        {
            if (front > rear)
            {
                Console.WriteLine("Queue Underflow");
                return -1;
            }
            else
            {
                int item = elements[front++];
                return item;
            }
        }
        public void Print()
        {
            if (front > rear)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                Console.WriteLine("Queue elements are:");
                for (int i = front; i <= rear; i++)
                {
                    Console.Write(elements[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    static void Main(string[] args)
    {
        int[] arr = { 64, 25, 12, 22, 11 };
        RecursiveSelectionSort(arr, arr.Length);
        Console.WriteLine("Sorted array:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Queue queue = new Queue(5);
        queue.Enqueue(3);
        queue.Enqueue(17);
        queue.Enqueue(24);
        queue.Enqueue(35);
        queue.Enqueue(36);
        queue.Enqueue(25);
        queue.Print();
        Console.WriteLine($"Removed: {queue.Dequeue()}");
        Console.WriteLine($"Removed: {queue.Dequeue()}");
        queue.Print();
    }
}