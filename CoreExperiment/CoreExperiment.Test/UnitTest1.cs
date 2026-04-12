using CoreExperiment.Core;

namespace CoreExperiment.Test
{
    public class UnitTest1
    {
        private readonly ICustomLogger _logger;

        public UnitTest1()
        {
            _logger = new Mock<ICustomLogger>();
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
