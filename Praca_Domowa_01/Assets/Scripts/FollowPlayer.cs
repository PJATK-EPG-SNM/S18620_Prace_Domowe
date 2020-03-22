using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    public Vector3 offset = new Vector3(0, 0,-10);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = Player.transform.position + offset;


    }
}
