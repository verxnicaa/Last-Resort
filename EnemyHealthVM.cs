using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthVM : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    bool isDead = false;

    int scoreDecrease = 1;
    EnemyScoreBoardVM enemyScoreBoard;

    private void Start()
    {
        enemyScoreBoard = FindObjectOfType<EnemyScoreBoardVM>();
    }

    public bool IsDead()
    {
        return isDead;
    }

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            Die();
            enemyScoreBoard.ScoreHit(scoreDecrease);
        }
    }

    private void Die()
    {
        if (isDead) return;
        isDead = true;
        GetComponent<Animator>().SetTrigger("die");
        Destroy(gameObject.GetComponent<CapsuleCollider>());
    }
}
