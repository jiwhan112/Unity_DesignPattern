using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Flyweight : MonoBehaviour {

	// Use this for initialization
	void Start () {
        FlyweightFactory flyFactory = new FlyweightFactory();
        Flyweight flyweight = flyFactory.GetFlyweight("A");
        Debug.Log(flyweight.GetData());
        Flyweight flyweight2 = flyFactory.GetFlyweight("A"); // 같은데이터 값은 재사용 한다.
        Debug.Log(flyweight2.GetData());
        Flyweight flyweight3 = flyFactory.GetFlyweight("CC"); // 새로운 것만 생성
        Debug.Log(flyweight3.GetData());
    }
	

}
