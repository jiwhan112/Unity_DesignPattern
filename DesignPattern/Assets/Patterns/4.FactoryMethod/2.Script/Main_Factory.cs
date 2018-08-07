using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Factory : MonoBehaviour {

    private void Start()
    {
        Fatctory_HpCreate cr_Hp = new Fatctory_HpCreate();
        Fatctory_MpCreate cr_Mp = new Fatctory_MpCreate();

        Item it;
        it = cr_Hp.Create();
        it.Use();
        it = cr_Mp.Create();
        it.Use();
    }
}
