using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyB : MonoBehaviour
{

    public GameObject platformDestructB;



    // Start is called before the first frame update
    void Start()
    {
        platformDestructB = GameObject.Find("PlatDestructB");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > platformDestructB.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
