using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace NLayers
{
    class Class_N
    {
        NLayers.Class_D objd = new NLayers.Class_D();
        public DataTable N_login(Class_E obj) {
            return objd.D_login(obj);
        }
    }
}
