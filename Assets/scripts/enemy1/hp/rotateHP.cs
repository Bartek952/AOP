using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateHP : MonoBehaviour
{
    //public GameObject Player;
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if(Player.transform.rotation.z != this.transform.rotation.z)
    //    {
    //        this.transform.Rotate(0, 0, Player.transform.rotation.z);
    //    }
    //}
    //public float Sensivity = 100f;

    //public GameObject playerBody;
    //public Transform HP;
    //// Start is called before the first frame update
    //void Start()
    //{
    //}

    //// Update is called once per frame
    //void Update()
    //{ 
    //        HP.Rotate(Vector3.zero * playerBody.transform.position.y * Sensivity * Time.deltaTime);
    //}
    public float mouseSensivity = 100f;

    public Transform playerBody;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;
            playerBody.Rotate(Vector3.right * mouseX);
        }
    }
}
