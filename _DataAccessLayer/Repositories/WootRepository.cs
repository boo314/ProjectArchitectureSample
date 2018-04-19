using _DataAccessLayer.Models;
using _DataAccessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataAccessLayer.Repositories
{
    public class WootRepository : BaseRepository<WootModel>, IWootRepository
    {
        public WootModel GetModelById(int id)
        {
            return Get(x => x.Id == id);
        }

        public WootModel GetByName(string name)
        {
            var result = new WootModel();
            using(var context = new CrowdNetDBContext())
            {
                result = context.wootModels.LastOrDefault(x => x.Name == name);
            }
            return result;
        }
    }
}
