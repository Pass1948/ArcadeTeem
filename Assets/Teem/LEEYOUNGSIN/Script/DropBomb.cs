using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DropBomb : MonoBehaviour
{

    [SerializeField] Bomb bomb;     // ��ź�� ���� ���� 

   
   private void OnFire(InputValue value)
   {
        DropB();
   }


    private void DropB() 
    {
        GameManager.Resource.Instantiate<Bomb>("Bomb", transform.position, transform.rotation);
        // ���� ��Ʈ��ũ �� ������ ����
    }
   
   
}
