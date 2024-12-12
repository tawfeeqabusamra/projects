using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ass21
{
    public class RacingGame : MonoBehaviour
    {
        public RaceState raceState;
        void SimulateRace()
        {
            switch (raceState)
            {
                case RaceState.Start:
                    Debug.Log("The race is about to begin. Get ready!");
                    transform.position += Vector3.forward * Time.deltaTime;
                    break;
                case RaceState.Accelerate:
                    Debug.Log("You press the gas pedal. The car speeds up!");
                    transform.position += Vector3.forward * Time.deltaTime * 2;
                    break;

                case RaceState.Turn:
                    Debug.Log("You approach a sharp turn. Be careful not to crash!");
                    transform.position += Vector3.right * Time.deltaTime;
                    break;

                case RaceState.Crash:
                    Debug.Log("You hit a barrier. The race is over.");
                    break;

                case RaceState.Finish:
                    Debug.Log("You crossed the finish line. Well done!");
                    break;

                default:
                    Debug.Log("This state is not defined. Something is wrong.");
                    break;
            }



        }
        [ExecuteAlways]
        void OnValidate()
        {
            SimulateRace();
        }
        void Start()
        {

        }


        void Update()
        {
            SimulateRace();


        }
    }
}