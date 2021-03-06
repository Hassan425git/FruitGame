using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game {
    public class ScrDestroyOnCol: MonoBehaviour
    {
        public static int characterAmount = 3;
        public GameObject[] characters = new GameObject[characterAmount];
        public GameObject particleObj;
        private ParticleSystem ps;
        public static int count=0;
        Text score;
        Text highscore;
        void Start()
        {
            ps = particleObj.GetComponent<ParticleSystem>();
            var em = ps.emission;
            em.enabled = false;
            highscore.text = PlayerPrefs.GetInt("High Score",0).ToString();
            //score = GetComponent<Text>();
        }

        void Update()
        {
            GameObject selectedChar = null;

            for (int i = 0; i < characterAmount; i++) {
                if (characters[i].GetComponent<ScrMovement>().selected) {
                    selectedChar = characters[i];
                }
            }

            if (selectedChar != null) {
                float distToChar = Vector3.Distance(selectedChar.transform.position, transform.position);

                if (distToChar < 0.5 && Input.GetKeyDown(KeyCode.E)) {

                    if (particleObj) {
                        particleObj.transform.position = transform.position;
                    }

                    var em = ps.emission;
                    ps.Clear();
                    ps.Play();
                    em.enabled = true;

                    Destroy(gameObject);
                    count = count + 1;
                }
            }
            int number = Random.Range(1,3);
            highscore.text = number.ToString();

            PlayerPrefs.SetInt("High Score", number);

           // score.text = "score text" + count;

        }

        
    }
}
