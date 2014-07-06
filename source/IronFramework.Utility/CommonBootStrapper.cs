using Microsoft.Mef.CommonServiceLocator;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronFramework.Utility
{

    /// <summary>
    /// Class CommonBootStrapper
    /// </summary>
    /// <remarks>http://wintersun.cnblogs.com/</remarks>
    /// <seealso cref="http://www.codeproject.com/Articles/51640/Common-Service-Locator-Separate-hard-reference-of"/>
    public abstract class CommonBootStrapper
    {
        public static IServiceLocator Locator;

        protected CommonBootStrapper()
        {
            Locator = CreateServiceLocator();
        }

        protected abstract IServiceLocator CreateServiceLocator();
    }


    public class MEFBootStrapper : CommonBootStrapper
    {
        protected override IServiceLocator CreateServiceLocator()
        {
              var container=new CompositionContainer();
              return new MefServiceLocator(container);
        }

    }

    /// <summary>
    /// Boot
    /// </summary>
    /// <example><code>
    /// BootStrapperManager.Initialize(new UnityBootStrapper());  
    /// ICustomer customer = CommonBootStrapper.Locator.GetInstance<ICustomer>(typeof(ICustomer).FullName);
    /// customer.SendMessage("This is me."); 
    /// </code></example>
    public class BootStrapperManager
    {
        private static CommonBootStrapper _bootStrapper;


        public static void Initialize(CommonBootStrapper bootStrapper)
        {
            _bootStrapper = bootStrapper;
        }

        public static CommonBootStrapper BootStrapper
        {
            get { return _bootStrapper; }
        }
    } 
}
