using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Observer : MonoBehaviour {


    private void Start()
    {
        MyButton b = new MyButton();
        b.OnClick();
        MyButton listener = new ButtonClick();
        b.SetClickListener(listener);
        b.OnClick();
    }

}
