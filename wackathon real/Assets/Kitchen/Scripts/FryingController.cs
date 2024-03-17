using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FryingController : MonoBehaviour
{
    public KitchenController kitchenScript;

    private bool frying = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(!frying){
            frying = kitchenScript.getFrying();
            if(frying){
                transform.position = new Vector3(0,0,0);
            }
        }
    }

    public void endFrying(){
        transform.position = new Vector3(30,30,0);
    }
}
