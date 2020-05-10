using System;

namespace CSharpMedium.Entities
{
    public class HourContract
    {
        public DateTime date { get; set; }
        public double valuePerHour { get; set; }
        public int hours { get; set; }

        public HourContract(DateTime data, double valuePorhora, int hora)
        {
            date = data;
            valuePerHour = valuePorhora;
            hours = hora;
        }
        public double totalValue(DateTime data){
            return valuePerHour * hours;
        }
    }
}
