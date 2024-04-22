using System;

public partial class Node
{
  public int Data;
  public Node Next;
  
  public Node(int data)
  {
    this.Data = data;
    this.Next = null;
  }
  
  public static int Length(Node head)
  {
    if (head == null)
      return 0;
    
    int length = 0;
    Node current = head;
    
    while (current != null)
    {
      length++;
      current = current.Next;
    }
    
    return length;
    
  }
  
  public static int Count(Node head, Predicate<int> func)
  {
    if (head == null)
      return 0;
    
    int count = 0;
    Node current = head;
    
    while (current != null)
    {
      if (func(current.Data))
        count++;
      
      current = current.Next;
    }
    
    return count;
  }
}