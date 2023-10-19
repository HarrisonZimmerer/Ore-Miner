using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed =8f;
    public bool canMove = true;
    public static float bottomY = -5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
        }
        if (canMove)
        {
            moveBall();
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                dropBall();
            }
        }
       
    }
    void moveBall()
    {
        float hAxis = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        //if(pos.x < leftBound)
        pos.x += hAxis * speed * Time.deltaTime;
    }
    void dropBall()
    {
        canMove = false;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.isKinematic = false;

    }
}
