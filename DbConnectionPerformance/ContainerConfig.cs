using ADOConnection;
using Autofac;
using DapperConnection;
using DataReadLibrary;
using EFConnection.Data;

namespace DbConnectionPerformance
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AdoHelper>();
            builder.RegisterType<DapperHelper>();
            builder.RegisterType<SchoolContextFactory>();
            builder.RegisterType<PerformanceTester>().As<IPerformanceTester>();
            builder.RegisterType<QueryHelper>().As<IQueryHelper>();

            return builder.Build();
        }
    }
}
