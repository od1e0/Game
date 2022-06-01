//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class TurellControler : MonoBehaviour
//{
//    [SerializeField] float VisionRadius = 10;
//    [SerializeField] GameObject BulletPrefab;
//    [SerializeField] float CooldownTime;
//    [SerializeField] Transform Joint;
//    [SerializeField] Transform AmmoHead;
//    [SerializeField] Transform TestObject;
//    [SerializeField] float RotationSpeed = 1;



//    private SphereCollider _visionCollider;
//    private Transform _playerPos;
//    private float _currentTime;

//    void Awake()
//    {
//        _visionCollider = GetComponent<SphereCollider>();
//    }
//    // Start is called before the first frame update
//    void Start()
//    {
//        _visionCollider.radius = VisionRadius;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (_playerPos != null)
//        {
//            _currentTime += Time.deltaTime;
//        }
//        var rotDirection = TestObject.position - Joint.position;
//        Joint.rotation = Quaternion.LookRotation(rotDirection.normalized);
//    }

//    void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("Player"))
//        { 
//            _playerPos = other.gameObject.transform;
//        }

//    }

//    void OnTriggerStay(Collider other)
//    {
//        if (_currentTime >= CooldownTime)
//        {
//            var ray = new Ray(AmmoHead.position, AmmoHead.forward);
           
            
            
//            _currentTime = 0;
//        }
//    }

//    private void OnTriggerExit(Collider other)
//    {
//        IEnumerator Fire()
//        {
//            while (true)
//            {
//                var bullet = Instantiate(BulletPrefab, AmmoHead.position, Quaternion.identity);
//                bullet.GetComponent<Bullet>().MoveBullet = transform.position;
//                yield return new WaitForSeconds(1);
//            }
//        }
//    }
     

     
     
//}


