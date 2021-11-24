using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    /// <summary>ボタンの効果音</summary>
    [SerializeField] AudioSource _audio1;


    //GameStart_"MainScene"にシーン遷移
    public void ChangeGameStart()
    {
        Debug.Log("ゲームスタート");
        _audio1.Play();
        SceneManager.LoadScene("MainScene");
    }
    //ResultScene_"ResultScene"にシーン遷移
    public void ChangeResultScene()
    {
        Debug.Log("リザルト表示");
        _audio1.Play();
        SceneManager.LoadScene("ResultScene");
    }
    //TitleScene_"TitleScene"にシーン遷移
    public void ChangeTitleScene()
    {
        Debug.Log("タイトルシーンに戻る");
        _audio1.Play();
        SceneManager.LoadScene("TitleScene");
    }

    //ゲーム終了
    public void GameExit()
    {
        Debug.Log("ゲーム終了");
        _audio1.Play();
        Application.Quit();
    }

}
