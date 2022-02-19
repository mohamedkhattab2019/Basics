#!/user/bin/env python3
# Python3 program to remove duplicates
# from unsorted linked list


class Node():

	def __init__(self, data):

		self.data = data
		self.next = None


class LinkedList():

	def __init__(self):

		# Head of list
		self.head = None

	def remove_duplicates(self):

		ptr1 = None
		ptr2 = None
		ptr1 = self.head
        # Pick elements one by one and stop when next is null
		while (ptr1  and ptr1.next):
			ptr2 = ptr1
			# Compare the picked element with rest of the elements
			while ptr2.next :
				if (ptr1.data == ptr2.next.data):
    				# If duplicate then delete it
					# Sequence of steps is important here
					ptr2.next = ptr2.next.next
				else:
					ptr2 = ptr2.next

			ptr1 = ptr1.next

	# Function to print nodes in a
	# given linked list
	def printList(self):
		temp = self.head

		while(temp != None):
			print(temp.data, end=" ")
			temp = temp.next

		print()


# Driver code
list = LinkedList()
list.head = Node(10)
list.head.next = Node(12)
list.head.next.next = Node(11)
list.head.next.next.next = Node(11)
list.head.next.next.next.next = Node(12)
list.head.next.next.next.next.next = Node(11)
list.head.next.next.next.next.next.next = Node(10)

print("Linked List before removing duplicates :")
list.printList()
list.remove_duplicates()
print()
print("Linked List after removing duplicates :")
list.printList()

# This code is contributed by maheshwaripiyush9
