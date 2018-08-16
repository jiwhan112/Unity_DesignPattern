using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_State : MonoBehaviour {

    // Use this for initialization
    Light newLight;
    
    void Start()
    {
        newLight = new Light();
        newLight.SetStateOn();
        StartCoroutine(SetOffFewMin());
    }
	
	// Update is called once per frame
	void Update () {
        newLight.Update();

    }
    IEnumerator SetOffFewMin()
    {
        yield return new WaitForSeconds(3.0f);
        newLight.SetStateOff();
    }
}
