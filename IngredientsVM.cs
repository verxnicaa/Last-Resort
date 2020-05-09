using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientsVM : MonoBehaviour
{

    int scoreDecrease = 1;

    IngredientsScoreBoardVM ingredientsScoreBoard;

    // Start is called before the first frame update
    void Start()
    {
        ingredientsScoreBoard = FindObjectOfType<IngredientsScoreBoardVM>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 0) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ingredientsScoreBoard.Collected(scoreDecrease);
        }
    }
}
