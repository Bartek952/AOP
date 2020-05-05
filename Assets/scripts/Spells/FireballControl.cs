using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballControl : MonoBehaviour
{
    float timer;
    void Start()
    {
        
    }

    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 10)
        {
            Destroy(this.gameObject);
        }

    }
}
