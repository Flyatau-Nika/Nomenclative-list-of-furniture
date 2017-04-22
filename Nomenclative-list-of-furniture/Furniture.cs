using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomenclative_list_of_furniture
{
    class Furniture
    {
        private string Name;

        public string _name
        {
            get { return Name; }
            set { Name = value; }
        }

        private int Size;

        public int _size
        {
            get { return Size; }
            set { Size = value; }
        }

        private string Set;

        public string _set
        {
            get { return Set; }
            set { Set = value; }
        }

        private int Colour;

        public int _colour
        {
            get { return Colour; }
            set { Colour = value; }
        }

        public string Info
        {
            get {
                return $"{Name} - {Size} - {Set} - {Colour}";
            }
        }

      //  public Elements(double Name, int Size, double Set, double Colour) 
      //  {
           // this.Name = Name;
           // this.Size = Size;
         //   this.Set = Set;
          //  this.Colour = Colour;
      //  }
        /// <summary>
        /// Переопределенный метод вывода строки массива
        /// </summary>
     
    }
}
