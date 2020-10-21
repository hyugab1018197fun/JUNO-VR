using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class UIManager : MonoBehaviour
{
    //３つのPanelを格納する変数
    //インスペクターウィンドウからゲームオブジェクトを設定する
    [SerializeField] GameObject MenuPanel;
    [SerializeField] GameObject Panela;
    [SerializeField] GameObject Panelb;
 
 
    // Start is called before the first frame update
    void Start()
    {
        //BackToMenuメソッドを呼び出す
        BackToMenu();
    }
 
 
    //MenuPanelでXR-HubButtonが押されたときの処理
    //XR-HubPanelをアクティブにする
    public void SelectA()
    {
        MenuPanel.SetActive(false);
        Panela.SetActive(true);
        Panelb.SetActive(false);
    }
 
 
    //MenuPanelでUnityButtonが押されたときの処理
    //UnityPanelをアクティブにする
    public void SelectB()
    {
        MenuPanel.SetActive(false);
        Panela.SetActive(false);
        Panelb.SetActive(true);
    }
 
 
    //2つのDescriptionPanelでBackButtonが押されたときの処理
    //MenuPanelをアクティブにする
    public void BackToMenu()
    {
        MenuPanel.SetActive(true);
        Panela.SetActive(false);
        Panelb.SetActive(false);
    }
}