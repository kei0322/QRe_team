using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class role_change : MonoBehaviour
{

    public GameObject role_change_canvas;
    public GameObject questoner_canvas;
    public GameObject respondent_canvas;
    // Start is called before the first frame update
    void Start()
    {
        questoner_canvas.gameObject.SetActive(false);
        respondent_canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void respondent()
    {
        role_change_canvas.gameObject.SetActive(false);
        questoner_canvas.gameObject.SetActive(false);
        respondent_canvas.gameObject.SetActive(true);
    }

    public void questoner()
    {
        role_change_canvas.gameObject.SetActive(false);
        respondent_canvas.gameObject.SetActive(false);
        questoner_canvas.gameObject.SetActive(true);
    }
}
