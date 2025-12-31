using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint; // Máu mặc định
    
    public System.Action onDead;// Sự kiện khi chết
    public System.Action OnHealthChanged; // Sự kiện khi máu thay đổi

    public int healthPoint; // Máu hiện tại

    private void Start()
    {
        healthPoint = defaultHealthPoint; // Khởi tạo máu
        OnHealthChanged?.Invoke(); // Gọi sự kiện khi máu thay đổi lúc bắt đầu
    }

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return; // Không làm gì nếu đã chết
        healthPoint -= damage; // Giảm máu
        OnHealthChanged?.Invoke(); // Gọi sự kiện khi máu thay đổi
        if (healthPoint <= 0) Die(); // Chết nếu máu <= 0
    }

    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation); // Tạo hiệu ứng nổ
        Destroy(explosion, 1f); // Hủy hiệu ứng sau 1 giây
        Destroy(gameObject); // Hủy object
        onDead?.Invoke(); // Gọi sự kiện khi chết nếu có đăng ký
    }
}