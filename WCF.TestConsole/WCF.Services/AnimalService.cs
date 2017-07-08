using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.DomainModel;
using WCF.Logic;

namespace WCF.Services
{
    public class AnimalService : IAnimalService
    {
        public Animal GetAnimalById(int id)
        {
            var logic = new AnimalLogic(null);

            return logic.GetById(id);
        }
    }
}
