using UnityEngine;

public class PlayerHeath : Health
{
    protected override void Die()
    {
        // Gọi hàm Die của lớp cha để thực hiện các hành động chung khi chết
        base.Die();
        // Thêm các hành động đặc biệt cho người chơi khi chết ở đây (nếu cần)

    }
}
