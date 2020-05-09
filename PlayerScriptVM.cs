using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScriptVM : MonoBehaviour
{
    public Text announcement;

    int allIngredientsCollected = 1;
    int allEnemiesDefeated = 1;

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Stairs"))
        {
            if (allIngredientsCollected == 0)
            {
                ResetText();
                SceneManager.LoadScene("Level 3 Victory");

            }
            if (allIngredientsCollected != 0)
            {
                announcement.text = "COLLECT ALL SPECIAL INGREDIENTS AND KILL ALL ZOMBIES TO CONTINUE";
                Invoke("ResetText", 5f);
            }

        }
    }

    void ResetText()
    {
        announcement.text = "";
    }

    public void UpdateChecklist(int ingredientsRemaining)
    {
        if (ingredientsRemaining == 0)
        {
            allIngredientsCollected = ingredientsRemaining;
        }
    }

    public void UpdateChecklistFinal(int enemiesRemaining)
    {
        if (enemiesRemaining == 0)
        {
            allEnemiesDefeated = enemiesRemaining;
        }
    }
}
