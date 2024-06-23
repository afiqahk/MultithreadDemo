// See https://aka.ms/new-console-template for more information
using MultithreadConsoleApp;
using SkiaSharp;
using System.Collections.Concurrent;

Console.WriteLine("Hello, World!");

ConcurrentQueue<int> qInput = new();
ConcurrentQueue<int> qOutput = new();
CancellationTokenSource cts = new CancellationTokenSource();

Controller controller = new Controller(cts, Utils.LogExitStatus);
Sender sender = new Sender(Utils.LogExitStatus);
Receiver receiver = new Receiver(Utils.LogExitStatus);
Processor processor = new Processor(Utils.LogExitStatus);

Thread controllerCaller = new Thread(
    new ThreadStart(controller.Run));
Thread senderCaller = new Thread(
    new ParameterizedThreadStart(sender.Run));
Thread receiverCaller = new Thread(
    new ParameterizedThreadStart(receiver.Run));
Thread processorCaller = new Thread(
    new ParameterizedThreadStart(processor.Run));

controllerCaller.Start();
processorCaller.Start(cts.Token);
receiverCaller.Start(cts.Token);
senderCaller.Start(cts.Token);

controllerCaller.Join();

cts.Dispose();
Console.WriteLine("Bye, World!");
