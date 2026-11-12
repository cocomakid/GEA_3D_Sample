using Unity.VisualScripting;
using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    public int attack; 
    public int defence;
    public bool isCtritical;
    public bool targetlsBoss;


    [ContextMenu("데미지")]
    void boss()
    {
        attack = attack - defence;

        if (isCtritical)
        {
            attack = attack * 2;
        }

        if (targetlsBoss)
        {
            attack = attack / 2;
        }

        if (attack < 0)
        {
            attack = 1;
        }

        Debug.Log(attack);

    }
}
