using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public class Phone
    {
        private string firm;
        public string Firm { get; set; }

        private string operating_systems;
        public string Operating_Systems { get; set; }

        private int ram;
        public int RAM
        {
            get { return ram; }
            set
            {
                if (value > 0)
                    ram = value;
                else
                    throw new InvalidRAMException();
            }
        }

        private double procesor_frequence; 
        public double Processor_frequency
        {
            get { return procesor_frequence; }
            set
            {
                if (value > 0)
                    procesor_frequence = value;
                else
                    throw new InvalidPFException();
            }
        }

        private int number_of_cores;
        public int Number_of_cores
        {
            get { return number_of_cores; }
            set
            {
                if (value > 0)
                    number_of_cores = value;
                else
                    throw new InvalidNumberException();
            }
        }
        public bool HasMini_jack { get; set; }
        public bool HasGPS { get; set; }

        public override string ToString()
        {
            return string.Format("Фірма: {0} | Операційна система: {1} | RAM: {2} | Частота процесора: {3} | Кількість ядер: {4} | [{5}, {6}]\r\n",
                Firm, Operating_Systems, RAM,
                Processor_frequency, Number_of_cores,
                HasMini_jack ? "Є роз'єм для наушників" : "Немає роз'єму для наушників",
                HasGPS ? "Є GPS" : "Немає GPS"); 
        }
    }

    public class PhoneException : Exception
    {
        public PhoneException(string messange) : base(messange) { }
    }

    public class InvalidRAMException : PhoneException
    {
        public InvalidRAMException() : base("Invalid age input") { }
    }

    public class InvalidPFException : PhoneException
    {
        public InvalidPFException() : base("Invalid weight input") { }
    }

    public class InvalidNumberException : PhoneException
    {
        public InvalidNumberException() : base("Invalid weight input") { }
    }
}
