using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class UIManager2 : MonoBehaviour
{
    [SerializeField] GameObject menuCamera;
    [SerializeField] GameObject mainCameraA;
    [SerializeField] GameObject mainCameraB;

    [SerializeField] GameObject CameraA1;
    [SerializeField] GameObject CameraA2;
    [SerializeField] GameObject CameraA3;
    [SerializeField] GameObject CameraA4;
    [SerializeField] GameObject CameraA5;

    [SerializeField] GameObject CameraB1;
    [SerializeField] GameObject CameraB2;
    [SerializeField] GameObject CameraB3;
    [SerializeField] GameObject CameraB4;
    [SerializeField] GameObject CameraB5;

    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject mainPanelA;
    [SerializeField] GameObject mainPanelB;

    [SerializeField] GameObject PanelA1;
    [SerializeField] GameObject PanelA2;
    [SerializeField] GameObject PanelA3;
    [SerializeField] GameObject PanelA4;
    [SerializeField] GameObject PanelA5;

    [SerializeField] GameObject PanelB1;
    [SerializeField] GameObject PanelB2;
    [SerializeField] GameObject PanelB3;
    [SerializeField] GameObject PanelB4;
    [SerializeField] GameObject PanelB5;

    [SerializeField] Button ButtonAtb;
    [SerializeField] Button ButtonA1;
    [SerializeField] Button ButtonA2;
    [SerializeField] Button ButtonA3;
    [SerializeField] Button ButtonA4;
    [SerializeField] Button ButtonA5;
    [SerializeField] Button ButtonA6;

    [SerializeField] Button ButtonBtb;
    [SerializeField] Button ButtonB1;
    [SerializeField] Button ButtonB2;
    [SerializeField] Button ButtonB3;
    [SerializeField] Button ButtonB4;
    [SerializeField] Button ButtonB5;
    [SerializeField] Button ButtonB6;

    [SerializeField] GameObject LightB5;


    void Start()
    {
        BackToMenu();
    }

    public void BackToMenu()
    {
        menuCamera.SetActive(true);

        mainCameraA.SetActive(false);
        CameraA1.SetActive(false);
        CameraA2.SetActive(false);
        CameraA3.SetActive(false);
        CameraA4.SetActive(false);
        CameraA5.SetActive(false);

        mainCameraB.SetActive(false);
        CameraB1.SetActive(false);
        CameraB2.SetActive(false);
        CameraB3.SetActive(false);
        CameraB4.SetActive(false);
        CameraB5.SetActive(false);

        menuPanel.SetActive(true);
        mainPanelA.SetActive(false);
        mainPanelB.SetActive(false);

        LightB5.SetActive(false);
    }

    public void OpenMainA()
    {
        mainCameraA.SetActive(true);
        mainCameraB.SetActive(false);

        menuPanel.SetActive(false);
        mainPanelA.SetActive(true);
        mainPanelB.SetActive(false);
    }

    public void OpenA1()
    {
        CameraA1.SetActive(true);
        PanelA1.SetActive(true);

        ButtonAtb.interactable = false;
        ButtonA1.interactable = false;
        ButtonA2.interactable = false;
        ButtonA3.interactable = false;
        ButtonA4.interactable = false;
        ButtonA5.interactable = false;
        ButtonA6.interactable = false;
    }

    public void CloseA1()
    {
        CameraA1.SetActive(false);
        PanelA1.SetActive(false);

        ButtonAtb.interactable = true;
        ButtonA1.interactable = true;
        ButtonA2.interactable = true;
        ButtonA3.interactable = true;
        ButtonA4.interactable = true;
        ButtonA5.interactable = true;
        ButtonA6.interactable = true;
    }

    public void OpenA2()
    {
        CameraA2.SetActive(true);
        PanelA2.SetActive(true);

        ButtonAtb.interactable = false;
        ButtonA1.interactable = false;
        ButtonA2.interactable = false;
        ButtonA3.interactable = false;
        ButtonA4.interactable = false;
        ButtonA5.interactable = false;
        ButtonA6.interactable = false;
    }

    public void CloseA2()
    {
        CameraA2.SetActive(false);
        PanelA2.SetActive(false);

        ButtonAtb.interactable = true;
        ButtonA1.interactable = true;
        ButtonA2.interactable = true;
        ButtonA3.interactable = true;
        ButtonA4.interactable = true;
        ButtonA5.interactable = true;
        ButtonA6.interactable = true;
    }   

    public void OpenA3()
    {
        CameraA3.SetActive(true);
        PanelA3.SetActive(true);

        ButtonAtb.interactable = false;
        ButtonA1.interactable = false;
        ButtonA2.interactable = false;
        ButtonA3.interactable = false;
        ButtonA4.interactable = false;
        ButtonA5.interactable = false;
        ButtonA6.interactable = false;
    }

    public void CloseA3()
    {
        CameraA3.SetActive(false);
        PanelA3.SetActive(false);

        ButtonAtb.interactable = true;
        ButtonA1.interactable = true;
        ButtonA2.interactable = true;
        ButtonA3.interactable = true;
        ButtonA4.interactable = true;
        ButtonA5.interactable = true;
        ButtonA6.interactable = true;
    }

    public void OpenA4()
    {
        CameraA4.SetActive(true);
        PanelA4.SetActive(true);

        ButtonAtb.interactable = false;
        ButtonA1.interactable = false;
        ButtonA2.interactable = false;
        ButtonA3.interactable = false;
        ButtonA4.interactable = false;
        ButtonA5.interactable = false;
        ButtonA6.interactable = false;
    }

    public void CloseA4()
    { 
        CameraA4.SetActive(false);
        PanelA4.SetActive(false);

        ButtonAtb.interactable = true;
        ButtonA1.interactable = true;
        ButtonA2.interactable = true;
        ButtonA3.interactable = true;
        ButtonA4.interactable = true;
        ButtonA5.interactable = true;
        ButtonA6.interactable = true;
    }

    public void OpenA5() 
    {
        CameraA5.SetActive(true);
        PanelA5.SetActive(true);

        ButtonAtb.interactable = false;
        ButtonA1.interactable = false;
        ButtonA2.interactable = false;
        ButtonA3.interactable = false;
        ButtonA4.interactable = false;
        ButtonA5.interactable = false;
        ButtonA6.interactable = false;
    }

    public void CloseA5()
    {
        CameraA5.SetActive(false);
        PanelA5.SetActive(false);

        ButtonAtb.interactable = true;
        ButtonA1.interactable = true;
        ButtonA2.interactable = true;
        ButtonA3.interactable = true;
        ButtonA4.interactable = true;
        ButtonA5.interactable = true;
        ButtonA6.interactable = true;
    }

    public void OpenMainB()
    {
        mainCameraA.SetActive(false);
        mainCameraB.SetActive(true);

        menuPanel.SetActive(false);
        mainPanelA.SetActive(false);
        mainPanelB.SetActive(true);
    }

    public void OpenB1()
    {
        CameraB1.SetActive(true);
        PanelB1.SetActive(true);

        ButtonBtb.interactable = false;
        ButtonB1.interactable = false;
        ButtonB2.interactable = false;
        ButtonB3.interactable = false;
        ButtonB4.interactable = false;
        ButtonB5.interactable = false;
        ButtonB6.interactable = false;
    }

    public void CloseB1()
    {
        CameraB1.SetActive(false);
        PanelB1.SetActive(false);

        ButtonBtb.interactable = true;
        ButtonB1.interactable = true;
        ButtonB2.interactable = true;
        ButtonB3.interactable = true;
        ButtonB4.interactable = true;
        ButtonB5.interactable = true;
        ButtonB6.interactable = true;
    }

    public void OpenB2()
    {
        CameraB2.SetActive(true);
        PanelB2.SetActive(true);

        ButtonBtb.interactable = false;
        ButtonB1.interactable = false;
        ButtonB2.interactable = false;
        ButtonB3.interactable = false;
        ButtonB4.interactable = false;
        ButtonB5.interactable = false;
        ButtonB6.interactable = false;
    }

    public void CloseB2()
    {
        CameraB2.SetActive(false);
        PanelB2.SetActive(false);

        ButtonBtb.interactable = true;
        ButtonB1.interactable = true;
        ButtonB2.interactable = true;
        ButtonB3.interactable = true;
        ButtonB4.interactable = true;
        ButtonB5.interactable = true;
        ButtonB6.interactable = true;
    }

    public void OpenB3()
    {
        CameraB3.SetActive(true);
        PanelB3.SetActive(true);

        ButtonBtb.interactable = false;
        ButtonB1.interactable = false;
        ButtonB2.interactable = false;
        ButtonB3.interactable = false;
        ButtonB4.interactable = false;
        ButtonB5.interactable = false;
        ButtonB6.interactable = false;
    }

    public void CloseB3()
    {
        CameraB3.SetActive(false);
        PanelB3.SetActive(false);

        ButtonBtb.interactable = true;
        ButtonB1.interactable = true;
        ButtonB2.interactable = true;
        ButtonB3.interactable = true;
        ButtonB4.interactable = true;
        ButtonB5.interactable = true;
        ButtonB6.interactable = true;
    }

    public void OpenB4()
    {
        CameraB4.SetActive(true);
        PanelB4.SetActive(true);

        ButtonBtb.interactable = false;
        ButtonB1.interactable = false;
        ButtonB2.interactable = false;
        ButtonB3.interactable = false;
        ButtonB4.interactable = false;
        ButtonB5.interactable = false;
        ButtonB6.interactable = false;
    }

    public void CloseB4()
    {
        CameraB4.SetActive(false);
        PanelB4.SetActive(false);

        ButtonBtb.interactable = true;
        ButtonB1.interactable = true;
        ButtonB2.interactable = true;
        ButtonB3.interactable = true;
        ButtonB4.interactable = true;
        ButtonB5.interactable = true;
        ButtonB6.interactable = true;
    }

    public void OpenB5()
    {
        CameraB5.SetActive(true);
        PanelB5.SetActive(true);
        LightB5.SetActive(true);

        ButtonBtb.interactable = false;
        ButtonB1.interactable = false;
        ButtonB2.interactable = false;
        ButtonB3.interactable = false;
        ButtonB4.interactable = false;
        ButtonB5.interactable = false;
        ButtonB6.interactable = false;
    }

    public void CloseB5()
    {
        CameraB5.SetActive(false);
        PanelB5.SetActive(false);
        LightB5.SetActive(false);

        ButtonBtb.interactable = true;
        ButtonB1.interactable = true;
        ButtonB2.interactable = true;
        ButtonB3.interactable = true;
        ButtonB4.interactable = true;
        ButtonB5.interactable = true;
        ButtonB6.interactable = true;
    }

}