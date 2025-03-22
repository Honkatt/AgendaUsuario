using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaUsuarios.Model;

namespace AgendaUsuarios.Controler
{
    internal class ContatosControler
    {
        ContatosModel model = new ContatosModel();

        public string SaveContatos(string nome, string zap, string email)
        {
            if (string.IsNullOrWhiteSpace(nome) ||
    string.IsNullOrWhiteSpace(zap))
                return "Campos Obrigatórios";
            if (string.IsNullOrWhiteSpace(email))
                return "Campos Obrigatórios";

            Contatos c = new Contatos()
            {
                Nome = nome,
                Zap = zap,
                Email = email
            };
            model.SetContatos(c);
            return "Salvo Namorales!";
        }
        public List<Contatos> GetAllContatos()
        {
            return model.GetContatos();
        }
    }
}
