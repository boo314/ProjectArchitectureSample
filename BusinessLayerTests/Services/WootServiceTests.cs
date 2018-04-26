using NUnit.Framework;
using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using BusinessLayer.Mappers.Abstract;
using _DataAccessLayer.Repositories.Abstract;
using _DataAccessLayer.Models;
using BusinessLayer.Exceptions;

namespace BusinessLayer.Services.Tests
{
    [TestFixture()]
    public class WootServiceTests
    {
        private Mock<IWootMapper> _wootMapper;
        private Mock<IWootRepository> _wootRepository;
        private WootService _sut;
        [SetUp]
        public void SetUp()
        {
            _wootMapper = new Mock<IWootMapper>();
            _wootRepository = new Mock<IWootRepository>();

            _sut = new WootService(_wootRepository.Object, _wootMapper.Object);
        }

        [Test()]
        public void GetWootById_ShouldReturnNewDTO_WhenGivenAnyId_Test()
        {
            _wootRepository
                .Setup(x => x.GetModelById(It.IsAny<int>()))
                .Throws(new NullReferenceException());
            //.Returns(It.IsAny<WootModel>());

            _wootMapper
                .Setup(x => x.GetWootDTOFromWootModel(It.IsAny<WootModel>()))
                .Returns(new DTO.WootDTO { Id = 1, Name = "To ja" });

            var result = _sut.GetWootById(It.IsAny<int>());

            Assert.AreEqual(1,result.Id);
            Assert.AreEqual("To Ty", result.Name);
        }
        [Test()]
        public void GetWootById_ShouldThrowsWootException_WhenRepositoryIsNull_Test()
        {
            _wootRepository
                .Setup(x => x.GetModelById(It.IsAny<int>()))
                .Throws(new NullReferenceException());

            _wootMapper
                .Setup(x => x.GetWootDTOFromWootModel(It.IsAny<WootModel>()))
                .Returns(new DTO.WootDTO { Id = 1, Name = "To ja" });

            Assert.Catch<WootException>(new TestDelegate(() => _sut.GetWootById(It.IsAny<int>())));
        }
    }
}