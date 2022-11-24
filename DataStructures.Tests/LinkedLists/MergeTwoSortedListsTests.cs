using DataStructures.LinkedLists;
using FluentAssertions;

namespace DataStructures.Tests.LinkedLists;
public class MergeTwoSortedListsTests
{
    [Test]
    public void MergeTwoSortedListsTest()
    {
        var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));
        var actual = MergeTwoSortedLists.MergeTwoLists(l1, l2);
        actual.Should().BeEquivalentTo(expected);
    }

    [Test]
    public void MergeTwoSortedListsRecursionTest()
    {
        var l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));
        var actual = MergeTwoSortedListsRecursion.MergeTwoLists(l1, l2);
        actual.Should().BeEquivalentTo(expected);
    }
}
