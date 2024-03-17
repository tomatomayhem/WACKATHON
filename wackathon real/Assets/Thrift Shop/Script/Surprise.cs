using UnityEngine;
using System.Collections;

public class Surprise : MonoBehaviour{
    Animator anim;

    void Start ()
    {
        anim = GetComponent<Animator>();
    
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space)) anim.SetTrigger("click");
    }
    public void changeExpression()
    {
        anim.SetTrigger("click");
    }
}