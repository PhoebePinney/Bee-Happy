using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeesAppear : MonoBehaviour
{
    public int lifeTime;
    public Text mytext = null;
    public GameObject queen;
    public GameObject worker;
    public GameObject drone;


    // Start is called before the first frame update
    void Start()
    {
        queen.SetActive(true);
        worker.SetActive(false);
        drone.SetActive(false);
        //StartCoroutine(ShowAndHide());
        queen.SetActive(true);
        mytext.text = "This is the Queen Bee!" + System.Environment.NewLine + System.Environment.NewLine + "One queen runs the whole hive." + System.Environment.NewLine + "Her job is to lay the eggs that will" + System.Environment.NewLine + "spawn the hive’s next generation of bees." + System.Environment.NewLine + System.Environment.NewLine + "The queen also produces chemicals that" + System.Environment.NewLine + "guide the behaviour of the other bees." + System.Environment.NewLine + System.Environment.NewLine + "You can identify her by her larger, longer body.";
        //yield return new WaitForSeconds(lifeTime);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (queen.activeSelf) 
            {
                queen.SetActive(false);
                worker.SetActive(true);
                mytext.text = "This is the worker bee!" + System.Environment.NewLine + System.Environment.NewLine + "These are all female and their roles are to" + System.Environment.NewLine + " forage for food (pollen and nectar from flowers)" + System.Environment.NewLine + "build and protect the hive, clean and" + System.Environment.NewLine + "circulate air by beating their wings." + System.Environment.NewLine + System.Environment.NewLine + "Workers are the only bees most people" + System.Environment.NewLine + "ever see flying around outside the hive.";
                //yield return new WaitForSeconds(lifeTime);
            } 
            else if (worker.activeSelf) 
            {
                worker.SetActive(false);
                drone.SetActive(true);
                mytext.text = "This is the drone bee!" + System.Environment.NewLine + System.Environment.NewLine + "These are the male bees and their" + System.Environment.NewLine + "purpose is to mate with the new queen." + System.Environment.NewLine + System.Environment.NewLine + "Several hundred live in each hive" + System.Environment.NewLine + "during the spring and summer." + System.Environment.NewLine + System.Environment.NewLine + " But come winter, when the hive goes into" + System.Environment.NewLine + "survival mode, the drones are kicked out!";
                //yield return new WaitForSeconds(lifeTime);

            }
            else if (drone.activeSelf)
            {
                SceneManager.LoadScene("FindQueen");

            }
        }
    }
}