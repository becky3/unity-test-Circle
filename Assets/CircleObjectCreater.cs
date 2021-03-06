﻿using UnityEngine;

public class CircleObjectCreater : MonoBehaviour {

    [SerializeField]
    private GameObject createObject; // 生成するオブジェクト

    [SerializeField]
    private int itemCount = 40; // 生成するオブジェクトの数

    [SerializeField]
    private float radius = 5f; // 半径

    [SerializeField]
    private float repeat = 2f; // 何周期するか

    void Start () {

        var oneCycle = 2.0f * Mathf.PI; // sin の周期は 2π

        for (var i = 0; i < itemCount; ++i)
        {

            var point = ((float)i / itemCount) * oneCycle; // 周期の位置 (1.0 = 100% の時 2π となる)
            var repeatPoint = point * repeat; // 繰り返し位置

            var x = Mathf.Cos(repeatPoint) * radius;
            var y = Mathf.Sin(repeatPoint) * radius;

            var position = new Vector3(x, y);

            Instantiate(
                createObject, 
                position, 
                Quaternion.identity, 
                transform
            );

        }

		
	}
	
}
