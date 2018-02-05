using System;
using Cyberkruz.Autorest.Client;
using Microsoft.Rest;

namespace Cyberkruz.Autorest.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Cyberkruz.Autorest.Client.Autorest(
                new Uri("http://localhost:51511"), new BasicAuthenticationCredentials());

            var jokes = client.GetJokes();

            foreach(var joke in jokes)
            {
                Console.WriteLine(joke.Question);
                Console.WriteLine(joke.Answer);
            }

            Console.ReadLine();
        }
    }
}
