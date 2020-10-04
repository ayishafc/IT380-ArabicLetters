using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
//Scene currentScene;

public class CanvasUIFunctions : MonoBehaviour
{
    [Header("Title Scene Properties", order = 0)]
    [Space(2f)]
    [Header("Intro Scene Properties", order = 1)]
    public GameObject introImage;
    public GameObject backButton;
    public GameObject nextButton;
    public Color backgroundColor;
    public TMP_Text introText;
    public TMP_Text titleText;
    [Header("Tutorial Scene Properties", order = 2)]
    [Space(2f)]
    [Header("Level01 Scene Properties", order = 3)]

    int introSequence;
    Scene currentScene;

    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Awake()
    {
        currentScene = SceneManager.GetActiveScene();
        switch (currentScene.name)
        {
            case "00TitleScreen":
                break;
            case "01IntroScene":
                introText.horizontalAlignment = HorizontalAlignmentOptions.Center;
                introText.text = " Arabic Under the Sea\n\n" + "Learn to read and speak Arabic!";
                introImage.SetActive(true);
                backButton.SetActive(false);
                titleText.text = "";
                break;
            case "02Tutorial":
                break;
            case "03Level01":
                break;
        }
    }

    public void IntroSequenceBack()
    {
        introSequence = introSequence - 2;
        IntroSequenceNext();
    }
    public void IntroSequenceNext()
    {
        introSequence++;
        switch (introSequence)
        {
            case 0:
                introText.horizontalAlignment = HorizontalAlignmentOptions.Center;
                introText.text = "Arabic Under the Sea \n \n" + "Learn to read and speak Arabic!";
                introImage.SetActive(true);
                backButton.SetActive(false);
                titleText.text = "";
                break;
            case 1:
                introImage.SetActive(false);
                backButton.SetActive(true);
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                titleText.text = "OVERVIEW";
                introText.text = "Title: Arabic Under the Sea\n" +
                                 "Platform: WebGL Build\n" +
                                 "Subject: Language\n" +
                                 "Sub-Subject: Reading\n" +
                                 "Main Focus: Arabic\n" +
                                 "Learning Level: Ages 2-4";
                break;
            case 2:
                titleText.text = "PROPOSED ED TECH SOLUTION";
                introText.text = "In recent years, the amount of time children spend on electronic devices has increased rapidly. I propose an app that teaches children how to read and speak Arabic using a tablet and mobile game with interactivity and immersion into the language.";
                break;
            case 3:
                titleText.text = "COMPETING SOFTWARE REVIEW";
                introText.text = "DinoLingo: DinoLingo teaches children a variety of languages by using color, music, and interactive play. It utilizes a point and reward system where the child can earn new dinosaurs as they progress through the level."+
                                 "\n\nEndlessAlphabet: Endless Alphabet teaches children how to read and pronounce English letters by giving the student a word with scrambled letters and an outline. The child has to drag the letters to fill in the word. Once the word is filled, it reads them the word and puts it in a sentence. The company also has a variant of the app for Spanish.";
                break;
            case 4:
                titleText.text = "COMPETING SOFTWARE SUGGESTED IMPROVEMENTS";
                introText.text = "Interactivity - while DinoLingo has interactive features, it focuses on using interaction for proceeding to the next stage of learning rather than as a means of transmitting information. I would change this in the app by having the child interact with the word directly instead of the functionality surrounding the word.\n" +
                    "Speaking vs Reading/Writing - most language learning apps for adults and especially for children focus on learning vocabulary and recognizing words on sight but rarely teach how to read and write the language. While recognizing words and their meanings is important, reading is an area that is generally lacking.\n";
                break;
            case 5:
                introText.text = "Engagement - most English-medium children’s apps focused on teaching languages use English to translate the words. For example, they write the word for ball (kurah in Arabic) and also write ‘ball’ in English with a picture to show a ball. While this strategy works for adults, it can confuse young children who will effectively pick up the language without the English translation. Immersion is the best way to learn a new language and is especially effective in younger children. Using the words the child interacted with in a sentence allows them to learn the language and its structure through immersion and the vocabulary and pronunciation through the main gameplay of the app.";
                titleText.text = "COMPETING SOFTWARE SUGGESTED IMPROVEMENTS cont'd";
                break;
            case 6:
                introText.text = "STAKEHOLDERS \n Parents, Children\n\n" +
                    "USERS \n Children aged";
                titleText.text = "STAKEHOLDERS AND USERS";
                break;
            case 7:
                introText.text = "Name: Karim\n" +
                    "Age: 3 Years Old\n" +
                    "Gender: Male\n" +
                    "Location: Suburbia, NJ\n" +
                    "Personal Notes: Enjoys being active and playing with any kind of ball\nLoves to play with other people\nLikes to play on the iPad\nUnderstands English and Bangla\n" +
                    "Student Notes: Doesn't have a long attention span\nDoes not liker reading or bedtime stories.";
                titleText.text = "PERSONA";
                break;
            case 8:
                introText.text = "After observing 3 year old boys around me, I decided to create a persona called Karim. He is a representative of most rambunctious 3 year olds that don’t have a large attention span but a lot of curiosity. I chose this age range for the app and 3 for the persona because that is when the brain learns languages the most efficiently.";
                titleText.text = "PERSONA JUSTIFICATION";
                break;
            case 9:
                introText.text = "Karim spends a lot of time playing mindless games on the iPad. His mom is concerned that he could be spending that time learning and doing more active learning tasks. However, Karim doesn’t seem to like any alphabet or number app she gives him. He also doesn’t like the memory card games that she gives him and throws a fit when she tries to read him a book. She wants him to learn arabic from someone who can pronounce the language properly so he has an easier time when he’s older. She doesn’t want him to struggle with the pronunciation when he’s older the way she struggles.";
                titleText.text = "PROBLEM SCENARIO";
                break;
            case 10:
                introText.text = "Karim’s mom searches the app store for an Arabic learning app she hasn’t tried yet and stumbles on Arabic Under the Sea. She downloads a trial of it, hoping that the ocean theme will attract Karim’s attention. He begins playing the game and it keeps him entertained for a while. Later that day, he comes to his mom and points at their fish and says “samak (arabic for fish)”. His mom is overjoyed and downloads the rest of the game for him.";
                    titleText.text = "ACTIVITY SCENARIO";
                break;
            case 11:
                nextButton.SetActive(false);
                introText.text = "Karim doesn’t like to sit still and is bored by most learning apps but his mom wants him to learn proper Arabic. She also wants him to spend less time playing mindless games on the iPad. She knows this is the best time to make sure he learns the language in its pure form and does whatever she can to make sure he has a better experience than she did. She thinks that an app might be the way to go because he gets excited as soon as he sees it and will at least try whatever she gives him on it. Once he begins playing the game, he is amused by the fun colors and animations and learns arabic words and letters as he plays.";
                titleText.text = "PROBLEM STATEMENT";
                break;
        }
    }
}
