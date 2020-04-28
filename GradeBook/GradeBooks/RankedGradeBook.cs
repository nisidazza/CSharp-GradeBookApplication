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

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

            //sort list 
            var sortedGrades = Students
                .Select(student => student.AverageGrade)
                .OrderBy(grade => grade)
                .ToList();

            //loop through the list - check each element with your value
            double ranking = 0;
            for (var i = 0; i < sortedGrades.Count; i++)
            {
                if (averageGrade <= sortedGrades[i])
                {
                    ranking = i;
                    break;
                }
            }

            double percentile = (1 - (ranking / Students.Count));

            if (percentile <= 0.2) return 'A';
            if (percentile <= 0.4) return 'B';
            if (percentile <= 0.6) return 'C';
            if (percentile <= 0.8) return 'D';

            return 'F';
        }
    }
}
