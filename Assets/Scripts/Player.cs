using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float movementX;
    private float movementY;
    private float moveForce = 10f;
    private Animator anim;
    private SpriteRenderer sr;
    private string MOVING = "isMoving";
    private Rigidbody2D rb;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        playerMoveKeyboard();
        animatePlayer();
        wall();      
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        anim.SetBool("isDead", true);
        Destroy(gameObject, 0.3f);
        SceneManager.LoadScene("Dead");
        
    }
  


    public void playerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;

        movementY = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0f, movementY, 0f) * Time.deltaTime * moveForce;
    }

    public void animatePlayer()
    {

        if (movementX > 0 || movementY > 0)
        {
            anim.SetBool(MOVING, true);
            sr.flipX = false;
        }
        else if (movementX < 0 || movementY < 0)
        {
            anim.SetBool(MOVING, true);
            sr.flipX = true;
        }
        else
        {
            anim.SetBool(MOVING, false);
        }
    }

    public void wall()
    {
        if(transform.position.x >= 7.8)
        {
            transform.position = new Vector2((float)7.8, transform.position.y);
        }
        if (transform.position.x <= -7.8)
        {
            transform.position = new Vector2((float)-7.8, transform.position.y);
        }
        if (transform.position.y <= -3.8)
        {
            transform.position = new Vector2(transform.position.x, (float)-3.8);
        }
        if (transform.position.y >= 3.8)
        {
            transform.position = new Vector2(transform.position.x, (float)3.8);
        }
    }

}