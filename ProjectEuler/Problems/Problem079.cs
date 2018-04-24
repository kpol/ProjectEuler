using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem079 : Problem<string>
    {
        // A common security method used for online banking is to ask the user for three random characters from a passcode.
        // For example, if the passcode was 531278, they may ask for the 2nd, 3rd, and 5th characters; the expected reply would be: 317.
        // The text file, keylog.txt, contains fifty successful login attempts.
        // Given that the three characters are always asked for in order, analyse the file so as to determine the shortest possible secret passcode of unknown length.

        public override string Run()
        {
            var attempts = File.ReadAllLines(@"Data\p079_keylog.txt").Select(s => new[] { int.Parse(s[0].ToString()), int.Parse(s[1].ToString()), int.Parse(s[2].ToString()) });
            var nodes = new Dictionary<int, Node<int>>();

            foreach (var attempt in attempts)
            {
                Node<int> node1;
                if (!nodes.TryGetValue(attempt[0], out node1))
                {
                    node1 = new Node<int> { Value = attempt[0] };
                    nodes.Add(attempt[0], node1);
                }

                Node<int> node2;
                if (!nodes.TryGetValue(attempt[1], out node2))
                {
                    node2 = new Node<int> { Value = attempt[1] };
                    nodes.Add(attempt[1], node2);
                }

                if (node2.Parents.All(n => n.Value != attempt[0]))
                {
                    node2.Parents.Add(node1);
                }

                Node<int> node3;
                if (!nodes.TryGetValue(attempt[2], out node3))
                {
                    node3 = new Node<int> { Value = attempt[2] };
                    nodes.Add(attempt[2], node3);
                }

                if (node3.Parents.All(n => n.Value != attempt[1]))
                {
                    node3.Parents.Add(node2);
                }
            }

            var result = string.Concat(nodes.OrderBy(n => n.Value.Parents.Count).Select(n => n.Key));

            return result;
        }

        private class Node<T>
        {
            public T Value { get; set; }

            public List<Node<T>> Parents { get; } = new List<Node<T>>();
        }
    }
}