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
        CurrentHealth = Mathf.Max(CurrentHealth - damage, 0); // �ǵ�: CurrentHealth�� 0������ �������� ���ϵ��� ����
        
        if (OnHealthChanged != null)
        {
            OnHealthChanged(CurrentHealth, MaxHealth);
        }
    }

    public void Heal(int amount)
    {
        CurrentHealth = Mathf.Min(CurrentHealth + amount, MaxHealth); // �ǵ�: CurrentHealth�� �ִ� ü�º��� ���� �ö��� ���ϵ��� ����
        
        if (OnHealthChanged != null)
        {
            OnHealthChanged(CurrentHealth, MaxHealth);
        }
    }
}
