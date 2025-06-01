using UnityEngine;
using UnityEngine.UI;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private Slider m_healthBar;

    public void UpdateHealthBar(int current, int max)
    {
        if (m_healthBar != null)
        {
            m_healthBar.value = (float)current / max;
        }
    }
}
