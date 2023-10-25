using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;

    public Rigidbody2D rb;
    public Animator animator;
    AudioSource audiosrc;
    public bool isMoving = false;

    Vector2 Movement;

    void Start()
    {
        Time.timeScale = 1;
        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Input 
        Movement.x = Input.GetAxisRaw("Horizontal")*speed;
        Movement.y = Input.GetAxisRaw("Vertical")*speed;

        animator.SetFloat("Horizontal", Movement.x);
        animator.SetFloat("Vertical", Movement.y);
        animator.SetFloat("Speed", Movement.sqrMagnitude);

        if (rb.velocity.x != 0|| rb.velocity.y != 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }



        if (isMoving)
        {
            if (!audiosrc.isPlaying)
            {
                audiosrc.Play();
            }
        }
        else
        {
            audiosrc.Stop();
        }
    }

    void FixedUpdate()
    {

        //rb.MovePosition(rb.position + Movement * speed * Time.fixedDeltaTime);
        rb.velocity = new Vector2(Movement.y, rb.velocity.y);
        rb.velocity = new Vector2(Movement.x, rb.velocity.x);
    }
}

