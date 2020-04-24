using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int mp = 53;
    
    public void Magic()
    {

        if(mp >= 5)
        {
        this.mp -= 5;
        int magic = this.mp;

        Debug.Log("魔法攻撃をした。残りMPは" + magic);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
} 

public class Test : MonoBehaviour {

    // Use this for initialization

    void Start()
    {
        int[] array = {20, 30, 40, 80, 90};

        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for(int t = 5-1; t >= 0; t--)
        {
            Debug.Log(array[t]);
        }
        Boss magic = new Boss();

        magic.Magic();

        for(int t = 0; t <= 10; t++)
        {
            magic.Magic();
        }
        magic.Magic();
    }

}



