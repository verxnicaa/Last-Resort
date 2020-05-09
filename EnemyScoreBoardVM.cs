using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScoreBoardVM : MonoBehaviour
{
    [SerializeField] int enemiesRemaining = 10;
    public Text enemiesRemainingText;
    int scoreDecrease = 1;

    private PlayerScriptVM playerScript;

    // Start is called before the first frame update
    void Start()
    {
        enemiesRemainingText = GetComponent<Text>();
        enemiesRemainingText.text = enemiesRemaining.ToString();

        playerScript = GameObject.FindObjectOfType<PlayerScriptVM>();
    }

    public void ScoreHit(int scoreDecrease)
    {
        enemiesRemaining = enemiesRemaining - 1;
        enemiesRemainingText.text = enemiesRemaining.ToString();

        playerScript.UpdateChecklistFinal(enemiesRemaining);
    }
}
