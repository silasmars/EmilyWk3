using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour
   {

         // Amount to move left or right from start point
      public float delta = 1.5f;

      public float speed = 2f;


      private Vector3 startPosition;


         // Start is called before the first frame update
      void Start()
         {
            startPosition = transform.position;
         }


         // Update is called once per frame
      void Update()
         {
            Vector3 startPos = startPosition;

            startPos.x += delta * Mathf.Sin(Time.time * speed);

            transform.position = startPos;
         }
   }
