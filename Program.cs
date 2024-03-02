using System.Collections;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1); stack.Push(2);
        stack.Push(3); stack.Push(4);
        stack.Push(5); stack.Push(6);
        stack.Push(7);

        int x = 4;
        int c;
        Queue<int> queue = new Queue<int>();
        while((c=stack.Pop())!=x){
            if(c!=x)
                queue.Enqueue(c);
        }
        while(queue.Count!=0)
            stack.Push(queue.Dequeue());
        
        foreach(int v in stack)
            Console.Write(v + " ");

        /*MyStack ms = new MyStack();
        ms.Push(1);
        ms.Push(2);
        ms.Push(3);//xoá
        ms.Push(4);
        ms.Push(5);

        MyStack temp = new MyStack();
        int c;
        while((c = (int)ms.Pop().data)!=3){
            if(c!=3)
                temp.Push(c);
        }
        
        do{
            ms.Push(temp.Pop().data);
        }while(!temp.IsEmpty());
        
        Stack s1 = new Stack();
        s1.Push(1); s1.Push(2);
        bool cs = (int)s1.Pop()==1;

        Stack<int> s2 = new Stack<int>();
        s1.Push(1); s2.Push(2);
        bool css = s2.Pop()==1;

        Queue q1 = new Queue();
        q1.Enqueue(1); q1.Enqueue(2);


        Queue<int> q2 = new Queue<int>();
        q2.Enqueue(1); q2.Enqueue(2);
        */

        Console.ReadLine();
    }
}