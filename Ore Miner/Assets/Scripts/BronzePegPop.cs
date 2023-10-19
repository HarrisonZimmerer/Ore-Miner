using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BronzePegPop : MonoBehaviour
{
    public ScoreCounter sC;
    private void Start()
    {
        GameObject scoreGo = GameObject.Find("ScoreCounter");
        sC = scoreGo.GetComponent<ScoreCounter>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collidedWith = collision.gameObject;
        if (collidedWith.CompareTag("Ball"))
        {
            Destroy(gameObject);
            sC.points += 10;
            HighScore.Set_HighScore(sC.points);
        }
    }
}
