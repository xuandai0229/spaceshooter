using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public RectTransform mask;// Mask của thanh máu
    public Health health;// Thành phần Health của kẻ địch

    private float orginalWidth;// Chiều rộng ban đầu của mask

    private void Start()
    {
        orginalWidth = mask.sizeDelta.x;// Lấy chiều rộng ban đầu của mask
        UpdateHealthVel();// Cập nhật thanh máu ban đầu
        health.OnHealthChanged += UpdateHealthVel;// Đăng ký sự kiện khi máu thay đổi
    }

    private void UpdateHealthVel()
    {
        float scale = (float)health.healthPoint / health.defaultHealthPoint;// Tính tỉ lệ máu còn lại
        mask.sizeDelta = new Vector2(scale * orginalWidth, mask.sizeDelta.y);// Cập nhật kích thước mask theo tỉ lệ máu
    }
}
