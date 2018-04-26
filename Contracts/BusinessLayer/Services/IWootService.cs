using BusinessLayer.DTO;

namespace BusinessLayer.Services.Abstract
{
    public interface IWootService
    {
        WootDTO GetWootById(int id);
    }
}