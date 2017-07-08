using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.DomainModel;
using WCF.Infrastructure;

namespace WCF.Logic
{
    public class AnimalLogic : IAnimalLogic
    {
        IAnimalRepository _rep = null;

        public AnimalLogic(IAnimalRepository repository)
        {
            _rep = repository;
        }

        public Animal GetById(int id)
        {
            return _rep.Get().FirstOrDefault(a => a.Id == id);
        }
    }
}
