using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f; // Sửa "seed" thành "speed" để đúng ngữ nghĩa
    public int damage;

    void Start()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<Health>(); // Sử dụng Health thay vì EnemyHealth để linh hoạt hơn
        if (enemy != null)
        {
            enemy.TakeDamage(damage); // Gây sát thương nếu có component Health
        }
        Destroy(gameObject); // Hủy viên đạn sau khi va chạm
    }

    void Update()
    {
        var newPosition = transform.position; // Sửa "newPotion" thành "newPosition" để đúng ngữ nghĩa
        newPosition.y += speed * Time.deltaTime; // Di chuyển viên đạn lên trên
        transform.position = newPosition; // Cập nhật vị trí mới
    }
}