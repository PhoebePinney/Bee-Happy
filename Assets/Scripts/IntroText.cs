using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IntroText : MonoBehaviour
{
    public Text mytext = null;
    public int lifeTime = 3;


    void Start()
    {
        mytext.text = "Welcome!"+ System.Environment.NewLine+ "You must be" + System.Environment.NewLine +"the new beekeeper!";
        StartCoroutine(ChangeText());

    }
    IEnumerator ChangeText()
    {
        yield return new WaitForSeconds(lifeTime);
        mytext.text = "I'm sure you know" + System.Environment.NewLine + "all about how to" + System.Environment.NewLine + "look after bees right?" + System.Environment.NewLine + "If not, just click here!";
    }
}

