using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectName : MonoBehaviour
{
    public GameObject Object;
    public Vector3 offset;
    public GameObject focalPoint;
    // Start is called before the first frame update
    void Start()
    {
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Object.transform.position + offset;
        transform.rotation = focalPoint.transform.rotation;
    }
}
