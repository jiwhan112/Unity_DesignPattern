using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mian_Visitor : MonoBehaviour {

	// Use this for initialization
	void Start () {
        List<IVisitable> visitable = new List<IVisitable>();
        visitable.Add(new VisitorableA(1,20));
        visitable.Add(new VisitorableA(3,20));
        visitable.Add(new VisitorableA(20,80));

        VisitorA visitorA = new VisitorA(); // 나이를 더해주는 방문자
        for (int i = 0; i < visitable.Count; i++)
        {
            visitable[i].Appect(visitorA); //
        }
        Debug.Log("AGE :" + visitorA.ageSum);

        // 경험치를 더해주는 방문자
        VisitorB visitorB = new VisitorB(); // 나이를 더해주는 방문자
        for (int i = 0; i < visitable.Count; i++)
        {
            visitable[i].Appect(visitorB); //
        }
        Debug.Log("EXP :"+ visitorB.totalEXP);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
