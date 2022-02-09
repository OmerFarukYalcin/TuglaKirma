using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tugla : MonoBehaviour
{
    public GameObject kirilmaEfekti;
    public AudioClip sesEfektiTuglaKýrýlma;
    public AudioClip sesEfektiTuglaCarpma;
    public Sprite[] tuglaSprite;
    private int maxCarpmaSayisi;
    private int CarpmaSayisi;
    public static int toplamTuglaSayisi;
    private Puan puanScripti;
    // Start is called before the first frame update
    void Start()
    {
        maxCarpmaSayisi = tuglaSprite.Length+1;
        toplamTuglaSayisi++;
        puanScripti = GameObject.FindObjectOfType<Puan>().GetComponent<Puan>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("top"))
        {
            puanScripti.puanArttir();
            CarpmaSayisi++;
            if (CarpmaSayisi >= maxCarpmaSayisi)
            {
                toplamTuglaSayisi--;
                Debug.Log(toplamTuglaSayisi);
                if (toplamTuglaSayisi <= 0)
                {
                    GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().birSonrakiSahne();
                }
                Vector3 pos = collision.contacts[0].point;
                GameObject go = Instantiate(kirilmaEfekti, pos, Quaternion.identity);
                Color tuglaRengi = GetComponent<SpriteRenderer>().color;
                go.GetComponent<ParticleSystemRenderer>().material.color = tuglaRengi;
                Destroy(go, 1f);
                AudioSource.PlayClipAtPoint(sesEfektiTuglaKýrýlma, transform.position);
                Destroy(gameObject);
            }
            else
            {
                AudioSource.PlayClipAtPoint(sesEfektiTuglaCarpma, transform.position);
                GetComponent<SpriteRenderer>().sprite=tuglaSprite[CarpmaSayisi-1];
            }
        }
    }
}
