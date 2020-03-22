using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    public float speed = 500f;
    public float jump = 400f;
    private bool isGrounded;
    private Rigidbody2D rb;
    


    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        float xDisplacement = Input.GetAxis("Horizontal")* speed *Time.deltaTime;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.UpArrow) && (isGrounded == true)) 
        {
            rb.AddForce(new Vector2(0, jump));
            isGrounded = false;
            
        }

        if (transform.position.y <= -8f)
        {
            transform.position = new Vector3(5.4f, -1.5f, 0f);

            


        }

        

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
}
