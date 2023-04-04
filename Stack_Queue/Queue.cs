using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lantz_assignment_4
{
    class Queue
    {
        private static int front, back, capacity = 5;
        private static int[] queueArray;

        //Constructor to set values
        public Queue()
        {
            front = back = 0;
            queueArray = new int[capacity];
        }
    
        //Method to insert an element at the rear of the queue
        public void queueEnqueue(int data)
        {
            //Check if queue is full
            if(capacity == back)
            {
                Write("\nQueue is empty\n");
                return;
            }

            //Insert element at the back of queue
            else
            {
                queueArray[back] = data;
                back++;
            }
            return;
        }
    
        //Method to delete an element from the front of the queue
        public void queueDequeue()
        {
            //If queue is empty
            if(front == back)
            {
                WriteLine("\nQueue is empty");
                return;
            }

            //Shift all elements from index 22 till back to the right by one
            else
            {
                for (int i = 0; i < back; i++)
                    queueArray[i] = queueArray[i + 1];

                //Store 0 at back indicating there's no element
                if (back < capacity)
                    queueArray[back] = 0;

                back--;
            }
            return;
        }
    
        //Method to display all elements in the Queue
        public void queueDisplay()
        {
            if(front == back)
            {
                WriteLine("\nQueue is empty");
                return;
            }

            //Traverse front to rear and print elements
            for (int i = front; i < back; i++)
                Write(" {0} <-- ", queueArray[i]);

            return;
        }
    
        //Show front of Queue
        public void queueFront()
        {
            if(front == back)
            {
                WriteLine("\nQueue is empty");
                return;
            }
            Write("\nFront element is: " + queueArray[front]);
            return;
        }

        //Show number of elements in the queue
        public int QueueSize()
        {
            return back - 1;
        }
    
    
    
    }//End of class
}
