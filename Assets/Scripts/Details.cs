using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name { get; set; }
    
    public Character(string name)
    {
        Name = name;
        Debug.Log("The player name is: " + name);
    }
}

public class Details : MonoBehaviour
{
    Character character;
    // Start is called before the first frame update
    void Start()
    {
        character = new Character("Quang");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
