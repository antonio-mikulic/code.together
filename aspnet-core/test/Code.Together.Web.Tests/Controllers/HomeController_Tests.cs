using System.Threading.Tasks;
using Code.Together.Models.TokenAuth;
using Code.Together.Web.Controllers;
using Shouldly;
using Xunit;

namespace Code.Together.Web.Tests.Controllers
{
    public class HomeController_Tests: TogetherWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}