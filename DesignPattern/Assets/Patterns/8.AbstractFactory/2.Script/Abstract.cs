using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChest
{
    
}
public interface IHead
{
    //보는기능
    void See();
}

public class EastChest : IChest
{

}
public class EastHead : IHead
{
    void IHead.See() //보는기능 구현
    {
        Debug.Log("EastHeadSee");
    }
}
public class Insect
{
    IChest chest;
    IHead head;
   public  void SetHead(IHead head)
    {
        this.head = head;
    }
    public void SetChest(IChest chest)
    {
        this.chest = chest;
    }
    public IChest GetChest()
    {
        return chest;
    }
    public IHead GetHead()
    {
        return head;
    }
}

public interface IFactory_Insect
{
    IChest Create_Chest();
    IHead Create_Head();
}

public class Factory_EastInsect : IFactory_Insect
{
   

    public IChest Create_Chest()
    {
        return new EastChest();
    }

    public IHead Create_Head()
    {
        return new EastHead();

    }
}
