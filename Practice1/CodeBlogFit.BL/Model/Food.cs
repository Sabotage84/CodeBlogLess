using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFit.BL.Model
{
    public class Food
    {
        public string Name { get; }

        public double Protein { get; }

        public double Fats { get;}

        public double Carbohydrates { get; }

        public double Calories { get; }

        private double CaloriesOneGramm { get { return (Calories / 100.00); } }
        private double ProteinsOneGramm { get { return (Protein / 100.00); } }
        private double FatssOneGramm { get { return (Fats / 100.00); } }


    }
}
