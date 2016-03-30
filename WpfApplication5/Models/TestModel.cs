using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace WpfApplication5.Models
{
    public class TestModel : IModel
    {
        public class TestModel3 : IModel
        {
            public void Show()
            {
                MessageBox.Show("TestModel3");
            }
        }
        public void Show()
        {
            MessageBox.Show("TestModel");
        }
    }
}
