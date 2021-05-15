using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltimateJoystickExample;
using UnityEngine.UI;


public class TankMovement : MonoBehaviour
{
    public float turnSpeed;
    private Rigidbody rb;
    public float shotSpeed;
    public AudioClip shotSound;
    private LineRenderer lineRenderer;
    RaycastHit hit;
    float rayRange = 10000f;
    [SerializeField] GameObject head;
    [SerializeField] GameObject body;
    [SerializeField] GameObject shotPos;
    [SerializeField] GameObject minePrefab;
    [SerializeField] GameObject diffuseShell;
    [SerializeField] GameObject penetrationShell;
    [SerializeField] GameObject bounceShell;
    [SerializeField] AudioClip powerUpSound;
    [SerializeField] Material colorRed;
    [SerializeField] Material colorBlue;
    ShellManager shellManagerSc;
    private int shotCount;
    private int mineCount;
    private Text shellText;
    private Text mineText;
    private Text speedUpText;
    private int shotMaxCount;
    private int mineMaxCount;
    private int moveSpeed;
    private int speedUpCount;
    private bool isLaser;
    private bool isDiffuse;
    private bool isPenetration;
    private bool isNormal;
    private bool isBounce;
    private bool isReinLaser;
    bool isReload;
    bool isMineReload;
    bool isShot;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        shellManagerSc = GameObject.FindGameObjectWithTag("ShellManager").GetComponent<ShellManager>();
        lineRenderer = GetComponentInChildren<LineRenderer>();
        shotMaxCount = SaveSystem.Instance.UserData.shotMaxCount;
        mineMaxCount = SaveSystem.Instance.UserData.mineMaxCount;
        moveSpeed = SaveSystem.Instance.UserData.moveSpeed;
        speedUpCount = SaveSystem.Instance.UserData.speedUpCount;
        isLaser = SaveSystem.Instance.UserData.isLaser;
        isDiffuse = SaveSystem.Instance.UserData.isDiffuse;
        isPenetration = SaveSystem.Instance.UserData.isPenetration;
        isNormal = SaveSystem.Instance.UserData.isNormal;
        isBounce = SaveSystem.Instance.UserData.isBounce;
        isReinLaser = SaveSystem.Instance.UserData.isReinLaser;
        if (!isLaser&&!isReinLaser)
        {
            lineRenderer.enabled = false;
        }
        else if (isLaser)
        {
            lineRenderer.material = colorRed;
        }
        else if (isReinLaser)
        {
            lineRenderer.material = colorBlue;
        }
        shellText = GameObject.FindGameObjectWithTag("ShellCountText").GetComponent<Text>();
        mineText = GameObject.FindGameObjectWithTag("MineCountText").GetComponent<Text>();
        speedUpText = GameObject.FindGameObjectWithTag("SpeedUpCount").GetComponent<Text>();
        shellText.text = (shotMaxCount - shotCount).ToString();
        mineText.text = (mineMaxCount - mineCount).ToString();
        speedUpText.text = speedUpCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (UltimateJoystick.GetJoystickState("PlayerMove"))
        {
            Move();
        }
        if (UltimateJoystick.GetJoystickState("PlayerTurn"))
        {
            Turn();
        }
        if (isLaser||isReinLaser)
        {
            Ray();
        }
        if (shotCount >= shotMaxCount)
        {
            Charge();
        }
        if (mineCount >= mineMaxCount)
        {
            MineCharge();
        }
    }


    private void Move()
    {
        Vector3 dir;
 //       if (CameraController.mainCameraON)
//        {
            dir = new Vector3(UltimateJoystick.GetVerticalAxis("PlayerMove"), 0, -UltimateJoystick.GetHorizontalAxis("PlayerMove")).normalized;
        rb.velocity = new Vector3(dir.x * moveSpeed * Time.deltaTime, 0, dir.z * moveSpeed * Time.deltaTime);
 //       }
 /*
        else
        {
               dir = new Vector3(UltimateJoystick.GetHorizontalAxis("PlayerMove") , 0, UltimateJoystick.GetVerticalAxis("PlayerMove")).normalized;
            //   rb.velocity = new Vector3((dir.x *Mathf.Cos(head.transform.rotation.eulerAngles.y)-dir.z* Mathf.Sin(head.transform.rotation.eulerAngles.y)) * GManager.instance.moveSpeed * Time.deltaTime, 0, (dir.x * Mathf.Sin(head.transform.rotation.eulerAngles.y) + dir.z * Mathf.Cos(head.transform.rotation.eulerAngles.y)) * GManager.instance.moveSpeed * Time.deltaTime);
            float angle = (720 + head.transform.rotation.eulerAngles.y) % 360;
            if (angle < 45  || angle >= 315)
            {
                rb.velocity = new Vector3(dir.x * SaveSystem.Instance.UserData.moveSpeed * Time.deltaTime, 0, dir.z * SaveSystem.Instance.UserData.moveSpeed * Time.deltaTime);
            }
            else if (angle < 135 && angle >= 45)
            {
                rb.velocity = new Vector3(dir.z * SaveSystem.Instance.UserData.moveSpeed * Time.deltaTime, 0, -dir.x * SaveSystem.Instance.UserData.moveSpeed * Time.deltaTime);
            }
            else if (angle < 225 && angle >= 135)
            {
                rb.velocity = new Vector3(-dir.x * SaveSystem.Instance.UserData.moveSpeed * Time.deltaTime, 0, -dir.z * SaveSystem.Instance.UserData.moveSpeed * Time.deltaTime);
            }
            else if (angle < 315 && angle >= 225)
            {
                rb.velocity = new Vector3(-dir.z * SaveSystem.Instance.UserData.moveSpeed * Time.deltaTime, 0, dir.x * SaveSystem.Instance.UserData.moveSpeed * Time.deltaTime);
            }
        }
 */
        
        float turnY = Mathf.Acos(UltimateJoystick.GetHorizontalAxis("PlayerMove")) / Mathf.PI * 180;
        float vertical = UltimateJoystick.GetVerticalAxis("PlayerMove");
        if (vertical < 0)
        {
            body.transform.rotation = Quaternion.Euler(0, turnY, 0);
        }
        else if (vertical > 0)
        {
            body.transform.rotation = Quaternion.Euler(0, -turnY, 0);
        }
    }

    private void Turn()
    {
        float turnY = Mathf.Acos(-UltimateJoystick.GetHorizontalAxis("PlayerTurn")) / Mathf.PI * 180;
        float horizontal = UltimateJoystick.GetHorizontalAxis("PlayerTurn");
        float vertical = UltimateJoystick.GetVerticalAxis("PlayerTurn");
        if (vertical > 0)
        {
            head.transform.rotation = Quaternion.Euler(0, turnY, 0);
        }
        else if (vertical < 0)
        {
           head.transform.rotation = Quaternion.Euler(0, -turnY, 0);
        }
        if ((Mathf.Pow(horizontal, 2) + Mathf.Pow(vertical, 2)) > 0.7f&&!isShot&&OptionManager.isJoystic)
        {
            StartCoroutine(ShotCorutine());
        }      
    }

    IEnumerator ShotCorutine()
    {
        isShot = true;
        Shot();
        yield return new WaitForSeconds(0.2f);
        isShot = false;
    }

    private void Charge()
    {
        if (!isReload)
        {
            isReload = true;
            StartCoroutine(Reload());
        }    
    }

    private void MineCharge()
    {
        if (!isMineReload)
        {
            isMineReload = true;
            StartCoroutine(MineReload());
        }
    }

    private void Ray()
    {
        Ray ray = new Ray(shotPos.transform.position, shotPos.transform.forward);
        lineRenderer.SetPosition(0, shotPos.transform.position);
        Physics.Raycast(ray, out hit, rayRange, LayerMask.GetMask("BlockingLayer")); 
        if (hit.transform != null)
        {
            lineRenderer.SetPosition(1,hit.point);
            if (isReinLaser)
            {
                if (hit.normal.z != 0)
                {
                    Vector3 reflect = Vector3.Reflect(shotPos.transform.forward, new Vector3(0, 0, 1));
                    if (Physics.Raycast(hit.point, reflect, out RaycastHit hit1, 1000, LayerMask.GetMask("BlockingLayer")))
                    {
                        if (hit1.transform != null)
                        {
                            lineRenderer.SetPosition(2, hit1.point);                         
                        }
                    }
                }
                if (hit.normal.x != 0)
                {
                    Vector3 reflect = Vector3.Reflect(shotPos.transform.forward, new Vector3(1, 0, 0));
                    if (Physics.Raycast(hit.point, reflect, out RaycastHit hit1, 1000, LayerMask.GetMask("BlockingLayer")))
                    {
                        if (hit1.transform != null)
                        {
                            lineRenderer.SetPosition(2, hit1.point);
                        }
                    }
                }
            }
            else
            {
                lineRenderer.SetPosition(2, shotPos.transform.position);           
            }
        }
        else
        {
            lineRenderer.SetPosition(1, shotPos.transform.position);
        }
    }

    public void Shot()
    {
        if (shotCount <shotMaxCount)
        {
            if (isNormal)
            {
                GameObject shell = shellManagerSc.GetShell();
                shell.transform.rotation = Quaternion.Euler(0, head.transform.rotation.eulerAngles.y + 90, 90);
                shell.transform.position = shotPos.transform.position;
                Rigidbody shellRb = shell.GetComponent<Rigidbody>();
                shellRb.AddForce(head.transform.forward * shotSpeed);
                AudioSource.PlayClipAtPoint(shotSound, transform.position);
                shotCount += 1;
                shellText.text = (shotMaxCount - shotCount).ToString();
            }
            if (isDiffuse)
            {
                for (int i = 0; i < 3; i++)
                {
                    GameObject shellClone = Instantiate(diffuseShell, shotPos.transform.position, Quaternion.Euler(0, head.transform.rotation.eulerAngles.y + 80 + 10 * i, 90));
                    Rigidbody rb = shellClone.GetComponent<Rigidbody>();
                    rb.AddForce(shellClone.transform.up * shotSpeed * 0.8f);
                }
                AudioSource.PlayClipAtPoint(shotSound, transform.position);
                shotCount += 1;
                shellText.text = (shotMaxCount - shotCount).ToString();
            }
            if (isPenetration)
            {
                GameObject shellClone = Instantiate(penetrationShell, shotPos.transform.position, Quaternion.Euler(0, head.transform.rotation.eulerAngles.y + 90, 90));
                Rigidbody rb = shellClone.GetComponent<Rigidbody>();
                rb.AddForce(head.transform.forward * shotSpeed * 1.2f);
                AudioSource.PlayClipAtPoint(shotSound, transform.position);
                shotCount += 1;
                shellText.text = (shotMaxCount - shotCount).ToString();
            }
            if (isBounce)
            {
                GameObject shellClone = Instantiate(bounceShell, shotPos.transform.position, Quaternion.Euler(0, head.transform.rotation.eulerAngles.y + 90, 90));
                Rigidbody rb = shellClone.GetComponent<Rigidbody>();
                rb.AddForce(head.transform.forward * shotSpeed);
                AudioSource.PlayClipAtPoint(shotSound, transform.position);
                shotCount += 1;
                shellText.text = (shotMaxCount - shotCount).ToString();
            }
        }
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(3);
        shotCount = 0;
        shellText.text = (shotMaxCount - shotCount).ToString();
        isReload = false;
    }

    IEnumerator MineReload()
    {
        yield return new WaitForSeconds(3);
        mineCount = 0;
        mineText.text = (mineMaxCount - mineCount).ToString();
        isMineReload = false;
    }

    public void Mine()
    {
        if (mineCount < mineMaxCount )
        {
            Instantiate(minePrefab, new Vector3(transform.position.x, 0, transform.position.z), Quaternion.identity);
            mineCount += 1;
            mineText.text = (mineMaxCount - mineCount).ToString();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ShellItem"))
        {
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(powerUpSound, other.transform.position);
            if (SaveSystem.Instance.UserData.shotMaxCount > 19) return;
            SaveSystem.Instance.UserData.shotMaxCount += 1;
            SaveSystem.Instance.Save();
            shotMaxCount = SaveSystem.Instance.UserData.shotMaxCount;
        }
        else if (other.CompareTag("MineItem"))
        {
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(powerUpSound, other.transform.position);
            if (SaveSystem.Instance.UserData.mineMaxCount > 9) return;
            SaveSystem.Instance.UserData.mineMaxCount += 1;
            SaveSystem.Instance.Save();
            mineMaxCount = SaveSystem.Instance.UserData.mineMaxCount;
        }
        else if (other.CompareTag("LaserItem"))
        {
            SaveSystem.Instance.UserData.isLaser = true;
            SaveSystem.Instance.UserData.isReinLaser = false;
            lineRenderer.enabled = true;
            lineRenderer.material = colorRed;
            AudioSource.PlayClipAtPoint(powerUpSound, other.transform.position);
            Destroy(other.gameObject);
            SaveSystem.Instance.Save();
            isLaser = SaveSystem.Instance.UserData.isLaser;
            isReinLaser = SaveSystem.Instance.UserData.isReinLaser;
        }
        else if (other.CompareTag("DiffusionShellItem"))
        {
            SaveSystem.Instance.UserData.isDiffuse = true;
            SaveSystem.Instance.UserData.isBounce = false;
            SaveSystem.Instance.UserData.isNormal = false;
            SaveSystem.Instance.UserData.isPenetration = false;
            AudioSource.PlayClipAtPoint(powerUpSound, other.transform.position);
            Destroy(other.gameObject);
            SaveSystem.Instance.Save();
            isDiffuse = SaveSystem.Instance.UserData.isDiffuse;
            isPenetration = SaveSystem.Instance.UserData.isPenetration;
            isNormal = SaveSystem.Instance.UserData.isNormal;
            isBounce = SaveSystem.Instance.UserData.isBounce;
        }
        else if (other.CompareTag("PenetrationShellItem"))
        {
            SaveSystem.Instance.UserData.isPenetration = true;
            SaveSystem.Instance.UserData.isBounce = false;
            SaveSystem.Instance.UserData.isDiffuse = false;
            SaveSystem.Instance.UserData.isNormal = false;
            AudioSource.PlayClipAtPoint(powerUpSound, other.transform.position);
            Destroy(other.gameObject);
            SaveSystem.Instance.Save();
            isDiffuse = SaveSystem.Instance.UserData.isDiffuse;
            isPenetration = SaveSystem.Instance.UserData.isPenetration;
            isNormal = SaveSystem.Instance.UserData.isNormal;
            isBounce = SaveSystem.Instance.UserData.isBounce;
        }
        else if (other.CompareTag("BounceShellItem"))
        {
            SaveSystem.Instance.UserData.isBounce = true;
            SaveSystem.Instance.UserData.isPenetration = false;
            SaveSystem.Instance.UserData.isDiffuse = false;
            SaveSystem.Instance.UserData.isNormal = false;
            AudioSource.PlayClipAtPoint(powerUpSound, other.transform.position);
            Destroy(other.gameObject);
            SaveSystem.Instance.Save();
            isDiffuse = SaveSystem.Instance.UserData.isDiffuse;
            isPenetration = SaveSystem.Instance.UserData.isPenetration;
            isNormal = SaveSystem.Instance.UserData.isNormal;
            isBounce = SaveSystem.Instance.UserData.isBounce;
        }
        else if (other.CompareTag("SpeedUpItem"))
        {
            Destroy(other.gameObject);
            if (SaveSystem.Instance.UserData.moveSpeed > 499) return;
            SaveSystem.Instance.UserData.moveSpeed += 15;
            SaveSystem.Instance.UserData.speedUpCount += 1;
            AudioSource.PlayClipAtPoint(powerUpSound, other.transform.position);
            SaveSystem.Instance.Save();
            moveSpeed = SaveSystem.Instance.UserData.moveSpeed;
            speedUpCount = SaveSystem.Instance.UserData.speedUpCount;
            speedUpText.text = speedUpCount.ToString();
        }
        else if (other.CompareTag("ReinLaserItem"))
        {
            SaveSystem.Instance.UserData.isReinLaser = true;
            SaveSystem.Instance.UserData.isLaser = false;
            lineRenderer.enabled = true;
            lineRenderer.material = colorBlue;
            AudioSource.PlayClipAtPoint(powerUpSound, other.transform.position);
            Destroy(other.gameObject);
            SaveSystem.Instance.Save();
            isLaser = SaveSystem.Instance.UserData.isLaser;
            isReinLaser = SaveSystem.Instance.UserData.isReinLaser;
        }
    }
}
