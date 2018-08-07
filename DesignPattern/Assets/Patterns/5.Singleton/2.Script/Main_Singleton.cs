using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Singleton : MonoBehaviour {

	
	void Start () {
        MySingleton Data1 = MySingleton.GetInstance();
        MySingleton Data2 = MySingleton.GetInstance();
        Data1.PlusData();
        Data1.PlusData();
        Data1.PlusData();
        Data1.PlusData();
        Data1.PlusData();
        Data1.PlusData();
        Debug.Log(Data2.Data); 
    }
    
}
