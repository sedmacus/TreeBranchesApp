using Appp;

namespace ApppTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Branch apple = new Branch();

            Branch apple11 = new Branch();

            Branch apple111 = new Branch();

            Branch apple12 = new Branch();

            Branch apple112 = new Branch();

            Branch apple1111 = new Branch();

            Branch apple11111 = new Branch();

            apple1111.branches.Add(apple11111);
            apple111.branches.Add(apple1111);

            apple11.branches.Add(apple111);
            apple11.branches.Add(apple112);

            apple.branches.Add(apple11);

            apple.branches.Add(apple12);

            Console.WriteLine($"depth: {BranchService.getDepthOfTree(apple)}");
            Assert.Pass();
        }
    }
}