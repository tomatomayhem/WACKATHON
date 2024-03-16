using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spatula : MonoBehaviour
{
    private bool followMouse = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(followMouse){
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePosition;
        }
    }

    void OnMouseDown(){
        followMouse = true;
    }

    void OnMouseUp(){
        followMouse = false;
    }
}
