using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebChat.Models;

namespace WebChat.Repository
{
    public class ChatContext : DbContext
    {
        public ChatContext() : base("Server=tcp:lancelotte.database.windows.net,1433;Initial Catalog=DbLancelotte;Persist Security Info=False;User ID=andrelance;Password=$823238and$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {

        }
        public DbSet<Message> messages { get; set; }

    }
}