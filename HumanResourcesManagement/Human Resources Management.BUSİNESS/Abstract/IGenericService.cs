using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Resources_Management.BUSİNESS.Abstract
{
    public interface IGenericService<T>
    {
        T GetUser();

    }
}
