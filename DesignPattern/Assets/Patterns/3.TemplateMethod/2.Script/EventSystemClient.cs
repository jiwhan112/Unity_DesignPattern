using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystemClient : MonoBehaviour {

    ITemplate_EventSystem eventSystem;
    GameEvent[] gameArray;
    
    private void Start()
    {
        eventSystem = new ITemplate_EventSystem();
        gameArray = new GameEvent[3];
        gameArray[0] = new Aqua_Fishing();
        gameArray[1] = new Aqua_Treasure();
        gameArray[2] = new Aqua_Show();
        eventSystem.Enter();
    }
    private void Update()
    {
        eventSystem.RunEvent(gameArray);
    }
}
