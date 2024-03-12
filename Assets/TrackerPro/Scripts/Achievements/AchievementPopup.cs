using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace TrackerPro
{
    public class AchievementPopup : MonoBehaviour
    {
        [SerializeField]
        private Settings settings;

        [SerializeField]
        private TextMeshProUGUI achievementTitleText;

        [SerializeField]
        private Image achievementIconImage;

        [SerializeField]
        private Animator animator;


        private void Start()
        {
            if(animator == null)
            {
                animator.GetComponent<Animator>();
            }
            TrackerProEvents.AchievementGranted += ShowAchievementAndSetValues;
        }

        public void ShowAchievementAndSetValues(Achievement achievement)
        {
            animator.Play("AchievementGrantedAnimation", 0, 0f);
            string path = achievement.trimmedIconPath;
            achievementIconImage.sprite = Resources.Load<Sprite>(path);
            achievementTitleText.text = string.Format("{0} completed!", achievement.title);
        }
    }

}


