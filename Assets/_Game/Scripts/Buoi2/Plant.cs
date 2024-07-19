﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant : Character
{
    public GameObject _bullet; //prefab viên đạn
    public Transform _bulletPos; //Vị trí bắn đạn //Hôm nay code bắn đạn theo timer
    public float _timer; // để public để nhìn khi chạy
    [SerializeField] private Animator _animator;
    [SerializeField] private Slider slider;

    private int heath = 1;

    public int Heath { get => heath; set => heath = value; }

    // Gõ các yêu cầu ở đây

    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > 3f) //đủ đk hơn 35, thay đổi chỗ này không phải cố định 35 mà ngẫu nhiên 3-5s bắn 1 lần
        {
            _animator.SetTrigger("Fire");
            _timer = 0.0f;
        }
        else
        {
            _animator.SetTrigger("Idle");

        }
    }
    private void PlaintShoot()
    {
        Instantiate(_bullet, _bulletPos.position, Quaternion.identity);
    }

    public void GetShot(float currentHeath, float maxHeath)
    {
        slider.value = currentHeath / maxHeath;
    }
}
