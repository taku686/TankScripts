using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rader : MonoBehaviour
{
     private Transform target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // 「root」を使うと「親（最上位の親）」の情報を取得することができる（ポイント）
            // LookAt()メソッドは指定した方向にオブジェクトの向きを回転させることができる（ポイント）
            transform.root.LookAt(target);
        }
    }
}
