using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class ProducerConsumerClass
    {
        private Queue<int> queue=new Queue<int>();
        private int capacity=5;
        private readonly object locker=new object();

        public void Produce()
        {
            int value = 1;
            while(true)
            {
                lock(locker)
                {
                    if (queue.Count == capacity)
                    {
                        Monitor.Wait(locker);
                    }
                    queue.Enqueue(value);
                    Console.WriteLine($"Produce :{value}");
                    value++;
                    Monitor.PulseAll(locker);
                }
                Thread.Sleep(500);
            }
        }

        public void Consume()
        {
            while(true)
            {
                lock (locker)
                {
                    if(queue.Count == 0)
                    {
                        Monitor.Wait(locker);
                    }
                    int value=queue.Dequeue();
                    Console.WriteLine($"Consume :{value}");
                    Monitor.PulseAll(locker);
                }
                Thread.Sleep(500);
            }
        }
    }
    internal class ProducerConsumer
    {
        public static void Main()
        {
            ProducerConsumerClass pc = new ProducerConsumerClass();

            Thread producer = new Thread(pc.Produce);
            Thread consumer = new Thread(pc.Consume);

            producer.Start();
            consumer.Start();

            producer.Join();
            consumer.Join();
        }
    }
}
