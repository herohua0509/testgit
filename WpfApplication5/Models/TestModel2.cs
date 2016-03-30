using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace WpfApplication5.Models
{
    public class TestModel2 : IModel
    {
        public void Show()
        {
            MessageBox.Show("TestModel2");
        }
    }
}
