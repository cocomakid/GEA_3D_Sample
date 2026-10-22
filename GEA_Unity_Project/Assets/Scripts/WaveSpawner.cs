using UnityEngine;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Transform[] spawnPoints;
    public int firstCount = 3;    // 1웨이브 마릿수
    public int addPerWave = 2;    // 웨이브마다 추가
    public float spawnGap = 0.5f; // 한 마리씩 나오는 간격
    public TMP_Text waveText;     // 비워 둬도 됨
    int wave = 0;
    int toSpawn = 0;              // 이번 웨이브에 남은 수
    float timer;

    public int lastWave = 0;   // 0 이면 끝없음


    void SpawnOne()
    {
        int e = Random.Range(0, enemyPrefabs.Length);
        int s = Random.Range(0, spawnPoints.Length);
        Vector3 pos = spawnPoints[s].position;
        Instantiate(enemyPrefabs[e], pos,
            Quaternion.identity);
    }

    void Update()
    {
        if (toSpawn > 0)    // 내보내는 중
        {
            timer += Time.deltaTime;
            if (timer < spawnGap) return;
            timer = 0f;
            SpawnOne();
            toSpawn--;
            return;
        }
        int alive = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (alive > 0) return;            // 다 잡을 때까지 대기

        if (lastWave > 0 && wave == lastWave)
        {
            GameManager.Instance.GameClear();
            enabled = false;
            return;
        }

        wave++;
        toSpawn = firstCount + addPerWave * (wave - 1);
        if (waveText != null) waveText.text = "WAVE " + wave;
    }
}


    
