using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="EnemyData/Create EnemyData",fileName ="TankEnemy")]
public class EnemyData : ScriptableObject
{
    private static readonly string RESOURCE_PATH = "ParameterTable";

    private static EnemyData s_instance = null;
    public static EnemyData Instance
    {
        get
        {
            if (s_instance == null)
            {
                var asset = Resources.Load(RESOURCE_PATH) as EnemyData;
                if (asset == null)
                {
                    // �A�Z�b�g���w��̃p�X�ɖ����B
                    // �N��������Ɉړ����������A�����₪�����ȁI
                    Debug.AssertFormat(false, "Missing ParameterTable! path={0}", RESOURCE_PATH);
                    asset = CreateInstance<EnemyData>();
                }
                s_instance = asset;
            }
            return s_instance;
        }
    }


    [SerializeField] Vector3 m_startPos;
    [SerializeField] float speed;
}
