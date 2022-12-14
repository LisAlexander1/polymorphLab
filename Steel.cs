using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphLab
{
    internal class Steel
    {
        private int density;
        private double thickness;
        private double width;

        public int Density
        {
            get => density;
            set => density = value >= 0 ? value : 0;
        }
        public double Thickness
        {
            get => thickness;
            set => thickness = value >= 0 ? value : 0;
        }
        public virtual double Width
        {
            get => width;
            set {
                width = value >= 0 ? value : 0;
            }
        }


        public Steel(int density, double thickness, double width)
        {
            this.density = density>=0 ? density : 0;
            this.thickness = thickness >= 0 ? thickness : 0;
            this.width = width >= 0 ? width : 0;
        }

        public virtual double GetArea()
        {
            return width * width / 1000000;
        }

        public virtual double GetWeight()
        {
            return thickness * density * GetArea() / 1000;
        }
        public virtual string Info()
        {
            return $"Плотность: {density} кг/м3, Толщина {thickness:F2} мм, Размер: {width:F0}x{width:F0} мм, Площадь: {GetArea():F2} м2, Вес: {GetWeight():F1} кг";
        }
    }
}
