namespace CSInterview.Algorithms
{
    public class Node
    {
        private static int CHARTS = 26;
        private Node[] children = new Node[CHARTS];

        private int GetCharIndex(char c)
        {
            return (int)c - 'a';
        }

        private Node GetNode(char c)
        {
            return children[GetCharIndex(c)];
        }

        private void SetNode(char c, Node node)
        {
            children[GetCharIndex(c)] = node;
        }

        public void Add(string s)
        {
            Add(s, 0);
        }
        private void Add(string s, int index)
        {
            if (index == s.Length)
                return;

            char current = s[index];
            int charCode = GetCharIndex(current);
            Node child = GetNode(current);
            if (child == null)
            {
                child = new Node();
                SetNode(current, child);
            }
            child.Add(s, index + 1);
        }

        public int FindCount(string s, int index)
        {
            if (index == s.Length)
            {
                return size;
            }

            Node child = GetNode(s[index]);
            if (child == null)
            {
                return 0;
            }
            return child.FindCount(s, index + 1);
        }


    }
}