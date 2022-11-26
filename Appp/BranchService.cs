

namespace Appp
{
    public static class BranchService
    {
        public static int getDepthOfTree(Branch tree)
        {
            if (tree.branches.Count == 0)
            {
                return 1;
            }
            else
            {
                return tree.branches.Select(x => 1 + getDepthOfTree(x)).Max();
            }
        }
    }
}
