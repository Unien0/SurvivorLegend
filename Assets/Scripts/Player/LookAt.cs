using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // 获取鼠标位置
        Vector3 mousePos = Input.mousePosition;
        // 将鼠标位置转换为世界空间坐标
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10f)); // 10f 是物体距离摄像机的距离，根据实际情况调整

        // 计算物体朝向
        Vector3 lookDir = mouseWorldPos - transform.position;
        lookDir.z = 0; // 保持物体在2D平面内旋转
        transform.up = lookDir.normalized; // 使用transform.up来设置物体朝向
    }
}
