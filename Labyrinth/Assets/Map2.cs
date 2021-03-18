using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map2 : MonoBehaviour
{
    // Шаблоны
    public GameObject border;
    public GameObject coin;
    public GameObject finish;
    public GameObject player;

    // Грани лабиринта
    GameObject border1;
    GameObject border2;
    GameObject border3;
    GameObject border4;

    // Препятствия
    GameObject gran;
    GameObject gran1;
    GameObject gran2;
    GameObject gran3;
    GameObject gran4;
    GameObject gran5;
    GameObject gran6;
    GameObject gran7;
    GameObject gran8;
    GameObject gran9;

    // Монетки
    GameObject coin1;
    GameObject coin2;
    GameObject coin3;
    GameObject coin4;


    // Финиш
    GameObject finish_;

    // Переменные
    private float angle;
    private bool flag_for_finish;


    void Start()
    {
        this.angle = 0;


        this.create_borders();
        this.create_barriers();
        this.create_coins();

        finish_ = Instantiate<GameObject>(finish);
        finish_.transform.position = new Vector3(-100, -100, 0);
        finish_.transform.localScale = new Vector3(0.2f, 0.2f, 0);
        finish_.gameObject.AddComponent<CircleCollider2D>();
        finish_.gameObject.AddComponent<CircleCollider2D>().isTrigger = true;

        Debug.Log(flag_for_finish);
        Debug.Log(finish_);

    }

    void Update()
    {
        key_handler();


        if (!flag_for_finish && (player.GetComponent<PlayerBehavoiur>().coins.ToString() == "4"))
        {
            flag_for_finish = true;
        };
    }


    /// <summary>
    /// Создание препятствий
    /// </summary>
    public void create_barriers()
    {

        gran = Instantiate<GameObject>(border);
        gran.transform.position = new Vector3((3.2f) * Mathf.Cos((float)(0.9f + 4.71f)), (3.2f) * Mathf.Sin((float)(0.9f + 4.71f)), 0);
        gran.transform.localScale = new Vector3(0.1f, 3.9f, 0);
      

        gran1 = Instantiate<GameObject>(border);
        gran1.transform.position = new Vector3((2f) * Mathf.Cos((float)(-0.1f + 1.57f)), (2f) * Mathf.Sin((float)(-0.1f + 1.57f)), 0);
        gran1.transform.localScale = new Vector3(5, 0.1f, 0);


        gran2 = Instantiate<GameObject>(border);
        gran2.transform.position = new Vector3((1f) * Mathf.Cos((float)(0.5f + 1.57f)), (1f) * Mathf.Sin((float)(0.5f + 1.57f)), 0);
        gran2.transform.localScale = new Vector3(0.1f, 3.8f, 0);


        gran3 = Instantiate<GameObject>(border);
        gran3.transform.position = new Vector3((1f) * Mathf.Cos((float)(-0.20f + 4.71f)), (1f) * Mathf.Sin((float)(-0.20f + 4.71f)), 0);
        gran3.transform.localScale = new Vector3(3, 0.1f, 0);
        SpriteRenderer sp3 = gran3.GetComponent<SpriteRenderer>();
        sp3.color = Color.black;
        gran3.gameObject.AddComponent<BoxCollider2D>().isTrigger = true;


        gran4 = Instantiate<GameObject>(border);
        gran4.transform.position = new Vector3((1.82f) * Mathf.Cos((float)(1.5f + 4.71f)), (1.82f) * Mathf.Sin((float)(1.5f + 4.71f)), 0);
        gran4.transform.localScale = new Vector3(1.3f, 0.1f, 0);
        

        gran5 = Instantiate<GameObject>(border);
        gran5.transform.position = new Vector3((1.3f) * Mathf.Cos((float)(1.2f + 4.71f)), (1.3f) * Mathf.Sin((float)(1.2f + 4.71f)), 0);
        gran5.transform.localScale = new Vector3(0.1f, 3f, 0);
        SpriteRenderer sp5 = gran5.GetComponent<SpriteRenderer>();
        sp5.color = Color.black;
        gran5.gameObject.AddComponent<BoxCollider2D>().isTrigger = true;


        gran6 = Instantiate<GameObject>(border);
        gran6.transform.position = new Vector3((2.2f) * Mathf.Cos((float)(-0.85f + 4.71f)), (2.2f) * Mathf.Sin((float)(-0.85f + 4.71f)), 0);
        gran6.transform.localScale = new Vector3(0.1f, 1f, 0);


        gran7 = Instantiate<GameObject>(border);
        gran7.transform.position = new Vector3((3.2f) * Mathf.Cos((float)(-0.15f + 4.71f)), (3.2f) * Mathf.Sin((float)(-0.15f + 4.71f)), 0);
        gran7.transform.localScale = new Vector3(0.1f, 1.7f, 0);

        gran8 = Instantiate<GameObject>(border);
        gran8.transform.position = new Vector3((3f) * Mathf.Cos((float)(-1.7f + 4.71f)), (3f) * Mathf.Sin((float)(-1.7f + 4.71f)), 0);
        gran8.transform.localScale = new Vector3(2.1f, 0.1f, 0);



    }

    /// <summary>
    /// Создание границ лабиринта
    /// </summary>
    public void create_borders()
    {
        // верхняя
        border1 = Instantiate<GameObject>(border);
        border1.transform.position = new Vector3(0, 4 + 0.05f, 0);
        border1.transform.localScale = new Vector3(8, 0.1f, 0);
        SpriteRenderer sp1 = border1.GetComponent<SpriteRenderer>();
        sp1.color = Color.white;

        // правая
        border3 = Instantiate<GameObject>(border);
        border3.transform.position = new Vector3(4 + 0.05f, 0, 0);
        border3.transform.localScale = new Vector3(0.1f, 8, 0);
        border3.gameObject.AddComponent<BoxCollider2D>().isTrigger = true;
        SpriteRenderer sp3 = border3.GetComponent<SpriteRenderer>();
        sp3.color = Color.black;
      

        // нижняя
        border2 = Instantiate<GameObject>(border);
        border2.transform.position = new Vector3(0, -4 - 0.05f, 0);
        border2.transform.localScale = new Vector3(8, 0.1f, 0);
        SpriteRenderer sp2 = border2.GetComponent<SpriteRenderer>();
        sp2.color = Color.white;


        // левая
        border4 = Instantiate<GameObject>(border);
        border4.transform.position = new Vector3(-4 - 0.05f, 0, 0);
        border4.transform.localScale = new Vector3(0.1f, 8, 0);
        SpriteRenderer sp4 = border4.GetComponent<SpriteRenderer>();
        sp4.color = Color.white;
    }

    /// <summary>
    /// Создание монеток
    /// </summary>
    private void create_coins()
    {
        coin1 = Instantiate<GameObject>(coin);
        coin1.transform.position = new Vector3((2.3f) * Mathf.Cos((float)(1.2f + 3.14f)), (2.3f) * Mathf.Sin((float)(1.2f + 3.14f)), 0);
        coin1.transform.localScale = new Vector3(0.5f, 0.5f, 0);
        coin1.gameObject.AddComponent<CircleCollider2D>();
        coin1.gameObject.AddComponent<CircleCollider2D>().isTrigger = true;

        coin2 = Instantiate<GameObject>(coin);
        coin2.transform.position = new Vector3((2) * Mathf.Cos((float)(2.8f + 3.14f)), (2) * Mathf.Sin((float)(2.8f + 3.14f)), 0);
        coin2.transform.localScale = new Vector3(0.5f, 0.5f, 0);
        coin2.gameObject.AddComponent<CircleCollider2D>();
        coin2.gameObject.AddComponent<CircleCollider2D>().isTrigger = true;

        coin3 = Instantiate<GameObject>(coin);
        coin3.transform.position = new Vector3((0) * Mathf.Cos((float)(1 + 3.14f)), (0) * Mathf.Sin((float)(1 + 3.14f)), 0);
        coin3.transform.localScale = new Vector3(0.5f, 0.5f, 0);
        coin3.gameObject.AddComponent<CircleCollider2D>();
        coin3.gameObject.AddComponent<CircleCollider2D>().isTrigger = true;

        coin4 = Instantiate<GameObject>(coin);
        coin4.transform.position = new Vector3((-3) * Mathf.Cos((float)(1 + 3.14f)), (-3) * Mathf.Sin((float)(1 + 3.14f)), 0);
        coin4.transform.localScale = new Vector3(0.5f, 0.5f, 0);
        coin4.gameObject.AddComponent<CircleCollider2D>();
        coin4.gameObject.AddComponent<CircleCollider2D>().isTrigger = true;
    }



    /// <summary>
    /// Считывает нажатие кнопок
    /// </summary>
    private void key_handler()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.angle += 0.005f;
            this.transform_objects();
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.angle -= 0.005f;
            this.transform_objects();
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.angle += 0.005f;
            this.transform_objects();
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.angle -= 0.005f;
            this.transform_objects();
        }

    }

    /// <summary>
    /// Поворот всех объектов
    /// </summary>
    public void transform_objects()
    {
        if (flag_for_finish) this.transform_object(finish_, "up", 1, 1);


        this.transform_object(border1, "up", 4);
        this.transform_object(border2, "down", 4);
        this.transform_object(border3, "right", 4);
        this.transform_object(border4, "left", 4);

        this.transform_object(gran, "down", 3.2f, 0.9f);
        this.transform_object(gran1, "up", 2f, -0.1f);
        this.transform_object(gran2, "up", 1f, 0.5f);
        this.transform_object(gran3, "down", 1f, -0.20f);
        this.transform_object(gran4, "down", 1.82f, 1.5f);
        this.transform_object(gran5, "down", 1.3f, 1.2f);
        this.transform_object(gran6, "down", 2.2f, -0.85f);
        this.transform_object(gran7, "down", 3.2f, -0.15f);
        this.transform_object(gran8, "down", 3f, -1.7f);

        this.transform_object(coin1, "left", 2.3f, 1.2f);
        this.transform_object(coin2, "left", 2, 2.8f);
        this.transform_object(coin3, "left", 0, 1f);
        this.transform_object(coin4, "left", -3, 1);

    }

    /// <summary>
    /// Поворот объекта на заданные угол
    /// </summary>
    public void transform_object(GameObject obj, string position, float R, float tmp = 0)
    {

        // Прикрепление к грани лабиринта
        float tmp_angle = this.angle;

        switch (position)
        {
            case "up":
                tmp_angle += 1.57f;
                break;

            case "right":
                tmp_angle += 0;
                break;

            case "down":
                tmp_angle += 4.71f;
                break;

            case "left":
                tmp_angle += 3.14f;
                break;
        }
        tmp_angle += tmp;
        if (obj)
        {
            obj.transform.rotation = Quaternion.Euler(0, 0, this.angle * 57.3f);
            obj.transform.position = new Vector3((R + 0.05f) * Mathf.Cos((float)(tmp_angle)), (R + 0.05f) * Mathf.Sin((float)(tmp_angle)), 0);
        }

    }
}

