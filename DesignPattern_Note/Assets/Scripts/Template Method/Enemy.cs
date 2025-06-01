using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected IAction m_action;
    private Player m_player;

    public abstract void Initialize(IAction action);

    public void Attack()
    {
        ApproachPlayer();
        PerformAction();
        Retreat();
    }

    protected virtual void ApproachPlayer()
    {
        Debug.Log("[Enemy] 적이 플레이어한테 접근합니다.");
    }

    protected virtual void PerformAction()
    {
        m_action.Execute(m_player);
    }

    protected virtual void Retreat()
    {
        Debug.Log("[Enemy] 적이 후퇴합니다.");
    }

    public void SetPlayer(Player player)
    {
        m_player = player;
    }
}

public class DamageEnemy : Enemy
{
    public override void Initialize(IAction action)
    {
        this.m_action = new DamageAction(7);
    }
}

public class HealEnemy : Enemy
{
    public override void Initialize(IAction action)
    {
        this.m_action = new HealAction(7);
    }
}
