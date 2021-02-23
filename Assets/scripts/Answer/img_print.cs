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
    //private int choices = 0;
    //private int answer=0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(v.answer);
        theme = "greatman";
    }

    // Update is called once per frame
    void Update()
    {
        if (theme == "greatman") gm_image_switch();
        //if (v.tohome == true) SceneManager.LoadScene("home");
    }

    private void gm_image_switch()
    {
        switch (v.choices)
        {
            case 0:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/nobunaga");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/hideyosi");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/ieyasu");
                break;
            case 1:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/saigoutakamori");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/sakamotoryouma");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/okitasousi");
                break;
            case 2:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/ezisonn");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/nikoratesura");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/raitokyoudai");
                break;
            case 3:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/nogutihideo");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/higutiiyou");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/hukuzawayukiti");
                break;
            case 4:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/da-winn");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/nyu-tonn");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/arukimedesu");
                break;
            case 5:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/be-to-benn");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/mo-tuxaruto");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/bahha");
                break;
            case 6:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/naporeonn");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/arekusanndorosudaiou");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/ramusesunisei");
                break;
            case 7:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/katusikahokusai");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/youkimi");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/gohho");
                break;
            case 8:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/akutagawaryuunosuke");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/dazaiosamu");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/natumesouseki");
                break;
            case 9:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/sokuratesu");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/hurannsisukozabieru");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/gannzi-");
                break;
            case 10:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/zyannnudaruku");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/seisyounagonn");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/naitinnge-ru");
                break;
            case 11:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/aketimituhide");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/inoutatdataka");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/sibusawaeiiti");
                break;
            case 12:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/davinnti");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/mikerannzyaro");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/ainnsyutainn");
                break;
            case 13:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/tinngisuhann");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/koronnbusu");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/sikoutei");
                break;
            case 14:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/peri-");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/rinnka-");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/no-beru");
                break;
            case 15:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/takirenntarou");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/syaikusupia");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/anntonio");
                break;
            case 16:
                if (v.answer == 0) img.sprite = Resources.Load<Sprite>("images/greatman/kaesaru");
                if (v.answer == 1) img.sprite = Resources.Load<Sprite>("images/greatman/puratonn");
                if (v.answer == 2) img.sprite = Resources.Load<Sprite>("images/greatman/minamotonoyositune");
                break;
            default:
                break;
        }

    }


}
