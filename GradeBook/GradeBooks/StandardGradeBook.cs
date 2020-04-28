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
        private readonly bool _isWeighted;

        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            _name = name;
            _isWeighted = isWeighted;
            Type = Enums.GradeBookType.Standard;
        }


    }
}
