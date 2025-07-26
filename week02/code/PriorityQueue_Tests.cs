using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities.
    // Expected: Highest priority first.
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
    // Scenario: Items with the same priority.
    // Expected: FIFO order preserved.
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

    [TestMethod]
    // Scenario: Includes a negative priority.
    // Assumes: Higher numbers mean higher priority.
    public void TestPriorityQueue_3()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Scarf", -2);
        pq.Enqueue("Watch", 5);
        pq.Enqueue("Handkerchief", 5);
        pq.Enqueue("Belt", 1);

        Assert.AreEqual("Watch", pq.Dequeue());
        Assert.AreEqual("Handkerchief", pq.Dequeue());
        Assert.AreEqual("Belt", pq.Dequeue());
        Assert.AreEqual("Scarf", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue.
    // Expected: InvalidOperationException with specific message.
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

    [TestMethod]
    public void TestPriorityQueue_5()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Brick", 3);
        Assert.AreEqual("Brick", pq.Dequeue());
    }

    [TestMethod]
    public void TestPriorityQueue_6()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Lowest", int.MinValue);
        pq.Enqueue("Highest", int.MaxValue);
        Assert.AreEqual("Highest", pq.Dequeue());
        Assert.AreEqual("Lowest", pq.Dequeue());
    }

    [TestMethod]
    public void TestPriorityQueue_7()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 3);
        Assert.AreEqual("A", pq.Dequeue());
        pq.Enqueue("B", 5);
        pq.Enqueue("C", 2);
        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
    }
}
