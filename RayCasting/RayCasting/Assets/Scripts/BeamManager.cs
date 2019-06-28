using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(LineRenderer))]
public class BeamManager : MonoBehaviour
{
    [Range(0f, 10f)]
    [Tooltip("Time before destruction")]
    public float time = 1f;
    [Header("Position")]
    public Vector3 start;
    public Vector3 end;

    private LineRenderer line;
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
        Destroy(gameObject, time);

        line.positionCount = 2;
        line.SetPosition(0, start);
        line.SetPosition(1, end);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
