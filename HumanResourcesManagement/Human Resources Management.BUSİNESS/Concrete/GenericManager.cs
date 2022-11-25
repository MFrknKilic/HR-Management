using Human_Resources_Management.BUSİNESS.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Resources_Management.BUSİNESS.Concrete
{
    public class GenericManager<T> : IGenericService<T>
    {
        public T GetUser()
        {
            throw new NotImplementedException();
        }
    }
}
