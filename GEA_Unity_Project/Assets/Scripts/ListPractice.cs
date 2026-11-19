using System.Collections.Generic;

using UnityEngine;

public class ListPractice : MonoBehaviour
{
    [ContextMenu("List 실습")]
    void ShowInventory()
    {
        List<string> inventory = new List<string>();
        inventory.Add("포션");
        inventory.Add("화살");
        inventory.Add("포션");
        inventory.Add("열쇠");
        inventory.Remove("포션");

        Debug.Log("아이템: " + inventory.Count);
        Debug.Log("열쇠 있음: " + inventory.Contains("열쇠"));
        Debug.Log("0번: " + inventory[0]);
        Debug.Log("1번: " + inventory[1]);
        Debug.Log("2번: " + inventory[2]);
    }
}
