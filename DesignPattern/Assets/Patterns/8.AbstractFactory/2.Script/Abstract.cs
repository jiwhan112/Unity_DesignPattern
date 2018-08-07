using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 각 부품 인터페이스 
public interface IChest
{
    
}
public interface IHead
{
    //보는기능
    void See();
}

// 부품구현
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

public class WestChest : IChest
{

}
public class WestHead : IHead
{
    void IHead.See() //보는기능 구현
    {
        Debug.Log("WestHeadSee");
    }
}


//Factory 인터페이스
public interface IFactory_Insect
{
    IChest Create_Chest();
    IHead Create_Head();
}
//Factory 구현
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
public class Factory_WestInsect : IFactory_Insect
{


    public IChest Create_Chest()
    {
        return new WestChest();
    }

    public IHead Create_Head()
    {
        return new WestHead();

    }
}



public class Insect
{
    IChest chest;
    IHead head;
    public void SetHead(IHead head)
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