using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;

namespace PostClassDeterminer
{
    internal class PostLattice
    {

        public class Node
        {
            public string[] DirectParents { get; set; }
            public string[] AllParents { get; set; }
            public Node(string[] directParents)
            {
                DirectParents = directParents;
                AllParents = Array.Empty<string>();
            }
        }

        // Key: name of Post's class
        // Element: set of Post's class direct parents
        public Dictionary<string, Node> Elements { get; set; }
        public string[] SortedParentCount { get; set; }
        public static Dictionary<string, Node> Template { get; set; }
        private const string templateDiagramFileName = "C:\\Uni\\4 курс\\Диплом\\PostClassDeterminer\\templatePostLattice.txt";

        static PostLattice()
        {
            Template = new Dictionary<string, Node>();
            string[] lines = File.ReadAllLines(templateDiagramFileName);
            // Creating template with file templateDiagramFileName
            Template.Add("P2", new Node(Array.Empty<string>()));
            foreach (string line in lines)
            {
                // Proccessing separate line
                // Key == className
                // Element == directParents converted to string array
                string[] parts = line.Split(new[] { "className: ", ", directParents: " }, StringSplitOptions.RemoveEmptyEntries);
                // Add new node, where key == parts[0]
                // node == new Node(parts[1].Split(','))
                Template.Add(parts[0], new Node(parts[1].Split(", ")));
            }
        }
        public PostLattice(int essentialVarNum)
        {
            // Create new dictionary from dicctionary template
            Elements = new(Template);
            
            // Add eight infinite families as finite depending on quantity
            // of function essential variable
            string essentialVarNumStr = essentialVarNum.ToString();
            string strI, strIPrevious;
            for (int i = 3; i <= essentialVarNum; i++)
            {
                strI = i.ToString();
                strIPrevious = (i - 1).ToString();

                Elements.Add("A_" + strI, new Node(new string[] { "A_" + strIPrevious }));
                Elements.Add("A1_" + strI, new Node(new string[] { "A_" + strI, "A1_" + strIPrevious }));
                Elements.Add("MA_" + strI, new Node(new string[] { "A_" + strI, "MA_" + strIPrevious }));
                Elements.Add("MA1_" + strI, new Node(new string[] { "A1_" + strI, "MA_" + strI,
                    "MA1_" + strIPrevious }));

                Elements.Add("a_" + strI, new Node(new string[] { "a_" + strIPrevious }));
                Elements.Add("a0_" + strI, new Node(new string[] { "a_" + strI, "a0_" + strIPrevious }));
                Elements.Add("Ma_" + strI, new Node(new string[] { "a_" + strI, "Ma_" + strIPrevious }));
                Elements.Add("Ma0_" + strI, new Node(new string[] { "a0_" + strI, "Ma_" + strI, 
                    "Ma0_" + strIPrevious }));
            }

            Elements.Add("P0_d", new Node(new string[] { "P_d", "Ma_" + essentialVarNumStr }));
            Elements.Add("P01_d", new Node(new string[] { "P0_d", "P1_d", "Ma0_" + essentialVarNumStr }));
            Elements.Add("P0", new Node(new string[] { "P", "MA_" + essentialVarNumStr }));
            Elements.Add("P01", new Node(new string[] { "P0", "P1", "MA1_" + essentialVarNumStr }));

            // Find all parent for all nodes in elements
            // Take returned dictionary of nodes and their number of all parents pairs
            // Sort it based on value using LINQ and assign sorted keys to string[] array
            SortedParentCount = this.FindAllParents().OrderByDescending(x => x.Value).Select(x => x.Key).ToArray();
        }
    
        // Finds all direct and indirect parents for each Hasse diagram node
        public Dictionary<string, int> FindAllParents()
        {
            Dictionary<string, int> parentCount = new();

            foreach (var keyValue in Elements)
            {
                // Create HashSet of all visited nodes
                var visited = new HashSet<string>();
                // Initialize queue of nodes to check their parents
                var queue = new Queue<string>(Elements[keyValue.Key].DirectParents);
                // Add nodes in queue to visited nodes
                visited.UnionWith(queue);

                // Initialize number of nodes in queue
                int count = queue.Count;
                while (queue.Count > 0)
                {
                    // Visit next node parents in queue
                    string current = queue.Dequeue();
                    foreach (string parent in Elements[current].DirectParents)
                    {
                        if (!visited.Contains(parent))
                        {
                            queue.Enqueue(parent);
                            visited.Add(parent);
                        }
                    }

                }

                Elements[keyValue.Key].AllParents = visited.ToArray();
                // Add amount of all parents of element to dictionary
                parentCount.Add(keyValue.Key, visited.Count);

            }

            return parentCount;

        }
    }
}