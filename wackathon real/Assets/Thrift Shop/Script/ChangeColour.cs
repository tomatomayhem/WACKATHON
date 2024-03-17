using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeColourRed()
    {
        Debug.Log("changing to red!");
        anim.SetTrigger("ChangeToRed");
    }
    public void ChangeColourGreen()
    {
        anim.SetTrigger("ChangeToGreen");
    }
    public void ChangeColourBlue()
    {
        anim.SetTrigger("ChangeToBlue");
    }
    public void ChangeColourPink()
    {
        anim.SetTrigger("ChangeToPink");
    }
    public void ChangeColourPurple()
    {
        anim.SetTrigger("ChangeToPurple");
    }
}
