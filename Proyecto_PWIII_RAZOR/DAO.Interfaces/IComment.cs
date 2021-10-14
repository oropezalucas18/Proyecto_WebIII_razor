using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Model;

namespace DAO.Interfaces
{
    public interface IComment:IDAO<Comment>
    {
        Comment Get(byte id);
    }
}
