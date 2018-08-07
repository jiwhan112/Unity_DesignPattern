using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_composite : MonoBehaviour {

    Folder
        Root = new Folder("Root"),
        Music = new Folder("Music"),
        Picture = new Folder("Picture");
    File
        track1 = new File("track1"),
        java = new File("java"),
        pic1 = new File("pic1"),
        pic2 = new File("pic2");

    private void Start() 
    {
        Root.AddComponent(Music);
        Root.AddComponent(Picture);
        Music.AddComponent(track1);
        Music.AddComponent(java);
        Picture.AddComponent(pic1);
        Picture.AddComponent(pic2);

        Show(Root);
    }


    static void Show(Component com) // 탐색
    {
        Debug.Log(com.GetName() + "/");
        if (com is Folder)
            for (int i = 0; i < ((Folder)com).GetChildren().Count; i++)
            {
                Show(((Folder)com).GetChildren()[i]);
            }
    }
}
