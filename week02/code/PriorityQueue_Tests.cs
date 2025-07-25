using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue mutliple items with different priorities and then dequeue them.
    // Expected Result: Items should be dequeued in order of their priority.    
    // Defect(s) Found:     
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low Priority", 1);
        pq.Enqueue("Medium Priority", 5);
        pq.Enqueue("High Priority", 10);

        Assert.AreEqual("High Priority", pq.Dequeue());
        Assert.AreEqual("Medium Priority", pq.Dequeue());
        Assert.AreEqual("Low Priority", pq.Dequeue());

    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same priority and then dequeue them. 
    // Expected Result: Items with the same priority should be dequeued in the order they were enqueued.
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Shoe", 5);
        pq.Enqueue("Tie", 5);
        pq.Enqueue("Belt", 1);

        Assert.AreEqual("Shoe", pq.Dequeue());
        Assert.AreEqual("Tie", pq.Dequeue());
        Assert.AreEqual("Belt", pq.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
    //Scenario: Enqueue an item with a negative priority and then dequeue it.
    //Expected Result: The item should be dequeued as it has the highest priority.
    public void TestPriorityQueue_3()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Scarf", 2);
        pq.Enqueue("Watch", 5);
        pq.Enqueue("Handkerchief", 5);
        pq.Enqueue("Belt", 1);



        Assert.AreEqual("Watch", pq.Dequeue());  //first with highest priority (5)
        Assert.AreEqual("Handkerchief", pq.Dequeue());  //second with highest priority (5)
        Assert.AreEqual("Scarf", pq.Dequeue());  //next highest (2)
        Assert.AreEqual("Belt", pq.Dequeue());  //lowest (1)
    }

    [TestMethod]
    //Scenario: Error excpetion shall be thrown if the queue is empty
    //Expected result: InvalidOperationException with a message of "The queue is empty."

    public void TestPriorityQueue_4()
    {
        var pq = new PriorityQueue();
        try
        {
            pq.Dequeue();
            Assert.Fail("Expected exception not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }
}
