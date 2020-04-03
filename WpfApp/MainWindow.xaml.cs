using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MouseMove += (sender, e) =>
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                    this.DragMove();
            };

            List<Test> list = new List<Test>();
            list.Add(new Test { Code= "\xe6eb",Title="测试" });
            list.Add(new Test { Code = "\xe6eb", Title = "测试" });
            list.Add(new Test { Code = "\xe6eb", Title = "测试" });
            list.Add(new Test { Code = "\xe6eb", Title = "测试" });

            List<Test> list1 = new List<Test>();
            list1.Add(new Test { Code = "\xe6eb", Title = "测试" });
            list1.Add(new Test { Code = "\xe6eb", Title = "测试" });



            //list.Add(new Test { Code = "#FFFFFF" });
            //list.Add(new Test { Code = "#FBFFFF" });
            //list.Add(new Test { Code = "#FFBFFF" });
            //list.Add(new Test { Code = "#FFFBFF" });
            t.ItemsSource = list;
            t1.ItemsSource = list;
        }


        public class Test
        {
            public string Code { get; set; }
            public string Title { get; set; }

        }

        private void t_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedText = (sender as ListBox).SelectedIndex.ToString();
           // MessageBox.Show(selectedText);
        }
    }


}
