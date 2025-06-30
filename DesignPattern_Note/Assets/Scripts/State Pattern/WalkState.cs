using UnityEngine;

public class WalkState : StateBase
{
    public override void Enter()
    {
        Debug.Log("Walk 상태 진입");
    }

    public override void Exit()
    {
        Debug.Log("Walk 상태 종료");
    }

    public override void UpdateState()
    {
        Debug.Log("Walk 상태 업데이트");
    }   
}
