using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyF : MonoBehaviour
{

    public GameObject platformDestruct;
    public GameObject platformLeft;




    // Start is called before the first frame update
    void Start()
    {
        platformDestruct = GameObject.Find("PlatDestructF");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < platformDestruct.transform.position.x)
        {
            platformLeft.transform.position = new Vector3(platformLeft.transform.position.x + 6.797f, platformLeft.transform.position.y, 0);
            Destroy(gameObject);            
        }
    }
}
