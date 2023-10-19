using LibrarySample;

namespace TestProject
{
    public class MathSolverTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("3+3",6)]
        [TestCase("3,3+3,3",6.6)]
        [TestCase("3-3",0)]
        [TestCase("3*3",9)]
        [TestCase("3/3",1)]
        public void Test(string expression, decimal result)
        {
            if (MathSolver.Evaluate(expression) == result)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}