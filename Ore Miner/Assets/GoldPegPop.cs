using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPegPop : MonoBehaviour
{
    public ScoreCounter scoreCounter;
    public dynamic int points = 0;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        ScoreCounter.points += 20;
        Debug.Log("Popped. Total Points: " + points);
        gameObject.SetActive(false);
    }

    void Start()
    {
        GameObject scoreGo = GameObject.Find("ScoreCounter");
        scoreCounter = scoreGO.GetComponent<ScoreCounter>();
    }
}

