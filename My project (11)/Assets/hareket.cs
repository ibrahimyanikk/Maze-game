using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private float hiz = 10;
    public UnityEngine.UI.Text zaman, can,bitis;
    float zamansayaci = 100f;
    float cansayaci = 3f;
    bool oyundevam = true;
    bool oyuntamam = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (oyundevam)
        {
            zamansayaci -= Time.deltaTime;
            zaman.text = (int)zamansayaci + "";
        }
        else
        {
            bitis.text = "GAME OVER";
        }
        if(zamansayaci==0)
        {
            oyundevam = false;
        }
        if(oyuntamam==true)
        {
            bitis.text = "helal len";
        }
        
    }
    private void FixedUpdate()
    {
        if (oyundevam)
        {
            float yatay = Input.GetAxis("Horizontal");
            float dikey = Input.GetAxis("Vertical");
            Vector3 kuvvet = new Vector3(-dikey, 0, yatay);
            rb.AddForce(kuvvet * hiz);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
    private void OnCollisionEnter(Collision cls)
    {
        string objismi = cls.gameObject.name;
        if(objismi.Equals("bitme"))
        {
            oyuntamam = true;
        }
        else if(!objismi.Equals("plane"))
        {
            cansayaci -= 1;
            can.text = cansayaci+"";
        }
        if(cansayaci==0)
        {
            oyundevam = false;        }
    }
}
