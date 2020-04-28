using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        private readonly string _name;

        public StandardGradeBook(string name) : base(name)
        {
            _name = name;
            Type = Enums.GradeBookType.Standard;
        }


    }
}
