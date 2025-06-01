using System.Runtime.CompilerServices;
using UnityEngine;

public interface IAction
{
    void Execute(Player player);
}

public class DamageAction : IAction
{
    private int m_damageAmount;

    public DamageAction(int damage)
    {
        m_damageAmount = damage;
    }

    public void Execute(Player player)
    {
        player.ApplyDamage(m_damageAmount);
    }
}

public class HealAction : IAction
{
    private int m_healAmount;

    public HealAction(int heal)
    {
        m_healAmount = heal;
    }

    public void Execute(Player player)
    {
        player.ApplyHeal(m_healAmount);
    }
}
