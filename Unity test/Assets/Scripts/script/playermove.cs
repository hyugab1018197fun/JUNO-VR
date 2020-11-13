using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
public GameObject Player;
    public GameObject Camera;
    public float speed;
    private Transform PlayerTransform;
    private Transform CameraTransform;
    // Use this for initialization
    void Start () {

        PlayerTransform = transform.parent;
        CameraTransform = GetComponent<Transform>();

    }
	private  static float PIpar2=Mathf.PI/2.0f;
	// Update is called once per frame
	void Update () {
        // float X_Rotation = Input.GetAxis("Mouse X");
        // float Y_Rotation = Input.GetAxis("Mouse Y");
        // PlayerTransform.transform.Rotate(0, X_Rotation, 0);
        // CameraTransform.transform.Rotate(-Y_Rotation, 0, 0);
        var Theta=PlayerTransform.transform.eulerAngles;


        float y_angleDir = Theta.y * (Mathf.PI / 180.0f);
        float x_angleDir = Theta.x * (Mathf.PI / 180.0f);
        float z_angleDir = Theta.z * (Mathf.PI / 180.0f);
        // Vector3 z_dir1 = new Vector3(Mathf.Sin(z_angleDir),  Mathf.Cos(z_angleDir),0);
        float dir1_x=Mathf.Sin(y_angleDir)*Mathf.Cos(x_angleDir);
        float dir1_y=-Mathf.Sin(x_angleDir);
        float dir1_z=Mathf.Cos(y_angleDir)*Mathf.Cos(x_angleDir);
        float dir2_x=-Mathf.Cos(y_angleDir)*Mathf.Cos(z_angleDir);
        float dir2_y=-Mathf.Sin(z_angleDir);
        float dir2_z=Mathf.Sin(y_angleDir)*Mathf.Cos(z_angleDir);
        var dir1=new Vector3(dir1_x,dir1_y,dir1_z);
        var dir2=new Vector3(dir2_x,dir2_y,dir2_z);
        // 前進
        if (Input.GetKey(KeyCode.W))
        {
            PlayerTransform.transform.position += (dir1) * speed * Time.deltaTime;
        }
        // 右移動
        if (Input.GetKey(KeyCode.A))
        {
            PlayerTransform.transform.position += (dir2) * speed * Time.deltaTime;
        }
        // 左移動
        if (Input.GetKey(KeyCode.D))
        {
            PlayerTransform.transform.position += -(dir2) * speed * Time.deltaTime;
        }
        // 後退
        if (Input.GetKey(KeyCode.S))
        {
            PlayerTransform.transform.position += -(dir1) * speed * Time.deltaTime;
        }

    }
}
