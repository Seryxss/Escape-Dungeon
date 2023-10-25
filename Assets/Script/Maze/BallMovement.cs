using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 movedirection;
    [SerializeField] private GameObject code;

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        movedirection = new Vector2(moveX, moveY).normalized;

    }

    void Move()
    {
        rb.velocity = new Vector2(movedirection.x * moveSpeed, movedirection.y * moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        code.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
