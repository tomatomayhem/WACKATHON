using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spatula : MonoBehaviour
{
    public FryingController fryingScript;
    public GameObject rightBound;
    public GameObject leftBound;
    public GameObject interactionObjects;

    private bool followMouse = false;
    private int stirs = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(stirs == 5){
            fryingScript.endFrying();
            interactionObjects.transform.position = new Vector3(0,0,0);
            Destroy(gameObject);
        }
        if(followMouse){
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x,0,-2);
            if(transform.position.x <= -5){
                transform.position = new Vector3(-5,-0,-2);
            }
            else if(transform.position.x >= -2.5f){
                transform.position = new Vector3(-2.5f,0,-2);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        stirs++;
    }

    void OnMouseDown(){
        followMouse = true;
        Debug.Log("click");
    }

    void OnMouseUp(){
        followMouse = false;
    }
}
