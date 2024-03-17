using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenController : MonoBehaviour
{
    private bool introduction = false;
    private bool chopping = false;
    private bool frying = false;

    // Start is called before the first frame update
    void Start()
    {
        introduction = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void endIntroduction(){
        introduction = false;
        chopping = true;
    }

    public bool getChopping(){
        return chopping;
    }

    public bool getFrying(){
        return frying;
    }

    public void endChopping(){
        chopping = false;
        frying = true;
    }
}
