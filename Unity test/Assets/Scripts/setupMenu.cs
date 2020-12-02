using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class setupMenu : MonoBehaviour
{
//　画面UI
	[SerializeField]
	private GameObject moveWindow;
    [SerializeField]
    private GameObject menuWindow;
	
 
	void Update () {
 
		//　スペースキーを押したら画面UIのオン・オフ
		if (Input.GetKeyDown ("space")) {
			menuWindow.SetActive (!menuWindow.activeSelf);
 			moveWindow.SetActive (!moveWindow.activeSelf);


		}
	}
}
