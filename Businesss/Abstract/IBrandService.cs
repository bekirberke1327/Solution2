using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesss
{
    public interface IBrandService
    {
        List<Brand> GetAll();
       void Add(Brand brand);
       void Update(Brand brand);
       void Delete(Brand brand);
    }
}
