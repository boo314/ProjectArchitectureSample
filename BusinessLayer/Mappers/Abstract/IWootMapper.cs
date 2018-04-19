using _DataAccessLayer.Models;
using BusinessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mappers.Abstract
{
    public interface IWootMapper
    {
        WootDTO GetWootDTOFromWootModel(WootModel model);
    }
}
