using Unity.VisualScripting;
using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    [ContextMenu("예측3")]
    void Predict3()
    {
        int a = 1;
        int b = 2;
        Debug.Log("합: " + a + b);
        Debug.Log("합: " + (a + b));
        Debug.Log(a + b + "점");
        Debug.Log((a + b) + "점");
        Debug.Log("HP" + 7 / 2);
    }

    /*public int gold = 100;
    public int potion = 3;

    [ContextMenu("골드 보기")]
    void ShowGold()
    {
        Debug.Log(gold);
    }*/ // gold

    /*public int attack = 10;
    int killCount = 0;

    [ContextMenu("Hello")]
    void Hello()
    {
        Debug.Log("Hello");
    }

    [ContextMenu("Test1")]
    void Test1()
    {
        int hp = 10;
        Debug.Log(hp);
    }

    [ContextMenu("Test2")]
    void Test2()
    {
        int hp = 7;
        Debug.Log(hp);
    }

    void Start()
    {
        Debug.Log(attack);
    }

    void Hit()
    {
        killCount = killCount + 1;
    }*/ // practice
}
