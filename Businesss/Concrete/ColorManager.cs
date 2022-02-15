using Businesss.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesss.Concrete
{
    public class ColorManager : IColorService
    {
        IColorService _colorDal;

        public ColorManager(IColorService colorService)
        {
            _colorDal = colorService;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal?.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
