using UnityEngine;
using Unity.UI;

//TextMeshProを使っている場合
using TMPro;

public class ScoreSum_07th : MonoBehaviour
{
    //ScoreManagerの変数を使うために宣言
    public ScoreManager_07th scoremana;

    public TextMeshProUGUI scoreText;
    int itemcount = 0;
    int sum = 0;

    void Update()
    {
        //ScoreManager内の変数である"itemCount"の値を取得
        itemcount = scoremana.itemCount;

        //スコアの計算
        sum = itemcount * 500;

        //テキストを表示
        scoreText.text = "Score:" + sum;

    }
}
