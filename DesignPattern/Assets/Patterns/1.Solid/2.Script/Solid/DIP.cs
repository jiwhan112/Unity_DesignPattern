using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// DIP 의존성 역전의 원칙
// 디자인에서 발생하던 하위레벨 모듈의 변경이 상위레벨 모듈의 변경을 요구하는 위계관를 끊는 의미의 역전
// 실제 사용관계는 바뀌지 않으며, 추상을 매개로 메시지를 주고 받음으로써 관계를 느슨하게 만듬

namespace TradButtonModel
    // 의존성이 강한 모델
{
    class LAMP
    {
        public void TurnOn()
        {
            Debug.Log("켜");
        }
        public void TurnOff()
        {
            Debug.Log("끔");
        }
    }
    class Button_Trad
    {
        LAMP lamp;
        bool bCurSwitch;
        public Button_Trad(LAMP l )
        {
            lamp = l;
            bCurSwitch = false;
        }
        public void Switch()
        {
            bCurSwitch = !bCurSwitch;
            if(bCurSwitch)
            {
                lamp.TurnOn();
            }
            else
            {
                lamp.TurnOff();
            }
        }
    }
}

namespace InvertedButtonModel
{
    //수정 모델
    public interface IButtonClient
    {
        void TurnOn();
        void TurnOff();
    }

    class Lamp : IButtonClient
    {
        public void TurnOff()
        {
            Debug.Log("끔");
        }

        public void TurnOn()
        {
            Debug.Log("켬");
        }
    }


    public abstract class Button_Inver
    {
        IButtonClient butClient;
        protected bool bol;
        protected Button_Inver(IButtonClient butClient)
        {
            this.butClient = butClient;
            bol = false;
        }
        public void Switch() // 불을 켜는 것을 처리하는 공통기능
        {
            if (bol)
                butClient.TurnOn();
            else
                butClient.TurnOff();
        }
        //결정기능 파생 클래스의 상태를 조사해서 결정된다.
        public abstract void SetState(bool set);
    }

    public class RoBotButton : Button_Inver
    {
        public RoBotButton(IButtonClient butClient) : base(butClient)
        {
        }

        public override void SetState(bool set)
        {
            bol = set;
        }
    }
}







