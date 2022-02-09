using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunBitti : MonoBehaviour
{
    public UnityEngine.UI.Text puanText;
    // Start is called before the first frame update
    void Start()
    {
        puanText.text = "Puanýnýz:" + GameObject.FindObjectOfType<Puan>().GetComponent<Puan>().puaniAl();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnaSahneyeGec()
    {
        SceneManager.LoadScene(0);
    }
}
