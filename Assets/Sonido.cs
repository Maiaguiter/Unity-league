using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gol = GetComponent<AudioSource>();
    }
    AudioSource gol;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
       if ( col.gameObject.name == "Sphere")
        {
            gol.Play();
        }
    }
}
