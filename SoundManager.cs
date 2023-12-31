using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip DestroySE;
    AudioSource audioSource;
    private GameObject[] enemyObject;
    private int EnemyCount;
    private bool StartEnemyCountFlag = true;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Update() //敵撃破時に爆破音を鳴らす
    {
        enemyObject = GameObject.FindGameObjectsWithTag("Enemy");

        if (StartEnemyCountFlag == true) //最初の敵の数を数えて保存
        {
            EnemyCount = enemyObject.Length;
            StartEnemyCountFlag = false;
        }

        if (enemyObject.Length == EnemyCount - 1) //敵の数が一体減ったら音を鳴らす
        {
            audioSource.PlayOneShot(DestroySE);
            EnemyCount--;
        }
    }
}
