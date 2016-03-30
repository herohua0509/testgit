using Spring.Context;
using Spring.Context.Support;
using Spring.Objects.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication5.Factory;
using WpfApplication5.Models;

namespace WpfApplication5
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            string test = "test";
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {

                var aaa = StaticTestFactory.CreateInstance<TestModel2>();
                aaa.Show();

                IApplicationContext ctx = ContextRegistry.GetContext();
                IObjectFactory factory = (IObjectFactory)ctx;
                IModel m2 = (IModel)factory.GetObject("TestModel");
               
                m2.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// 构造器创建
        /// </summary>
        static void CreateByConstructor()
        {
            string[] xmlFiles = new string[] 
            {
                "assembly://CreateObjects/CreateObjects/Objects.xml"
            };
            IApplicationContext context = new XmlApplicationContext(xmlFiles);

            IObjectFactory factory = (IObjectFactory)context;
            Console.WriteLine(factory.GetObject("personDao").ToString());
        }
    }
}
