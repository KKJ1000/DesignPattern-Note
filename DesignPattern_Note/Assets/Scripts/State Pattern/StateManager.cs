using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateManager : MonoBehaviour
{
    [SerializeField] EState currentState;
    [SerializeField] StateBase[] stateBases;

    Dictionary<EState, StateBase> stateDictionary;

    public void TransitionTo(EState nextState)
    {
        if (currentState == nextState) return;

        stateDictionary[currentState].Exit();
        currentState = nextState;
        stateDictionary[nextState].Enter();
    }

    private void Awake()
    {
        stateDictionary = new();
        foreach (StateBase stateBase in stateBases)
        {
            stateDictionary.TryAdd(stateBase.eState, stateBase);
        }
        stateDictionary[currentState].Enter();
    }

    private void Update()
    {
        stateDictionary[currentState].UpdateState();
    }
}
