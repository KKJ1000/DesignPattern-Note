using UnityEngine;

public class Example : MonoBehaviour
{
    void Start()
    {
        var playerGameObject = new GameObject("Player");
        var player = playerGameObject.AddComponent<Player>();

        var damageEnemyGameObject = new GameObject("DamageEnemy");
        var damageEnemy = damageEnemyGameObject.AddComponent<DamageEnemy>();
        damageEnemy.Initialize(new DamageAction(7));
        damageEnemy.SetPlayer(player);

        var healEnemyGameObject = new GameObject("HealEnemy");
        var healEnemy = healEnemyGameObject.AddComponent<HealEnemy>();
        healEnemy.Initialize(new HealAction(7));
        healEnemy.SetPlayer(player);

        damageEnemy.Attack();
        healEnemy.Attack();
    }
}
