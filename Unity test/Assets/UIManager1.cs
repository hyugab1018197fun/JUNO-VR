using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class UIManager1 : MonoBehaviour
{
    [SerializeField] GameObject menuCamera;
    [SerializeField] GameObject mainCameraA;
    [SerializeField] GameObject mainCameraB;

    //[SerializeField] GameObject CameraA1;
    [SerializeField] GameObject CameraA2;
    //[SerializeField] GameObject CameraA3;
    //[SerializeField] GameObject CameraA4;
    //[SerializeField] GameObject CameraA5;

    //[SerializeField] GameObject CameraB1;
    //[SerializeField] GameObject CameraB2;
    //[SerializeField] GameObject CameraB3;
    //[SerializeField] GameObject CameraB4;
    //[SerializeField] GameObject CameraB5;

    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject mainPanelA;
    [SerializeField] GameObject mainPanelB;

    //[SerializeField] GameObject PanelA1;
    [SerializeField] GameObject PanelA2;
    //[SerializeField] GameObject PanelA3;
    //[SerializeField] GameObject PanelA4;
    //[SerializeField] GameObject PanelA5;

    //[SerializeField] GameObject PanelB1;
    //[SerializeField] GameObject PanelB2;
    //[SerializeField] GameObject PanelB3;
    //[SerializeField] GameObject PanelB4;
    //[SerializeField] GameObject PanelB5;


    void Start()
    {
        BackToMenu();
    }
 
    //メニュー画面に移動
    public void BackToMenu()
    {
        menuCamera.SetActive(true);
        mainCameraA.SetActive(false);
        mainCameraB.SetActive(false);
        menuPanel.SetActive(true);
        mainPanelA.SetActive(false);
        mainPanelB.SetActive(false);
    }

    //木星メイン画面を表示
    public void OpenMainA()
    {
        menuCamera.SetActive(false);
        mainCameraA.SetActive(true);
        mainCameraB.SetActive(false);
        menuPanel.SetActive(false);
        mainPanelA.SetActive(true);
        mainPanelB.SetActive(false);
    }

    //大赤班画面を表示
    public void OpenA2()
    {
        mainCameraA.SetActive(false);
        CameraA2.SetActive(true);
        PanelA2.SetActive(true);
    }

    //大赤班画面を閉じる
    public void CloseA2()
    {
        mainCameraA.SetActive(true);
        CameraA2.SetActive(false);
        PanelA2.SetActive(false);
    }

    //JUNOメインパネルを表示
    public void OpenMainB()
    {
        menuCamera.SetActive(false);
        mainCameraA.SetActive(false);
        mainCameraB.SetActive(true);
        menuPanel.SetActive(false);
        mainPanelA.SetActive(false);
        mainPanelB.SetActive(true);
    }

}