using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    class IdName
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = (value < 0) ? 0 : value; }
        }

        public string Name { get; set; }
        public string Info = "";

        public IdName() { return; }

        public IdName(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
