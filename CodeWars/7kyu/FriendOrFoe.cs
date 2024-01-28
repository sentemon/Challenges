using System;
using System.Collections.Generic;

public static class Kata {
  public static IEnumerable<string> FriendOrFoe (string[] names) {
    List<string> friends = new List<string>();
    
    foreach (string name in names)
    {
      if (name.Length == 4)
      {
        friends.Add(name);
      }
    }
    
    return friends;
  }
}