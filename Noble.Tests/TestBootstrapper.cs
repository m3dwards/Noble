using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy.Testing.Fakes;
using System.IO;
using Nancy.Testing;

namespace Noble.Tests
{

    public class TestBootstrapper : Bootstrapper
    {
        protected override Type RootPathProvider
        {
            get
            {
                var assemblyFilePath =
                    new Uri(typeof(Bootstrapper).Assembly.CodeBase).LocalPath;

                var assemblyPath =
                    Path.GetDirectoryName(assemblyFilePath);

                var rootPath =
                    PathHelper.GetParent(assemblyPath, 3);

                //rootPath =
                //    Path.Combine(rootPath, @"Noble");

                FakeRootPathProvider.RootPath = rootPath;

                return typeof(FakeRootPathProvider);
            }
        }
    }
}
