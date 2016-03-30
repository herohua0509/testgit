using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfApplication5.Models;

namespace WpfApplication5.Factory
{
    public class InstanceTestFactory
    {
        public  IModel CreateInstance<T>() where T : IModel
        {
            return Activator.CreateInstance<T>();
        }
    }
}
