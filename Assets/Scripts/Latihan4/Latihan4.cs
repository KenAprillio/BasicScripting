using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan4 : MonoBehaviour
{
    Karakter player1;
    // Start is called before the first frame update
    void Start()
    {
        player1 = new Karakter();
        player1.Name = "Kenobi";
        player1.Health = 600;
        player1.Damage = 100;

        //Menampilkan hasil inisialisasi attribute
        Debug.Log("Name: "+ player1.Name+", Health: "+ player1.Health+", Damage: "+ player1.Damage);

        //Memanggil salah satu method di class karakter
        player1.Jump();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
