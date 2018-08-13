using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public List<CollectableObject> collectables;

    public static Inventory Instance;

	private void Start()
	{
        Instance = this;
        collectables = new List<CollectableObject>();
	}

    public bool Check(string name){

        foreach(CollectableObject c in collectables){
            if (c.name == name){
                return true;
            }
        }
        return false;
    }

    public void Add(CollectableObject c){
        collectables.Add(c);
    }

    public void Remove(string name)
    {
        foreach (CollectableObject c in collectables)
        {
            if (c.name == name)
            {
                collectables.Remove(c);
                return;
            }
        }
    }
}
