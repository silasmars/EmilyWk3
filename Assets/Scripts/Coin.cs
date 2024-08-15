using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
       {
          GameManager.score = 0;
       }

    // Update is called once per frame
    void Update()
       {
          transform.Rotate(Vector3.up * Time.deltaTime * 180);
       }

    private void OnTriggerEnter(Collider other)
       {
          GameManager.score ++;


          Debug.Log(GameManager.score);


          GameManager.gm.UpdateScore();


          Destroy(gameObject);
       }
}
