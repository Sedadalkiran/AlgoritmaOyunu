using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    float distance = 10f;

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector2 nesnePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector3(nesnePosition.x, nesnePosition.y, 0);
    }
}
