using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellManager : MonoBehaviour
{
    [SerializeField] private GameObject playerShell;
    private List<GameObject> playerShellList;
    [SerializeField] private GameObject enemyShell;
    private List<GameObject> enemyShellList;
    private const int maxCount = 20;

    private void Awake()
    {
        CreatePool();
    }

    private void CreatePool()
    {
        playerShellList = new List<GameObject>();
        enemyShellList = new List<GameObject>();
        for (int i = 0; i < maxCount; i++)
        {
            //弾を生成してリストに加える
            GameObject newPlayerObj = CreateNewPlayerShell();
            GameObject newEnemyObj = CreateNewEnemyShell();
            newPlayerObj.SetActive(false);
            newEnemyObj.SetActive(false);
            playerShellList.Add(newPlayerObj);
            enemyShellList.Add(newEnemyObj);
        }
    }

    //未使用の弾を探して返す
    //弾がない場合は新しく作って返す
    public GameObject GetShell()
    {
        foreach (GameObject obj in playerShellList)
        {
            if (!obj.activeSelf)
            {
                obj.SetActive(true);
                obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
                obj.GetComponent<PlayerShell>().currentBounceCount = 0;
                return obj;
            }
        }

        //すべて使用中だったら新しく作り、リストに加える
        GameObject newobj = CreateNewPlayerShell();
        playerShellList.Add(newobj);
        return newobj;
    }

    private GameObject CreateNewPlayerShell()
    {      
        GameObject newObj = Instantiate(playerShell, transform);
        return newObj;
    }

    public GameObject GetEnemyShell()
    {
        foreach (GameObject obj in enemyShellList)
        {
            if (!obj.activeSelf)
            {
                obj.SetActive(true);
                obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
                obj.GetComponent<EnemyShell>().currentBounceCount = 0;
                obj.GetComponent<EnemyShell>().bounceCount = 0;
                return obj;
            }
        }

        //すべて使用中だったら新しく作り、リストに加える
        GameObject newobj = CreateNewEnemyShell();
        enemyShellList.Add(newobj);
        return newobj;
    }

    private GameObject CreateNewEnemyShell()
    {
        GameObject newObj = Instantiate(enemyShell, transform);
        return newObj;
    }
}
