using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Estudo.Interfaces;

namespace TDD.Estudo.Services
{
    public class MensagemService
    {

        private IPersisteMensagem _repository;

        public MensagemService(IPersisteMensagem _rep)
        {
            _repository = _rep;
        }
    }
}
