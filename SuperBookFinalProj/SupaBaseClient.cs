using Supabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBookFinalProj
{
    public static class SupaBaseClient
    {
        public static Client Client { get; private set; }

        static SupaBaseClient()
        {
            var url = "https://tgxxkstbeetnhetjcyen.supabase.co";
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InRneHhrc3RiZWV0bmhldGpjeWVuIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDA0MDM5MjYsImV4cCI6MjA1NTk3OTkyNn0.lMBzLb9bR2Z0wDnIDfg38_VvtgELhNZgzz0UlYCAUSQ";

            var options = new SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            Client = new Client(url, key, options);
            Client.InitializeAsync().Wait();
        }
    }
}
