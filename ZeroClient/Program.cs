using System;
using NetMQ;
using NetMQ.Sockets;

namespace ZeroClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string topic = "";

            if(args.Length > 0)
            {
                topic = args[0];
            }

            Console.WriteLine($"Initialized Client for numbers that start with {topic}");

            using (var subscriber = new SubscriberSocket())
            {
                subscriber.Connect("tcp://localhost:5555");
                
                subscriber.Subscribe(topic);

                Console.Write("Received:");
                while(true)
                {
                    var message = subscriber.ReceiveFrameString();

                    Console.Write($" {message}");
                }
            }
        }
    }
}
