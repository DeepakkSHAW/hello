using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hello
{
    public class Self
    {
        public string href;
    }

    public class Links
    {
        public Self self;
    }

    public class PlayerState
    {
        public int x;
        public int y;
        public string direction;
        public Boolean wasHit;
        public int score;
    }

    public class Arena
    {
        public List<int> dims;
        public Dictionary<string, PlayerState> state;
    }

    public class ArenaUpdate
    {
        public Links _links;
        public Arena arena;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
