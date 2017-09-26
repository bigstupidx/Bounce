using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class StarController : MonoBehaviour
{


    public Button btnLv1;
    public Button btnLv2;
    public Button btnLv3;
    public Button btnLv4;
    public Button btnLv5;
    public Button btnLv6;
    public Button btnLv7;
    public Button btnLv8;
    public Button btnLv9;
    public Button btnLv10;
    public Button btnLv11;

    public Sprite block;
    public Sprite star;

    public GameObject star11;
    public GameObject star12;
    public GameObject star13;
    public GameObject star21;
    public GameObject star22;
    public GameObject star23;
    public GameObject star31;
    public GameObject star32;
    public GameObject star33;
    public GameObject star41;
    public GameObject star42;
    public GameObject star43;
    public GameObject star51;
    public GameObject star52;
    public GameObject star53;
    public GameObject star61;
    public GameObject star62;
    public GameObject star63;
    public GameObject star71;
    public GameObject star72;
    public GameObject star73;
    public GameObject star81;
    public GameObject star82;
    public GameObject star83;
    public GameObject star91;
    public GameObject star92;
    public GameObject star93;
    public GameObject star101;
    public GameObject star102;
    public GameObject star103;
    public GameObject star111;
    public GameObject star112;
    public GameObject star113;


    // Use this for initialization
    void Start()
    {
        setStar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setStar()
    {
        setStarLv1();
        setStarLv2();
        setStarLv3();
        setStarLv4();
        setStarLv5();
        setStarLv6();
        setStarLv7();
        setStarLv8();
        setStarLv9();
        setStarLv10();
        setStarLv11();
    }

    void setStarLv1()
    {

        if (PlayerPrefs.GetInt("1") == 3)
        {
            btnLv1.GetComponent<Image>().sprite = block;
            star11.GetComponent<Image>().sprite = star;
            star12.GetComponent<Image>().sprite = star;
            star13.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("1") == 2)
        {
            btnLv1.GetComponent<Image>().sprite = block;
            star11.GetComponent<Image>().sprite = star;
            star12.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("1") == 1)
        {
            btnLv1.GetComponent<Image>().sprite = block;
            star11.GetComponent<Image>().sprite = star;
        }
    }

    void setStarLv2()
    {

        if (PlayerPrefs.GetInt("2") == 3)
        {
            btnLv2.GetComponent<Image>().sprite = block;
            star21.GetComponent<Image>().sprite = star;
            star22.GetComponent<Image>().sprite = star;
            star23.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("2") == 2)
        {
            btnLv2.GetComponent<Image>().sprite = block;
            star21.GetComponent<Image>().sprite = star;
            star22.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("2") == 1)
        {
            btnLv2.GetComponent<Image>().sprite = block;
            star21.GetComponent<Image>().sprite = star;
        }
    }

    void setStarLv3()
    {

        if (PlayerPrefs.GetInt("3") == 3)
        {
            btnLv3.GetComponent<Image>().sprite = block;
            star31.GetComponent<Image>().sprite = star;
            star32.GetComponent<Image>().sprite = star;
            star33.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("3") == 2)
        {
            btnLv3.GetComponent<Image>().sprite = block;
            star31.GetComponent<Image>().sprite = star;
            star32.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("3") == 1)
        {
            btnLv3.GetComponent<Image>().sprite = block;
            star31.GetComponent<Image>().sprite = star;
        }
    }

    void setStarLv4()
    {

        if (PlayerPrefs.GetInt("4") == 3)
        {
            btnLv4.GetComponent<Image>().sprite = block;
            star41.GetComponent<Image>().sprite = star;
            star42.GetComponent<Image>().sprite = star;
            star43.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("4") == 2)
        {
            btnLv4.GetComponent<Image>().sprite = block;
            star41.GetComponent<Image>().sprite = star;
            star42.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("4") == 1)
        {
            btnLv4.GetComponent<Image>().sprite = block;
            star41.GetComponent<Image>().sprite = star;
        }
    }

    void setStarLv5()
    {

        if (PlayerPrefs.GetInt("5") == 3)
        {
            btnLv5.GetComponent<Image>().sprite = block;
            star51.GetComponent<Image>().sprite = star;
            star52.GetComponent<Image>().sprite = star;
            star53.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("5") == 2)
        {
            btnLv5.GetComponent<Image>().sprite = block;
            star51.GetComponent<Image>().sprite = star;
            star52.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("5") == 1)
        {
            btnLv5.GetComponent<Image>().sprite = block;
            star51.GetComponent<Image>().sprite = star;
        }
    }

    void setStarLv6()
    {

        if (PlayerPrefs.GetInt("6") == 3)
        {
            btnLv6.GetComponent<Image>().sprite = block;
            star61.GetComponent<Image>().sprite = star;
            star62.GetComponent<Image>().sprite = star;
            star63.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("6") == 2)
        {
            btnLv6.GetComponent<Image>().sprite = block;
            star61.GetComponent<Image>().sprite = star;
            star62.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("6") == 1)
        {
            btnLv6.GetComponent<Image>().sprite = block;
            star61.GetComponent<Image>().sprite = star;
        }
    }

    void setStarLv7()
    {

        if (PlayerPrefs.GetInt("7") == 3)
        {
            btnLv7.GetComponent<Image>().sprite = block;
            star71.GetComponent<Image>().sprite = star;
            star72.GetComponent<Image>().sprite = star;
            star73.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("7") == 2)
        {
            btnLv7.GetComponent<Image>().sprite = block;
            star71.GetComponent<Image>().sprite = star;
            star72.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("7") == 1)
        {
            btnLv7.GetComponent<Image>().sprite = block;
            star71.GetComponent<Image>().sprite = star;
        }
    }

    void setStarLv8()
    {

        if (PlayerPrefs.GetInt("8") == 3)
        {
            btnLv8.GetComponent<Image>().sprite = block;
            star81.GetComponent<Image>().sprite = star;
            star82.GetComponent<Image>().sprite = star;
            star83.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("8") == 2)
        {
            btnLv8.GetComponent<Image>().sprite = block;
            star81.GetComponent<Image>().sprite = star;
            star82.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("8") == 1)
        {
            btnLv8.GetComponent<Image>().sprite = block;
            star81.GetComponent<Image>().sprite = star;
        }
    }

    void setStarLv9()
    {

        if (PlayerPrefs.GetInt("9") == 3)
        {
            btnLv9.GetComponent<Image>().sprite = block;
            star91.GetComponent<Image>().sprite = star;
            star92.GetComponent<Image>().sprite = star;
            star93.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("9") == 2)
        {
            btnLv9.GetComponent<Image>().sprite = block;
            star91.GetComponent<Image>().sprite = star;
            star92.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("9") == 1)
        {
            btnLv9.GetComponent<Image>().sprite = block;
            star91.GetComponent<Image>().sprite = star;
        }
    }

    void setStarLv10()
    {

        if (PlayerPrefs.GetInt("10") == 3)
        {
            btnLv10.GetComponent<Image>().sprite = block;
            star101.GetComponent<Image>().sprite = star;
            star102.GetComponent<Image>().sprite = star;
            star103.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("10") == 2)
        {
            btnLv10.GetComponent<Image>().sprite = block;
            star101.GetComponent<Image>().sprite = star;
            star102.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("10") == 1)
        {
            btnLv10.GetComponent<Image>().sprite = block;
            star101.GetComponent<Image>().sprite = star;
        }
    }

    void setStarLv11()
    {

        if (PlayerPrefs.GetInt("11") == 3)
        {
            btnLv11.GetComponent<Image>().sprite = block;
            star111.GetComponent<Image>().sprite = star;
            star112.GetComponent<Image>().sprite = star;
            star113.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("11") == 2)
        {
            btnLv11.GetComponent<Image>().sprite = block;
            star111.GetComponent<Image>().sprite = star;
            star112.GetComponent<Image>().sprite = star;
        }
        else if (PlayerPrefs.GetInt("11") == 1)
        {
            btnLv11.GetComponent<Image>().sprite = block;
            star111.GetComponent<Image>().sprite = star;
        }
    }
}
