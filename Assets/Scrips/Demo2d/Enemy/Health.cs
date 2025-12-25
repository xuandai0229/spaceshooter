using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint; // Máu mặc định
    protected int healthPoint; // Máu hiện tại

    private void Start()
    {
        healthPoint = defaultHealthPoint; // Khởi tạo máu
    }

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return; // Không làm gì nếu đã chết
        healthPoint -= damage; // Giảm máu
        if (healthPoint <= 0) Die(); // Chết nếu máu <= 0
    }

    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation); // Tạo hiệu ứng nổ
        Destroy(explosion, 1f); // Hủy hiệu ứng sau 1 giây
        Destroy(gameObject); // Hủy object
    }
}