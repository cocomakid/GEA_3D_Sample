using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    [ContextMenu("계단")]
    void star()
    {
        string result = "";
        for (int i = 0; i <= 3; i++)
        {
            for (int j = 0; j < i; j++)
            {
                result += "*";
                
            }
            result += "\n";
        }
        Debug.Log(result);
    }

}
