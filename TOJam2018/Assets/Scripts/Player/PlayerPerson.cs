﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TOJAM
{
    public class PlayerPerson : PlayerCart
    {

        override protected void OnTriggerEnter2D(Collider2D collider)
        {

        }

        override protected void OnCollisionEnter2D(Collision2D collision)
        {

        }

        override protected void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.tag == Constants.TAG_GROUND)
            {
                _playerRef.HitGround();
            }
        }
    }
}

