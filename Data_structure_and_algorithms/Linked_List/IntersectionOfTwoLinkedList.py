#!/user/bin/env python3
# Definition for singly-linked list.

# defining a node for LinkedList
class Node:
  def __init__(self,data):
    self.data=data
    self.next=None


def getIntersectionNode(self, headA, headB):
    """
    :type headA, headA: ListNode
    :rtype: ListNode
    """
    #l1,l2 = headA,headB
    #while l1 != l2 :
    #    l1=l1.next if l1 else headB
    #    l2=l2.next if l2 else headA
    #return l1

    hashMap = {}
        
    while headA:
        hashMap[headA] = 1 
        headA = headA.next
        
    while headB:
        if headB in hashMap:
            return headB.data
        headB = headB.next 
            
    return None 
            
    # Driver code
 
 
common=Node(15)
   
#Defining first LinkedList
   
headA=Node(3)
headA.next=Node(6)
headA.next.next=Node(9)
headA.next.next.next=common
headA.next.next.next.next=Node(30)
   
  # Defining second LinkedList
   
headB=Node(10)
headB.next=common
headB.next.next=Node(30)
   
print("The node of intersection is ",getIntersectionNode(15,headA,headB))      
        