using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace ApiWeb.Models
{
    public class UsuarioForm
    {
        //public string ID { get; set; }
        //public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        //public Anotacao anotacao { get; set; }
        //public List<Evento> eventos { get; set; }
    }
}
