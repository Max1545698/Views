﻿using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Views.Infrastructure
{
    public class SimpleExpander : IViewLocationExpander
    {
        public void PopulateValues(ViewLocationExpanderContext context)
        {

        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {

            //"/Views/{1}/{0}.cshtml"
            //"/Views/Shared/{0}.cshtml"
            //Заполнитель {0} применяется для ссылки на имя метода действия, а заполнитель{1} - для ссылки на имя контроллера. 


            foreach (string location in viewLocations) 
            {
                yield return location.Replace("Shared", "Common");
            }
            yield return "Views/Legacy/{1}/{0}/View.cshtml";
        }

        
    }
}
