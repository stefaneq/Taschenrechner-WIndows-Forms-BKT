using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taschenrechner_stefan2
{
    public partial class Taschenrechner : Form
    {
        double wert1 = 0;
        String rechenart = "";
        bool rechenart_eingabe = false;
        /*Wert1 ist der Wert der Rechnung (Zahlen) */
        /*rechenart ist die Rechenart +-usw*/
        /*rechenart_eingabe ist wenn der Button gedrückt wurde, damit dieser sich auf True umändert wie unten beschrieben*/
        public Taschenrechner()
        {
            InitializeComponent();
        }
        /*zahl1 als Vorlage */
        private void zahl1_Click(object sender, EventArgs e)
        {
            ergebnisbox.Text = ergebnisbox.Text + "1";
        }


        /* Hier wird nun das object sender festgelegt. Dies wird unter Events auf jeden Button angewendet */
        private void button_Click(object sender, EventArgs e)
        {
            /*If-Schleife = Textbox immer null außer bei Eingabe, sowie auch das die Eingegebene Zahl nach Rechenart verschwindet
             und eine neue Zahl eingeben kann*/
            if ((ergebnisbox.Text == "0") || (rechenart_eingabe))
                ergebnisbox.Clear();

            rechenart_eingabe = false;
            Button B = (Button)sender;
            ergebnisbox.Text = ergebnisbox.Text + B.Text;
        }

        private void leeren_Click(object sender, EventArgs e)
        {
            ergebnisbox.Text = "0";
        }
        private void radieren_Click(object sender, EventArgs e)
        {
            ergebnisbox.Text = "0";
            wert1 = 0;
        }
        private void rechnen_click(object sender, EventArgs e)
        {
            Button B = (Button)sender; /*Der Wert im Button wird als Variable gesendet */
            rechenart = B.Text;
            wert1 = Double.Parse(ergebnisbox.Text); /*String wird zu Double umgewandelt */
            /*Hier wird der bool von false auf true gesetzt*/
            rechenart_eingabe = true;
            /*Befehl um die Alte Eingabe anzeigen zu lassen bzw verschwindet wenn ergebnis gedrückt wird*/
            alt_eingabe.Text = wert1 + "" + rechenart;
        }

        private void ausfuehren_Click(object sender, EventArgs e)
        {/*Befehl um die Alte Eingabe anzeigen zu lassen bzw verschwindet wenn ergebnis gedrückt wird*/
            alt_eingabe.Text = "";
            switch (rechenart)
            {/*Hier wird eigentlich gerechnet*/
                case "+":
                    ergebnisbox.Text = (wert1 + Double.Parse(ergebnisbox.Text)).ToString();
                    break;
                case "-":
                    ergebnisbox.Text = (wert1 - Double.Parse(ergebnisbox.Text)).ToString();
                    break;
                case "*":
                    ergebnisbox.Text = (wert1 * Double.Parse(ergebnisbox.Text)).ToString();
                    break;
                case "/":
                    ergebnisbox.Text = (wert1 / Double.Parse(ergebnisbox.Text)).ToString();
                    break;
                default:
                    break;

            }

        }


    }
}
