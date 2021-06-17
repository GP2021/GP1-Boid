using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour
{
    Vector3 position; // ボイドの位置
    Vector3 velocity; // ボイドの速度

    void Start()
    {
        // 初期位置をランダム設定
        position.x = Random.Range(-5.0f, 5.0f);
        position.y = Random.Range(-5.0f, 5.0f);
        position.z = Random.Range(-5.0f, 5.0f);
        // 初期速度をランダム設定
        velocity.x = Random.Range(-1.0f, 1.0f);
        velocity.y = Random.Range(-1.0f, 1.0f);
        velocity.z = Random.Range(-1.0f, 1.0f);
    }

    void Update()
    {
        // velocityの修正
        //
        // リーダーを追いかける力を計算
        //
        GameObject leader = GameObject.FindGameObjectWithTag("Leader");
        // リーダーの位置
        Vector3 leaderPos = leader.transform.position;
        // position --> leaderPos
        Vector3 dir = (leaderPos - position).normalized;
        Vector3 force = 2.0f * dir;

        velocity += force;

        // positionの修正
        position = position + velocity * Time.deltaTime;
        transform.position = position;
    }
}
