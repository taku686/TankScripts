using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField] GameObject stage1;
    [SerializeField] GameObject stage2;
    [SerializeField] GameObject stage3;
    [SerializeField] GameObject stage4;
    [SerializeField] GameObject stage5;
    [SerializeField] GameObject stage6;
    [SerializeField] GameObject stage7;
    [SerializeField] GameObject stage8;
    [SerializeField] GameObject stage9;
    [SerializeField] GameObject stage10;
    [SerializeField] GameObject player;
    [SerializeField] List<GameObject> allEnemies;
    [SerializeField] List<GameObject> strongEnemies;


    public void SetUpScene()
    {
        if (GManager.instance.stage == 1)
        {
            Instantiate(stage1, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            Instantiate(allEnemies[0], new Vector3(0, 0, -30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 2)
        {
            Instantiate(stage2, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-14, 0.5f, -30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-14, 0.5f, -30);
            GManager.instance.clearPos.position = new Vector3(-10, 0, -10);
            Instantiate(allEnemies[0], new Vector3(14, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[1], new Vector3(14, 0, 30), Quaternion.identity);
            Instantiate(allEnemies[2], new Vector3(-14, 0, 30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 3)
        {
            Instantiate(stage3, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 0), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(allEnemies[2], new Vector3(0, 0, 30), Quaternion.identity);
            Instantiate(allEnemies[2], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[3], new Vector3(-8, 0, 30), Quaternion.identity);
            Instantiate(allEnemies[3], new Vector3(8, 0, -30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 4)
        {
            Instantiate(stage4, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(10, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(10, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(-18, 0, 0);
            Instantiate(allEnemies[0], new Vector3(-8, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[1], new Vector3(-8, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[2], new Vector3(15, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[3], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[3], new Vector3(-18, 0, -30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 5)
        {
            Instantiate(stage5, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(allEnemies[4], new Vector3(6, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[4], new Vector3(-6, 0, -10), Quaternion.identity);

        }
        else if (GManager.instance.stage == 6)
        {
            Instantiate(stage6, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(allEnemies[1], new Vector3(18, 0, 33), Quaternion.identity);
            Instantiate(allEnemies[4], new Vector3(17, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[1], new Vector3(-16, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[4], new Vector3(-15, 0, 20), Quaternion.identity);
            Instantiate(allEnemies[1], new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 7)
        {
            Instantiate(stage7, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(allEnemies[2], new Vector3(-13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[3], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[2], new Vector3(13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[3], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[3], new Vector3(0, 0, -30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 8)
        {
            Instantiate(stage8, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-19, 0.5f, -32), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-19, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(17, 0, 31);
            Instantiate(allEnemies[4], new Vector3(-11, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[4], new Vector3(7, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[4], new Vector3(17, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[4], new Vector3(-2, 0, -31), Quaternion.identity);

        }
        else if (GManager.instance.stage == 9)
        {
            Instantiate(stage9, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(14, 0.5f, 28), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(14, 0.5f, 28);
            GManager.instance.clearPos.position = new Vector3(-15, 0, -25);
            Instantiate(allEnemies[4], new Vector3(-15, 0, -25), Quaternion.identity);
            Instantiate(allEnemies[4], new Vector3(10, 0, 8), Quaternion.identity);
            Instantiate(allEnemies[3], new Vector3(-6, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[3], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[2], new Vector3(-10, 0, 20), Quaternion.identity);
            Instantiate(allEnemies[2], new Vector3(-15, 0, 30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 10)
        {
            Instantiate(stage10, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(allEnemies[5], new Vector3(-10, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[5], new Vector3(10, 0, -30), Quaternion.identity);

        }
        else if (GManager.instance.stage == 11)
        {
            Instantiate(stage1, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            Instantiate(allEnemies[5], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[2], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[5], new Vector3(-15, 0, -30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 12)
        {
            Instantiate(stage2, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-14, 0.5f, -30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-14, 0.5f, -30);
            GManager.instance.clearPos.position = new Vector3(-10, 0, -10);
            Instantiate(allEnemies[5], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[5], new Vector3(10, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[3], new Vector3(-10, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[3], new Vector3(-10, 0, -10), Quaternion.identity);
        }
        else if (GManager.instance.stage == 13)
        {
            Instantiate(stage3, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 0), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(allEnemies[4], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[4], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[4], new Vector3(0, 0, 30), Quaternion.identity);
            Instantiate(allEnemies[4], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[4], new Vector3(10, 0, 10), Quaternion.identity);
        }
        else if (GManager.instance.stage == 14)
        {
            Instantiate(stage4, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(10, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(10, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(-18, 0, 0);
            Instantiate(allEnemies[0], new Vector3(-8, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[1], new Vector3(-8, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[2], new Vector3(15, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[3], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[3], new Vector3(-18, 0, -30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 15)
        {
            Instantiate(stage5, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(allEnemies[6], new Vector3(-6, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(6, 0, -10), Quaternion.identity);

        }
        else if (GManager.instance.stage == 16)
        {
            Instantiate(stage6, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(allEnemies[4], new Vector3(18, 0, 33), Quaternion.identity);
            Instantiate(allEnemies[5], new Vector3(17, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(-16, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[4], new Vector3(-15, 0, 20), Quaternion.identity);
            Instantiate(allEnemies[5], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(10, 0, 19), Quaternion.identity);
        }
        else if (GManager.instance.stage == 17)
        {
            Instantiate(stage7, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(allEnemies[2], new Vector3(-13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[2], new Vector3(13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 18)
        {
            Instantiate(stage8, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-19, 0.5f, -32), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-19, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(17, 0, 31);
            Instantiate(allEnemies[6], new Vector3(-11, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(7, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(17, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(-2, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[5], new Vector3(17, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[5], new Vector3(0, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[2], new Vector3(7, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[2], new Vector3(-10, 0, -31), Quaternion.identity);
        }
        else if (GManager.instance.stage == 19)
        {
            Instantiate(stage9, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(14, 0.5f, 28), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(14, 0.5f, 28);
            GManager.instance.clearPos.position = new Vector3(-15, 0, -25);
            Instantiate(allEnemies[6], new Vector3(-15, 0, -25), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(10, 0, 8), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(-6, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(-10, 0, 20), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(-15, 0, 30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 20)
        {
            Instantiate(stage10, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(allEnemies[7], new Vector3(-10, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(10, 0, -30), Quaternion.identity);

        }
        else if (GManager.instance.stage == 21)
        {
            Instantiate(stage1, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            Instantiate(allEnemies[7], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(15, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(-15, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 22)
        {
            Instantiate(stage2, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-14, 0.5f, -30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-14, 0.5f, -30);
            GManager.instance.clearPos.position = new Vector3(-10, 0, -10);
            Instantiate(allEnemies[6], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(10, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(-10, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(-10, 0, -10), Quaternion.identity);
        }
        else if (GManager.instance.stage == 23)
        {
            Instantiate(stage3, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 0), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(allEnemies[5], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(0, 0, 30), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(10, 0, 10), Quaternion.identity);
        }
        else if (GManager.instance.stage == 24)
        {
            Instantiate(stage4, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(10, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(10, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(-18, 0, 0);
            Instantiate(allEnemies[7], new Vector3(-8, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(-8, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(15, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(-18, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(9, 0, 9), Quaternion.identity);
        }
        else if (GManager.instance.stage == 25)
        {
            Instantiate(stage5, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(allEnemies[8], new Vector3(-6, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(6, 0, -10), Quaternion.identity);

        }
        else if (GManager.instance.stage == 26)
        {
            Instantiate(stage6, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(allEnemies[6], new Vector3(18, 0, 33), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(17, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(-16, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(-15, 0, 20), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(10, 0, 19), Quaternion.identity);
        }
        else if (GManager.instance.stage == 27)
        {
            Instantiate(stage7, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(allEnemies[5], new Vector3(-13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[5], new Vector3(13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[5], new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 28)
        {
            Instantiate(stage8, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-19, 0.5f, -32), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-19, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(17, 0, 31);
            Instantiate(allEnemies[4], new Vector3(-11, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[4], new Vector3(7, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(17, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(-2, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[5], new Vector3(17, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[5], new Vector3(0, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(7, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(-10, 0, -31), Quaternion.identity);
        }
        else if (GManager.instance.stage == 29)
        {
            Instantiate(stage9, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(14, 0.5f, 28), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(14, 0.5f, 28);
            GManager.instance.clearPos.position = new Vector3(-15, 0, -25);
            Instantiate(allEnemies[8], new Vector3(-15, 0, -25), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(10, 0, 8), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(-6, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(-10, 0, 20), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(-15, 0, 30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 30)
        {
            Instantiate(stage10, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(allEnemies[9], new Vector3(-10, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[9], new Vector3(10, 0, -30), Quaternion.identity);

        }
        else if (GManager.instance.stage == 31)
        {
            Instantiate(stage1, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            Instantiate(allEnemies[8], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(15, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(-15, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 32)
        {
            Instantiate(stage2, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-14, 0.5f, -30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-14, 0.5f, -30);
            GManager.instance.clearPos.position = new Vector3(-10, 0, -10);
            Instantiate(allEnemies[7], new Vector3(10, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(-10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(14, 0, 30), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(14, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(-14, 0, 30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 33)
        {
            Instantiate(stage3, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 0), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(allEnemies[7], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[6], new Vector3(0, 0, 30), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(10, 0, 10), Quaternion.identity);
        }
        else if (GManager.instance.stage == 34)
        {
            Instantiate(stage4, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(10, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(10, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(-18, 0, 0);
            Instantiate(allEnemies[8], new Vector3(-8, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(-8, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(15, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(-18, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(9, 0, 9), Quaternion.identity);
        }
        else if (GManager.instance.stage == 35)
        {
            Instantiate(stage5, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(allEnemies[10], new Vector3(-6, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[10], new Vector3(6, 0, -10), Quaternion.identity);

        }
        else if (GManager.instance.stage == 36)
        {
            Instantiate(stage6, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(allEnemies[8], new Vector3(18, 0, 33), Quaternion.identity);
            Instantiate(allEnemies[9], new Vector3(17, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[10], new Vector3(-16, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[8], new Vector3(-15, 0, 20), Quaternion.identity);
            Instantiate(allEnemies[9], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[10], new Vector3(10, 0, 19), Quaternion.identity);
        }
        else if (GManager.instance.stage == 37)
        {
            Instantiate(stage7, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(allEnemies[7], new Vector3(-13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[9], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[9], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[9], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[7], new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 38)
        {
            Instantiate(stage8, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-19, 0.5f, -32), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-19, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(17, 0, 31);
            Instantiate(allEnemies[10], new Vector3(-11, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[10], new Vector3(7, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[4], new Vector3(17, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[4], new Vector3(-2, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[9], new Vector3(17, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[9], new Vector3(0, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[5], new Vector3(7, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[5], new Vector3(-10, 0, -31), Quaternion.identity);

        }
        else if (GManager.instance.stage == 39)
        {
            Instantiate(stage9, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(14, 0.5f, 28), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(14, 0.5f, 28);
            GManager.instance.clearPos.position = new Vector3(-15, 0, -25);
            Instantiate(allEnemies[10], new Vector3(-15, 0, -25), Quaternion.identity);
            Instantiate(allEnemies[10], new Vector3(10, 0, 8), Quaternion.identity);
            Instantiate(allEnemies[10], new Vector3(-6, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[9], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[9], new Vector3(-10, 0, 20), Quaternion.identity);
            Instantiate(allEnemies[9], new Vector3(-15, 0, 30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 40)
        {
            Instantiate(stage10, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(allEnemies[11], new Vector3(-10, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[11], new Vector3(10, 0, -30), Quaternion.identity);

        }
        else if (GManager.instance.stage == 41)
        {
            Instantiate(stage1, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            Instantiate(allEnemies[10], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[10], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[9], new Vector3(15, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[9], new Vector3(-15, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 42)
        {
            Instantiate(stage2, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-14, 0.5f, -30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-14, 0.5f, -30);
            GManager.instance.clearPos.position = new Vector3(-10, 0, -10);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(14, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(14, 0, 30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-14, 0, 30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 43)
        {
            Instantiate(stage3, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 0), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-8, 0, 30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(8, 0, -30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 44)
        {
            Instantiate(stage4, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(10, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(10, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(-18, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-8, 0, -5), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-8, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, -5), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-18, 0, -30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 45)
        {
            Instantiate(stage5, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-6, 0, -10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(6, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-12, 0, -20), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -20), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(12, 0, -20), Quaternion.identity);
        }
        else if (GManager.instance.stage == 46)
        {
            Instantiate(stage6, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(18, 0, 33), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(17, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-16, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, 20), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 47)
        {
            Instantiate(stage7, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-13, 0, 10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 48)
        {
            Instantiate(stage8, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-19, 0.5f, -32), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-19, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(17, 0, 31);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-11, 0, 32), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(7, 0, 32), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(17, 0, -31), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-2, 0, -31), Quaternion.identity);

        }
        else if (GManager.instance.stage == 49)
        {
            Instantiate(stage9, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(14, 0.5f, 28), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(14, 0.5f, 28);
            GManager.instance.clearPos.position = new Vector3(-15, 0, -25);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, -25), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, 8), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-6, 0, -5), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-10, 0, 20), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 50)
        {
            Instantiate(stage10, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-10, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(6, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-6, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 51)
        {
            Instantiate(stage1, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(15, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 52)
        {
            Instantiate(stage2, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-14, 0.5f, -30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-14, 0.5f, -30);
            GManager.instance.clearPos.position = new Vector3(-10, 0, -10);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-10, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-10, 0, -10), Quaternion.identity);
        }
        else if (GManager.instance.stage == 53)
        {
            Instantiate(stage3, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 0), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, 10), Quaternion.identity);
        }
        else if (GManager.instance.stage == 54)
        {
            Instantiate(stage4, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(10, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(10, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(-18, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-8, 0, -5), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-8, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-18, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(9, 0, 9), Quaternion.identity);
        }
        else if (GManager.instance.stage == 55)
        {
            Instantiate(stage5, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-6, 0, -10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(6, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-12, 0, -20), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -20), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(12, 0, -20), Quaternion.identity);
        }
        else if (GManager.instance.stage == 56)
        {
            Instantiate(stage6, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(18, 0, 33), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(17, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-16, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 20), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, 19), Quaternion.identity);
        }
        else if (GManager.instance.stage == 57)
        {
            Instantiate(stage7, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-13, 0, 10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 58)
        {
            Instantiate(stage8, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-19, 0.5f, -32), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-19, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(17, 0, 31);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-11, 0, 32), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(7, 0, 32), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(17, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-2, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(17, 0, 32), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(7, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-10, 0, -31), Quaternion.identity);
        }
        else if (GManager.instance.stage == 59)
        {
            Instantiate(stage9, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(14, 0.5f, 28), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(14, 0.5f, 28);
            GManager.instance.clearPos.position = new Vector3(-15, 0, -25);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, -25), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, 8), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-6, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 60)
        {
            Instantiate(stage10, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-10, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(6, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-6, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 61)
        {
            Instantiate(stage1, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(15, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 62)
        {
            Instantiate(stage2, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-14, 0.5f, -30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-14, 0.5f, -30);
            GManager.instance.clearPos.position = new Vector3(-10, 0, -10);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-10, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-10, 0, -10), Quaternion.identity);
        }
        else if (GManager.instance.stage == 63)
        {
            Instantiate(stage3, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 0), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, 10), Quaternion.identity);
        }
        else if (GManager.instance.stage == 64)
        {
            Instantiate(stage4, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(10, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(10, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(-18, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-8, 0, -5), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-8, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(15, 0, -5), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-18, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(9, 0, 9), Quaternion.identity);
        }
        else if (GManager.instance.stage == 65)
        {
            Instantiate(stage5, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-6, 0, -10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(6, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-12, 0, -20), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -20), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(12, 0, -20), Quaternion.identity);
        }
        else if (GManager.instance.stage == 66)
        {
            Instantiate(stage6, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(18, 0, 33), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(17, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-16, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 20), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, 19), Quaternion.identity);
        }
        else if (GManager.instance.stage == 67)
        {
            Instantiate(stage7, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 68)
        {
            Instantiate(stage8, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-19, 0.5f, -32), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-19, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(17, 0, 31);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-11, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(7, 0, 32), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(17, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-2, 0, -31), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(17, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(7, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-10, 0, -31), Quaternion.identity);
        }
        else if (GManager.instance.stage == 69)
        {
            Instantiate(stage9, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(14, 0.5f, 28), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(14, 0.5f, 28);
            GManager.instance.clearPos.position = new Vector3(-15, 0, -25);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, -25), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, 8), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-6, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 70)
        {
            Instantiate(stage10, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-10, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(6, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-6, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 71)
        {
            Instantiate(stage1, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 72)
        {
            Instantiate(stage2, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-14, 0.5f, -30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-14, 0.5f, -30);
            GManager.instance.clearPos.position = new Vector3(-10, 0, -10);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-10, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-10, 0, -10), Quaternion.identity);
        }
        else if (GManager.instance.stage == 73)
        {
            Instantiate(stage3, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 0), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, 10), Quaternion.identity);
        }
        else if (GManager.instance.stage == 74)
        {
            Instantiate(stage4, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(10, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(10, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(-18, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-8, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-8, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-18, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(9, 0, 9), Quaternion.identity);
        }
        else if (GManager.instance.stage == 75)
        {
            Instantiate(stage5, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-6, 0, -10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(6, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-12, 0, -20), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -20), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(12, 0, -20), Quaternion.identity);
        }
        else if (GManager.instance.stage == 76)
        {
            Instantiate(stage6, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(18, 0, 33), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(17, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-16, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 20), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, 19), Quaternion.identity);
        }
        else if (GManager.instance.stage == 77)
        {
            Instantiate(stage7, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 78)
        {
            Instantiate(stage8, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-19, 0.5f, -32), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-19, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(17, 0, 31);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-11, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(7, 0, 32), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(17, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-2, 0, -31), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(17, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(7, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-10, 0, -31), Quaternion.identity);
        }
        else if (GManager.instance.stage == 79)
        {
            Instantiate(stage9, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(14, 0.5f, 28), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(14, 0.5f, 28);
            GManager.instance.clearPos.position = new Vector3(-15, 0, -25);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, -25), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, 8), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-6, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 80)
        {
            Instantiate(stage10, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-10, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(6, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-6, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 81)
        {
            Instantiate(stage1, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 82)
        {
            Instantiate(stage2, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-14, 0.5f, -30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-14, 0.5f, -30);
            GManager.instance.clearPos.position = new Vector3(-10, 0, -10);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, 10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-10, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-10, 0, -10), Quaternion.identity);
        }
        else if (GManager.instance.stage == 83)
        {
            Instantiate(stage3, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 0), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, 10), Quaternion.identity);
        }
        else if (GManager.instance.stage == 84)
        {
            Instantiate(stage4, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(10, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(10, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(-18, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-8, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-8, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-18, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(9, 0, 9), Quaternion.identity);
        }
        else if (GManager.instance.stage == 85)
        {
            Instantiate(stage5, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-6, 0, -10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(6, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-12, 0, -20), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -20), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(12, 0, -20), Quaternion.identity);
        }
        else if (GManager.instance.stage == 86)
        {
            Instantiate(stage6, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(18, 0, 33), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(17, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-16, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 20), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, 19), Quaternion.identity);
        }
        else if (GManager.instance.stage == 87)
        {
            Instantiate(stage7, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(13, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 88)
        {
            Instantiate(stage8, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-19, 0.5f, -32), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-19, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(17, 0, 31);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-11, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(7, 0, 32), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(17, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-2, 0, -31), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(17, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 32), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(7, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-10, 0, -31), Quaternion.identity);
        }
        else if (GManager.instance.stage == 89)
        {
            Instantiate(stage9, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(14, 0.5f, 28), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(14, 0.5f, 28);
            GManager.instance.clearPos.position = new Vector3(-15, 0, -25);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, -25), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, 8), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-6, 0, -5), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 90)
        {
            Instantiate(stage10, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-10, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(6, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-6, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 91)
        {
            Instantiate(stage1, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 92)
        {
            Instantiate(stage2, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-14, 0.5f, -30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-14, 0.5f, -30);
            GManager.instance.clearPos.position = new Vector3(-10, 0, -10);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, 10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-10, 0, 10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-10, 0, -10), Quaternion.identity);
        }
        else if (GManager.instance.stage == 93)
        {
            Instantiate(stage3, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 0), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(10, 0, 10), Quaternion.identity);
        }
        else if (GManager.instance.stage == 94)
        {
            Instantiate(stage4, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(10, 0.5f, 30), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(10, 0.5f, 30);
            GManager.instance.clearPos.position = new Vector3(-18, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-8, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-8, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-18, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(9, 0, 9), Quaternion.identity);
        }
        else if (GManager.instance.stage == 95)
        {
            Instantiate(stage5, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-6, 0, -10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(6, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-12, 0, -20), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -20), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(12, 0, -20), Quaternion.identity);
        }
        else if (GManager.instance.stage == 96)
        {
            Instantiate(stage6, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-17, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-17, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, 0);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(18, 0, 33), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(17, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-16, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 20), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, 19), Quaternion.identity);
        }
        else if (GManager.instance.stage == 97)
        {
            Instantiate(stage7, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 31), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 31);
            GManager.instance.clearPos.position = new Vector3(0, 0, -30);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-13, 0, 10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(13, 0, 10), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (GManager.instance.stage == 98)
        {
            Instantiate(stage8, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(-19, 0.5f, -32), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(-19, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(17, 0, 31);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-11, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(7, 0, 32), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(17, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-2, 0, -31), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(17, 0, 32), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(0, 0, 32), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(7, 0, -31), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-10, 0, -31), Quaternion.identity);
        }
        else if (GManager.instance.stage == 99)
        {
            Instantiate(stage9, Vector3.zero, Quaternion.identity);
            Instantiate(player, new Vector3(14, 0.5f, 28), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(14, 0.5f, 28);
            GManager.instance.clearPos.position = new Vector3(-15, 0, -25);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, -25), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, 8), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-6, 0, -5), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(10, 0, -10), Quaternion.identity);
            Instantiate(allEnemies[Random.Range(0, 11)], new Vector3(-15, 0, 30), Quaternion.identity);
        }
        else if (GManager.instance.stage == 100)
        {
            Instantiate(stage1, Vector3.zero, Quaternion.identity);
            //    Instantiate(stage2, new Vector3(45, 0, 0), Quaternion.identity);
            //     Instantiate(stage3, new Vector3(45, 0, 75), Quaternion.identity);
            //     Instantiate(stage4, new Vector3(45, 0, -75), Quaternion.identity);
            //     Instantiate(stage5, new Vector3(0, 0, -75), Quaternion.identity);
            //     Instantiate(stage6, new Vector3(0, 0, 75), Quaternion.identity);
            //     Instantiate(stage7, new Vector3(-45, 0, 75), Quaternion.identity);
            //     Instantiate(stage8, new Vector3(-45, 0, -75), Quaternion.identity);
            //     Instantiate(stage9, new Vector3(-45, 0, 0), Quaternion.identity);
            Instantiate(player, new Vector3(0, 0.5f, 0), Quaternion.identity);
            GManager.instance.startPos.position = new Vector3(0, 0.5f, 0);
            GManager.instance.clearPos.position = new Vector3(0, 0, -10);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, 30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, 30), Quaternion.identity);
            //      Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(0, 0, 20), Quaternion.identity);
            //     Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(0, 0, -20), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, 30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(0, 0, -30), Quaternion.identity);
            Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, -30), Quaternion.identity);
            //      Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(-20, 0, 0), Quaternion.identity);
            //       Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(50, 0, 5), Quaternion.identity);
            //      Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(50, 0, -10), Quaternion.identity);
            //     Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, 15), Quaternion.identity);
            //      Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-15, 0, 15), Quaternion.identity);
            //      Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(35, 0, 5), Quaternion.identity);
            //      Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(35, 0, 90), Quaternion.identity);
            //     Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, -15), Quaternion.identity);
            //        Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(53, 0, 55), Quaternion.identity);
            //        Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(53, 0, 90), Quaternion.identity);
            //       Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(-2, 0, 80), Quaternion.identity);
            //        Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(15, 0, -15), Quaternion.identity);
            //       Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(8, 0, 55), Quaternion.identity);
            //        Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(8, 0, 95), Quaternion.identity);
            //        Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(-30, 0, 95), Quaternion.identity);
            //      Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-45, 0, 95), Quaternion.identity);
            //      Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-60, 0, 95), Quaternion.identity);
            //       Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(-60, 0, 65), Quaternion.identity);
            //       Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(-30, 0, 65), Quaternion.identity);
            //       Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-60, 0, 15), Quaternion.identity);
            //       Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-60, 0, -25), Quaternion.identity);
            //        Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(-50, 0, -10), Quaternion.identity);
            //       Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(-64, 0, -105), Quaternion.identity);
            //       Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-55, 0, -55), Quaternion.identity);
            //       Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-46, 0, -90), Quaternion.identity);
            //       Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(-63, 0, -3), Quaternion.identity);
            //       Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(-37, 0, -55), Quaternion.identity);
            //        Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(-10, 0, -66), Quaternion.identity);
            //         Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(3, 0, -66), Quaternion.identity);
            //        Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(3, 0, -90), Quaternion.identity);
            //        Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(-10, 0, -85), Quaternion.identity);
            //         Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(50, 0, -87), Quaternion.identity);
            //       Instantiate(strongEnemies[Random.Range(0, 3)], new Vector3(44, 0, -60), Quaternion.identity);
            //       Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(-37, 0, -55), Quaternion.identity);
            //      Instantiate(allEnemies[Random.Range(0, 12)], new Vector3(-37, 0, -55), Quaternion.identity);
        }
    }
}


