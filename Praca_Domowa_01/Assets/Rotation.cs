using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    bool started;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move());
    }

    // Update is called once per frame
    public float speed;
    public bool left;
    
    void Update()
    {
        if ((left == true) && (started == true))
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);

        }
        else
        {
            transform.Rotate(Vector3.back * speed * Time.deltaTime);

        }
    }
    
    IEnumerator Move()
    {
        started = false;
        yield return new WaitForSeconds(0.9f);
        started = true;

    }
}
