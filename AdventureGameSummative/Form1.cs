using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
//Kashish Dhanoa
//
namespace AdventureGameSummative
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;
        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
            //starting text
            outputLabel.Text = "Welcome to the Wizarding World. I've got a *secret* quest for you! That is, " +
                        "if you're from Gryffindor house.\n\nAre you from Gryffindor House??";
            redLabel.Text = "I am!";
            blueLabel.Text = "I am not sure...";
            yellowLabel.Text = "I am not.";
            sceneImageBox.BackgroundImage = Properties.Resources.gryf;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 10;
                }
                else if (scene == 2)
                {
                    scene = 0;
                }
                else if (scene == 3)
                {
                    scene = 4;
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
                else if (scene == 5)
                {
                    scene = 8;
                }
                else if (scene == 6)
                {
                    scene = 0;
                }
                else if (scene == 7)
                {
                    scene = 10;
                }
                else if (scene == 8)
                {
                    scene = 0;
                }
                else if (scene == 9)
                {
                    scene = 0;
                }
                else if (scene == 10)
                {
                    scene = 12;
                }
                else if (scene == 11)
                {
                    scene = 0;
                }
                else if (scene == 12)
                {
                    scene = 14;
                }
                else if (scene == 13)
                {
                    scene = 0;
                }
                else if (scene == 14)
                {
                    scene = 16;
                }
                else if (scene == 15)
                {
                    scene = 0;
                }
                else if (scene == 16)
                {
                    scene = 0;
                }
                else if (scene == 17)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 21;
                }
                else if (scene == 19)
                {
                    scene = 21;
                }
                else if (scene == 20)
                {
                    scene = 23;
                }
                else if (scene == 21)
                {
                    scene = 25;
                }
                else if (scene == 22)
                {
                    scene = 0;
                }
                else if (scene == 23)
                {
                    scene = 0;
                }
                else if (scene == 24)
                {
                    scene = 0;
                }
                else if (scene == 25)
                {
                    scene = 0;
                }
                else if (scene == 26)
                {
                    scene = 0;
                }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 3;
                }
                else if (scene == 1)
                {
                    scene = 11;
                }
                else if (scene == 2)
                {
                    scene = 27;
                }
                else if (scene == 3)
                {
                    scene = 5;
                }
                else if (scene == 4)
                {
                    scene = 7;
                }
                else if (scene == 5)
                {
                    scene = 9;
                }
                else if (scene == 6)
                {
                    scene = 27;
                }
                else if (scene == 7)
                {
                    scene = 11;
                }
                else if (scene == 8)
                {
                    scene = 27;
                }
                else if (scene == 9)
                {
                    scene = 27;
                }
                else if (scene == 10)
                {
                    scene = 13;
                }
                else if (scene == 11)
                {
                    scene = 27;
                }
                else if (scene == 12)
                {
                    scene = 15;
                }
                else if (scene == 13)
                {
                    scene = 27;
                }
                else if (scene == 14)
                {
                    scene = 17;
                }
                else if (scene == 15)
                {
                    scene = 27;
                }
                else if (scene == 16)
                {
                    scene = 27;
                }
                else if (scene == 17)
                {
                    int value = randGen.Next(1, 101);

                    if (value < 70)
                    {
                        scene = 20;
                    }
                    else
                    {
                        scene = 19;
                    }
                }
                else if (scene == 18)
                {
                    scene = 22;
                }
                else if (scene == 19)
                {
                    scene = 22;
                }
                else if (scene == 20)
                {
                    scene = 24;
                }
                else if (scene == 21)
                {
                    scene = 26;
                }
                else if (scene == 22)
                {
                    scene = 27;
                }
                else if (scene == 23)
                {
                    scene = 27;
                }
                else if (scene == 24)
                {
                    scene = 27;
                }
                else if (scene == 25)
                {
                    scene = 27;
                }
                else if (scene == 26)
                {
                    scene = 27;
                }
            }
            else if (e.KeyCode == Keys.N)  //yellow button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }
            }
            switch (scene)
            {//Display text and game options to screen based on the current scene 
                case 0://start scene
                    outputLabel.Text = "Welcome to the Wizarding World. I've got a *secret* quest for you! That is, " +
                        "if you're from Gryffindor house.\n\nAre you from Gryffindor House??";
                    redLabel.Text = "I am!";
                    blueLabel.Text = "I am not sure...";
                    yellowLabel.Text = "I am not.";
                    sceneImageBox.BackgroundImage = Properties.Resources.gryf;
                    break;
                case 1:
                    outputLabel.Text = "It is likely that you may not return home after this quest, nor can your safety be guaranteed." +
                        "Upon quest completion, you will gain house points!\n\nWould you like to begin your quest?";
                    redLabel.Text = "Yes!";
                    blueLabel.Text = "No.";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.castle;
                    break;
                case 2:
                    outputLabel.Text = "This is the GRYFFINDOR Quest Request, so, unfortunately, I have no available quests for you. " +
                        "Come back in the upcoming weeks to see what I have in store!\n\n Play again?";

                    redLabel.Text = "Yes!";
                    blueLabel.Text = "No.";
                    yellowLabel.Text = "";
                    break;
                case 3:
                    outputLabel.Text = "Well let's find out what house you're in!\n\nDo you tend to make decisions using your gut " +
                        "feeling?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.coa;
                    break;
                case 4:
                    outputLabel.Text = "You walk into a room and find a jerk being rude to your best friend (even though your best " +
                        "friend did nothing wrong). They both exit the room through separate doors.\n\n Do you follow and talk to your " +
                        "friend first?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No, I go after the JERK!";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.coa;
                    break;
                case 5:
                    outputLabel.Text = "You walk into a room and find a jerk being rude to your best friend (even though your best " +
                        "friend did nothing wrong). They both exit the room through separate doors.\n\nDo you follow and talk to the " +
                        "jerk first?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No, I go after my friend!";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.coa;
                    break;
                case 6:
                    outputLabel.Text = "Unfortunately you are a Hufflepuff! You cannot complete this quest at this time. " +
                        "Come back in 3 weeks for my Hufflepuff quests!\n\nPlay Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.huffle;
                    break;
                case 7:
                    outputLabel.Text = "Congratulations! You are a Gryffindor. You may take on this quest! It is likely " +
                        "that you may not return home after this quest, nor can your safety be guaranteed.  " +
                        "Upon quest completion, you will gain house points!\n\n Would you like to begin your quest? ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "Unfortunately you are a Slytherin! You cannot complete this quest at this time. " +
                        "Come back in next week for my Slytherin quests!\n\nPlay Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.slyth;
                    break;
                case 9:
                    outputLabel.Text = "Unfortunately you are a Ravenclaw! You cannot complete this quest at this time. " +
                        "Come back in 2 weeks for my Ravenclaw quests!\n\nPlay Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.raven;
                    break;
                case 10:
                    outputLabel.Text = "Your quest is to retrieve a magical red amethyst. The closest one is located in the Den of Dragons. " +
                        "You have until dusk in 2 days time. The sooner you leave the better.\n\nWill you leave for your quest tonight or " +
                        "tommorow at dawn?";
                    redLabel.Text = "I will leave tonight!";
                    blueLabel.Text = "I will leave tomorrow at dawn...";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.red;
                    break;
                case 11:
                    outputLabel.Text = "Alright. Come back soon to see if I have another quest for you. Goodbye! \n\n Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "Good choice. It's hard to see at night, so you sneaked away quietly! Because of the lack of " +
                        "light, you didn't see that you stepped on a small Acromantula until its family started to surround you " +
                        "(or at least, that's what you assume). You see a clear opening you could run through to escape the " +
                        "Acromantula.\n\nWill you sprint through the opening or will you use Lumos to help you see in the dark?";
                    redLabel.Text = "I'll sprint through the opening!";
                    blueLabel.Text = "I will use Lumos to help me see.";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.acro;
                    break;
                case 13:
                    outputLabel.Text = "Uh oh. Remember this was a SECRET quest... Prof. McGonagall caught you wandering about. " +
                        "No more adventuring for you today. Come back in a few weeks for another quest!\n\nPlay Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.mcgona;
                    break;
                case 14:
                    outputLabel.Text = "Wow, you're fast! You've just left the forbidden forest. You seem tired.\n\nWould you like to " +
                        "set up camp and rest for a few hours or continue your journey by foot?";
                    redLabel.Text = "I'm tired, I should rest!";
                    blueLabel.Text = "I should continue my journey, can't slow down!";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.tent;

                    break;
                case 15:
                    outputLabel.Text = "Bad idea!!! By the time you get your wand out, the Acromantula have completely surrounded you. " +
                        "You just gave them a tasty meal!\n\nPlay Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.acro;
                    break;
                case 16:
                    outputLabel.Text = "Uh, oh. During your sleep the Acromantula found you and took you back for an early snack!" +
                        "\n\nPlay Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.acro;
                    break;
                case 17:
                    outputLabel.Text = "Great, you must keep going! You've now been walking peacefully for hours. Suddenly you " +
                        "encounter a fork in the path. One path is filled bushes, shrubs and overgrown grass, the other has a muddy " +
                        "trail and branches dead leaves.\n\n Which path do you choose?";
                    redLabel.Text = "The path with overgrown grass, shrubs and bushes!";
                    blueLabel.Text = "The muddy trail with branches and dead leaves!";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.fork;
                    break;
                case 18:
                    outputLabel.Text = "The road less traveled was a good choice. You camp out for the night using a disillusionment " +
                        "charm. You slept peacefully. When you wake up you continue your hike. Before you reach the Den of Dragons " +
                        "at the top of a mountain, you must cross the Lake of Shining Pebbles. As you use your boat (that you luckily " +
                        "packed), you realize you've run out of drinking water.\n\nWill you get water from your one-time Agumenti " +
                        "Charm or will you drink from the Lake? ";
                    redLabel.Text = "I'll use my Agumenti Charm!";
                    blueLabel.Text = "I'll just drink from the Lake.";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.boat;
                    break;
                case 19:
                    outputLabel.Text = "You continue down the path and reach a nearby brook. You rest and use your disillusionment " +
                        "charm. You slept peacefully. When youwake up, you follow the brook for hours until you reach the Lake of " +
                        "Shining Pebbles. As you use your boat to cross the river, you realize you have run out of drinking water.\n\n" +
                        " Will you get water from your one-time Agumenti Charm or will you drink from the Lake?";
                    redLabel.Text = "I'll use my Agumenti Charm!";
                    blueLabel.Text = "I'll just drink from the Lake.";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.boat;
                    break;
                case 20:
                    outputLabel.Text = "Uh, oh. You walked right into an invisible centaur trap. Some witches and wizards " +
                        "come to see what they've caught. When they realize they've caught YOU they debate bribing you or " +
                        "giving you a forgetfulness charm.\n\n What should you suggest for them to do?  ";
                    redLabel.Text = "I should tell them to bribe me.";
                    blueLabel.Text = "I should tell them to use a forgetfullness charm on me!";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.wizard;
                    break;
                case 21:
                    outputLabel.Text = "Though this charm is one use. You are hydrated and ready to go! On your final stretch of your " +
                        "journey you must sneak past the Fire-breathing Guardian Dragon. You can see the amethyst, it is so close. " +
                        "You could use your cloak of invisibility to sneak past the dragon, or apparate to the other side.\n\nShould you " +
                        "use your cloak or should you apparate?";
                    redLabel.Text = "I'm gonna use my invisibility cloak!";
                    blueLabel.Text = "I'm gonna apparate!";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.mount;

                    break;
                case 22:
                    outputLabel.Text = "Oh no, you've disturbed the Merpeople. Because you didn't bring anything to help you " +
                        "breathe underwater, you get sucked under. You make a fantastic mermaid meal!\n\nPlay Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.mer;
                    break;
                case 23:
                    outputLabel.Text = "The witches and wizards give in. You've made an oath to not tell anyone about this trap, " +
                        "in return they gift you a RED AMYTHST! CONGRAGULATIONS! You have successfully completed your quest. " +
                        "Your house gains 85 points!!\n\nPlay Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.red;
                    break;
                case 24:
                    outputLabel.Text = "The witches and wizards agree. They cast a forgetfulness charm on you and apparate you back" +
                        " to Hogwarts. You failed your quest. No house points for you.\n\n Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.castle;
                    break;
                case 25:
                    outputLabel.Text = "Woohoo!!! You are sneakkkyy! You've got the magical red amethyst! I knew you could do it! Your house " +
                        "gains 100 points! Apparate back home! Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.red;
                    break;
                case 26:
                    outputLabel.Text = "Oh no! You've awaken the Guardian Dragon. She could sense your apparition magic right away. " +
                        "It took her seconds to find you. You were burnt to a crisp.\n\nPlay Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    sceneImageBox.BackgroundImage = Properties.Resources.dragonangry;
                    break;
                case 27:
                    outputLabel.Text = "Thanks for playing!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                default:
                    break;
            }
        }
    }
}
