namespace CSInterview.Algorithms
{
    public class TrieNode
    {
        private static int CHARTS = 26;
        private TrieNode[] children = new TrieNode[CHARTS];
        private int size = 0;
        private int GetCharIndex(char c)
        {
            return (int)c - 'a';
        }

        private TrieNode GetNode(char c)
        {
            return children[GetCharIndex(c)];
        }

        private void SetNode(char c, TrieNode node)
        {
            children[GetCharIndex(c)] = node;
        }

        public void Add(string s)
        {
            Add(s, 0);
        }

        // Core function !!!
        private void Add(string s, int index)
        {
            size++;
            if (index == s.Length)
                return;

            char current = s[index];
            int charCode = GetCharIndex(current);
            TrieNode child = GetNode(current);
            if (child == null)
            {
                child = new TrieNode();
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

            TrieNode child = GetNode(s[index]);
            if (child == null)
            {
                return 0;
            }
            return child.FindCount(s, index + 1);
        }


    }
}