using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObj : MonoBehaviour
{
    public AudioClip clip;
    private Vector3 nowMoveDir = Vector3.zero;
    public float moveSpeed = 10;
    public float roundSpeed = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    /// <summary>
    /// 开火方法
    /// </summary>
    public void Fire()
    {
        if (MusicData.soundIsOpen)
        {
            AudioSource audio = this.gameObject.AddComponent<AudioSource>();
            audio.clip = clip;
            audio.volume = MusicData.volume;
            audio.Play();
            Destroy(audio, 1.8f);
        }
        Instantiate(Resources.Load<GameObject>("Bullet"),this.transform.position,this.transform.rotation);
    }

    public void MoveGyro(Vector2 dir)
    {
        nowMoveDir.x = dir.x;
        nowMoveDir.z = dir.y;
        nowMoveDir.y = 0;

    }
    private void Update()
    {
        if (nowMoveDir != Vector3.zero)
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(nowMoveDir), 40 * Time.deltaTime);
        }
    }
}
