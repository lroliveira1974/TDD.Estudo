using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Estudo.Models;

namespace TDD.Estudo.Interfaces
{
    public interface IPersisteMensagem
    {
        void PersisteMensagem(Mensagem oMensagem);
    }
}
