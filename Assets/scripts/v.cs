﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class v : MonoBehaviour
{
    //加藤君の作った共通変数
    public static int[] panel = new int[3];
    public static int player_count = 2; //回答者数
    public static int ansum = 0;
    public static bool tohome = false;
    public static string theme = "greatman";
    public static int choices = 0;
    public static bool ttf = false;
    public static int answer = 0;


    //岩下が作った共通変数
    public static int all_player = 3;//全体のプレイヤー数
    public static int turn_sum = 0;//ターンの合計
    public static int result_sum = 0;//リザルトボタンを押した人数
    public static int select_sum = 0;//ロールを選択した人の数
    public static bool turn_frag = false;
    public static bool result_frag = false;
    public static bool wait_frag = false;//全員待ったかどうか
}
