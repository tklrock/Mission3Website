using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission3Website.Models
{
    public class CalculatorModel
        // Defining each of the variables used in the calculator form, requiring they be between 0 and 100
    {
        [Range(0.0,100.0)]
        public float Assignments { get; set; }

        [Range(0.0, 100.0)]
        public float GroupProject { get; set; }

        [Range(0.0, 100.0)]
        public float Quizzes { get; set; }

        [Range(0.0, 100.0)]
        public float Exams { get; set; }

        [Range(0.0, 100.0)]
        public float INTEX { get; set; }
    }
}
