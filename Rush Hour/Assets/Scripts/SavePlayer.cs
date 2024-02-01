using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "SavePlayer", order = 1)]
public class SavePlayer : ScriptableObject
{
    //public int ID;
    //public string username;
    //public int points;
    public List<string> username = new List<string>(5);
    public List<int> score = new List<int>(5);
}
