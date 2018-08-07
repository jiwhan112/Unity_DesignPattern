using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 게임의 플로우를 구현
/// 2. 일정시간이 지나도 이벤트 발생
/// 3. 이벤트시간 체크
/// 4. 이벤트 제거
/// 5. 이벤트 쿨타임
/// 6. 반복
/// </summary>
interface IEventCheckSystem // 일정한 프로세스를 가진 이벤트 시스템을 템플릿 메소드 패턴으로 구현 한 것 
{
    void StartEvent(GameEvent _event);
    void EventUpdate(GameEvent _event);
    void DelEvent(GameEvent _event);
}
class ITemplate_EventSystem : MonoBehaviour, IEventCheckSystem
{
    int index; //현재 이벤트 순서
    int MAXindex;
    float fTimer;// 현재 경과 시간
    
    bool bDuringEvent; // 이벤트 판단
    bool bDelEvent; // 이벤트 판단
    GameEvent currentEvent; //현재 이벤트

    public void SetGameEvent(GameEvent _event) // 이벤트 알고리즘을 바꿔 끼움 전략패턴 사용
    {
        currentEvent = _event;
    }

    public void Enter()
    {
        fTimer = 0;
        bDuringEvent = false;
        bDelEvent = false;
        currentEvent = null;
        Debug.Log("초기화");
    }
   
    public void RunEvent(GameEvent[] _event) //이벤트 실행
    {
      
        if (currentEvent == null && bDuringEvent == false)
        {
            index = 0;
            MAXindex = _event.Length-1;
            SetGameEvent(_event[index]);
            Debug.Log("초기화2");
        }
        fTimer += Time.deltaTime;
        
        if (bDuringEvent == false)
        {
            bDuringEvent = true;
            StartEvent(currentEvent); //이벤트 실행
        }
        EventUpdate(currentEvent); //이벤트 업데이트

        if (bDelEvent == true)
        {
            DelEvent(currentEvent); //이벤트 삭제
            bDelEvent = false;
            bDuringEvent = false;
            index++;
            if (MAXindex < index) index = 0;
            SetGameEvent(_event[index]);
        }
    }

    public void StartEvent(GameEvent _event)
    {
        _event.StartEvent();
    }


    public void DelEvent(GameEvent _event)
    {
        _event.DelEvent();
    }

    public void EventUpdate(GameEvent _event)
    {
       
        _event.UpdateEvent();
        if (fTimer > _event.DelayTime)
        {
            bDelEvent = true;
            fTimer = 0;
        }
        // 중간에 이벤트를 끝내버리는 기능이 들어옴
        // 해당 구현
    }
}



