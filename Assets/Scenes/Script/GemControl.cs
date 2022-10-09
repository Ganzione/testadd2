using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemControl : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        // 프레임마다 등속으로 낙하시킨다
        transform.Translate(0, -0.01f, 0);

        //화면 밖으로 나오면 오브젝트 소멸시킴
        if (transform.position.y < -7.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;              // 젬의 중심 좌표
        Vector2 p2 = this.player.transform.position;  // 플레이어의 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;  // 젬의 반경
        float r2 = 0.5f;  // 플레이어의 반경

        if (d < r1 + r2)
        {
            // 충돌한 경우는 젬을 지운다
            Destroy(gameObject);
        }
    }
}
