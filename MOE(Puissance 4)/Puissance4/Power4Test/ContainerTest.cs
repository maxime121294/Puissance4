using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Power4;
using Autofac;

namespace Power4Test
{
    [TestClass]
    public class ContainerTest
    {
        [TestMethod]
        public Autofac.IContainer CreateContainer(Action<ContainerBuilder> configure = null)
        {
            
            ContainerBuilder builder = new ContainerBuilder();
            
            builder.RegisterType<ArrayFormat>().As<IArrayFormatter>().SingleInstance();
            builder.RegisterType<ArrayStock>().As<IArrayStock>().SingleInstance();
            builder.RegisterType<KeyboardInput>().As<IInput>().SingleInstance();
            builder.RegisterType<Iterator>().As<IIterator>().SingleInstance();
            builder.RegisterType<ColorOutput>().As<IOutput>().SingleInstance();
            builder.RegisterType<Player>().As<IPlayer>().SingleInstance();
            builder.RegisterType<Token>().As<IToken>().SingleInstance();


            if (configure != null)
                configure(builder);

            var container = builder.Build();
            return container;
        }
    }
}
