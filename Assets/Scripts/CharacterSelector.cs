using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : Object
{
    public static void RandomSelector() 
    {
        int i = Random.Range(0, 16);
        PlayerPrefs.SetInt("Character", i);
        GameObject Character_skin = GameObject.Find("Canvas").GetComponent<Buttons>().Character[i];
        GameObject Parent = GameObject.Find("Center");
        GameObject spawn_character = Instantiate(Character_skin, Vector3.zero, Quaternion.identity);
        spawn_character.transform.parent = Parent.transform;
        if(Parent.transform.childCount>=2)
        {
            Destroy(Parent.transform.GetChild(0).gameObject);
        }
    }
    public static void Start_Game() 
    {
        int i = PlayerPrefs.GetInt("Character");
        GameObject Character_skin = GameObject.Find("Canvas").GetComponent<Buttons>().Character[i];
        Instantiate(Character_skin, Vector3.zero, Quaternion.identity);
    }
}
