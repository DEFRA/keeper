using Microsoft.AspNetCore.Builder;

namespace Keeper.Test.Config;

public class EnvironmentTest
{

   [Fact]
   public void IsNotDevModeByDefault()
   { 
       var builder = WebApplication.CreateEmptyBuilder(new WebApplicationOptions());
       var isDev = Keeper.Config.Environment.IsDevMode(builder);
       Assert.False(isDev);
   }
}
