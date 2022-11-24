using DataStructures.LinkedLists;
using FluentAssertions;

namespace DataStructures.Tests.LinkedLists;
public class ReverseListsTests
{
    [Test]
    public void ReverseListTest()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expected = new ListNode(5, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(1)))));
        var actual = ReverseLinkedLists.ReverseList(head);
        actual.Should().BeEquivalentTo(expected);
    }
}
