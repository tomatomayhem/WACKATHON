using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoppingController : MonoBehaviour
{

    public chop knifeScript;
    public KitchenController kitchenScript;

    private bool started = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(!started){
            if(kitchenScript.getChopping()){
                started = true;
                startChopping();
            }
        }
    }

    public void startChopping(){
        transform.position = new Vector3(0,0,0);
        knifeScript.beginChopping();
    }

    public void removeChopping(){
        transform.position = new Vector3(20,20,0);
    }
}
