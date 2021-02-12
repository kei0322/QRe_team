using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class img_print : MonoBehaviourPunCallbacks
{
    public PhotonView photonView;//pun使うために必用な奴

    public Image img;//画像

    //偉人
    public Sprite greatman0;
    public Sprite greatman1;
    public Sprite greatman2;

    private string theme;
    private int choices = 0;
    private int answer=0;

    // Start is called before the first frame update
    void Start()
    {
        theme = "greatman";
    }

    // Update is called once per frame
    void Update()
    {
        if (theme == "greatman") gm_image_switch();
        if (v.tohome == true) SceneManager.LoadScene("home");
    }

    private void gm_image_switch()
    {
        switch (choices)
        {
            case 0:
                if (answer == 0) img.sprite = greatman0;
                if (answer == 1) img.sprite = greatman1;
                if (answer == 2) img.sprite = greatman2;
                break;
            default:
                break;
        }

    }
}
