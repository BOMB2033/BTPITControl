using System;
using System.Collections.Generic;
using System.Text;

namespace BTPITControl
{
    class BTPITControl
    {
        public List<List<string>> data = new List<List<string>>();
        public void AutoSet() 
        {
            data.Add(new List<string>
            {
                "Разговоры о важном. Грошиков А.В",
                "Разработка программных модулей. Сорокин М.А.",
                "Английский язык. Вершкова Н.В.",
                "Разработка ПО. Пармузина М.В."

            });
            data.Add(new List<string>
            {
                "Бух-учёт. Дудина И.А.",
                "Бух-учёт. Дудина И.А.",
                "Разработка программных модулей. Сорокин М.А.",
                ""

            });
            data.Add(new List<string>
            {
                "",
                "Базы данных. Пармузина М.В.",
                "Компьютерные сети. Сорокин М.А.",
                "Дискретная математика. Мочалова С.Э."

            });
            data.Add(new List<string>
            {
                "Разработка интерфейса ИС. Сорокин М.А",
                "Разработка ПО. Пармузина М.В.",
                "Физ-ра(если будет). Глушкова О.А.",
                "Немецкий язык(туфта). Протасова Е.И."

            });
            data.Add(new List<string>
            {
                "Разработка ПО. Пармузина М.В.",
                "Численные методы. Мочалова С.Э.",
                "Разработка программных модулей. Сорокин М.А.",
                ""

            });
        }

        public List<string> GetDataDay(int day) 
        {
            return data[day];
        }
    }
}
