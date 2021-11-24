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
        Debug.Log("ゲームスタート");
        SceneManager.LoadScene("MainScene");
    }
    //ResultScene_"ResultScene"にシーン遷移
    public void ChangeResultScene()
    {
        Debug.Log("リザルト表示");
        SceneManager.LoadScene("ResultScene");
    }
    //TitleScene_"TitleScene"にシーン遷移
    public void ChangeTitleScene()
    {
        Debug.Log("タイトルシーンに戻る");
        SceneManager.LoadScene("TitleScene");
    }

    //ゲーム終了
    public void GameExit()
    {
        Debug.Log("ゲーム終了");
       Application.Quit();
    }

}
