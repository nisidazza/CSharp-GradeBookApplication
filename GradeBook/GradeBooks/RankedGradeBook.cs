using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        private readonly string _name;

        public RankedGradeBook(string name) : base(name)
        {
            _name = name;
            Type = Enums.GradeBookType.Ranked;
        }
    }
}
