using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.NUnit3;
using EntityFrameworkCore.AutoFixture.InMemory;

namespace DailyJoke.Application.Test.TestInfra
{
    public class InMemoryDomainAutoDataAttribute : AutoDataAttribute
    {
        public InMemoryDomainAutoDataAttribute()
          : base(() => new Fixture().Customize(new AutoMoqCustomization 
                                    { 
                                        ConfigureMembers = true, 
                                        GenerateDelegates = true 
                                    })
                                    .Customize(new InMemoryCustomization
                                    {
                                        UseUniqueNames = true,  // ensures each context has a unique store name, so data doesn't bleed between tests
                                    })
          )
        {
        }
    }
}
