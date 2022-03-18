using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Transform player;
    Vector3 tempPos;

    [SerializeField] float minX = 0, maxX = 17.5f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // 當 update 全部完成才執行
    void LateUpdate()
    {
        //player物件消失
        if (player == null)
            return;

        // 初始化相機位置
        tempPos = transform.position;
        tempPos.x = player.position.x;
        //設定相機範圍
        if (tempPos.x > maxX)
            tempPos.x = maxX;

        if (tempPos.x < minX)
            tempPos.x = minX;
        // 移動相機
        transform.position = tempPos;
    }
}
