//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kursovai.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Задача
    {
        public int Ключ { get; set; }
        public string НазваниеЗадачи { get; set; }
        public int КлючНаправление { get; set; }
        public int КлючСделанойРабочим { get; set; }
        public string Описание { get; set; }
        public System.DateTime ДатаПоставленойЗадачи { get; set; }
        public int КлючПроверки { get; set; }
        public int КлючИсполнителя { get; set; }
        public int КлючАдминистратора { get; set; }
    
        public virtual Сотрудник Сотрудник { get; set; }
        public virtual Направление Направление { get; set; }
        public virtual Проверка Проверка { get; set; }
        public virtual СделаноРаботником СделаноРаботником { get; set; }
        public virtual Сотрудник Сотрудник1 { get; set; }

        public string DataT
        {
            get
            {
                return ДатаПоставленойЗадачи.ToString("dd:MMMM:yyyy");
            }
        }
    }

}
