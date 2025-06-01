using UnityEngine;

public class Player : MonoBehaviour
{
    private int m_life = 10;

    public void ApplyDamage(int damage)
    {
        m_life -= damage;
        Debug.Log($"[Player] ���� : {damage}, ���� ü�� : {m_life}");
    }

    public void ApplyHeal(int heal)
    {
        m_life += heal;
        Debug.Log($"[Player] ȸ�� : {heal}, ���� ü�� : {m_life}");
    }
}
