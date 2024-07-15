using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_DbGrid
{
    /// <summary>
    /// Класс-описание объекта типа User
    /// </summary>
    public class User
    {
        public string id_kaf { get; set; }
        public string nameKaf { get; set; }
        public string id_Disc { get; set; }
        public string Disc { get; set; }
        public string id_spec { get; set; }
        public string spec { get; set; }
        public string kurs { get; set; }
        public string sem { get; set; }
    }

    /// <summary>
    /// Класс-список объектов типа User
    /// </summary>
    public class LibUsers
    {
        public IList<User> Users { get; set; }
    }

}
