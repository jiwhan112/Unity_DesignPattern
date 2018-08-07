using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IGameEvent
{
    void StartEvent();
    void DelEvent();
    void UpdateEvent();

}
public class GameEvent :IGameEvent
{
   public string EventName;
    public float DelayTime;
    public GameEvent(string EventName,float time)
    {
        this.EventName = EventName;
        DelayTime = time;
    }
    public virtual void DelEvent()
    {
        Debug.Log(EventName + " 이벤트종료");
    }

    public virtual void StartEvent()
    {
        Debug.Log(EventName + " 시작");

    }

    public virtual void UpdateEvent()
    {
        Debug.Log(EventName+ " 이벤트중");
    }

  
}

public class Aqua_Fishing :  GameEvent
{
    public Aqua_Fishing() : base("낚시", 5)
    {
    }
}
public class Aqua_Treasure : GameEvent
{
    public Aqua_Treasure() : base("보물상자", 5)
    {
    }
}

public class Aqua_Show : GameEvent
{
    public Aqua_Show() : base("아쿠아쇼", 5)
    {
    }
}
