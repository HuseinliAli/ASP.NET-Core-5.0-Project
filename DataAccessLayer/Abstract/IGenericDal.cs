using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T sent);

        void Update(T sent);

        void Delete(T sent);

        T GetById(int id);

        List<T> GetListAll();
    }
}
