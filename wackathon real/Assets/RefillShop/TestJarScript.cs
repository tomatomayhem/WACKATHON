using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestJarScript : MonoBehaviour
{
    public Vector3 start;
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        // do little animation
        
    }

    private void OnMouseDrag()
    {
        // drag food to jar?
        // make inside action follow mouse?
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Debug.Log("mouse: " + mousePosition.x.ToString() + ", " + mousePosition.y.ToString());
        transform.position = mousePosition;

    }

    private void OnMouseEnter()
    {
        // open lid + grow a little? highlight.
        
    }

    

    private void OnMouseUpAsButton()
    {
        transform.position = start;
    }
}
