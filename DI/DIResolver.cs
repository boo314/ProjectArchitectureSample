using _DataAccessLayer.Repositories;
using _DataAccessLayer.Repositories.Abstract;
using BusinessLayer.Mappers;
using BusinessLayer.Mappers.Abstract;
using BusinessLayer.Services;
using BusinessLayer.Services.Abstract;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DI
{
    public class DIResolver : IDependencyResolver
    {

        private readonly IKernel _kernel;

        public DIResolver()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            _kernel.Bind<IWootRepository>().To<WootRepository>();
            _kernel.Bind<IWootMapper>().To<WootMapper>();
            _kernel.Bind<IWootService>().To<WootService>(); // Registering Types    
        }
    }
}
