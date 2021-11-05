using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector2 oldPos;
    float lookDirection;
    private void Update()
    {
        if (oldPos == null)
        {
            oldPos = transform.position;
        }
        lookDirection = -Vector2.Angle(Vector2.up, oldPos);
        transform.eulerAngles = new Vector3(0, 0, lookDirection);

        oldPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            Destroy(gameObject);
        }
    }
}
