using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PlayerContoller : MonoBehaviour
{
    public float speed = 800.0f;
    public Text scoreText;
    private int count = 0;
    public GameObject Ramp;
    public Text winText;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        //Debug.log("Object Tagged");
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            scoreText.text = "Score: " + count;
            Debug.Log("Object Tagged");

            if(count>= SpawnScript.getTotalNumberOfPickups()+ NextRoomActivator.getTotalNumberOfPickups())
            {
                Ramp.gameObject.SetActive(true);
                //Time.timeScale = 0f;
            }
            if (count >= 22)
            {
                winText.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
            {
//#if UNITY_EDITOR
//             UnityEditor.EditorApplication.isPlaying = false;
//#else 
//                Application.Quit();
//#endif
            }
        }
    }  
}
