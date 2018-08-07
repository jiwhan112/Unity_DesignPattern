using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Builder : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        //팩토리를 이용한 패턴
        ComputerFactory _ComputerFactory = new ComputerFactory();
        MacComputer mac = new MacComputer();
        LGComputer lg = new LGComputer();
        Computer com = new Computer();

        //Make Mac
        Computer o;
        _ComputerFactory.Make(mac);
         o =_ComputerFactory.Get();
        Debug.Log( o.ToString());

        // Make lgCom
        _ComputerFactory.Make(lg);
         o = _ComputerFactory.Get();
        Debug.Log(o.ToString());

        //Defalut
        _ComputerFactory.Make(com);
        o = _ComputerFactory.Get();
        Debug.Log(o.ToString());


        // 빌더를 이용한 패턴
        // 빌더를 계속 리턴해서 함수를 계속 불러와 도쿠먼트를 굳이 안찾아 넣어도 됨
        Computer com2 = ComputerBuilder.Start().SetCPU("i7").SetRAM("8g").SetVGA("1070GTX").Build();
        Debug.Log(com2.ToString()); 
    }
}
