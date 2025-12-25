using UnityEngine;

public class Bullet : MonoBehaviour
{
    public  float seed = 5f;
    void Start()
    {
        
    }

   
    void Update()
    {
        var newPotion = transform.position;//dung de lay vi tri hien tai
        newPotion.y += seed * Time.deltaTime; //di chuyen vien dan len tren theo truc y
        transform.position = newPotion;//cap nhat lai vi tri moi cho vien dan


    }
}
