using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Proxy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ISubjectByProxy real = new RealSubject();
        ISubjectByProxy proxy1 = new Proxy(real);
        ISubjectByProxy proxy2 = new Proxy(real);

        proxy1.Action1(); // 간단한
        proxy2.Action1();
        proxy1.Action2(); // 실제
        proxy2.Action2();


    }    
}
