using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutionsTests.Medium
{
    [TestFixture]
    public class ConvertArrayTo2D_2610_Tests
    {
        public void FindMatrix_Tests(int[] input, IList<IList<int>> output)
        {
            var obj = new ConvertArrayTo2D_2610();
            IList<IList<int>> result = obj.FindMatrix(input);
            Assert.That(result, Is.EqualTo(output));
        }
        
    }
}
