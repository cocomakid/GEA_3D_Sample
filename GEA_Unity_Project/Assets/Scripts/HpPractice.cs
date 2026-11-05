using UnityEngine;

public class HpPractice : MonoBehaviour
{
    public int currentHp;
    public int maxHp;


    [ContextMenu("체력")]
    void ShowHp()
    {
        Debug.Log("Hp: " + 100 / maxHp * currentHp + "%");
    }
}
