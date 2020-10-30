using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class UIManager : MonoBehaviour
{
    //インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject CameraA;
    [SerializeField] GameObject PanelA;
    [SerializeField] GameObject PanelB;
    [SerializeField] GameObject PanelC;
 

    void Start()
    {
        BackToMenu();
    }
 
 
    //パネルAを表示（要書き足し）
    public void SelectA()
    {
        mainCamera.SetActive(false);
        CameraA.SetActive(true);
        PanelA.SetActive(true);
    }
 
    //最初の画面に戻る
    public void BackToMenu()
    {
        mainCamera.SetActive(true);
        CameraA.SetActive(false);
        PanelA.SetActive(false);
    }
}