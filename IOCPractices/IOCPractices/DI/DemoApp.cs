using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCPractices.DI
{


    public class DemoAppFirstWay
    {
        public void FirstWay()
        {
            var outputWriter = new ConsoleOutput();
            var todayWriter = new TodayWriter(outputWriter);
            todayWriter.WriteDate();
        }
    }
    public class DemoAppSecondWay
    {
        IContainer Container { get; set; }
        public void SecondWayStart()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWriter>();
            Container = builder.Build();

            // The WriteDate method is where we'll make use
            // of our dependency injection. We'll define that
            // in a bit.
        }

        public void SeconWayEveryTime()
        {
            // Create the scope, resolve your IDateWriter,
            // use it, then dispose of the scope.
            using (var scope = Container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDateWriter>();
                writer.WriteDate();
            }
        }




    }
}
