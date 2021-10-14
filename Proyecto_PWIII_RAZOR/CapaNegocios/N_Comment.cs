using System;
using System.Collections.Generic;
using System.Data;
using DataLayer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class N_Comment
    {
        private readonly D_Comment comment = new D_Comment();
        public DataTable ShowComment()
        {
            return comment.ShowComment();
        }
    }
}
