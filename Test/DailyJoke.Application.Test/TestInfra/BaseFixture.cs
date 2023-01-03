using AutoMapper;
using DailyJoke.Application.Mappings;

namespace DailyJoke.Application.Test.TestInfra
{
    internal class BaseFixture
    {
        private IMapper _mapper;
        protected IMapper Mapper { get { return _mapper; } }

        [OneTimeSetUp]
        public void Init()
        {
            _mapper = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            }).CreateMapper();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
        }
    }
}
