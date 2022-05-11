using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeAssembler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform t in transform)
        {
            t.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        other.gameObject.SetActive(false);
        Transform NewPart = transform.Find(other.name);
        NewPart.gameObject.SetActive(true);
    }
}

