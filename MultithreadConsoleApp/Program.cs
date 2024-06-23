// See https://aka.ms/new-console-template for more information
using MultithreadConsoleApp;
using SkiaSharp;
using System.Collections.Concurrent;

ConcurrentQueue<int> qInput = new();
ConcurrentQueue<int> qOutput = new();

Console.WriteLine("Hello, World!");

Thread controllerCaller = new Thread(
    new ThreadStart(Controller.RunController));
Thread senderCaller = new Thread(
    new ThreadStart(Sender.RunSender));
Thread receiverCaller = new Thread(
    new ThreadStart(Receiver.RunReceiver));
Thread processorCaller = new Thread(
    new ThreadStart(Receiver.RunReceiver));


controllerCaller.Start();
controllerCaller.Join();
processorCaller.Start();
receiverCaller.Start();
senderCaller.Start();

Console.WriteLine("Bye, World!");
