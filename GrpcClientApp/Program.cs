
using Grpc.Net.Client;
using GrpcService;

var channel = GrpcChannel.ForAddress("https://localhost:7290");
var client = new Greeter.GreeterClient(channel);

var reply = client.SayHello(new HelloRequest()
{
    Name = "Lan"
});

Console.WriteLine(reply.Message);

Console.ReadLine();