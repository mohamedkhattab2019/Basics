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

# Searching and sorting 
## Binary search
*  Binary Search is a searching algorithm used in a **sorted array** by repeatedly dividing the search interval in half. The idea of binary search is to use the information that the array is sorted and reduce the time complexity to O(Log n).
*  Binary vs Linear(sequential) Search:
  * Time complexity of linear search -O(n) , Binary search has time complexity O(log n).
  * Linear search performs equality comparisons and Binary search performs ordering comparisons
<table>
  <tr style="background-color: #a99ee7;">
    <td>
      <img src="https://blog.penjee.com/wp-content/uploads/2015/04/binary-and-linear-search-animations.gif" width="400" height="300">     
    </td>
    <td>
     <img src="https://blog.penjee.com/wp-content/uploads/2015/12/linear-vs-binary-search-worst-case.gif" width="400" height="300">
    </td> 
   <td>
     <img src="https://blog.penjee.com/wp-content/uploads/2015/12/linear-vs-binary-search-best-case.gif" width="400" height="300">
    </td> 
  </tr>
</table>

## Sorting 
### Buble Sort:
* Time Complixty : ![\Large O(n^2)](https://latex.codecogs.com/svg.latex?\Large&space;O(n^2)) 

<img src="https://www.programmingsimplified.com/images/c/bubble-sort.gif" width="300" height="100">

### Merge Sort

* Time Complixty : ![\Large O(nlog(n))](https://latex.codecogs.com/svg.latex?\Large&space;O(nlog(n))) 
* Merge Sort is **a Divide and Conquer algorithm**. It divides the input array into two halves, calls itself for the two halves, and then merges the two sorted halves
 <img src="https://media.geeksforgeeks.org/wp-content/cdn-uploads/Merge-Sort-Tutorial.png" width="500" height="500">
 
 ### Quick Sort 
* QuickSort is **a Divide and Conquer algorithm**. It picks an element as pivot and partitions the given array around the picked pivot. 
* pick pivot in different ways:
  * Always pick first element as pivot.
  * Always pick last element as pivot.
  * Pick a random element as pivot.
  * Pick median as pivot.
* Time Complixty : 
  * Average and best case  ![\Large O(nlog(n))](https://latex.codecogs.com/svg.latex?\Large&space;O(nlog(n)))
  * worest case : ![\Large O(n^2)](https://latex.codecogs.com/svg.latex?\Large&space;O(n^2)) 

 <img src="https://upload.wikimedia.org/wikipedia/commons/6/6a/Sorting_quicksort_anim.gif" width="400" height="300">  

# TREES 
* **A tree is non-linear and a hierarchical data structure consisting of a collection of nodes such that each node of the tree stores a value, a list of references to nodes (the “children”).**
* Data structure Like trees Starts from a Roots and you add data to its branches
* a Trees is realy just extention of **linked list** ; the first element on the tree (Root) istead of pointnig to one next element it can have several.
* Constraints : 
  * Trees must be connected given one node you can reach to the others
  * Trees must not be cyclic (reach the same node twice)
* Terminologies:
      <img src="https://media.geeksforgeeks.org/wp-content/cdn-uploads/20201129105858/Tree-Basic-Terminology.png" width="700" height="500">       
    * **Ancestor of a Node:** Any predecessor nodes on the path of the root to that node are called Ancestors of that node. {1, 2} are the parent nodes of      the node {7}
    * **Descendant:** Any successor node on the path from the leaf node to that node. {7, 14} are the descendants of the node. {2}.
    * **Sibling:** Children of the same parent node are called siblings. {8, 9, 10} are called siblings.
    * **Depth of a node:** The count of edges from the root to the node. Depth of node {14} is 3.
    * **Height of a node:** The number of edges on the longest path from that node to a leaf. Height of node {3} is 2.
    * **Height of a tree:** The height of a tree is the height of the root node i.e the count of edges from the root to the deepest node. The height of the  above tree is 3.
    * **Level of a node:** The count of edges on the path from the root node to that node. The root node has level 0.
 
## Tree Traversal
 * **trees are non-linear data structure,so there is no clear way.**
### Depth First Search (DFS)
* ***Depth First Traversals:*** 
(a) Inorder (Left, Root, Right) : 4 2 5 1 3 
(b) Preorder (Root, Left, Right) : 1 2 4 5 3 
(c) Postorder (Left, Right, Root) : 4 5 2 3 1
Breadth-First or Level Order Traversal: 1 2 3 4 5 

Preorder Traversal (Practice): 

Algorithm Preorder(tree)
   1. Visit the root.
   2. Traverse the left subtree, i.e., call Preorder(left-subtree)
   3. Traverse the right subtree, i.e., call Preorder(right-subtree)
   4. <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/7/7f/Depth-First-Search.gif/220px-Depth-First-Search.gif" width="500" height="500">       

