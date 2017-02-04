using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Dialogue.Logic.Services;
using System.Reflection;
using Umbraco.Core;
using Umbraco.Core.Services;
using UnderlakareCmsDialogue.Business.Services.Interfaces;

namespace UnderlakareCmsDialogue.Business.Registries
{
    public static class DependencyRegistry
    {
        public static IContainer RegisterDependencies(this ApplicationContext applicationContext)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(Umbraco.Web.UmbracoApplication).Assembly);
            builder.RegisterApiControllers(typeof(Umbraco.Web.UmbracoApplication).Assembly);

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<Services.TopicService>()
                .As<ITopicsService>()
                .WithParameter("topicService", ServiceFactory.TopicService);

            builder.RegisterType < Services.MemberService>()
                .As<IMembersService>()
                .WithParameter("memberService", ServiceFactory.MemberService);

            builder.RegisterInstance(applicationContext.Services.ContentService).As<IContentService>();
            builder.RegisterInstance(applicationContext.Services.UserService).As<IUserService>();
            builder.RegisterInstance(applicationContext.Services.MemberService).As<IMemberService>();


            var container = builder.Build();

            return container;
        }

    }
}