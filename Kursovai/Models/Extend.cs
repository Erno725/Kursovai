using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovai.Models
{
   public partial class Задача
    {
        public string  DataPostZ
        {
            get
            {
                return ДатаПоставленойЗадачи.ToString("dd:MMMM:yyyy");

            }
        }
        public string Proverka
        {
            get 
            {
                if (КлючПроверки == true)
                {
                    return "/Resources/icons8-зеленый-квадрат-48.png";
                }
                else 
                {
                    return "/Resources/icons8-красный-квадрат-48.png";
                }

            }
        }
        public string SdelanoRab
        {
            get
            {
                if (КлючСделанойРабочим == true)
                {
                    return "/Resources/icons8-зеленый-квадрат-48.png";
                }
                else
                {
                    return "/Resources/icons8-красный-квадрат-48.png";
                }
            }
        }
    }
}
