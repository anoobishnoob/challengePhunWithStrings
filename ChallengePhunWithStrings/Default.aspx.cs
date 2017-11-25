using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            /* // will need to remove these multi line comments to see each section. 
              //I did not want to create more labels and muddy the code
             string name = "Samme Qandil";
            string revName = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                revName += name[i];
            }
            resultLabel.Text = revName;
            */
            // In my case, the result would be:
            // lidnaQ emmaS




            // 2.  Reverse this sequence:
            /*
            string names = "Luke,Leia,Han,Chewbacca";
            string[] rebelScum = names.Split(',');
            string revNames = "";
            for (int i = rebelScum.Length - 1; i >= 0; i--)
            {
                revNames += rebelScum[i] + "," + " ";
            }
            revNames = revNames.Remove(revNames.Length - 2, 2);
            resultLabel.Text = revNames;


            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke
            */



            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***
            /*
            string names = "Luke,Leia,Han,Chewbacca";
            string[] rebelScum = names.Split(',');
            string result = "";
            for (int i = 0; i < rebelScum.Length; i++)
            {
                int padLeft = (14 - rebelScum[i].Length) / 2;
                string temp = rebelScum[i].PadLeft(rebelScum[i].Length + padLeft, '*');
                result += temp.PadRight(14, '*');
                result += "<br />";
            }
            resultLabel.Text = result;
            */

            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.
            string removeME = "remove-me";
            int index = puzzle.IndexOf(removeME);
            puzzle = puzzle.Remove(index, removeME.Length);
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace('z', 't');
            puzzle = puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");
            resultLabel.Text = puzzle;



        }
    }
}