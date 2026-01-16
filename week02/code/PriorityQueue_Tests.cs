using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: The Dequeue function shall remove the item with the highest priority.
    // Expected Result: Sebastian (Pri:1), Jennifer (Pri:2)
    // Defect(s) Found: Dequeue() was not removing anything from the queue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Sebastian", 1);
        priorityQueue.Enqueue("John", 3);
        priorityQueue.Enqueue("Jennifer", 2);

        priorityQueue.Dequeue();


        string expectedResult = "[Sebastian (Pri:1), Jennifer (Pri:2)]";

        Assert.AreEqual(expectedResult, priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed.
    // Expected Result: Sebastian (Pri:1), Gabby(Pri:3) Jennifer (Pri:2)
    // Defect(s) Found: None.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Sebastian", 1);
        priorityQueue.Enqueue("John", 3);
        priorityQueue.Enqueue("Jennifer", 2);
        priorityQueue.Enqueue("Gabby", 3);

        priorityQueue.Dequeue();

        string expectedResult = "[Sebastian (Pri:1), Jennifer (Pri:2), Gabby (Pri:3)]";

        Assert.AreEqual(expectedResult, priorityQueue.ToString());
    }
    
    [TestMethod]
    // Scenario: If the queue is empty, then an error exception shall be thrown.
    // Expected Result: InvalidOperationException with a message of "The queue is empty".
    // Defect(s) Found: None.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}