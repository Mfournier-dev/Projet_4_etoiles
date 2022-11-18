using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4_etoiles.DataAccess
{
    public interface IDAO <TDTO> where TDTO : IDTO
    {
        public TDTO GetById(int id);

        public List<TDTO> GetAll();
    }
}
