class Node{
    public Node next;
    public object data;
}
class MyStack{
    Node top;
    public bool IsEmpty(){
        return top == null;
    }
    public void Push(object ele){
        Node n = new Node();
        n.data = ele;
        n.next = top;
        top = n;
    }
    public Node Pop(){
        if(IsEmpty())
            return null;
        Node d = top;
        top = top.next;
        return d;
    }
}