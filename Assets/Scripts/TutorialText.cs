using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TutorialText : MonoBehaviour
{
    public Text mytext = null;
    public int lifeTime = 5;


    void Start()
    {
        mytext.text = "Perfect!" + System.Environment.NewLine + System.Environment.NewLine + "Lets start by meeting the honey bees!";
        StartCoroutine(ChangeText1());

    }
    IEnumerator ChangeText1()
    {
        yield return new WaitForSeconds(lifeTime);
        mytext.text = "Honey bees are super important pollinators for"+ System.Environment.NewLine + "flowers, fruits and vegetables." + System.Environment.NewLine + "This means that they help other plants grow!" + System.Environment.NewLine + System.Environment.NewLine + "Bees transfer pollen between the male and female parts," + System.Environment.NewLine + "allowing plants to grow seeds and fruit.";
        yield return new WaitForSeconds(lifeTime+3);
        mytext.text = "Honey bees live in hives (or colonies)." + System.Environment.NewLine + System.Environment.NewLine + "The members of the hive are divided into three types:";
    }
}
    

