using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour 
{
    int can = 50; 
    int mana = 60;
    string isim = "WARW�CK";
    void Start()
    {   //birinci k�s�m
        Debug.Log(can);
        Debug.Log(mana);
        //kontrol
        if (can >= 50 && mana >= 50)
        {
            Debug.Log("ka�t�n " + can + "ve" + mana + "ile hadi gine iyisin");

        }
        else
        {
            Debug.Log("�ld�n ");
        }
        //ikinci k�s�m 
        for (int i = 0; i <= 5; i++) {

            can--;
            Debug.LogWarning("Karakter sald�rd�");
            Debug.LogWarning("can�n " + can);
        }
        //d�ng�
        string[] itemler = { "muz","elma","k�l�c"};
        for (int a = 0 ;a <= 2;a++)
        {
            Debug.Log( itemler[a]);
        }
    }

}
