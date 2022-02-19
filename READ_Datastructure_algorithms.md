# Notation And code efficiency(Complexty)
* efficienncy mean how will you're using your computer resources to get a particular job done.
* you can devide it into a two main categ. `space` and `Time`.
* **Time** mean how long does you're code take to run. 
* **space** mean how much storage space do you need ?
* ***Efficiency*** mean to get the most done with minimum resources 
* **Notation**
<img src="https://www.devopsschool.com/blog/wp-content/uploads/2021/06/Complete-Tutorial-on-big-O-big-oh-notation-740x414.png" data-canonical-src="https://gyazo.com/eb5c5741b6a9a16c692170a41a49c858.png" width="200" height="100" />

* example : lets say we need to add 200 to input which method below will be faster:
 <table>
  <tr style="background-color: #a99ee7;">
    <td>
      for 2 iteration :
        add 100 to input  
    </td>
    <td>
      for 100 iteration :
        add 2 to input  
    </td>    
  </tr>
</table> 

* Aprroximation : 
if we say we need `O(26n+3)` to itterate through the alphabet words this is the worst cas so we consider an approximation to be `O(n)`.

* linked List
* A linked list is a linear data structure, in which the elements are not stored at contiguous memory locations. The elements in a linked list are linked using    pointers(address) as shown in the below image:
 <img src="https://media.geeksforgeeks.org/wp-content/cdn-uploads/gq/2013/03/Linkedlist.png" data-canonical-src="https://gyazo.com/eb5c5741b6a9a16c692170a41a49c858.png" width="700" height="150" />.
* **A linked list consists of nodes where each node contains a data field (value) and a reference(link) to the next node in the list.**
* **Comparing to Arrayes insertion or deletion element to or from lnked list is easier.**
* **Singly-linked list**: linked list in which each node points to the next node and the last node points to null
* **Doubly-linked list**: linked list in which each node has two pointers, p and n, such that p points to the previous node and n points to the next node; the last node's n pointer points to null
* **Circular-linked list**: linked list in which each node points to the next node and the last node points back to the first node
* **Time Complexity:**
  * Access: O(n)
  * Search: O(n)
  * Insert: O(1) -> since you does shifting around pointers not iterating over every element in the list. 
  * Remove: O(1) 
  
```python
  class Element(object):
    def __init__(self, value):
        self.value = value
        self.next = None

 class LinkedList(object):
	#we're just establishing that a LinkedList is something that has a head Element, which
	# is the first element in the list. If we establish a new LinkedList without a head, 
	# it will default to None. 
    def __init__(self, head=None):
        self.head = head # address 

    #If the LinkedList already has a head, iterate through the next reference in every 
    # Element until you reach the end of the list. Set next for the end of the list to be
    # the new_element.
    def append(self, new_element):
        current = self.head
        if self.head:
            while current.next:
                 current = current.next
                 
            current.next = new_element
        else:
            self.head = new_element

    def get_position(self, position):
        """ Get object at certain position,
        Get an element from a particular position.
        Assume the first position is "1".
        Return "None" if position is not in the list."""
        current = self.head
        pos =1
        if self.head.next:
            
            while current:
                
                if position== pos:
                    return current
                pos+=1
                current = current.next
                
            return None
        else:
            return 1
       # current = self.head
        #pos=1
        #if self.head.next:
        #    while current:
        #    	if position==pos:
        #    		return current
        #    	pos+=1
        #        current = current.next
        #    return None
        #else:
        #    return 1

    def insert(self, new_element, position):
        """Insert a new node at the given position.
        Assume the first position is "1".
        Inserting at position 3 means between
        the 2nd and 3rd elements."""
        new_element.next = self.get_position(position)
        self.get_position(position-1).next=new_element
        pass

    def delete(self, value):
        """Delete the first node with a given value."""
        if self.get_position(value)==self.head:
        	self.head = self.get_position(value).next
        		
        else:
        	self.get_position(value-1).next = self.get_position(value).next
        	
        pass
# Test cases
# Set up some Elements
e1 = Element(1)
e2 = Element(2)
e3 = Element(3)
e4 = Element(4)

# Start setting up a LinkedList
ll = LinkedList(e1)
ll.append(e2)
ll.append(e3)


# Test get_position
# Should print 3
print ll.head.next.next.value
# Should also print 3
print ll.get_position(3).value

# Test insert
ll.insert(e4,3)
# Should print 4 now
print ll.get_position(3).value
# Test delete
ll.delete(1)
# Should print 2 now
print ll.get_position(1).value
# Should print 4 now
print ll.get_position(2).value
# Should print 3 now
print ll.get_position(3).value
```
