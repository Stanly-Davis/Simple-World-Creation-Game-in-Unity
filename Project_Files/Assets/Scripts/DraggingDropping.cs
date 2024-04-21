using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggingDropping : MonoBehaviour
{

    public Vector3 mouse;
    public Vector3 mousePosition;


    private void OnMouseDown()
    {

        mouse = Camera.main.WorldToScreenPoint(transform.position);

        mousePosition = Input.mousePosition - mouse;

        // Debug.Log("MouseDown");
    }


    private void OnMouseDrag() 
    {

        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);

        // Debug.Log("MouseDrag");

        
    }

}
