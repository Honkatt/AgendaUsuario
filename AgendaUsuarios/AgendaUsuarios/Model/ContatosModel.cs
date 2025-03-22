using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaUsuarios.Model
{
    internal class ContatosModel
    {
        private static List<Contatos> contatos = new List<Contatos>();

        public void SetContatos(Contatos contato)
        {
            contatos.Add(contato);
        }
        public List<Contatos> GetContatos()
        {
            return contatos;
        }
    }
}
