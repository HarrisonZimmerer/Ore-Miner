using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPegPop : MonoBehaviour
{
    public static int points = 0;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other)
    {
        points += 20;
        Debug.Log("Popped. Total Points: " + points);
        gameObject.SetActive(false);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
