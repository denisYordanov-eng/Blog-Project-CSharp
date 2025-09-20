//using Blog_CSharp_Project.Migrations;
//using Blog_CSharp_Project.Models;
using Microsoft.Owin;
using Owin;
using System.Data.Entity;

[assembly: OwinStartupAttribute(typeof(Blog_CSharp_Project.Startup))]
namespace Blog_CSharp_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            ConfigureAuth(app);
        }
    }
}
