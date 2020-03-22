using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMov : MonoBehaviour
{

    private Vector3 pos1;
    private Vector3 pos2;
    private Vector3 nexPos;

    public float speed = 10;

    public Transform childTransform;

    public Transform transform2;
    // Start is called before the first frame update
    void Start()
    {
        pos1 = childTransform.localPosition;
        pos2 = transform2.localPosition;
        nexPos = pos2;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {

        childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nexPos, speed * Time.deltaTime);
        if (childTransform.localPosition == pos2)
        {

            nexPos = pos1;
            childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nexPos, speed * Time.deltaTime);

        }
        if (childTransform.localPosition == pos1)
        {
            nexPos = pos2;
            childTransform.localPosition = Vector3.MoveTowards(childTransform.localPosition, nexPos, speed * Time.deltaTime);
        }
    }
   
   
}
