using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.DomainModel;

namespace WCF.Services
{
    [ServiceContract]
    public interface IAnimalService
    {
        [OperationContract]
        Animal GetAnimalById(int id);
    }
}
