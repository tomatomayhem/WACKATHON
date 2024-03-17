using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introductionScript : MonoBehaviour
{
    public KitchenController kitchenScript;
    public GameObject interactionObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void endIntroduction(){
        kitchenScript.endIntroduction();
        interactionObjects.transform.position = new Vector3(50,50,0);
        Destroy(gameObject);
    }
}
