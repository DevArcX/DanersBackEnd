using Microsoft.Data.SqlClient;
using Models;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class rolPersonaReposiroty : ICRUD<rolPersonaModels>
    {

        private _dbContext _db = new _dbContext();

        public rolPersonaModels Create(rolPersonaModels input)
        {
            _db.RolPersona.Add(input);
            _db.SaveChanges();
            return input;
        }

        public int Delete(int id)
        {
            rolPersonaModels model = _db.RolPersona.Find(id);
            _db.RolPersona.Remove(model);
            return _db.SaveChanges();
        }

        public rolPersonaModels GetById(int id)
        {
            rolPersonaModels rolPersona = _db.RolPersona.Find(id);
            return rolPersona;
        }

        public List<rolPersonaModels> ListaAll()
        {
            try
            {
                List<rolPersonaModels> lista = _db.RolPersona.ToList();
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public rolPersonaModels Update(rolPersonaModels input)
        {
            _db.RolPersona.Update(input);
            _db.SaveChanges();
            return input;
        }
    }
}
