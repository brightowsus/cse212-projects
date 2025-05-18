using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Items with different priorities are dequeued in correct priority order
    // Expected Result: Dequeue returns highest priority, FIFO for equal priorities
    // Defect(s) Found: Original code did not check last element or remove from list
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 3);
        pq.Enqueue("D", 2);

        Assert.AreEqual("B", pq.Dequeue()); // first 3-priority item
        Assert.AreEqual("C", pq.Dequeue()); // second 3-priority item
        Assert.AreEqual("D", pq.Dequeue()); // next highest
        Assert.AreEqual("A", pq.Dequeue()); // lowest
    }

    [TestMethod]
    // Scenario: All items have same priority → should return in FIFO order
    // Expected Result: Items returned in the order they were enqueued
    // Defect(s) Found: Original code chose last of same-priority items
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("X", 2);
        pq.Enqueue("Y", 2);
        pq.Enqueue("Z", 2);

        Assert.AreEqual("X", pq.Dequeue());
        Assert.AreEqual("Y", pq.Dequeue());
        Assert.AreEqual("Z", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue should throw exception
    // Expected Result: InvalidOperationException is thrown
    public void TestPriorityQueue_ThrowsOnEmptyDequeue()
    {
        var pq = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => pq.Dequeue());
    }
}
