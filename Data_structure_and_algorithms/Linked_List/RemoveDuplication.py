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

    def insert(self, new_element, position):
        """Insert a new node at the given position.
        Assume the first position is "1".
        Inserting at position 3 means between
        the 2nd and 3rd elements."""
        new_element.next = self.get_position(position)
        self.get_position(position-1).next=new_element
        
    def delete(self, value):
        """Delete the first node with a given value."""
        if self.get_position(value)==self.head:
            self.head = self.get_position(value).next
        else:
            self.get_position(value-1).next = self.get_position(value).next
        pass
        	
    # Utility function to print the
    # linked LinkedList
    def printList(self):
        temp = self.head
        while(temp):
            print(temp.value)
            temp = temp.next
        pass
    def removeDuplicates(self):
        current=self.head
        if current is None:
            return
        while current.next :
            if current.value==current.next.value :
                newpointer = current.next.next
                current.next = None
                current.next = newpointer
            else:
                current=current.next
    
		            
# Test cases
# Set up some Elements
e1 = Element(11)
e2 = Element(11)
e3 = Element(11)
e4 = Element(13)
e5 = Element(13)
e6 = Element(20)

# Start setting up a LinkedList
llist = LinkedList(e1)
llist.append(e2)
llist.append(e3)
llist.append(e4)
llist.append(e5)
llist.append(e6)
# Driver Code
print ("Created Linked List: ")
llist.printList()
print()
print("Linked List after removing",
			"duplicate elements:")
llist.removeDuplicates()
llist.printList()

# This code is contributed by
# Dushyant Pathak.
