using StackAndQueue_Application;
Console.WriteLine("***********Welcome to Stack and Queue Program**********");
LinkedListStack linkedListStack = new LinkedListStack();
linkedListStack.Push(70);
linkedListStack.Push(30);
linkedListStack.Push(56);
linkedListStack.Display();
linkedListStack.Peek();
linkedListStack.Pop();
linkedListStack.IsEmpty();
linkedListStack.Display();
LinkedListQueue qt = new LinkedListQueue();
qt.Enqueue(56);
qt.Enqueue(30);
qt.Enqueue(70);
qt.Display();
qt.Dequeue();
qt.Dequeue();
qt.Dequeue();

qt.Display();

