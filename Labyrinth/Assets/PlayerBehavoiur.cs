using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class PlayerBehavoiur : MonoBehaviour
{

    public int coins = 0;
    public GameObject light;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(1, 2.5f, 0);
        transform.localScale = new Vector3(0.3f, 0.3f, 0);
        this.coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other);
        if (other is CircleCollider2D && this.coins != 4)
        {
            Destroy(other.gameObject);

            this.coins++;
        }
        else if (other is Collider2D && this.coins == 4)
        {
            SceneManager.LoadScene(0);
            this.coins = 0;
        }
        else if(other is Collider2D)
        {
            this.coins = 0;

            GameObject light_ = Instantiate<GameObject>(light);
            light_.transform.position = new Vector3(0, 0, 0);
            light_.transform.localScale = new Vector3(1.5f, 1.5f, 0);

            StartCoroutine(ExampleCoroutine()); 
            
        }
       
    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.2f);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);

        SceneManager.LoadScene(0);
    }
}
