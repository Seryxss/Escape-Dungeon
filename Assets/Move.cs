using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public bool isBeingHeld = false;
    void Update()
    {

        if (isBeingHeld == true)
        {
            Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = objPosition;


        }
    }

    private void OnMouseDown()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = objPosition;
        isBeingHeld = true;
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }
}