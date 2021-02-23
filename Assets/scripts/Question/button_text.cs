using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_text : MonoBehaviour
{
    public GameObject bt0;
    public GameObject bt1;
    public GameObject bt2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (v.theme == "greatman") gm_image_switch();
    }

    private void gm_image_switch()
    {
        switch (v.choices)
        {
            case 0:
                bt0.GetComponent<Text>().text = "織田信長";
                bt1.GetComponent<Text>().text = "豊臣秀吉";
                bt2.GetComponent<Text>().text = "徳川家康";
                break;
            case 1:
                bt0.GetComponent<Text>().text = "西郷隆盛";
                bt1.GetComponent<Text>().text = "坂本龍馬";
                bt2.GetComponent<Text>().text = "沖田総司";
                break;
            case 2:
                bt0.GetComponent<Text>().text = "エジソン";
                bt1.GetComponent<Text>().text = "ニコラ・テスラ";
                bt2.GetComponent<Text>().text = "ライト兄弟";
                break;
            case 3:
                bt0.GetComponent<Text>().text = "野口英世";
                bt1.GetComponent<Text>().text = "樋口一葉";
                bt2.GetComponent<Text>().text = "福沢諭吉";
                break;
            case 4:
                bt0.GetComponent<Text>().text = "ダーウィン";
                bt1.GetComponent<Text>().text = "ニュートン";
                bt2.GetComponent<Text>().text = "アルキメデス";
                break;
            case 5:
                bt0.GetComponent<Text>().text = "ベートーヴェン";
                bt1.GetComponent<Text>().text = "モーツァルト";
                bt2.GetComponent<Text>().text = "バッハ";
                break;
            case 6:
                bt0.GetComponent<Text>().text = "ナポレオン";
                bt1.GetComponent<Text>().text = "アレクサンドロス大王";
                bt2.GetComponent<Text>().text = "ラムセス2世";
                break;
            case 7:
                bt0.GetComponent<Text>().text = "葛飾北斎";
                bt1.GetComponent<Text>().text = "楊貴妃";
                bt2.GetComponent<Text>().text = "ゴッホ";
                break;
            case 8:
                bt0.GetComponent<Text>().text = "芥川龍之介";
                bt1.GetComponent<Text>().text = "太宰治";
                bt2.GetComponent<Text>().text = "夏目漱石";
                break;
            case 9:
                bt0.GetComponent<Text>().text = "ソクラテス";
                bt1.GetComponent<Text>().text = "フランシスコ・ザビエル";
                bt2.GetComponent<Text>().text = "ガンジー";
                break;
            case 10:
                bt0.GetComponent<Text>().text = "ジャンヌ・ダルク";
                bt1.GetComponent<Text>().text = "清少納言";
                bt2.GetComponent<Text>().text = "ナイチンゲール";
                break;
            case 11:
                bt0.GetComponent<Text>().text = "明智光秀";
                bt1.GetComponent<Text>().text = "伊能忠敬";
                bt2.GetComponent<Text>().text = "渋沢栄一";
                break;
            case 12:
                bt0.GetComponent<Text>().text = "レオナルド・ダ・ヴィンチ";
                bt1.GetComponent<Text>().text = "ミケランジェロ";
                bt2.GetComponent<Text>().text = "アインシュタイン";
                break;
            case 13:
                bt0.GetComponent<Text>().text = "チンギス・ハン";
                bt1.GetComponent<Text>().text = "コロンブス";
                bt2.GetComponent<Text>().text = "始皇帝";
                break;
            case 14:
                bt0.GetComponent<Text>().text = "ペリー";
                bt1.GetComponent<Text>().text = "リンカーン";
                bt2.GetComponent<Text>().text = "ノーベル";
                break;
            case 15:
                bt0.GetComponent<Text>().text = "滝廉太郎";
                bt1.GetComponent<Text>().text = "シェイクスピア";
                bt2.GetComponent<Text>().text = "アントニオ";
                break;
            case 16:
                bt0.GetComponent<Text>().text = "カエサル";
                bt1.GetComponent<Text>().text = "プラトン";
                bt2.GetComponent<Text>().text = "源義経";
                break;

            default:
                break;
        }

    }
}
