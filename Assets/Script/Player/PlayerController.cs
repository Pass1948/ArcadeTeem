using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    // ���� ���� ����
    // [SerializeField] Bomb bomb;
   
   //private void OnFire(InputValue value)
   //{
   //    photonView.RPC("RequestCreateBullet", RpcTarget.MasterClient, transform.position, transform.rotation);
   //}
   //
   //// ������Ŭ���̾�Ʈ ����(������ �� �߿��Ұ��)
   //[PunRPC]
   //private void RequestCreateBullet(Vector3 position, Quaternion rotation, PhotonMessageInfo info)
   //{
   //    // ������Ŭ���̾�Ʈ ����(����)���� ������ �����ϴ� ������
   //    if (Time.time < lastFireTime + fireCoolTime)
   //        return;
   //    lastFireTime = Time.time;
   //
   //    float sentTime = (float)info.SentServerTime;
   //    // ������ ���� �Ǵ����� �ʰ� ������ �ѹ� ��ġ�� ������ ������ ���� �Ǵ��ϰ� ����(������ ����)
   //    photonView.RPC("ResultCreateBullet", RpcTarget.AllViaServer, position, rotation, sentTime, info.Sender);
   //
   //}
   //
   //
   //
   //[PunRPC]
   //private void ResultCreateBullet(Vector3 position, Quaternion rotation, float sentTime, Player player)
   //{
   //    bulletCount++;      // ���� ����ȭ ����
   //
   //    float lag = (float)(PhotonNetwork.Time - sentTime);
   //
   //    Bullet bullet = Instantiate(bulletPrefeb, position, rotation); // ���� ���ؼ� ������ ���� ��Ȯ�� Ÿ�̹��� ���������
   //    bullet.SetPlayer(player);
   //    bullet.ApplyLag(lag);
   //    Debug.Log($"{photonView.Owner.NickName}�߽�!");
   //}
   //
}
