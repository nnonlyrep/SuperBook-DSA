using Supabase;
using SuperBookFinalProj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supabase.Postgrest.Models;

namespace SuperBookFinalProj.userSide
{
    public partial class SupaBaseComponent : Component
    {
        public SupaBaseComponent()
        {
            InitializeComponent();
        }

        public SupaBaseComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }

    public class SupabaseService
    {
        private Client _supabaseClient;

        public SupabaseService()
        {
            _supabaseClient = new Client("https://tgxxkstbeetnhetjcyen.supabase.co", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InRneHhrc3RiZWV0bmhldGpjeWVuIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDA0MDM5MjYsImV4cCI6MjA1NTk3OTkyNn0.lMBzLb9bR2Z0wDnIDfg38_VvtgELhNZgzz0UlYCAUSQ");
        }

        public async Task SaveReservation(Reservation reservation)
        {
            try
            {
                var response = await _supabaseClient
                .From<Reservation>()
                .Insert(reservation);

                Console.WriteLine("Reservation saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving reservation: {ex.Message}");
            }

        }
    }


    }
