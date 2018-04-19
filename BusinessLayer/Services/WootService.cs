using _DataAccessLayer.Repositories.Abstract;
using BusinessLayer.DTO;
using BusinessLayer.Mappers.Abstract;
using BusinessLayer.Services.Abstract;
using System;

namespace BusinessLayer.Services
{
    public class WootService : IWootService
    {
        private IWootRepository _wootRepository;
        private IWootMapper _wootMapper;

        public WootService(IWootRepository wootRepository, IWootMapper wootMapper)
        {
            _wootRepository = wootRepository;
            _wootMapper = wootMapper;
        }

        public WootDTO GetWootById(int id)
        {
            try
            {
                var response = _wootRepository.GetModelById(id);
                var result = _wootMapper.GetWootDTOFromWootModel(response);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}