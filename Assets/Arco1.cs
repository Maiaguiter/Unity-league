using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arco1 : MonoBehaviour
{
    public GameObject Sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)

    {
        if (col.gameObject.name == "Arco")
        {
            Debug.Log("ded");
            Destroy(Sphere);
        }
        }
    }

