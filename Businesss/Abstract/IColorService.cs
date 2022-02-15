using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesss.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
    }
}
