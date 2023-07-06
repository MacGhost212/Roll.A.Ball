using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnScript : MonoBehaviour
{
    public GameObject player;
    public GameObject pickup;
    public int noOfPickups = 8;
    public int radius = 4;
    int counter = 0;


    public bool secondRowOfPickups = true;
    public bool SpawnInCircle = true;
    public bool globalRotation = false;

    //public Transform pickupParent;
    static List<GameObject> pickupList = new List<GameObject>();

    void Start()
    {
        // pickupParent.transform.position = player.transform.position;
        {
            for (int i = 0; i < noOfPickups; i++)
            {
                pickupList.Add(Instantiate(pickup, player.transform.position + new Vector3(2 - i, 0, -2), Quaternion.identity));

                if (secondRowOfPickups)
                {
                    pickupList.Add(Instantiate(pickup, player.transform.position + new Vector3(2 - i, 0, 2), Quaternion.identity));
                }
            }
        }


        if (SpawnInCircle)
        {
            foreach (GameObject pickup in pickupList)
            {
                float theta = counter * 2 * Mathf.PI / pickupList.Count;
                float x = Mathf.Sin(theta) * radius;
                float z = Mathf.Cos(theta) * radius;

                pickup.transform.position = (player.transform.position + new Vector3( x, 0, z));
                counter++;
            }
        }
    } 
            public static int getTotalNumberOfPickups()
    {
        return pickupList.Count;
    }
}
        
       
 
