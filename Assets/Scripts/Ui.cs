using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ui : MonoBehaviour
{
    public GameObject Baby;
    public Transform SpawnPoint;

    public GameObject window;
    public GameObject eventWindow;
    public TextMeshProUGUI statText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnBaby()
    {
        GameObject gO = Instantiate(Baby, SpawnPoint);
        BabyManager b = gO.GetComponent<BabyManager>(); 
        statText.text = "Int: " + gO.GetComponent<BabyManager>().intelligence + " / " + "Cha: " + gO.GetComponent<BabyManager>().charisma + " / " + "Health: " + gO.GetComponent<BabyManager>().health;
        window.SetActive(true);
    }
    public void CloseWindow()
    {
        window.SetActive(false);
    }
    public void LeftButton()
    {
        eventWindow.SetActive(false);
    }
    public void RightButton()
    {
        eventWindow.SetActive(false);
    }
}
