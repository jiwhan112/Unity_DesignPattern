using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// main
public class Main_AbstractFactory : MonoBehaviour
{

    private void Start() //main
    {
       // IFactory_Insect factory = new Factory_EastInsect();
        IFactory_Insect factory = new Factory_WestInsect();

        IHead head = factory.Create_Head();
        IChest chest = factory.Create_Chest();
        head.See();
    }


}
