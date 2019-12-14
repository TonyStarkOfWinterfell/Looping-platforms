using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLeft : MonoBehaviour
{

    public GameObject geepee;
    // Start is called before the first frame update


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ground")
        {
            Vector3 lips = col.transform.position;
            Debug.Log("position = " + lips);
        }
    }

}
