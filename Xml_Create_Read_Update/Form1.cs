using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Xml_Create_Read_Update
{
    public partial class Form1 : Form
    {

        /*This tuttorial created by Ozzy Ozmen Celik for education.
          And puspose of this tuttorial is showing how to create & update XML File Also how to read from xml file  */


        public Form1()
        {
            InitializeComponent();
        }

       
        // Adding question into Listbox by textboxQuestion
        private void btnaddQuestion_Click(object sender, EventArgs e)
        {
            listboxQuestions.Items.Add(txtQuestion.Text);
            txtQuestion.Clear();
            txtQuestion.Focus();
        }

        // Adding answer into Listbox by textboxAnswer
        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            listboxAnswers.Items.Add(txtAnswer.Text);
            txtAnswer.Clear();
            txtAnswer.Focus();
        }

        // Create XmL button event
        private void BtnXML_Click(object sender, EventArgs e)
        {

            if (listboxQuestions.Items.Count > 0 && listboxAnswers.Items.Count > 0)
            {
                XMLCreat();
                listboxQuestions.Items.Clear();
                listboxAnswers.Items.Clear();

            }
            else
            {
            
                MessageBox.Show("Upps XML File couldnt create cause of you forgot adding question and answer both !!!");
            }
        }



        // creating a xml file
        private void XMLCreat()
        {
            // created a xmltextwriter method and added xmlfile with set encoding type
            XmlTextWriter xmlcrt = new XmlTextWriter("Questions.xml", Encoding.Unicode);

            // set first element of xml file which one will be included child elements inside.
            xmlcrt.WriteStartElement("Questions");

            // Check the file directory if our xml file already created or not
            string File_Directory = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Questions.xml";

            if (File.Exists(File_Directory) == true) 
            {
                // created a string variable ( questionstring ) to set to Selected Questions Listbox.selecteditem.
                // And set child elements
                // end the element

                for (int i = 0; i < listBoxSelectedQuestions.Items.Count; i++)
                {
                    string questionstring = listBoxSelectedQuestions.Items[i].ToString();
                    xmlcrt.WriteStartElement("Question");
                    xmlcrt.WriteElementString("QuestionSentence", questionstring);
                    xmlcrt.WriteEndElement();
                }

                // created a string variable ( answerstring ) to set to Selected Answers Listbox.selecteditem.
                // And set child elements
                // end the element
                for (int i = 0; i < listBoxSelectedAnswers.Items.Count; i++)
                {
                    string answerstring = listBoxSelectedAnswers.Items[i].ToString();
                    xmlcrt.WriteStartElement("Answer");
                    xmlcrt.WriteElementString("AnswerSentence", answerstring);
                    xmlcrt.WriteEndElement();
                }
            }

            // created a string variable ( questionstring ) to set to Questions Listbox.selecteditem.
            // And set child elements
            // end the element

            for (int i = 0; i < listboxQuestions.Items.Count; i++)
            {

                string questionstring = listboxQuestions.Items[i].ToString();
                xmlcrt.WriteStartElement("Question");
                xmlcrt.WriteElementString("QuestionSentence", questionstring);
                xmlcrt.WriteEndElement();

            }
            // created a string variable ( answerstring ) to set to Answer Listbox.selecteditem.
            // And set child elements
            // end the element

            for (int j = 0; j < listboxAnswers.Items.Count; j++)
            {
                string answerstring = listboxAnswers.Items[j].ToString();

                xmlcrt.WriteStartElement("Answer");
                xmlcrt.WriteElementString("AnswerSentence", answerstring);
                xmlcrt.WriteEndElement();
            }

            // end the element
            xmlcrt.WriteEndElement();

            // created the xml fie with close event.
            xmlcrt.Close();
       
           

        }

        // Read questions from  xml file
        private void XmlReadQuestions()
        {
            //created xmldokument method
            XmlDocument readxml = new XmlDocument();

            // loaded the file 
            readxml.Load("Questions.xml");

            // created Questions object as XmlNode and set it wth questions
            XmlNode Questions = readxml.SelectSingleNode("Questions");

            // called all questionSentences each by each with foreach
            foreach (XmlNode question in Questions.SelectNodes("Question"))
            {
                //created aa string and set it with QuestionSentence
                string aa = question.SelectSingleNode("QuestionSentence").InnerText;

               // and added in to listbox
                listBoxSelectedQuestions.Items.Add(aa);

                //created array named s.q
                string[] SelectedQuestions = new string[listBoxSelectedQuestions.Items.Count];

                // put values in to s.q array with for
                for (int i = 0; i < listBoxSelectedQuestions.Items.Count; i++)
                {
                  SelectedQuestions[i] = listBoxSelectedQuestions.Items[i].ToString();

                   
                }
            }

        }
        // Read answers from xml file
        private void XmlReadAnsers()
        {
            //created xmldokument method
            XmlDocument readxml = new XmlDocument();

            // loaded the file
            readxml.Load("Questions.xml");

            // created Questions object as XmlNode and set it wth questions
            XmlNode Questions = readxml.SelectSingleNode("Questions");

            // called all answernSentences each by each with foreach
            foreach (XmlNode answer in Questions.SelectNodes("Answer"))
            {
                //created aa string and set it with AnswerSentence
                string aa = answer.SelectSingleNode("AnswerSentence").InnerText;

                // called all questionSentences each by each with foreach
                listBoxSelectedAnswers.Items.Add(aa);

                //created array named s.a
                string[] SelectedAnswers = new string[listBoxSelectedAnswers.Items.Count];

                // put values in to s.a array with for
                for (int i = 0; i < listBoxSelectedAnswers.Items.Count; i++)
                {
                    SelectedAnswers[i] = listBoxSelectedAnswers.Items[i].ToString();


                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // i didnt use forum load but u can use if wantto set something work on load event
        }

        //read from xml button event
        private void BtnReadXML_Click(object sender, EventArgs e)
        {
            listBoxSelectedQuestions.Items.Clear();
            listBoxSelectedAnswers.Items.Clear();

            // Check the file directory if our xml file already created or not
            string File_Directory = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Questions.xml";

            if (File.Exists(File_Directory) == true) 
            {
                //called our read questions and answers methods
                XmlReadQuestions();
                XmlReadAnsers();
            }
            else
            {
                MessageBox.Show("Sorry there must be a xml file in the project before update and read actions !!!");
                MessageBox.Show("PLEASE CREATE NEW XML FILE !!!");
            }
           
            
        }
    }
}
