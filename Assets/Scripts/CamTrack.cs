using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CamTrack : MonoBehaviour
{
       public GameObject track;


       public float camSpeed;

    // Start is called before the first frame update
    void Start()
       {
        
       }

    // Update is called once per frame
    void Update()
       {
           transform.position = track.transform.position;

           transform.Rotate(Vector3.up*Input.GetAxisRaw("Mouse X") * camSpeed);
       }
}
