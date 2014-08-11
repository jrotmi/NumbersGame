using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumbersGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int currentNumber = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var enterNewNumber = true;

            while (enterNewNumber)
            {

                string userString = TextBoxUserInput.Text;
                int userInput;
                int.TryParse(userString, out userInput);
                currentNumber = currentNumber + userInput;
                //int gameStanding = 0;

                var retry = true;

                while (retry)
                {
                    if (currentNumber < 21)
                    {
                        Random rnd = new Random();
                        int computerNumber = rnd.Next(1, 3);
                        currentNumber = currentNumber + computerNumber;

                        if (currentNumber >= 21)
                        {
                            TextBlockBanter.Text = " Ahahahhahahah! YES! YES! I WIN! I WAS BORN FOR THIS!!";

                            currentNumber = 0;

                            TextBoxUserInput.Text = "";

                            enterNewNumber = false;

                            break;
                        }
                        else
                        {
                            TextBoxUserInput.Text = "";

                            TextBlockBanter.Text = " Go ahead, your turn! It's only going to bring you closer to your demise.... Hahhahahah!!!!!";
                            retry = false;

                        }
                    }
                    else if (currentNumber >= 21)
                    {
                        TextBlockBanter.Text = " Noooooooo! This is NOT possible! I lost! What is my mother gonna say?!";

                        currentNumber = 0;
                        enterNewNumber = false;
                        break;
                    }
                }

                break;
            }
            }

        }
    }

