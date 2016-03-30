using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfApplication5.Models;

namespace WpfApplication5.Factory
{
    public static class StaticTestFactory
    {
        public static IModel CreateInstance<T>() where T:IModel
        {
            return Activator.CreateInstance<T>();放屁
        }
    }
}
