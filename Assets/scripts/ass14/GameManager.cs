using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    
    void Start()
    {
        Player1 tefo = new Player1("tefo", 80);
        Enemy ali = new Enemy("ali", 60);

        Debug.Log(tefo.Name);
        Debug.Log(tefo.Health);
        Debug.Log(ali.Name);
        Debug.Log(ali.Health);
        Debug.Log(tefo.Heal(30));
        Debug.Log(ali.Attack(tefo,35));
        



    }


}
