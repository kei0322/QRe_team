using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class questoner : MonoBehaviourPunCallbacks
{
    public PhotonView photonView;

    public Image img;//左の画像

    public Text name;
    public Text description;

    //偉人
    public Sprite greatman0;
    public Sprite greatman1;
    public Sprite greatman2;

    //共有変数
    private string theme="greatman";
    private int choices = 0;
    private int answer = 0;
    private bool ttf = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (theme == "greatman") gm_image_switch();
        if (v.ansum >= v.player_count) photonView.RPC(nameof(to_test_frag), RpcTarget.All);
        if (ttf == true) SceneManager.LoadScene("result");
    }

    private void gm_image_switch()
    {
        switch (choices)
        {
            case 0:
                if (answer == 0) { img.sprite = greatman0; name.GetComponent<Text>().text = "織田信長"; description.GetComponent<Text>().text = "・鳴かぬなら\n・うつけ\n・楽市楽座\n・火縄銃\n・天下布武\n・人間五十年"; }
                if (answer == 1) { img.sprite = greatman1; name.GetComponent<Text>().text = "豊臣秀吉"; description.GetComponent<Text>().text = "織田信長"; }
                if (answer == 2) { img.sprite = greatman2; name.GetComponent<Text>().text = "徳川家康"; description.GetComponent<Text>().text = "織田信長"; }
                break;
            default:
                break;
        }

    }

    [PunRPC]
    void to_test_frag()
    {
        ttf = true;
    }
}
