using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vehiculo
    {
        private string _marca;
        private string _color;
        private Motor _motor;
        private Rueda[] _rueda;

        public Vehiculo(string marca, string color)
        {
            _marca = marca;
            _color = color;
            _motor = new Motor();
            _rueda = new Rueda[4];

        }

        public void addRueda(string rueda,string modelo)
        {
            _rueda = new Rueda(rueda,modelo);
        }
    }
}
