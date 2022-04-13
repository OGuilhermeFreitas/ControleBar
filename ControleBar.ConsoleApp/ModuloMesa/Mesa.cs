using System;
using ControleBar.ConsoleApp.Compartilhado;

namespace ControleBar.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public string NumeroMesa { get; set; }
        
        public Mesa(string numeroMesa)
        {
            NumeroMesa = numeroMesa;
        }
        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Nome da Mesa: " + NumeroMesa + Environment.NewLine;
        }


    }


}
