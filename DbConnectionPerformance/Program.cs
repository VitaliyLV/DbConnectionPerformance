using Autofac;
using DbConnectionPerformance;

var container = ContainerConfig.Configure();
using var scope = container.BeginLifetimeScope();
var perfTester = scope.Resolve<IPerformanceTester>();
perfTester.TestReadPerformance();
