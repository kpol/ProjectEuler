using System.IO;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// <see cref="Problem018"/>.
    /// </summary>
    public class Problem067 : Problem018
    {
        protected override string GetTriangleData => File.ReadAllText(@"Data\p067_triangle.txt");
    }
}