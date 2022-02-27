#!/user/bin/env python3
# Python program for linked list implementation of stack

# Class to represent a node


class StackNode:

	# Constructor to initialize a node
	def __init__(self, data):
		self.data = data
		self.next = None


class Stack:

	# Constructor to initialize the root of linked list
	def __init__(self):
		self.head = None

	def isEmpty(self):
		return True if self.head is None else False
    # append head every time chnge headd to be new node and the new node point to the prev head
	def push(self, data):
		newNode = StackNode(data)
		newNode.next = self.head
		self.head = newNode
		print ("% d pushed to stack" % (data))

	def pop(self):
		if (self.isEmpty()):
			return float("-inf")
		temp = self.head
		self.head = self.head.next
		popped = temp.data
		return popped

	def peek(self):
		if self.isEmpty():
			return float("-inf")
		return self.head.data
	def printStack(self):
		temp = self.head
		print("Stack Elements : ")
		while(temp != None):
			print(temp.data, end=" ")
			temp = temp.next

		print()

    


# Driver code
stack = Stack()
stack.push(10)
stack.push(20)
stack.push(30)
stack.printStack()

print ("% d popped from stack" % (stack.pop()))
print ("% d popped from stack" % (stack.pop()))
print ("Top element is % d " % (stack.peek()))