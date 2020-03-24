using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
       
    rb = Player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        
        
        rb.AddForce(new Vector2(0, 600f));
        
    }

}
