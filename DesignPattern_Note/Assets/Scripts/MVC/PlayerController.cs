using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerModel m_playerModel;
    private PlayerView m_playerView;

    private void Awake()
    {
        m_playerView = GetComponent<PlayerView>();
        m_playerModel = new PlayerModel(100);
        m_playerModel.OnHealthChanged += m_playerView.UpdateHealthBar;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            DamagePlayer();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            HealPlayer();
        }
    }

    private void DamagePlayer()
    {
        m_playerModel.TakeDamage(10);
    }

    private void HealPlayer()
    {
        m_playerModel.Heal(10);
    }

    private void OnDestroy()
    {
        if (m_playerModel != null)
        {
            m_playerModel.OnHealthChanged -= m_playerView.UpdateHealthBar;
        }
    }
}
