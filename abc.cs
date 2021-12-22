using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,Time.deltaTime);
        transform.Rotate(0f, -0.005f, -0.015f);
        Invoke("moveForward", 8f);

    }
    void moveForward()
    {
        transform.Translate(0, 0, Time.deltaTime * 4);
    }
}
