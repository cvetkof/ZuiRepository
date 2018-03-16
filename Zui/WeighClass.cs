using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zui
{
    public static class WeighClass
    {
        /// <summary>
        /// веса критериев
        /// </summary>
        public static double[] WeighKriterion { get; set; }

        public static void Initialize_WeighKriterion()
        {
            WeighKriterion = new double[6];
        }

        /// <summary>
        /// оценка альтернати по характеристикам
        /// </summary>
        public static double[] WeighKriterion_ForCharacteristic { get; set; }

        public static void Initialize_WeighKriterion_ForCharacteristic()
        {
            WeighKriterion_ForCharacteristic = new double[5];
        }

        /// <summary>
        /// оценка альтернатив по цене
        /// </summary>
        public static double[] WeighKriterion_ForCost { get; set; }

        public static void Initialize_WeighKriterion_ForCost()
        {
            WeighKriterion_ForCost = new double[5];
        }

        /// <summary>
        /// оценка альтернатив по сертификации
        /// </summary>
        public static double[] WeighKriterion_ForSertif { get; set; }

        public static void Initialize_WeighKriterion_ForSertif()
        {
            WeighKriterion_ForSertif = new double[5];
        }

        /// <summary>
        /// оценка альтернатив по доп.функциям
        /// </summary>
        public static double[] WeighKriterion_ForAddFunc { get; set; }

        public static void Initialize_WeighKriterion_ForAddFunc()
        {
            WeighKriterion_ForAddFunc = new double[5];
        }

        /// <summary>
        /// оценка альтернатив по удобству использования
        /// </summary>
        public static double[] WeighKriterion_ForUsability { get; set; }

        public static void Initialize_WeighKriterion_ForUsability()
        {
            WeighKriterion_ForUsability = new double[5];
        }

        /// <summary>
        /// оценка альтернатив по размеру
        /// </summary>
        public static double[] WeighKriterion_ForSize { get; set; }

        public static void Initialize_WeighKriterion_ForSize()
        {
            WeighKriterion_ForSize = new double[5];
        }

        /// <summary>
        /// функции полезности
        /// </summary>
        public static double[] FunctionUtility { get; set; }

        public static void Initialize_FunctionUtility()
        {
            FunctionUtility = new double[5];
        }

        /// <summary>
        /// нормированная цена
        /// </summary>
        public static double[] NormCost { get; set; }

        public static void Initialize_NormCost()
        {
            NormCost = new double[5] {30730, 15434, 94919, 219730, 101990 };
        }

        /// <summary>
        /// результирующий список
        /// </summary>
        public static double[] Result { get; set; }

        public static void Initialize_Result()
        {
            Result = new double[5];
        }

    }
}
