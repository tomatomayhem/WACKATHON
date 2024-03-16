using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choppingAnimation : MonoBehaviour
{
    Animator animator;
    private int numChops = 0;
    private bool knifeCollision = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(knifeCollision);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        knifeCollision = true;
    }

    private void OnTriggerExit2D(Collider2D collsion){
        knifeCollision = false;
    }

    private void OnMouseDown()
    {
        Debug.Log("click");
        if(knifeCollision){
            numChops ++;
            if(numChops % 2 == 0){
                if(!animator.GetBool("slicing")){
                    animator.SetBool("slicing",true);
                }
                else{
                    animator.SetBool("dicing",true);
                }
            }
        }
    }
}
