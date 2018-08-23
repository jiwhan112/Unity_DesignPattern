using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StateController : Singleton<StateController>
{
    [SerializeField]
    private List<StateMachine> stateList;
    private Dictionary<string, StateMachine> stateDictionary;

    [SerializeField]
    private string currentStateName;
    [SerializeField]
    private string beforeStateName;

    public string CurrentStateName { get { return currentStateName; } }

    private StateMachine currentState;

    void Start()
    {
        stateDictionary = new Dictionary<string, StateMachine>();

        for (int i = 0; i < stateList.Count; i++)
        {
            stateList[i].Controller = this;
            stateDictionary.Add(stateList[i].GetType().Name, stateList[i]);
        }

        if (stateList.Count > 0)
        {
            currentState = stateList[0];
            currentStateName = currentState.GetType().Name;
            currentState.Init();
        }
    }

    void Update()
    {
        if (currentState != null) currentState.Execute();
    }

    public void ChangeState(string name, params object[] datas)
    {
        beforeStateName = currentStateName;
        if (currentState != null) currentState.Exit();
        currentState = stateDictionary[name];
        currentState.Init(datas);

        currentStateName = currentState.GetType().Name;
    }

    public void ChangeBeforeState(params object[] datas)
    {
        if (currentState != null) currentState.Exit();
        currentState = stateDictionary[beforeStateName];
        currentState.Init(datas);

        currentStateName = currentState.GetType().Name;
    }
}


