using UnityEngine;
using Unity.UI;

//TextMeshPro���g���Ă���ꍇ
using TMPro;

public class ScoreSum_07th : MonoBehaviour
{
    //ScoreManager�̕ϐ����g�����߂ɐ錾
    public ScoreManager_07th scoremana;

    public TextMeshProUGUI scoreText;
    int itemcount = 0;
    int sum = 0;

    void Update()
    {
        //ScoreManager���̕ϐ��ł���"itemCount"�̒l���擾
        itemcount = scoremana.itemCount;

        //�X�R�A�̌v�Z
        sum = itemcount * 500;

        //�e�L�X�g��\��
        scoreText.text = "Score:" + sum;

    }
}
