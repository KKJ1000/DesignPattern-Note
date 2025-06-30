using UnityEngine;

public abstract class StateBase : MonoBehaviour
{
    public EState eState;

    public abstract void Enter();
    public abstract void UpdateState();
    public abstract void Exit();
}
