using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TradButtonModel;
using InvertedButtonModel;

public class Main_Solid : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        // OCP 부분
        Beverage c = new Coffee(1);
        Beverage w = new Water(2);

        Debug.Log(c.ToString());
        Debug.Log(w.ToString());

        //LSP부분 
        Entity ch = new Charactor();
        Entity m = new MyMonster();

        ch.Attack();
        m.Attack();

        //ISP부분
        Dog dog = new Dog();
        Bird bird = new Bird();
        dog.CRY();
        bird.CRY();
        bird.FLY();

        //DIP부분
        LAMP lamp = new LAMP();
        Button_Trad Button1 = new Button_Trad(lamp);
        Button1.Switch();

        IButtonClient iLamp = new Lamp();
        Button_Inver Button2 = new RoBotButton(iLamp);
        Button2.Switch();
        Button2.SetState(true);
        Button2.Switch();
    }


}
