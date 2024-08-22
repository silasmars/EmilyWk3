using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampRotation : MonoBehaviour
   {

      public float speed = 1;


      public float RotAngleX = 45;


         // Start is called before the first frame update
      void Start()
         {
        
         }


         // Update is called once per frame
      void Update()
         {
            float rX = Mathf.SmoothStep(0, RotAngleX, Mathf.PingPong(Time.time * speed, 1));


            transform.rotation = Quaternion.Euler(0, rX, 0);
         }
   }
