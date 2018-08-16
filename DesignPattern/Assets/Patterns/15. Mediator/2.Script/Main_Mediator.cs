using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Mediator : MonoBehaviour {


    private void Start()
    {
        Mediator medi = new ChatMediator();
        Colleague col1 = new ChatColleague();
        Colleague col2 = new ChatColleague(); ;
        Colleague col3 = new ChatColleague(); ;
        Colleague col4 = new ChatColleague(); ;
        
        col1.Join(medi);
        col2.Join(medi);
        col3.Join(medi);
        col4.Join(medi);

        col1.SendData("111");
        col1.SendData("222");
        col1.SendData("333");
        col1.SendData("444");
    }

}
