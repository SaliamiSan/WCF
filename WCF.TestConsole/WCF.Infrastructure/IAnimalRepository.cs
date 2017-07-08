using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.DomainModel;

namespace WCF.Infrastructure
{
    public interface IAnimalRepository
    {
        IQueryable<Animal> Get();
    }
}
