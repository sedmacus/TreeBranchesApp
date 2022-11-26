using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appp
{
    public class Branch
    {
        public List<Branch> branches { get; set; }

        public Branch()
        {
            branches = new List<Branch>();
        }


        void printTree(Branch branch)
        {
            if (branch.branches.Count == 0)
            {
                Console.WriteLine("\n");
            }
            branch.branches.ForEach(x => Console.WriteLine(" O "));
            branch.branches.ForEach(x => printTree(x));
        }
    }
}
