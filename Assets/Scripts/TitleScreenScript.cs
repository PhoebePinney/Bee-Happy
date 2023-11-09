using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Tutorial button png")
                {
                    SceneManager.LoadScene("Tutorial");
                }

                else if (hit.transform.name == "Play button png")
                {
                    SceneManager.LoadScene("Play");
                }

                else if (hit.transform.name == "New game button png")
                {
                    SceneManager.LoadScene("New Game");
                }
            }
        }


    }
}
