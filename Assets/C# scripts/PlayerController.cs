using UnityEngine;

public class Doodler : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject enemyPrefab;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        // �����������, ��� bullet ����� ������ � �������, ������� ������� ��� � ����������� �����, ������� ����� �������
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject); // ���������� �����
        }
    }
}