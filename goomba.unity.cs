using UnityEngine;
using System.Collections;

public class GOOMBAAAAAAAAAAA : MonoBehaviour
{
    string Str = "";
    void Awake()
    {
    Str += "GOOMB";
    }
    void Update()
    {
    Str += "A";
    }
    void OnApplicationQuit()
    {
        Debug.Log(Str);
    }
}
