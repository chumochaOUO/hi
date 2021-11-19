using UnityEngine;

/// <summary>
/// ����G2D ��V���b����
/// </summary>


public class controller2D : MonoBehaviour
{
    #region ���G���}
    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("���D����"), Range(0, 1500)]
    public float jump = 300f;
    //���餸��
    private Rigidbody2D rig;

    #endregion
    //void = �I�s
    //Start �u�|����@��
    private void Start()
    {
        //������� = ���o����<2D ����>()
         rig = GetComponent<Rigidbody2D>(); 
    }

    ///<summary>
    ///Update �� 60 FPS �� �C�@�V������1��
    ///�T�w��s�ƥ�(FixedUpdate)�G50 FPS
    ///�B�z���z�欰
    ///</summary>
    private void FixedUpdate()
    {
        Move(); 
    }


    #region ��k
    ///<summary>
    ///1.���a�O�_�������ʫ���A���k��V���A�BD
    ///2.���󲾰ʦ欰(API)
    ///3.Unity API >unityengine>classic>input>getAxis
    ///</summary>
    private void Move()
    {
        //h �� ���w�� ��J.���o�b�V(�����b) - �����b�N���k��P AD
        float h = Input.GetAxis("Horizontal");
        print("���a���k�����" + h); 
    }
    #endregion
}
