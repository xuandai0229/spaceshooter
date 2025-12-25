using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public float shootingInterval;//thoi gian giua cac lan ban dan
    public float lastBulletTime;//thoi gian ban dan cuoi cung
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            if(Time.time - lastBulletTime >= shootingInterval)//kiem tra thoi gian giua cac lan ban dan
            {
                ShooBullet();
                lastBulletTime = Time.time;//cap nhat thoi gian ban dan cuoi cung
            }
        }
    }

    private void ShooBullet()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);//tao vien dan moi o vi tri va huong cua nguoi choi
    }
}
