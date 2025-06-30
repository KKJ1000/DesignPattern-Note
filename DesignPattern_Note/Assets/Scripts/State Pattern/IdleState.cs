using UnityEngine;

public class IdleState : StateBase
{
    public override void Enter()
    {
        Debug.Log("Idle 상태 진입");
    }

    public override void Exit()
    {
        Debug.Log("Idle 상태 종료");
    }

    public override void UpdateState()
    {
        Debug.Log("Idle 상태 업데이트");
    }
}
