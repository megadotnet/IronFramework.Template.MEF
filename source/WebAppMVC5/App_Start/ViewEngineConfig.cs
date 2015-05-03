using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMVC5
{
    public class ViewEngineConfig
    {
        public static void RegisterViewEngines(System.Web.Mvc.ViewEngineCollection viewEngines)
        {
            viewEngines.Clear();
            viewEngines.Add(new KendoRazorViewEngine());
            
        }
    }
}