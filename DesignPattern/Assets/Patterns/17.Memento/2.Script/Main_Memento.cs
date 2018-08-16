using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Memento : MonoBehaviour {
    


	void Start () {

        Monster m = new Monster();
        m.Monster_("aa").Monster_(1.0f, 2.0f, 1.0f);
        Debug.Log(m.ReturnDamage());

        Memento NoBuf = m.CreateMemento(); // 버프가 걸리기전 세이브
        m.BufUp(50); // 버프가 걸림
        Debug.Log(m.ReturnDamage());
        m.SetMemento(NoBuf); // 다시 되돌림
        Debug.Log(m.ReturnDamage());

    }

}
