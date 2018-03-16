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
using System.Windows.Shapes;

namespace Zui
{
    /// <summary>
    /// Логика взаимодействия для ResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        public ResultWindow()
        {
            InitializeComponent();

            OutPutResult();
        }

        public void OutPutResult()
        {
            var max = WeighClass.Result[0];
            int indexMax = 0;
            for (int i = 1; i < 5; i ++)
            {
                if (max < WeighClass.Result[i])
                {
                    max = WeighClass.Result[i];
                    indexMax = i;
                }
            }

            switch(indexMax)
            {
                case 0: this.Result_TextBox.Text = "VipNet";
                    break;
                case 1: this.Result_TextBox.Text = "WuthGuard";
                    break;
                case 2: this.Result_TextBox.Text = "ESR-ST";
                    break;
                case 3: this.Result_TextBox.Text = "Gate-3000";
                    break;
                case 4: this.Result_TextBox.Text = "Континент";
                    break;
            }
        }
    }
}
