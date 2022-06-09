using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace puzzle
{
    public class PuzzleManager : MonoBehaviour
    {
         private bool cushion1, cushion2, cushion3, cushion4;

         private bool latern1, latern2;
        
        [SerializeField] private GameObject basementKey;
        [SerializeField] private GameObject gardenKey;

        void Update()
        {
            if (cushion1 && cushion2 && cushion3 && cushion4)
            {
                basementKey.gameObject.SetActive(true);
            }

            if (latern1 && latern2)
            {
                gardenKey.gameObject.SetActive(true);
            }
        }

        public void CushionActivation(int number)
        {
            switch (number)
            {
                case 1:
                    cushion1 = true;
                    break;
                case 2 when cushion1:
                    cushion2 = true;
                    break;
                case 3 when cushion2:
                    cushion3 = true;
                    break;
                case 4 when cushion3:
                    cushion4 = true;
                    break;
            }
        }

        public void LaternActivation(int number)
        {
            switch (number)
            {
                case 1:
                    latern1 = true;
                    break;
                case 2:
                    latern2 = true;
                    break;
            }
        }
    }
}