using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 요구사항
 * 게임 아이템과 아이템생성구현
 * 데이터베이스에 정보요청
 * 생성후 남용을 위한 로그 생성
 * 물약을 예시로 구현
 */

interface IFatoryMethod_ITEM
{
    Item Create(); // 템플릿
    
    //구현함수
    void Request();
    void CreateProduction(); //생성전 연출을 추가해도 됨
    void SetLog(Item it);
    Item CreateMethod();

}

public class Factory_Item : IFatoryMethod_ITEM
{
    public Item Create()
    {
        
        Request();
        CreateProduction();
        Item it = CreateMethod();
        SetLog(it);
        return it;
    }

    virtual public void Request()//요청
    {
        Debug.Log("요청");
    }

    virtual public void SetLog(Item it)//로그
    {
        Debug.Log("Log:" + it.Name +" // "+ it.GetHashCode());

    }
   virtual public  void CreateProduction()
    {
        Debug.Log("생성전 연출");
    }
    // 아이템 생성 알고리즘
    virtual public Item CreateMethod()
    {
        return null;
    }
   

}

public class Fatctory_HpCreate : Factory_Item
{
    public override Item CreateMethod()
    {
        return new HPItem();
    }

    public override void Request()
    {
        base.Request();
    }

    public override void SetLog(Item it)
    {
        base.SetLog(it);
    }
}
public class Fatctory_MpCreate : Factory_Item
{
    public override Item CreateMethod()
    {
        return new MPItem();
    }

    public override void Request()
    {
        base.Request();
    }

    public override void SetLog(Item it)
    {
        base.SetLog(it);
    }
}