using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mabi_trade_main : MonoBehaviour
{
    struct Player
    {
        public int money;
        public int have_weight;
        public int slot;
    }
    struct Goods
    {
        public string name;
        public int price;
        public int weight;
        public int bundle;
        public int benefit;
    }
    // Start is called before the first frame update
    void Start()
    {
        Goods g1 = new Goods();
        g1.name = "posion 1";
        g1.price = 15;
        g1.weight = 1;
        g1.bundle = 35;
        g1.benefit = 27;

        Goods g2 = new Goods();
        g2.name = "posion 2";
        g2.price = 32;
        g2.weight = 1;
        g2.bundle = 30;
        g2.benefit = 34;

        Player p = new Player();
        p.money = 330000;
        p.have_weight = 900;
        p.slot = 8;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
