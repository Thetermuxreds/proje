using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour 
{
    int can = 50; 
    int mana = 60;
    string isim = "WARWÝCK";
    void Start()
    {   //birinci kýsým
        Debug.Log(can);
        Debug.Log(mana);
        //kontrol
        if (can >= 50 && mana >= 50)
        {
            Debug.Log("kaçtýn " + can + "ve" + mana + "ile hadi gine iyisin");

        }
        else
        {
            Debug.Log("Öldün ");
        }
        //ikinci kýsým 
        for (int i = 0; i <= 5; i++) {

            can--;
            Debug.LogWarning("Karakter saldýrdý");
            Debug.LogWarning("canýn " + can);
        }
        //döngü
        string[] itemler = { "muz","elma","kýlýc"};
        for (int a = 0 ;a <= 2;a++)
        {
            Debug.Log( itemler[a]);
        }
    }

}
