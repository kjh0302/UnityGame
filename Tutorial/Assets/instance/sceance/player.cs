using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stat
{
    public stat()
    {
        Debug.Log("stat ����");
    }
}

public class player : MonoBehaviour
{
    #region ���� ������
    // Ŭ���� ���ο� ���ԵǾ� �ִ� �Ӽ��� ���� ������
    // �����ϴ� �������Դϴ�.
    stat stat = new stat();

    // public
    // Ŭ���� ���ο� �ڱⰡ ����ϰ� �ִ� Ŭ���� �׸���
    // Ŭ���� �ܺο����� ������ ����ϴ� �������Դϴ�.
    public int health = 100;

    // private
    // Ŭ���� ���ο����� ������ ����ϴ� �������Դϴ�.
    private float speed;

    // ���� �����ڸ� �������� ������ �⺻ ���� ������(private)�� �����˴ϴ�.
    Vector3 direction;

    #endregion


    // start( ) : ���� ������Ʈ�� �����Ǿ��� ��, �� �ѹ��� ȣ��Ǹ�
    //           ��ũ��Ʈ�� ��Ȱ��ȭ�Ǿ��� �� ȣ����� �ʽ��ϴ�.
    private void Start()
    {
        speed = 5.0f;
    }

    // start( ) : �� �����Ӹ��� ����Ǵ� �̺�Ʈ �Լ��Դϴ�.
    private void Update()
    {
        // p = p0 + vt   (p0 : ���� ��ġ   v : ����� ũ��    t : �ð�)
        // Input.GetAxis : -1 ~ 1 ������ ���� ��ȯ�ϴ� �Լ��Դϴ�.
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        // ������ ����ȭ
        direction.Normalize();

        transform.Translate(direction * speed * Time.deltaTime);
    }

}
