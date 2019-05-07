using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace Lo.Util.Ioc
{
    public class AutofacIocHelper:IServiceProvider
    {
        private readonly ContainerBuilder _container;
        private static readonly AutofacIocHelper dbinstance = new AutofacIocHelper("DBcontainer");

        public AutofacIocHelper(string containerName)
        {
            _container = new ContainerBuilder();
            //section.Configure(_container);
        }

        public static AutofacIocHelper DBInstance
        {
            get { return dbinstance; }
        }
        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }


    }
}
