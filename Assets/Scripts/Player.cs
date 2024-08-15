using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
       public Transform cameraRig;


       Rigidbody rb;


       public float speed;

    // Start is called before the first frame update
    void Start()
       {
          GameManager.gm.player = gameObject; 
        
        
          rb = GetComponent<Rigidbody>();
       }

    // Update is called once per frame
    void Update()
       {
           Vector3 movement = cameraRig.forward * Input.GetAxisRaw("Vertical");

           movement += cameraRig.right * Input.GetAxisRaw("Horizontal");


           rb.AddForce (movement * speed * Time.deltaTime);
       }
}
