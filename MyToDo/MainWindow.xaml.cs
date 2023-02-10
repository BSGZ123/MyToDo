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

namespace MyToDo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*
             * 界面按钮操作实现逻辑
             */
            btnMin.Click += (s, e) => { this.WindowState = WindowState.Minimized; };
            btnMax.Click += (s, e) => 
            { if(this.WindowState == WindowState.Maximized)
                    this.WindowState = WindowState.Normal;
              else
                    this.WindowState = WindowState.Maximized;

            };
            btnClose.Click += (s, e) => { this.Close(); };


            ColorZone.MouseMove += (s, e) =>//鼠标左键按下时，程序界面跟随鼠标指针
            {
                if(e.LeftButton== MouseButtonState.Pressed)
                {
                    this.DragMove();
                }
            };

            ColorZone.MouseDoubleClick += (s, e) =>//鼠标双击依据情况放大还是回归正常
            {
                if (this.WindowState == WindowState.Normal)
                    this.WindowState = WindowState.Maximized;
                else
                    this.WindowState = WindowState.Normal;
            };



        }
    }
}
