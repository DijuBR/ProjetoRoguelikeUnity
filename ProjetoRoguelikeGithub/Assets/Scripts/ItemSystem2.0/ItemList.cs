using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class ItemList 
{
   public ItemSystem item;
   public string name;
   public int stack;

   public ItemList(ItemSystem newItem, string newName, int newStack){

    item = newItem;
    name = newName;
    stack = newStack;
   }
}
