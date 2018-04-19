using _DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataAccessLayer.Repositories.Abstract
{
    public interface IWootRepository
    {
        WootModel GetModelById(int id);
        WootModel GetByName(string name);

    }
}
