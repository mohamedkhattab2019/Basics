#!/user/bin/env python3
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
print (ll.head.next.next.value)
# Should also print 3
print (ll.get_position(3).value)

# Test insert
ll.insert(e4,3)
# Should print 4 now
print (ll.get_position(3).value)
# Test delete
ll.delete(1)
# Should print 2 now
print (ll.get_position(1).value)
# Should print 4 now
print (ll.get_position(2).value)
# Should print 3 now
print (ll.get_position(3).value)