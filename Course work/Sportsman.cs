using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Course_work
{
    class Sportsman
    {

        int regestration_number;
        string surname;
        string name;
        string patronymic;
        string counrty;
        string kind_ofsport;
        int place;
        byte error = 0;


        public int Regestration_Number { get => regestration_number; set => regestration_number = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public string Country { get => counrty; set => counrty = value; }
        public string Kind_OfSport { get => kind_ofsport; set => kind_ofsport = value; }
        public int Place { get => place; set => place = value; }
        public byte Error { get => error; set => error = value; }


        public Sportsman(int regestration_number, string surname, string name, string patronymic, string counrty, string kind_ofsport, int place)
        {
            Regestration_Number = regestration_number;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Country = counrty;
            Kind_OfSport = kind_ofsport;
            Place = place;

        }

    }
}
