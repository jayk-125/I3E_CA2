using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    void Collected()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ///Increases move speed
            collision.gameObject.GetComponent<StarterAssets.FirstPersonController>().MoveSpeed += 3.0f;
            ///Increases jump height
            collision.gameObject.GetComponent<StarterAssets.FirstPersonController>().JumpHeight += 1.0f;
            Collected();
            Debug.Log("It works");
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}