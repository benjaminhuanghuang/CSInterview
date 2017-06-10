//https://www.youtube.com/watch?v=oSWTXtMglKE

namespace CSInterview.Algorithms
{
    public class Node
    {
        public Node Left;
        public Node Right;
        public int Data;

        public Node(int data)
        {
            this.Data = data;
        }

        public void Insert(int value)
        {
            if (value <= Data)
            {
                if (Left == null)
                {
                    Left = new Node(value);
                }
                else
                {
                    Left.Insert(value);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new Node(value);
                }
                else
                {
                    Right.Insert(value);
                }
            }
        }

        public bool Contains(int value)
        {
            if (value == Data)
            {
                return true;
            }
            else if (value < Data)
            {
                if (Left == null)
                    return false;
                return Left.Contains(value);
            }
            else
            {
                if (Right == null)
                    return false;
                return Right.Contains(value);
            }
        }

    }
}