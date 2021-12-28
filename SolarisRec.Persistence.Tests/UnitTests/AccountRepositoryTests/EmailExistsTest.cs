using FluentAssertions;
using SolarisRec.Core.Account.Processes.SecondaryPorts;
using System.Threading.Tasks;
using Xunit;

namespace SolarisRec.Persistence.Tests.UnitTests.AccountRepositoryTests
{    
    public class EmailExistsTest
    {
        private readonly IAccountRepository sut;

        public EmailExistsTest(IAccountRepository accountRepository)
        {
            this.sut = accountRepository;
        }

        private SolarisRecDbContext CreateDbContext()
        {
            var account = new PersistenceModel.Account
            {
                AccountName = "Unit Test",
                Password = "unittest",
                Email = "unit@test.com"
            };

            return new SolarisRecDbContextBuilder().WithAccount(account).Build();
        }

        [Fact]
        public async Task EmailExistsReturnsTrue()
        {
            var exists = await sut.EmailExists("");

            exists.Should().Be(true);
        }

        [Fact]
        public async Task EmailDoesNotExistsReturnsFalse()
        {
            var exists = await sut.EmailExists("");

            exists.Should().Be(false);
        }
    }
}
