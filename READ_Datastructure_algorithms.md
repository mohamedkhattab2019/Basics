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

# linked List
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
  
# Stack FILO
* Stack is a linear data structure that follows a particular order in which the operations are performed. The order may be LIFO(Last In First Out) or FILO(First In Last Out).
* Stack is realy usefull when you care about the most recent elements.
* Stack Operations :
   * Push: Adds an item in the stack. If the stack is full, then it is said to be an Overflow condition.
   * Pop: Removes an item from the stack. The items are popped in the reversed order in which they are pushed. If the stack is empty, then it is said to be an          Underflow condition.
   * Peek or Top: Returns the top element of the stack.
   * isEmpty: Returns true if the stack is empty, else false.
 <img src="https://media.geeksforgeeks.org/wp-content/uploads/20210716162942/stack-660x345.png" data-canonical-src="https://gyazo.com/eb5c5741b6a9a16c692170a41a49c858.png" width="400" height="250" />.
 
 * **Time Complexity:**
   * Access: O(n)
   * Search: O(n)
   * Insert(Push): O(1)
   * Remove(Pop): O(1)
   * isEmpty() and peek() : O(1)
* Applications :
  * Redo-undo features at many places like editors, photoshop.
  * Forward and backward feature in web browsers
  * Used in many algorithms like Tower of Hanoi, tree traversals, stock span problem, histogram problem.

* Queue
* A Queue is a collection of elements, supporting two principle operations: enqueue, which inserts an element into the queue, and dequeue, which removes an      element from the queue
* First in, first out data structure **(FIFO)**: the oldest added object is the first to be removed
*  **Time Complexity**:
Access: O(n)
Search: O(n)
Insert: O(1)
Remove: O(1)
