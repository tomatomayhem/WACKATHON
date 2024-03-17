using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigJarScript : MonoBehaviour
{
    public Animator animator;
    private bool full = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("triggered collision");
        var jar = collision.GetComponent<TestJarScript>();
        if (jar != null && jar.tag == "Beans")
        {
            Debug.Log("collided w beans sjar");
            // check if right ingredient
            // trigger animation
            animator.SetTrigger("Fill");
            full = true;
        }

        if (full)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-10, transform.position.y, 0), 10f * Time.deltaTime);
        }
    }
}
