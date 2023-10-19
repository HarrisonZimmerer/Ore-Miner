using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var Gold = GameObject.FindGameObjectsWithTag("Gold");
        if (Gold.Length == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
