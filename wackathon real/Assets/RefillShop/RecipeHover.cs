using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeHover : MonoBehaviour
{
    private Vector3 start = new Vector3(-5, -8, 0);
    private Vector3 end = new Vector3(-5, -3, 0);
    private Vector3 padding = new Vector3(2, 1, 0);
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = start;
        text.transform.position = start + padding;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        StartCoroutine(BounceMove(transform.position, end, 8f, 3f));
    }

    private void OnMouseExit()
    {
        // get back to start position
        StartCoroutine(BounceMove(transform.position, start, 10f, 0f));
    }

    IEnumerator BounceMove(Vector3 start, Vector3 end, float moveSpeed, float bounceHeight)
    {
        float startTime = Time.time;
        float journeyLength = Vector3.Distance(start, end);
        float fracComplete = 0f;

        while (fracComplete < 1f)
        {
            float distCovered = (Time.time - startTime) * moveSpeed;
            fracComplete = distCovered / journeyLength;
            float bounceFactor = Mathf.Sin(fracComplete * Mathf.PI) * bounceHeight;
            transform.position = Vector3.Lerp(start, end + new Vector3(0f, bounceFactor, 0f), fracComplete);
            text.transform.position = transform.position + (transform.position.y < 0 ? padding : (-1 * padding));

            yield return null;
        }
    }
}
