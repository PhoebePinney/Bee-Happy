using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 3f;
    public float rotateSpeed = 5f;

    Vector3 newPosition;
    bool isMoving = false;

    void Start()
    {
        PositionChange();
    }

    void PositionChange()
    {
        newPosition = new Vector2(Random.Range(-12.0f, 12.0f), Random.Range(-15.0f, 15.0f));
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, newPosition) < 1)
            PositionChange();

        if (LookAt2D(newPosition))
            transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * speed);
    }

    bool LookAt2D(Vector3 lookAtPosition)
    {
        float distanceX = lookAtPosition.x - transform.position.x;
        float distanceY = lookAtPosition.y - transform.position.y;
        float angle = (Mathf.Atan2(distanceX, distanceY) * Mathf.Rad2Deg) + 270;

        Quaternion endRotation = Quaternion.AngleAxis(angle, Vector3.back);
        transform.rotation = Quaternion.Slerp(transform.rotation, endRotation, Time.deltaTime * rotateSpeed);

        if (Quaternion.Angle(transform.rotation, endRotation) < 1f)
            return true;

        return false;
    }
}