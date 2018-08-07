using System.Collections;
using System.Collections.Generic;
using UnityEngine;


interface IITEM
{
    void Use();
}

public class Item : MonoBehaviour ,IITEM{

    public string Name;

    public Item(string name)
    {
        Name = name;
    }
  virtual public void Use()
    {
        Debug.Log("Log:" + Name + "사용됩니다.");
    }    
}

public class HPItem : Item
{
   public HPItem() : base("빨간포션")
    {

    }
    public override void Use()
    {
        base.Use();
        Debug.Log("HP회복");
       
    }
}
public class MPItem : Item
{
    public MPItem() : base("마력포션")
    {
        base.Use();
        Debug.Log("MP회복");
        
    }
}