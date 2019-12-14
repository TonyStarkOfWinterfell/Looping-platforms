using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformF : MonoBehaviour
{


    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;

    //public GameObject platformLeft;
    public GameObject cam;


    private float platformWidth;







    // Start is called before the first frame update
    void Start()
    {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(platformWidth);
        if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
            Instantiate(thePlatform, transform.position, transform.rotation);

            //platformLeft.transform.position = new Vector3(platformLeft.transform.position.x + 6.797f, platformLeft.transform.position.y, 0);
        }
    }
}
