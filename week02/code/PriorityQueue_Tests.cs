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
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low Priority", 1);
        priorityQueue.Enqueue("Medium Priority", 5);
        priorityQueue.Enqueue("High Priority", 10);

        Assert.AreEqual("High Priority", priorityQueue.Dequeue());
        Assert.AreEqual("Medium Priority", priorityQueue.Dequeue());
        Assert.AreEqual("Low Priority", priorityQueue.Dequeue());
        Assert.IsTrue(priorityQueue.IsEmpty(), "Priority queue should be empty after dequeuing all items.");
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same priority and then dequeue them. 
    // Expected Result: Items with the same priority should be dequeued in the order they were enqueued.
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Shoe", 5);
        priorityQueue.Enqueue("Tie", 5);
        priorityQueue.Enqueue("Belt", 1);

        Assert.AreEqual("Shoe", priorityQueue.Dequeue());
        Assert.AreEqual("Tie", priorityQueue.Dequeue());
        Assert.AreEqual("Belt", priorityQueue.Dequeue());
        Assert.IsTrue(priorityQueue.IsEmpty(), "Priority queue should be empty after dequeuing all items.");
    }

    // Add more test cases as needed below.
    [TestMethod]
    //Scenario: Enqueue an item with a negative priority and then dequeue it.
    //Expected Result: The item should be dequeued as it has the highest priority.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item 1", -1);
        priorityQueue.Enqueue("Item 2", 0);
        priorityQueue.Enqueue("Item 3", 1);

        Assert.AreEqual("Item 1", priorityQueue.Dequeue());
        Assert.AreEqual("Item 2", priorityQueue.Dequeue());
        Assert.AreEqual("Item 3", priorityQueue.Dequeue());
        Assert.IsTrue(priorityQueue.IsEmpty(), "Priority queue should be empty after dequeuing all items.");
    }

}