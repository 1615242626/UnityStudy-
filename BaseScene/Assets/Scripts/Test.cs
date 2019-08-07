using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //临时的游戏个体
    public GameObject cube;
	// Use this for initialization
	void Start () {
        //设置位置
        transform.position = new Vector3(0,0,5);
        //设置旋转
        //transform.rotation =
        //Quaternion.AngleAxis
        //(45,Vector3.up)*
        // Quaternion.AngleAxis
        // (45,Vector3.right);
        //设置游戏个体的旋转 (欧拉角【万向节死锁】)
        //transform.rotation = 
        //    Quaternion.Euler(45,45,0);
        //transform.eulerAngles = 
        //    new Vector3(45,45,0);
	}
	
	// Update is called once per frame
	void Update ()
    {
        //transform.position += 
        //    new Vector3(0,0,2)*0.2f;
        ////移动（注意自身坐标系，世界坐标系）
        //transform.Translate(Vector3.forward,Space.World);
        //transform.Translate(Vector3.forward, Space.Self);
        //transform.Translate(transform.forward, Space.World);
        ////自身转自身（错误）
        //transform.Translate(transform.forward, Space.Self);
        ////旋转
        //transform.rotation *=
        //    Quaternion.AngleAxis(1,Vector3.up);
        //transform.Rotate(Vector3.up * 5f);
        ////围绕某一个物体进行旋转
        transform.RotateAround
            (cube.transform.position,
            cube.transform.up,20);
        //太阳公转，地球自转加公转（围着太阳）
        //，月球围着地球转（自转）
        //自身转世界的API世界转自身的API
        //transform.TransformDirection();
        //transform.TransformPoint();
        //transform.TransformVector();
        //transform.InverseTransformDirection();

    }
}
 