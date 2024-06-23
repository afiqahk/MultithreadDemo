// See https://aka.ms/new-console-template for more information
using MultithreadConsoleApp;
using SkiaSharp;
using System.Collections.Concurrent;

Console.WriteLine("Hello, World!");

ConcurrentQueue<int> qInput = new();
ConcurrentQueue<int> qOutput = new();
CancellationTokenSource cts = new CancellationTokenSource();

Controller controller = new Controller(cts);
Sender sender = new Sender(Utils.LogExitStatus);

Thread controllerCaller = new Thread(
    new ThreadStart(controller.RunController));
Thread senderCaller = new Thread(
    new ParameterizedThreadStart(sender.RunSender));
Thread receiverCaller = new Thread(
    new ThreadStart(Receiver.RunReceiver));
Thread processorCaller = new Thread(
    new ThreadStart(Receiver.RunReceiver));

controllerCaller.Start();
processorCaller.Start();
receiverCaller.Start();
senderCaller.Start(cts.Token);

controllerCaller.Join();

cts.Dispose();
Console.WriteLine("Bye, World!");
