using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManagerScript : MonoBehaviour
{

    public GameObject player;
    public Text coinsAmount;


    // Start is called before the first frame update
    void Start()
    {
        coinsAmount.text = player.GetComponent<PlayerBehavoiur>().coins.ToString() + "/4";
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<PlayerBehavoiur>().coins.ToString() == "4")
        {
            coinsAmount.text = "Go! FINISH!";          
        }
        else
        {
            coinsAmount.text = player.GetComponent<PlayerBehavoiur>().coins.ToString() + "/4";
        }
    }

    public void GoToFirstLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToSecondLevel()
    {
        SceneManager.LoadScene(0);
    }
}
