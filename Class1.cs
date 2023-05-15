using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5
{
    class Elenergetics
    {
        public string Exists { get; set; }
        public int Year { get; set; }
        public decimal Power { get; set; }


        public override string ToString()
        {
            return $"Год постройки: {Year}" +
                    $"\nМощность: {Power} МВт" +
                    $"\nДействует ли на 2023 год электростанция: {Exists}";
        }
    }

    sealed class Hydroplant : Elenergetics
    {
        public int NumbOfСores { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nКоличество энергоблоков: {NumbOfСores}";
        }

    }

    sealed class Thermplant : Elenergetics
    {
        public decimal NumpipesOf { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\nКоличество турбин: {NumpipesOf}";
        }
    }

    sealed class Nuclearplant : Elenergetics
    {
        public string Type { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nТип генератора: {Type}";
        }
    }
}
