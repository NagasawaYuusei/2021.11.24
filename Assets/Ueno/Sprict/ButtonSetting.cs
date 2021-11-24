using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSetting : MonoBehaviour
{
    /// <summary>buttonにマウスをかざした時に表示されるスプライト</summary>
    [SerializeField] GameObject _ButtonBackImage;
    /// <summary>説明のパネル</summary>
    [SerializeField] GameObject _SetumeiImage;
    /// <summary>ボタンの効果音</summary>
    [SerializeField] AudioSource _audio1;
    /// <summary>ボタンの効果音</summary>
    [SerializeField] AudioSource _audio2;

    // マウスカーソルが対象オブジェクトに重なっている間コールされ続ける
    public void OnMouseEnter()
    {
        Debug.Log("MouseEnter!!");
        _ButtonBackImage.SetActive(true);
        _audio2.Play();
    }
    // マウスカーソルが対象オブジェクトから退出した時にコールされる
    public void OnMouseExit()
    {
        Debug.Log("MouseExit!!");
        _ButtonBackImage.SetActive(false);
        
    }
    public void OnSetumei ()
    {
        _SetumeiImage.SetActive(true);
        _audio1.Play();
    }
    public void OnSetumeiExit()
    {
        _ButtonBackImage.SetActive(false);
        _SetumeiImage.SetActive(false);
        _audio1.Play();
    }
}
