﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientsScoreBoardVM : MonoBehaviour
{
    [SerializeField] int ingredientsRemaining = 5;
    public Text ingredientsRemainingText;
    int scoreDecrease = 1;

    private PlayerScriptVM playerScript;

    // Start is called before the first frame update
    void Start()
    {
        ingredientsRemainingText = GetComponent<Text>();
        ingredientsRemainingText.text = ingredientsRemaining.ToString();

        playerScript = GameObject.FindObjectOfType<PlayerScriptVM>();
    }

    public void Collected(int scoreDecrease)
    {
        ingredientsRemaining = ingredientsRemaining - 1;
        ingredientsRemainingText.text = ingredientsRemaining.ToString();

        playerScript.UpdateChecklist(ingredientsRemaining);
    }
}
