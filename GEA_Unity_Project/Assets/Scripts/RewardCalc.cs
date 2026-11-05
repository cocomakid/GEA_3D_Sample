using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725, gold = 1234, members = 4, kills = 7, expPerKill = 35, totalDamage = 250, hits = 20;

    public float expRate = 1.5f;

    [ContextMenu("정산")]
    void CalcReward()
    {
        int playMinutes = playSeconds / 60;
        int playHours = playMinutes / 60;
        int goldPerMember = gold / members;
        int exp = kills * expPerKill;
        int totalExp = (int)(exp * expRate);
        int levelUp = exp / 100;
        float avgDamage = (float)totalDamage / hits;
        Debug.Log(playSeconds + "+" + playMinutes + "+" + playHours);
        Debug.Log("플레이 시간: " + playHours + "시간" + (playMinutes % 60) + "분 " + (playSeconds % 60) + "초");
        Debug.Log(playHours + ":" + (playMinutes % 60 / 10) + (playMinutes % 60 % 10) + ":" + (playMinutes % 60 / 10) + (playSeconds % 60));
        Debug.Log("획득 골드: " + gold);
        Debug.Log("멤버당 골드: " + goldPerMember + ", 리더보너스 : " + (gold % members));
        Debug.Log("획득 경험치: " + totalExp + "(기본)" + exp);
        Debug.Log("레벨: " + levelUp + ", 다음 레벨까지: " + (100 - (totalExp % 100)));
        Debug.Log("평균 데미지: " + avgDamage);
    }
}
