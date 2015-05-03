using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Web;

namespace WebAppMVC5.App_Start
{
    /// <summary>
    /// sss
    /// </summary>
    /// <see cref="http://stackoverflow.com/questions/21017036/mef-with-mvc-4-or-5-pluggable-architecture-2014#"/>
    public class Bootstrapper
    {
        private static CompositionContainer CompositionContainer;
        private static bool IsLoaded = false;

        public static void Compose(List<string> pluginFolders)
        {
            if (IsLoaded) return;

            var catalog = new AggregateCatalog();

            catalog.Catalogs.Add(new DirectoryCatalog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin")));

            foreach (var plugin in pluginFolders)
            {
                var directoryCatalog = new DirectoryCatalog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Modules", plugin));
                catalog.Catalogs.Add(directoryCatalog);

            }
            CompositionContainer = new CompositionContainer(catalog);

            //CompositionContainer.ComposePart();
            IsLoaded = true;
        }

        public static T GetInstance<T>(string contractName = null)
        {
            var type = default(T);
            if (CompositionContainer == null) return type;

            if (!string.IsNullOrWhiteSpace(contractName))
                type = CompositionContainer.GetExportedValue<T>(contractName);
            else
                type = CompositionContainer.GetExportedValue<T>();

            return type;
        }
    }
}