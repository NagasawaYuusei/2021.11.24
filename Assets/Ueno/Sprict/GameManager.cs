using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    //GameStart_"MainScene"にシーン遷移
    public void ChangeGameStart() 
    {
        SceneManager.LoadScene("MainScene");
        Debug.Log("ゲームスタート");
    }
    //TitleScene_"TitleScene"にシーン遷移
    public void ChangeTitleScene()
    {
        SceneManager.LoadScene("TitleScene");
        Debug.Log("タイトルシーンに戻る");
    }
}
