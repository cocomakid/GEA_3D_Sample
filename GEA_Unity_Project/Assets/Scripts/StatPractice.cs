using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string playerName = "Player";
    public int level = 1;
    public float attack = 10.0f;
    public bool isBoss = true;

    [ContextMenu("Show Stats")]
    void ShowStats()
    {
        Debug.Log("Name: " + playerName);
        Debug.Log("Level: " + level);
        Debug.Log("Attack: " + attack);
        Debug.Log("Is Boss: " + isBoss);
    }




    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
