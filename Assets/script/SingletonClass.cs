using UnityEngine;

public class SingletonClass
{
    private SingletonClass() { }                      // �����ڸ� private����: �ܺο��� new ���ϰ�

    private static SingletonClass instance;           // �ν��Ͻ��� ������ static ����

    public static SingletonClass Instance             // ���� ���� ���� (�Ӽ�)
    {
        get
        {
            if (instance == null)                     // ���� �ν��Ͻ��� ������
            {
                instance = new SingletonClass();      // �ν��Ͻ� ����
            }
            return instance;                          // �ν��Ͻ� ��ȯ
        }
    }
}