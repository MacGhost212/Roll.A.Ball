using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRoomActivator : MonoBehaviour
{
    public GameObject triggerBox;
    public GameObject pickup;
    bool doOnce = false;
    int numberOfPickups = 5;

    public GameObject prefab;//new
   //public GameObject randomPickUpGenorator;//new

    static List<GameObject> nextRoom = new List<GameObject>();
    static List<GameObject> pickups = new List<GameObject>();//new

    void OnTriggerEnter(Collider other)
    {
        if(!doOnce)
        {
            randomPickupSpawn();
            //pickupSpawned = true;
        }
        print(doOnce);
     
        //foreach(GameObject pickup in nextRoom)
        // {
        //    pickup.transform.SetParent(PickupParent);
        // }
      
    }
    
    //void onTriggerEnter(Collider other)//new
    //{
    //    GameObject randomPickUpGenorator;
    //    for (int i = 0; i < 5; i++)
    //    {
    //        Vector3 position = new Vector3(Random.Range(-20.0f, 12.0f), 0.5f, Random.Range(-20.0f, 12.0f));
    //        pickups.Add(randomPickUpGenorator);
    //   }
    // }//new

    void randomPickupSpawn()
    {
        for (int i = 0; i < numberOfPickups; i++)
        {
            Vector3 postion = new Vector3(Random.Range(-10.0f, 10.0f), -0.5f, Random.Range(20.0f, 5.0f));
            nextRoom.Add(Instantiate(pickup, triggerBox.transform.position + postion, Quaternion.identity));
        }
        doOnce = true;
    }
    public static int getTotalNumberOfPickups()//new
    {                                          //new
        return pickups.Count;                  //new
    }                                          //new
}
