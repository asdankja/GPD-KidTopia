using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyStats : MonoBehaviour
{
    private int intelligence, charisma, health;

    void Start()
    {
        intelligence = Random.Range(0, 100); //how smort
        charisma = Random.Range(0, 100); // how well they can bargain etc
        health = Random.Range(0, 100); // life expectancy


        Debug.Log("Int " + intelligence + "\n"
            +"Charisma " + charisma + "\n"
            + "Health " + health);
    }
}
