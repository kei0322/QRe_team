using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Photon使うときは必ずオブジェクトにPhoton Viewをつけること！
using Photon.Pun;

public class role_change : MonoBehaviourPunCallbacks
{
    //岩下
    //加藤君が作ってくれたものにかなり手を加えてます
    //具体的にタイマースタートを同期させるためにいろいろ付け加えてます
    //やってる処理は解答・出題を選択→全員が選択し終わるまで待機→全員が選択し終わったらタイマースタート&問題表示→結果発表→最初の役割選択画面に戻る

    public GameObject role_change_canvas;
    public GameObject questoner_canvas;
    public GameObject respondent_canvas;
    public GameObject button_canvas;//回答者のボタン
    public GameObject button_role_0;//ロール選択のボタン0
    public GameObject button_role_1;//ロール選択のボタン1
    public GameObject wait_text;//待機中のメッセージ
    public GameObject timer;
    public GameObject scripts;

    private int ans;
    private int cho;

    button reset;
    // Start is called before the first frame update
    void Awake()
    {
        questoner_canvas.gameObject.SetActive(false);
        respondent_canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (v.select_sum >= v.all_player)
        {

            photonView.RPC(nameof(to_wait_frag), RpcTarget.All);
        }

        if (v.wait_frag == true)
        {
            //*** パネルを開けてからタイマーの処理を開始するので順番変えない***//
            photonView.RPC(nameof(wait_reset), RpcTarget.All);//フラグリセット
            photonView.RPC(nameof(role_panel_change), RpcTarget.All);//パネルの表示と非表示を行うよ
            photonView.RPC(nameof(RoleStartTurn), RpcTarget.All);//スタートターンの処理を全員で同期するよ
        }
    }

    public void respondent()
    {
        questoner_canvas.gameObject.SetActive(false);
        respondent_canvas.gameObject.SetActive(true);
        Debug.Log("回答者を選択します");
    }

    public void questoner()
    {
        ans = (int)Random.Range(0.0f, 3.0f);//三人の中から答えとなる人を一人選ぶ
        cho = (int)Random.Range(0.0f, 18.0f);//いっぱいの中からクイズのセットを選ぶ
        //ans = 2;
        if (ans == 0) photonView.RPC(nameof(answer0_share), RpcTarget.All);//全員の答えとなる人を0番(1番左)に設定する
        if (ans == 1) photonView.RPC(nameof(answer1_share), RpcTarget.All);//全員の答えとなる人を1番(真ん中)に設定する
        if (ans == 2) photonView.RPC(nameof(answer2_share), RpcTarget.All);//全員の答えとなる人を2番(1番右)に設定する

        if (cho == 0) photonView.RPC(nameof(choices0_share), RpcTarget.All);
        if (cho == 1) photonView.RPC(nameof(choices1_share), RpcTarget.All);
        if (cho == 2) photonView.RPC(nameof(choices2_share), RpcTarget.All);
        if (cho == 3) photonView.RPC(nameof(choices3_share), RpcTarget.All);
        if (cho == 4) photonView.RPC(nameof(choices4_share), RpcTarget.All);
        if (cho == 5) photonView.RPC(nameof(choices5_share), RpcTarget.All);
        if (cho == 6) photonView.RPC(nameof(choices6_share), RpcTarget.All);
        if (cho == 7) photonView.RPC(nameof(choices7_share), RpcTarget.All);
        if (cho == 8) photonView.RPC(nameof(choices8_share), RpcTarget.All);
        if (cho == 9) photonView.RPC(nameof(choices9_share), RpcTarget.All);
        if (cho == 10) photonView.RPC(nameof(choices10_share), RpcTarget.All);
        if (cho == 11) photonView.RPC(nameof(choices11_share), RpcTarget.All);
        if (cho == 12) photonView.RPC(nameof(choices12_share), RpcTarget.All);
        if (cho == 13) photonView.RPC(nameof(choices13_share), RpcTarget.All);
        if (cho == 14) photonView.RPC(nameof(choices14_share), RpcTarget.All);
        if (cho == 15) photonView.RPC(nameof(choices15_share), RpcTarget.All);
        if (cho == 16) photonView.RPC(nameof(choices16_share), RpcTarget.All);

        respondent_canvas.gameObject.SetActive(false);
        questoner_canvas.gameObject.SetActive(true);
        Debug.Log("出題者を選択します");
    }

    //選択で共通すること
    public void select_role()
    {
        photonView.RPC(nameof(wait_share), RpcTarget.All);
        //選択ボタン消去&待機メッセージ表示
        button_role_0.gameObject.SetActive(false);
        button_role_1.gameObject.SetActive(false);
        wait_text.gameObject.SetActive(true);
    }

    [PunRPC]
    void wait_share()
    {
        v.select_sum++;
        Debug.Log(v.select_sum);
    }

    [PunRPC]
    void to_wait_frag()
    {
        v.wait_frag = true;
    }



    [PunRPC]
    void role_panel_change()
    {
        timer.gameObject.SetActive(true);
        button_canvas.gameObject.SetActive(true);
        button_role_0.gameObject.SetActive(true);
        button_role_1.gameObject.SetActive(true);
        wait_text.gameObject.SetActive(false);
        role_change_canvas.gameObject.SetActive(false);
    }

    [PunRPC]
    void RoleStartTurn()
    {
        scripts.GetComponent<TurnBasedSystem>().StartTurn();
    }

    [PunRPC]
    void wait_reset()
    {
        v.select_sum = 0;
        v.wait_frag = false;
    }

    [PunRPC]
    void answer0_share()
    {
        v.answer = 0;
    }

    [PunRPC]
    void answer1_share()
    {
        v.answer = 1;
    }

    [PunRPC]
    void answer2_share()
    {
        v.answer = 2;
    }

    [PunRPC]
    void choices0_share()
    {
        v.choices = 0;
    }

    [PunRPC]
    void choices1_share()
    {
        v.choices = 1;
    }

    [PunRPC]
    void choices2_share()
    {
        v.choices = 2;
    }

    [PunRPC]
    void choices3_share()
    {
        v.choices = 3;
    }

    [PunRPC]
    void choices4_share()
    {
        v.choices = 4;
    }

    [PunRPC]
    void choices5_share()
    {
        v.choices = 5;
    }

    [PunRPC]
    void choices6_share()
    {
        v.choices = 6;
    }

    [PunRPC]
    void choices7_share()
    {
        v.choices = 7;
    }

    [PunRPC]
    void choices8_share()
    {
        v.choices = 8;
    }

    [PunRPC]
    void choices9_share()
    {
        v.choices = 9;
    }

    [PunRPC]
    void choices10_share()
    {
        v.choices = 10;
    }

    [PunRPC]
    void choices11_share()
    {
        v.choices = 11;
    }

    [PunRPC]
    void choices12_share()
    {
        v.choices = 12;
    }

    [PunRPC]
    void choices13_share()
    {
        v.choices = 13;
    }

    [PunRPC]
    void choices14_share()
    {
        v.choices = 14;
    }

    [PunRPC]
    void choices15_share()
    {
        v.choices = 15;
    }

    [PunRPC]
    void choices16_share()
    {
        v.choices = 16;
    }
}
