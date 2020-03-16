using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChildPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Transform childTransform;
    public Transform obrazek;
    public Transform player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider)
        {

            collision.collider.transform.SetParent(childTransform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        collision.collider.transform.SetParent(null);

    }
}
