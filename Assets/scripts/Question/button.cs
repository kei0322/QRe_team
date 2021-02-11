﻿using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button : MonoBehaviourPunCallbacks
{
    public PhotonView photonView;

    public Image Invalid_image0;
    public Image Invalid_image1;
    public Image Invalid_image2;
    public GameObject button_set;

    public void to_game()
    {
        SceneManager.LoadScene("game");
    }

    public void select0()
    {
        v.panel[0]++;
        Debug.Log(v.panel[0]);
        Invalid_image0.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        Invalid_image1.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        Invalid_image2.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        button_set.gameObject.SetActive(false);
        photonView.RPC(nameof(ansum_share), RpcTarget.All);
    }
    public void select1()
    {
        v.panel[1]++;
        Debug.Log(v.panel[1]);
        Invalid_image0.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        Invalid_image1.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        Invalid_image2.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        button_set.gameObject.SetActive(false);
        photonView.RPC(nameof(ansum_share), RpcTarget.All);
    }
    public void select2()
    {
        v.panel[2]++;
        Debug.Log(v.panel[2]);
        Invalid_image0.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        Invalid_image1.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        Invalid_image2.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        button_set.gameObject.SetActive(false);
        photonView.RPC(nameof(ansum_share), RpcTarget.All);
    }

    public void tohome()
    {
        SceneManager.LoadScene("home");
    }

    [PunRPC]
    void ansum_share()
    {
        v.ansum++;
    }


}