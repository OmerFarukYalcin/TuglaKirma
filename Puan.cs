using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puan : MonoBehaviour
{
    private int puan;

    public void puanArttir()
    {
        puan++;
    }

    public int puaniAl()
    {
        return puan;
    }

    public void PuanSifirla()
    {
        puan = 0;
    }
}
