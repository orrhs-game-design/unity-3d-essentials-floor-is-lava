using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallReloader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("floor"))
        {
            Debug.Log("You lose");
            SceneManager.LoadScene(0);
        }
        else if (collision.gameObject.CompareTag("goal"))
        {
            Debug.Log("You Win");
        }
    }
}
