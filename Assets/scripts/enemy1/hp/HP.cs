using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{

    public int hp = 5;
    public GameObject HPplate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            Destroy(HPplate);
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider c)
    {
        if(c.tag == "fireball")
        {
            hp -= 1;
            HPplate.transform.localScale = new Vector3(hp, 0.4f, 0.01f);
        }
    }
}
