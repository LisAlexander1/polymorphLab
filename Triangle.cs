using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphLab
{
    internal class TriangleList : Steel
    {
        private double length;
        public double Length
        {
            get => length;
            set
            {
                Console.WriteLine(length);
                length = value >= 0 ? length : 0;
            }
        }

        public TriangleList(int density, double thickness, double width, double length) : base(density, thickness, width)
        {
            Width = width;
            this.length = length;
        }


        public override double GetArea()
        {
            return Width * Length / 2000000;
        }

        public override string Info()
        {
            return $"Плотность: {Density} кг/м3, Толщина {Thickness:F2} мм, Размер: {Width:F0}x{length:F0} мм, Площадь: {GetArea():F2} м2, Вес: {GetWeight():F1} кг";
        }
    }
}
