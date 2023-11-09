using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    private Vector3 startPosition;
    public float top = 3.0f;
    public float bottom = 1.5f;

    bool up = true;
    // Use this for initialization
    void Start()
    {
        //maxSpeed = 3;
        startPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        MoveVertical();
    }
    void MoveVertical()
    {
        var temp = transform.position;
        print(up);
        if (up == true)
        {
            temp.y += 0.01f;
            transform.position = temp;
            if (transform.position.y >= top)
            {
                up = false;
            }
        }
        if (up == false)
        {
            temp.y -= 0.01f;
            transform.position = temp;
            if (transform.position.y <= bottom)
            {
                up = true;
            }
        }
    }
}