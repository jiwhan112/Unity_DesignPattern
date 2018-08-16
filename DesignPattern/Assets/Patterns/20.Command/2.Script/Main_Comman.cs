using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Comman : MonoBehaviour {

	// Use this for initialization
	void Start () {
        List<ICommand> list = new List<ICommand>();
        list.Add(new StringPrintCommand("111"));
        list.Add(new StringPrintCommand("2222"));
        list.Add(new StringPrintCommand("33333"));
        list.Add(new StringPrintCommand("44"));

        list.Sort();
        foreach (var item in list)
        {
            item.Excute();

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
