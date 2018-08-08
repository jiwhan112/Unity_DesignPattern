using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Chain : MonoBehaviour {

    private void Start()
    {
        ICalculator plus = new PlusCalculator();
        ICalculator sub = new SubCalculator();
        ICalculator muti = new MutiCalculator();
        ICalculator dis = new DisCalculator();
        plus.AddProcess(sub);
        sub.AddProcess(muti);
        muti.AddProcess(dis);
        Request re1 = new Request(1, 1, "+");
        Request re2 = new Request(1, 1, "/");
        Request re3 = new Request(2, 2, "*");
        Request re4 = new Request(2, 2, "-");
        Request re5 = new Request(2, 2, "5");

        plus.Process(re1);
        plus.Process(re2);
        plus.Process(re3);
        plus.Process(re4);
        plus.Process(re5);

    }
}
