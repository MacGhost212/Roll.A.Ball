using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public static float timeRemaining = 60.0f;
    public Text counterText;
    public static bool playerWin = false;
    //public GameObject playerLoseScreen;
    public Text TimeText;

    // Update is called once per frame
    void Update()
    {
      // if(!playerWin)
          {
            timeRemaining -= Time.deltaTime;
            counterText.text = "Time:" + (timeRemaining). ToString("0");
            if(timeRemaining <= 0)
            {
               // playerLoseScreen.gameObject.SetActive(true);
                Time.timeScale = 0f;
                //TimeText.text = "Time:" + timeRemaining;
                Debug.Log("Object Tagged");
            }
        }
    }
}
