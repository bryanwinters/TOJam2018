﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TOJAM
{
    public static class Constants 
    {
        //ENUMS
        public enum GameState { none, menu, game, gameOver, paused, launching}
        public enum PlatformDifficulty { none, easy, medium, hard, expert}
        public enum ObstacleType { none, rockSmall, rockMed, rockLarge, trafficCone, oil, goat, car, barrier}

        //GAMEPLAY VARIABLES
        public const float PLAYER_BASE_SPEED = 0f;

        //TAGS
        public const string TAG_PLAYER_CART = "PlayerCart";
        public const string TAG_PLAYER_PERSON = "PlayerPerson";
        public const string TAG_GROUND = "Ground";
        public const string TAG_OBSTACLE = "Obstacle";

        public static float GetSpeedForObstacle (ObstacleType type)
        {
            switch(type)
            {
                case ObstacleType.barrier:
                    return -100f;
                case ObstacleType.car:
                    return -100f;
                case ObstacleType.goat:
                    return -50f;
                case ObstacleType.none:
                    return 0f;
                case ObstacleType.oil:
                    return 10f;
                case ObstacleType.rockLarge:
                    return -20f;
                case ObstacleType.rockMed:
                    return -10f;
                case ObstacleType.rockSmall:
                    return -5f;
                case ObstacleType.trafficCone:
                    return -15f;
                default:
                    return 0f;
            }
        }
    }
}

