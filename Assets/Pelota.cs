using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float velocidad = 0.1F;
    
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Arco")
        {
            
            Debug.Log("Contacto");
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        }

    }
}
