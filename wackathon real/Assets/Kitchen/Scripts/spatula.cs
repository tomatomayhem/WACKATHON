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
            transform.position = new Vector3(mousePosition.x,1.5f,-1);
            if(transform.position.x <= -2.5f){
                transform.position = new Vector3(-2.5f,1.5f,-1);
            }
            else if(transform.position.x >= 0.5f){
                transform.position = new Vector3(0.5f,1.5f,-1);
            }
        }
    }

    void OnMouseDown(){
        followMouse = true;
        Debug.Log("click");
    }

    void OnMouseUp(){
        followMouse = false;
    }
}
