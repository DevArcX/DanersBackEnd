using Logic.Interface;
using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class rolPersonaLogic : ICRUDLogic<rolPersonaModels>
    {
        rolPersonaReposiroty repo = new rolPersonaReposiroty();

        public rolPersonaModels Create(rolPersonaModels input)
        {
            input = repo.Create(input);
            return input;
        }

        public int Delete(int id)
        {
            id=repo.Delete(id);
            return id;
        }

        public rolPersonaModels GetById(int id)
        {
            rolPersonaModels model = repo.GetById(id);
            return model;
        }

        public List<rolPersonaModels> ListaAll()
        {
            List<rolPersonaModels> lista=repo.ListaAll();
            return lista;
        }

        public rolPersonaModels Update(rolPersonaModels input)
        {
            input = repo.Update(input);
            return input;
        }
    }
}
