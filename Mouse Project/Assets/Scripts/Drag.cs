using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    //variable for the game

    bool isBeingHeld;       //determine if object is being held

    // Update is called once per frame
    void Update()
    {
        if(isBeingHeld)
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            gameObject.transform.localPosition = new Vector2(mousePos.x,mousePos.y);
        }      
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            isBeingHeld = true;
            Debug.Log("click");
        }
    }
    
    void OnMouseUp()
    {
        isBeingHeld = false;
        //transform.position = Vector2.zero;
    }   
}
