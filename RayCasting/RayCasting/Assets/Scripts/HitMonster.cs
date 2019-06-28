using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitMonster : MonoBehaviour
{
    public float rayRange = 3f;
    
    void Start()
    {

    }


    void Update()
    {
        RaycastHit hit;
        Color clr = Color.blue;
        if (Physics.Raycast(transform.position, transform.forward, out hit, rayRange))
        {
            if(hit.transform.tag == "monster")
            {
                Debug.Log("Hit monster !");
                clr = Color.magenta;
            }
            else
            {
                clr = Color.blue;
                Debug.Log("Hit Something !");
            }
            Debug.DrawRay(transform.position, transform.forward * rayRange, clr);
        }

    }
}
