using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    
    void Start()
    {
        GameContainer<string> t = new GameContainer<string>();
        t.SetItem("Healing Potion");
        Debug.Log($"Stored item: {t.GetItem()}");
        string description = GameUtils.DescribeItem("Healing Potion");
        Debug.Log(description);
        List<int> a =new List<int>();
        
    }


}
