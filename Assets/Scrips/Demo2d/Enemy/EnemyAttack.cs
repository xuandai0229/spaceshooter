using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EnemyHeath heath;// tham chiếu đến EnemyHealth để truy cập máu của kẻ địch
    public int damege;// sat thuong

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var playerHealth = collision.GetComponent<PlayerHeath>();// lấy component PlayerHealth từ đối tượng va chạm
        if (playerHealth != null)// nếu có component PlayerHealth
        {
            playerHealth.TakeDamage(damege);// gây sát thương cho người chơi
            heath.TakeDamage(1000);// kẻ địch tự sát sau khi tấn công

        }
    }
}
