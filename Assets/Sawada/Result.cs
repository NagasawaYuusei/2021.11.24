using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Result : MonoBehaviour
{
    [SerializeField] Text resultText = default;
    [SerializeField] Text newRecord;
    ScoreManager scoreManager = default;
    static int beforeResult;
    int maxScore = 999999999;
    int moneyResult;
    float scoreChangeInterval = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GetComponent<ScoreManager>();
        moneyResult = scoreManager.moneyScore;
        int tempScore = moneyResult; 
        moneyResult = Mathf.Min(moneyResult + moneyResult, maxScore);
        if (tempScore != maxScore)
        {
            DOTween.To(() => tempScore,
                x => tempScore = x,
                moneyResult,
                scoreChangeInterval)
                .OnUpdate(() => resultText.text = tempScore.ToString())
                .OnComplete(() => resultText.text = moneyResult.ToString());
        }
        if (moneyResult > beforeResult)
        {
            newRecord.enabled = true;
            beforeResult = moneyResult;
        }
        else if (moneyResult <= beforeResult) newRecord.enabled = false;
    }

}
