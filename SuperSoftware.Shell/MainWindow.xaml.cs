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
using SuperSoftware.Utility;

namespace SuperSoftware.Shell
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            test();
        }

        public void test()
        {
            try
            {
                LogHelper.Trace("跟踪");
                LogHelper.Debug("调试");
                LogHelper.Error("错误");
                LogHelper.Info("信息");
                LogHelper.Fatal("严重");
                LogHelper.Warn("警告");

                string tmp = "2a";
                int a = int.Parse(tmp);
            }
            catch (Exception ex)
            {
                LogHelper.Trace("跟踪", ex);
                LogHelper.Debug("调试", ex);
                LogHelper.Error("core 类发生错误", ex);
                LogHelper.Info("信息", ex);
                LogHelper.Fatal("严重", ex);
                LogHelper.Warn("警告", ex);
                //throw;
            }

        }
    }
}
