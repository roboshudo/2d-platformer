using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProjectilesPickup : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("플레이어가 발사체 픽업(Projectile Pickup)와 충돌했습니다.");

            // 발사체 획득 처리.
            PlayerController player = collision.collider.gameObject.GetComponent<PlayerController>();
            player.hasProjectile = true;

            // 발사체 소멸 처리.
            GameObject.Destroy(gameObject);

        }

    }

}
