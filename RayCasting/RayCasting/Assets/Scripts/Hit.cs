using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color clr = Color.green;
        if (Physics.Raycast(transform.position, transform.forward))
        {
            Debug.Log("Hit Something !");
            clr = Color.red;
        }
        Debug.DrawRay(transform.position, transform.forward * 10, clr);

        //Debug.DrawRay(transform.position, transform.forward * 10, Color.green);
        //if (Physics.Raycast(transform.position, transform.forward)){
        //    Debug.Log("Hit Something !");
        //    Debug.DrawRay(transform.position, transform.forward * 10, Color.red);
        //}
    }
}
