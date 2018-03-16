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
    /// Логика взаимодействия для SizeUsabilityWindow.xaml
    /// </summary>
    public partial class SizeUsabilityWindow : Window
    {
        public SizeUsabilityWindow()
        {
            InitializeComponent();
        }

        private void Enter_value(object sender, RoutedEventArgs e)
        {
            WeighClass.Initialize_WeighKriterion_ForSize();
            WeighClass.Initialize_WeighKriterion_ForUsability();
            WeighClass.Initialize_FunctionUtility();
            WeighClass.Initialize_NormCost();
            WeighClass.Initialize_Result();

            OverWriting1(Enter_weigh1(Enter_array1()));
            OverWriting(Enter_weigh(Enter_array()));

            ValueFuncUtilit();
            SetNormCost();
            SetResult_array();

            var resultWindow = new ResultWindow();
            resultWindow.Show();
            this.Close();
        }

        /// <summary>
        /// заполнение таблицы
        /// </summary>
        /// <returns></returns>
        public double[,] Enter_array1()
        {
            double[] kriterion = new double[5];

            kriterion[0] = Convert.ToDouble(VipNetTextBox.Text);
            kriterion[1] = Convert.ToDouble(WuthGuardTextBox.Text);
            kriterion[2] = Convert.ToDouble(ESR_STTextBox.Text);
            kriterion[3] = Convert.ToDouble(CSP_VPN_GATE_3000_TextBox.Text);
            kriterion[4] = Convert.ToDouble(APM_Continent_TextBox.Text);

            double[,] weighArray = new double[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        weighArray[i, j] = 1;
                    }
                    else
                    {
                        weighArray[i, j] = kriterion[i] / kriterion[j];
                    }
                }
            }

            return weighArray;
        }

        /// <summary>
        /// расчет весов критериев
        /// </summary>
        /// <param name="array"> таблица </param>
        /// <returns> веса еритериев </returns>
        public double[] Enter_weigh1(double[,] array)
        {
            double[] weighKriterion = new double[] { 1, 1, 1, 1, 1 };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    weighKriterion[i] *= array[j, i];
                }

                weighKriterion[i] = Math.Pow(weighKriterion[i], 0.2);
            }

            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += weighKriterion[i];
            }

            for (int i = 0; i < 5; i++)
            {
                weighKriterion[i] /= sum;
            }

            return weighKriterion;
        }

        /// <summary>
        /// перенос значений в результирующий массив весов критериев
        /// </summary>
        /// <param name="array"></param>
        public void OverWriting1(double[] array)
        {
            int i = 0;
            foreach (double x in array)
            {
                WeighClass.WeighKriterion_ForSize[i] = x;
                i++;
            }
        }

        /// <summary>
        /// заполнение таблицы
        /// </summary>
        /// <returns></returns>
        public double[,] Enter_array()
        {
            double[] kriterion = new double[5];

            kriterion[0] = Convert.ToDouble(VipNetTextBox_Copy.Text);
            kriterion[1] = Convert.ToDouble(WuthGuardTextBox_Copy.Text);
            kriterion[2] = Convert.ToDouble(ESR_STTextBox_Copy.Text);
            kriterion[3] = Convert.ToDouble(CSP_VPN_GATE_3000_TextBox_Copy.Text);
            kriterion[4] = Convert.ToDouble(APM_Continent_TextBox_Copy.Text);

            double[,] weighArray = new double[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        weighArray[i, j] = 1;
                    }
                    else
                    {
                        weighArray[i, j] = kriterion[i] / kriterion[j];
                    }
                }
            }

            return weighArray;
        }

        /// <summary>
        /// расчет весов критериев
        /// </summary>
        /// <param name="array"> таблица </param>
        /// <returns> веса еритериев </returns>
        public double[] Enter_weigh(double[,] array)
        {
            double[] weighKriterion = new double[] { 1, 1, 1, 1, 1 };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    weighKriterion[i] *= array[j, i];
                }

                weighKriterion[i] = Math.Pow(weighKriterion[i], 0.2);
            }

            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += weighKriterion[i];
            }

            for (int i = 0; i < 5; i++)
            {
                weighKriterion[i] /= sum;
            }

            return weighKriterion;
        }

        /// <summary>
        /// перенос значений в результирующий массив весов критериев
        /// </summary>
        /// <param name="array"></param>
        public void OverWriting(double[] array)
        {
            int i = 0;
            foreach (double x in array)
            {
                WeighClass.WeighKriterion_ForUsability[i] = x;
                i++;
            }
        }


        public void ValueFuncUtilit()
        {
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                WeighClass.FunctionUtility[i] = ((WeighClass.WeighKriterion[k] * WeighClass.WeighKriterion_ForCost[i]) + (WeighClass.WeighKriterion[k+1] * WeighClass.WeighKriterion_ForCharacteristic[i])
                    + (WeighClass.WeighKriterion[k+2] * WeighClass.WeighKriterion_ForSertif[i]) + (WeighClass.WeighKriterion[k+3] * WeighClass.WeighKriterion_ForUsability[i]) 
                    + (WeighClass.WeighKriterion[k+4] * WeighClass.WeighKriterion_ForAddFunc[i]) + (WeighClass.WeighKriterion[k+5] * WeighClass.WeighKriterion_ForSize[i])) / 6;
            }
        }

        public void SetNormCost()
        {
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                sum += WeighClass.NormCost[i];
            }

            for (int i = 0; i < 5; i++)
            {
                WeighClass.NormCost[i] /= sum;
            }

        }

        public void SetResult_array()
        {
            for(int i = 0; i < 5; i++)
            {
                WeighClass.Result[i] = WeighClass.FunctionUtility[i] /*/ WeighClass.NormCost[i]*/;
            }
        }
    }
}
