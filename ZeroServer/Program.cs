using System;
using System.Threading;
using NetMQ;
using NetMQ.Sockets;

namespace ZeroServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var publisher = new PublisherSocket())
            {
                publisher.Bind("tcp://*:5555");

                var random = new Random();
                while (true)
                {
                    publisher.SendFrame($"{random.Next(0, 1000)}");
                }
            }
        }
    }
}
