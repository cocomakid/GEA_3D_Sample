using NUnit.Framework;
using UnityEngine;

public class ForeachPractice : MonoBehaviour
{
    public int[] monsterHps = { 0, 35, 0, 80, 12 };
    [ContextMenu("foreach 실습")]
    void CountAlive()
    {
        int hps = 0;
        int aliveCount = 0;
        foreach (int hp in monsterHps)
        {
            if (hp > 0)
            {
                aliveCount++;
                hps += hp;
            }
        }
        Debug.Log("살아있는 몬스터 수: " + aliveCount);
        Debug.Log("남은 체력 합: " + hps);
    }

}
