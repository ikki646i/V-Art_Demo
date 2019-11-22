using UnityEngine;
using UnityEngine.Video;
using System.Collections;
namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonPressedHandler : MonoBehaviour
    {
        public HoverButton hoverButton;

        public GameObject player;
        public GameObject target;

        public bool useVideo = false;
        public VideoPlayer video;

        private void Start()
        {
            hoverButton.onButtonDown.AddListener(OnButtonDown);
        }

        private void OnButtonDown(Hand hand)
        {
            player.transform.position = target.transform.position;
            if (useVideo) {
                video.frame = 2250;
                video.Play();
            }
        }
    }
}