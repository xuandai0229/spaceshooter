using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefab;

    private void OnTriggerEnter2D(Collider2D collision) =>  Die();


    void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);//dung de tao hieu ung no khi ke dich chet,tai ve vi tri ke dich va giu nguyen huong cua no
        Destroy(explosion, 1f);//hieu ung no se bi huy sau 1 giay
        Destroy(gameObject);//huy doi tuong ke dich
    }

}
