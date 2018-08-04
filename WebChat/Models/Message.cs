using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebChat.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Conteudo { get; set; }
    }
}