using UnityEngine;

public class ScriptA : MonoBehaviour
{
    public int A = 1; // ��� ���� A
    public int B = 2; // ��� ���� B

    int AddMethod(int a, int b) // �Ű� ���� a, b
    {
        return a + b;
    }

    void Update()
    {
        AddMethod(A, B);
    }
}