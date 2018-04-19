using _DataAccessLayer.Models;
using BusinessLayer.DTO;
using BusinessLayer.Mappers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mappers
{
    public class WootMapper : IWootMapper
    {
        public WootDTO GetWootDTOFromWootModel(WootModel model)
        {
            var result = new WootDTO
            {
                Id = model.Id,
                Name = model.Name
            };
            return result;
        }
    }
}
