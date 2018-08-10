using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Observer : MonoBehaviour {


    private void Start()
    {
        
        Subject s = new Subject();
        Oberver o1 = new Oberver();
        Oberver o2 = new Oberver();
        Oberver2 o3 = new Oberver2(10, 100);
        // 추가 삭제 마다 신호를 주게 만듬
        s.Add(o1);
        s.Add(o2);
        s.Remove(o1);
        s.Add(o3);

    }

}
