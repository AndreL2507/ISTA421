# Andre Lacquement
### C# Ch.20 Homework
---

1. What is a delegate?
A delegate is a reference to a method. 

1. How do you invoke a method that has been assigned to a delegate variable?
You call it by the name you gave to the delegate 

1. What is an event?
Use to define and trap significant actions and arrange for a delegate to be called to handle the situation. 

1. How do you raise an event?
Use an event source to monitor certain events happening

1. What is the purpose of an event source (the class encapsulating an event)? Separating particular events into classes. 


1. Explain with specificity what happens when an event is raised, assuming you have subscribed to that event with at least one delegate. The event is called when it is not null, then all the attached delegates are called in sequence. 

1. Events can only be directly raised from a method inside their containing class (event source). How does this improve security?
It will only be raised if it is not null. 

1. Provide code that:
        Declares a delegate
        Declares a method which can be assigned to that delegate
        Instantiates the delegate and assigns the method to it
        
1. Provide code that:
        Declares an event
        Registers a method with the event
        Registers a lambda expression with the event
        Raises the event (be sure you handle properly events that have no subscribed delegates)
        Unsubscribes the method from the event


