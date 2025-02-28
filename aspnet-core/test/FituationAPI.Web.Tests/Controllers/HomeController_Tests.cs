﻿using System.Threading.Tasks;
using FituationAPI.Models.TokenAuth;
using FituationAPI.Web.Controllers;
using Shouldly;
using Xunit;

namespace FituationAPI.Web.Tests.Controllers
{
    public class HomeController_Tests: FituationAPIWebTestBase
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