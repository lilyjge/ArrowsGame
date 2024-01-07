using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 10;
    public int randHolder;

    public Rigidbody2D myBody;
    private ArrowSpawner instance;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        switch(randHolder)
        {
            case 0:
                myBody.velocity = new Vector2(myBody.velocity.x, speed);
                break;
            case 3:
                myBody.velocity = new Vector2(myBody.velocity.x, -speed);
                break;
            case 1:
                myBody.velocity = new Vector2(-speed, myBody.velocity.y);
                break;
            case 2:
                myBody.velocity = new Vector2(speed, myBody.velocity.y);
                break;
        }
        
       
    }
}
