using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnClick : MonoBehaviour
{
    //variables for this game
   public float speed = 1f;

   Vector2 lastMousePos;

   bool moving;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            lastMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            moving = true;
        }

        if (moving && (Vector2)transform.position != lastMousePos)
        {
            float step = speed * Time.deltaTime;

            transform.position = Vector2.MoveTowards(transform.position, lastMousePos, step);

        }

        else
        {
            moving = false;
        }
    }
}
