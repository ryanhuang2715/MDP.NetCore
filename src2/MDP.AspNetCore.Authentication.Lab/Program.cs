using Microsoft.Extensions.Hosting;

namespace MDP.AspNetCore.Authentication.Lab
{
    public class Program
    {
        // Methods
        public static void Main(string[] args)
        {
            // Host
            MDP.AspNetCore.Host.Create(args).Run();
        }
    }
}