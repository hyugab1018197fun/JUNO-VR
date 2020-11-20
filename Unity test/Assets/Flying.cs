using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public float MovementSpeed = 100f;          // 通常時の進行速度
    public float MaxMovementSpeed = 1000f;      // ブースト時の進行速度
    public float RotationSpeed = 100f;          // 回転速度

    void Start()
    {
    }

    void Update()
    {
        UpdatePosition();
    }

    void UpdatePosition()
    {

        Quaternion AddRot = Quaternion.identity;
        float yaw = 0;
        float pitch = 0;
        float roll = 0;

        // 縦回転
        yaw = Input.GetAxisRaw("Horizontal") * (Time.fixedDeltaTime * RotationSpeed);

        // 横回転
        pitch = Input.GetAxisRaw("Vertical") * (Time.fixedDeltaTime * RotationSpeed);

        // 軸回転
        if (Input.GetAxisRaw("roll_R") < 0.8)
        {
            roll = Input.GetAxisRaw("roll_R") * (Time.fixedDeltaTime * RotationSpeed);
        }
        else if (Input.GetAxisRaw("roll_L") < 0.8)
        {
            roll = -Input.GetAxisRaw("roll_L") * (Time.fixedDeltaTime * RotationSpeed);
        }

        AddRot.eulerAngles = new Vector3(-pitch, yaw, -roll);
        GetComponent<Rigidbody>().rotation *= AddRot;

        Vector3 AddPos = Vector3.zero;
        Vector3 RLPos = Vector3.zero;
        // 左
        if (Input.GetAxisRaw("Mouse X") < -0.1)
        {
            RLPos = Vector3.left;
        }
        // 右
        else if (Input.GetAxisRaw("Mouse X") > 0.1)
        {
            RLPos = Vector3.right;
        }

        // 前進
        if (Input.GetAxisRaw("Mouse Y") < -0.1)
        {
            AddPos = Vector3.forward;
        }
        // 後進
        else if (Input.GetAxisRaw("Mouse Y") > 0.1)
        {
            AddPos = Vector3.back;
        }

        AddPos = GetComponent<Rigidbody>().rotation * (AddPos + RLPos);

        // ブースト
        if (Input.GetButton("Boost"))
        {
            GetComponent<Rigidbody>().velocity = AddPos * (Time.fixedDeltaTime * MaxMovementSpeed);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = AddPos * (Time.fixedDeltaTime * MovementSpeed);
        }
    }
}