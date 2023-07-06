using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public Text DeadText;

    //void Start()
   // {
   //   player = GameObject.FindGameObjectWithTag("Player");
   // }

    void OnTriggerEnter(Collider  other)
    {
        //var enemy = other.gameObject.GetComonent(PlayerController);
            player.gameObject.SetActive (false);
            DeadText.gameObject.SetActive(true);
    }
}
