using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chop : MonoBehaviour
{
    public Ingredients ingredientScript;
    public GameObject startPos;
    public GameObject targetPos;

    private Animator currentAnimator;
    private int numIngredients;
    private int count = 0;
    private float speed = 5f;
    private bool chopping = false;
    private int numChops = 0;
    private bool vegCollision = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPos.transform.position;
        ingredientScript.generateVeg(count);
        numIngredients = ingredientScript.getNumIngredients();
    }

    // Update is called once per frame
    void Update()
    {
        if(count < numIngredients){
            if(!chopping){
                transform.position = Vector3.MoveTowards(transform.position,targetPos.transform.position,speed*Time.deltaTime);
            }
            if(transform.position == targetPos.transform.position){
                nextVeg();
                transform.position = startPos.transform.position;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Veg")){
            vegCollision = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.CompareTag("Veg")){
            vegCollision = false;
        }
    }

    private void OnMouseDown()
    {
        if(!chopping){
            chopping = true;
            StartCoroutine(PauseCoroutine());
            if(vegCollision){
                Debug.Log(vegCollision);
                numChops ++;
                if(numChops % 2 == 0){
                    if(!currentAnimator.GetBool("slicing")){
                        currentAnimator.SetBool("slicing",true);
                    }
                    else{
                        currentAnimator.SetBool("dicing",true);
                    }
                }
            }
        }
    }

    IEnumerator PauseCoroutine(){
        transform.Rotate(0,0,30);
        yield return new WaitForSeconds(0.25f);
        transform.Rotate(0,0,-30);
        chopping = false;
    }

    private void nextVeg(){
        numChops = 0;
        ingredientScript.deleteVeg(count);
        count ++;
        if(count < numIngredients){
            ingredientScript.generateVeg(count);
            currentAnimator = ingredientScript.getCurrentVeg().GetComponent<Animator>();
        }
    }
}
