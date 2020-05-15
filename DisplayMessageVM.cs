using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMessageVM : MonoBehaviour
{
    //[SerializeField] Canvas scientistMessageCanvas;
    public float time = 10;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, time);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
