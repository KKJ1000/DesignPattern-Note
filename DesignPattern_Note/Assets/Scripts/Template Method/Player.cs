using UnityEngine;

public class Player : MonoBehaviour
{
    private int m_life = 10;

    public void ApplyDamage(int damage)
    {
        m_life -= damage;
        Debug.Log($"[Player] 피해 : {damage}, 현재 체력 : {m_life}");
    }

    public void ApplyHeal(int heal)
    {
        m_life += heal;
        Debug.Log($"[Player] 회복 : {heal}, 현재 체력 : {m_life}");
    }
}
