using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{

    public int lifeTime;
    public GameObject button;

    public void Start()
    {
        
        button.SetActive(false);
        StartCoroutine(ShowAndHide());
    }
    IEnumerator ShowAndHide()
    {
        button.SetActive(true);
        yield return new WaitForSeconds(lifeTime);
        button.SetActive(true);
    }
}
