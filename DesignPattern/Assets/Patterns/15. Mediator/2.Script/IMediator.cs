using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 중재자 패턴
 * 중재할 데이터를 걸러서 중재해줌
 * 채팅에서 귓말 같은 특정인에게 보내는 정보를 걸러서 보내주는 행위등
 * 
 */
public abstract class Mediator
{
    protected List<Colleague> ListColleague; // Colleague를 저장할 리스트

    public Mediator() // 초기화
    {
        ListColleague = new List<Colleague>();
    }

    public bool AddColleague(Colleague colleague) // 중재자에 추가
    {
        if (colleague == null) return false;
        ListColleague.Add(colleague);
        return true;
    }

    public abstract void Mediate(string data); // 중재 행위 추상화
  

}
public abstract class Colleague
{
    Mediator mediator;

    public bool Join(Mediator medi) // mediator에 해당 colleague 정보를 알려줌
    {        
        if (medi == null) return false;

        Debug.Log("Join:" + this);
        this.mediator = medi;
        return mediator.AddColleague(this);
    }
    public bool SendData(string data) // 어떤일이 발생함 // 현재는 데이터를 보내는 것
    {
        if (mediator == null) return false;
        mediator.Mediate(data); // 해당 중재자에 데이터 재전송
        return true;
    }

    abstract public void Handle(string data); // 중재 행위 추상화
}


public class ChatMediator : Mediator
{
    public override void Mediate(string data)
    {
        for (int i = 0; i < ListColleague.Count; i++)
        {
            // 중재 가능성 
            // 귓말 / 확성기 같은 것
            ListColleague[i].Handle(data); //현재는 모든사람에게 데이터를 돌려보냄
        }
    }
}

public class ChatColleague : Colleague
{
    public override void Handle(string data)
    {
        Debug.Log(data);
    }
}
