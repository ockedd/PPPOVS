using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Core.Services
{
    internal interface IProductService
    {
        void Add();
        void Remove();
        void Edit();
        void Search();
    }
}
