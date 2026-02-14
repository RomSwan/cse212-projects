public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        else return;
    }

    public bool Contains(int value)
    {
        if (value < Data)
        {
            if (Left is null) return false;
            else return Left.Contains(value);
        }
        if (value > Data)
        {
            if (Right is null) return false;
            else return Right.Contains(value);
        }
        else return true;
    }

    public int GetHeight()
    {
        int left = 0, right = 0, biggerTree;

        if (Left is not null) left = Left.GetHeight();
        if (Right is not null) right = Right.GetHeight();

        if (left > right) biggerTree = left;
        else biggerTree = right;

        return 1 + biggerTree;
    }
}