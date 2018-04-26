using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataAccessLayer.Models.Abstract
{
    public class BaseModel<IdType>
    {
        public IdType Id { get; set; }
    }
}
