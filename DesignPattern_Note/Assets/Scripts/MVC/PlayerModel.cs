using System;
using UnityEngine;

public class PlayerModel
{
    public int MaxHealth { get; private set; }
    public int CurrentHealth { get; private set; }

    public event Action<int, int> OnHealthChanged;

    public PlayerModel(int maxHealth)
    {
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth = Mathf.Max(CurrentHealth - damage, 0); // 의도: CurrentHealth가 0밑으로 내려가지 못하도록 제한
        
        if (OnHealthChanged != null)
        {
            OnHealthChanged(CurrentHealth, MaxHealth);
        }
    }

    public void Heal(int amount)
    {
        CurrentHealth = Mathf.Min(CurrentHealth + amount, MaxHealth); // 의도: CurrentHealth가 최대 체력보다 위로 올라가지 못하도록 제한
        
        if (OnHealthChanged != null)
        {
            OnHealthChanged(CurrentHealth, MaxHealth);
        }
    }
}
