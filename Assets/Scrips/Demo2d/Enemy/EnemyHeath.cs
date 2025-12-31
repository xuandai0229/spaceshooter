using UnityEngine;

public class EnemyHeath : Health
{

    public static int livingEnemyCount = 0; // Biến đếm số kẻ thù còn sống

    private void Awake() => livingEnemyCount++; // Tăng biến đếm khi kẻ thù xuất hiện

    protected override void Die()
    {
        livingEnemyCount--; // Giảm biến đếm khi kẻ thù chết
        // Gọi hàm Die của lớp cha để thực hiện các hành động chung khi chết
        base.Die();

        // Thêm các hành động đặc biệt cho kẻ thù khi chết ở đây (nếu cần)
        
    }
}
