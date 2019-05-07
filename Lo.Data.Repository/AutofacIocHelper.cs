using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Autofac;
using Autofac.Configuration;
using Autofac.Core;
using Lo.Data.Extension;
using Microsoft.Extensions.Configuration;

namespace Lo.Data.Repository
{
    public class AutofacIocHelper : IServiceProvider
    {
        private readonly IContainer _container;
        private static readonly AutofacIocHelper dbinstance = new AutofacIocHelper();

        private AutofacIocHelper()
        {
            string path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"Config\autofac.json");
            var config = new ConfigurationBuilder()
                .AddJsonFile(path)
                .Build();

            var module = new ConfigurationModule(config);
            var builder = new ContainerBuilder();
            builder.RegisterModule(module);
            _container = builder.Build();
        }
        public static string GetmapToByName(string containerName, string itype, string name = "")
        {
            try
            {
                //UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
                //var _Containers = section.Containers;
                //foreach (var _Container in _Containers)
                //{
                //    if (_Container.Name == containerName)
                //    {
                //        var _Registrations = _Container.Registrations;
                //        foreach (var _Registration in _Registrations)
                //        {
                //            if (name == "" && string.IsNullOrEmpty(_Registration.Name) && _Registration.TypeName == itype)
                //            {
                //                return _Registration.MapToName;
                //            }
                //        }
                //        break;
                //    }
                //}
                return "";
            }
            catch
            {
                throw;
            }

        }

        public static AutofacIocHelper DBInstance
        {
            get { return dbinstance; }
        }
        public object GetService(Type serviceType)
        {
            return _container.Resolve(serviceType);
        }

        public T GetService<T>()
        {
            return _container.Resolve<T>();
        }

        public T GetService<T>(params Parameter[] obj)
        {
            return _container.Resolve<T>(obj);
        }
        public T GetService<T>(string serviceName, params Parameter[] obj)
        {
            return _container.ResolveNamed<T>(serviceName, obj);
        }
    }
}
