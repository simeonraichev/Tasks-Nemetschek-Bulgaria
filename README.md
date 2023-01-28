
# Tasks-Nemetschek-Bulgaria

This is the continuation of our interview with Nemetschek Bulgaria and the tasks I was given to write this past week.


## Task 1 - Animal Lifespan
Create an application that simulates the lifespan of individual animal spices. For the purpose of the application define:

A set of foods that are known to the application.
A set of animal spices that satisfy the following requirements:
Animal spice is defined with: Maximum energy - integer number
Diet - a set of foods from known foods that animals can eat
Every instance of an animal has Current energy and starts his lifespan with maximum energy

Animals have functionality Feed that accepts food and satisfies the following requirements: Feeding an animal with food increases its current energy by one of the animals can eat the food and reduce it by one otherwise.
Current energy cannot exceed maximum energy.
If animals reach zero energy animal die and cannot eat anymore.
A Simulate lifespan functionality that: Create a predefined number of animals from each animal spice.
Feed every animal with random food from known foods until there are alive animals
When all animals are dead returns statistics of minimum, maximum and average lifespan for every animal spice.
Create a console application that runs the simulation and prints the lifespan simulation statistics.

Clarifications/Requirements:

Details about additional functionality and properties that are not mentioned can be implemented according to the author's vision.
When implementing the application, pay attention to: the individual principles in OOP.
advantages and disadvantages of the data structures used in the particular case.

    This code defines a class Animal that has a MaximumEnergy and Diet properties and a CurrentEnergy field, which starts at the maximum energy and can be increased or decreased through the Feed method. The IsAlive method returns true if the animal's current energy is greater than 0.

    The Main method creates a list of known foods, a list of animal species, and a dictionary to store the simulation results for each species. Then, it creates a new instance of the animal and feeds it with random food from the known foods list until the animal dies. The lifespan of the animal is recorded in days and added.
## Task 2 - Stack implementation
Define an interface for accessing a Stack structure that supports push and pop functionality. Create two implementations of the interface by using Array and Linked list structures. Compare the advantages and disadvantages of both implementations.

    · The Array-based implementation has a fixed size and is more efficient for memory usage and performance, but it can cause stack overflow if the stack becomes full. 
    · The Linked List-based implementation can grow as needed and does not cause stack overflow, but it uses more memory and may be less efficient for performance.
## Task 3 - Queue implementation

Define an interface for accessing the Queue structure that supports Enqueue and Dequeue functionality. Create two implementations of the interface by using Array and Linked list structures. Compare the advantages and disadvantages of both implementations.

    Advantages of using an array-based implementation:
    · Faster dequeue operations due to constant time complexity
    · Lower overhead due to not having to allocate memory for pointers


    Disadvantages of using an array-based implementation:
    · Slower enqueue operations due to having to resize the array when it becomes full
    · More memory overhead due to having to allocate an entire array.
## Array VS LinkedList
General comparison between an Array & LinkedList
    
Advantages of an array:

    · Direct access to elements via indexing, which is fast.
    · Good cache locality, as elements are stored in contiguous memory locations.
    · Easy to implement basic operations such as inserting and deleting at the end.

Disadvantages of an array:

    · Inserting or deleting an element in the middle of an array requires shifting all the elements after it, which can be slow.
    · The size of an array is fixed, so it can't be resized easily.
    · It can waste a lot of space if the array is not full.

Advantages of a linked list:

    · Dynamic size, as elements can be added or removed easily.
    · Inserting or deleting an element in the middle of a list requires only updating the pointers of the previous and next nodes, which is fast.

Disadvantages of a linked list:

    · No direct access to elements, as you have to start at the head and follow the links to find an element, which can be slow.
    · Poor cache locality, as elements are stored in non-contiguous memory locations.
    · More memory overhead, as each element in the list requires an additional pointer to the next element.