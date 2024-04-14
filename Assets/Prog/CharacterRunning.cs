using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRunning : MonoBehaviour
{

    // private float horizontal;
    // private float speed = 8f;
    // private bool isFacingRight = true;

    //[SerializeField] private Rigidbody2D rb;
    //[SerializeField] private Transform groundCheck;
    //[SerializeField] private LayerMask groundLayer;

    // Update is called once per frame
    // void Update()
    // {
    // horizontal = Input.GetAxisRaw("HorizontalRun");
    // Flip();
    //}

    //private void FixedUpdate()
    //{
    // rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    //}

    //private void Flip()
    //{
    //  if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
    //{
    //isFacingRight = !isFacingRight;
    //Vector3 localScale = transform.localScale;
    //localScale.x *= -1f;
    //transform.localScale = localScale;
    //}
    //}

    public float Speed;
    private Rigidbody2D rig;



    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Correr();
    }

    void Correr()
    {
        Vector3 movement = new Vector3(Input.GetAxis("HorizontalRun"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;
    }

   

}
