using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public float shootingInterval;//thoi gian giua cac lan ban dan
    

    public Vector3 bulletOffset;//vi tri ban dan so voi nguoi choi
    public float lastBulletTime;//thoi gian ban dan cuoi cung
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            UpdateFiring();
        }
    }

    private void UpdateFiring()
    {
        if(Time.time - lastBulletTime > shootingInterval)//kiem tra thoi gian giua cac lan ban dan
        {
            ShooBullet();
            lastBulletTime = Time.time;//cap nhat thoi gian ban dan cuoi cung
        }
        {

        }
    }

    private void ShooBullet()
    {
        var buller = Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation);
        //tao vien dan moi o vi tri nguoi choi + offset, voi huong goc giong nguoi choi
    }
}
