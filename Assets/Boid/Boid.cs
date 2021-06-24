using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour
{
    Vector3 position; // ボイドの位置
    Vector3 velocity; // ボイドの速度
    float maxSpeed; // ボイドの最大速度

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
        // 最大速度をボイドごとにランダム設定
        maxSpeed = Random.Range(3.0f, 10.0f);
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
        Vector3 diff = leaderPos - position;
        Vector3 dir = diff.normalized;
        float dist  = diff.magnitude;
        Vector3 force = dist * dist * dir; // 距離の二乗に応じた追跡力
        velocity += force;

        //
        // 分離ルール
        //
        GameObject[] boids = GameObject.FindGameObjectsWithTag("Boid");
        for (int i = 0; i < boids.Length; ++i)
        {
            //boids[i].transform.position;
            //position;
            // をもとに、分離する力をもとめて、velocityを更新

            // HINT 1: boids[i] のなかに、自分自身も含まれる
            //  = 距離ゼロになったら分離力の計算から除外
            //
            // HINT 2: 一定以上の距離になったら計算から除外
        }

        // 速度の修正（clamp）
        float speed = Mathf.Clamp(velocity.magnitude, 0.0f, maxSpeed);
        velocity = velocity.normalized * speed;
        // positionの修正
        position = position + velocity * Time.deltaTime;
        transform.position = position;
    }
}
