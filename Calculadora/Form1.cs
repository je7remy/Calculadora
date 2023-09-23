using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
namespace Calculadora
{
    
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
          
        }

        SpeechRecognitionEngine Reconocedor = new SpeechRecognitionEngine();
        SpeechSynthesizer Sintetizador = new SpeechSynthesizer();

        double a;
        double b;
        string c;
        double Memoria = 0;



      
        

private void btnN1_Click(object sender, EventArgs e)
        {
          
                txtpantalla.Text = txtpantalla.Text + "1";

            

            
        }

        private void btnN2_Click(object sender, EventArgs e)
        
            {
                txtpantalla.Text = txtpantalla.Text + "2";
            }
        

        private void btnN3_Click(object sender, EventArgs e)
        {
       
                txtpantalla.Text = txtpantalla.Text + "3";
            
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "4";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "4";
            }
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "5";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "5";
            }
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "6";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "6";
            }
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "7";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "7";
            }
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "8";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "8";
            }
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "9";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "9";
            }
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "0";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "0";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

            if (txtpantalla.Text != "")
            
            a = Convert.ToDouble(this.txtpantalla.Text); 
            c = "/";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text != "")
            
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "*";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text != "")
            {
                a = Convert.ToDouble(this.txtpantalla.Text);
                c = "-";
                this.txtpantalla.Clear();
                this.txtpantalla.Focus();
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text != "")
            
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "+";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + ".";
            //   txtpantalla.Text +=",";
            //if (txtpantalla.Text != "")
            //    if (txtpantalla.Text.Contains(',') == false)
            //    {
            //        txtpantalla.Text = txtpantalla.Text + ',';
            //    }

        }


        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text != "")


                    b = Convert.ToDouble(this.txtpantalla.Text);
            switch (c)
            {
                case "+":
            
                    this.txtpantalla.Text = Convert.ToString(a + b);
                    Sintetizador.Speak(txtpantalla.Text);
                   
                //    Reconocedor.Dispose();
                    break;

                case "-":
                    txtpantalla.Text = Convert.ToString(b - a);
                    Sintetizador.Speak(txtpantalla.Text);
                    break;

                case "*":
                    this.txtpantalla.Text = Convert.ToString(b * a);
                    Sintetizador.Speak(txtpantalla.Text);
                    break;

                case "/":
                    if (b != 0) { 
                    this.txtpantalla.Text = Convert.ToString(b / a);
                        Sintetizador.Speak(txtpantalla.Text);
                    }
                    else
                    {
                        Sintetizador.Speak("No se puede dividir entre 0");
                    }
                    break;

            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtpantalla.Text="";
           Sintetizador.Speak("la pantalla esta vacia");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            a = 0;
            b = 0;
            c = "";
            txtpantalla.Clear();
            Sintetizador.Speak("la pantalla esta vacia");
        }

        private void txtpantalla_TextChanged(object sender, EventArgs e)
        {
            this.txtpantalla.Focus();
            if (txtpantalla.Text == "∞") Sintetizador.Speak("no se puede dividir entre cero");
           
            else { 
            
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("quieres salir del programa?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (dialogResult == DialogResult.Yes)
            //{

            //}
            //else if (dialogResult == DialogResult.No) 
            //{

            //}
            //  MessageBox.Show("Realmente desea salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //{
            //}
            //System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            //messageBoxCS.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason);
            //messageBoxCS.AppendLine();
            //messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.Cancel);
            //messageBoxCS.AppendLine();
            //MessageBox.Show(messageBoxCS.ToString(), "FormClosing Event");
            if (MessageBox.Show("Realmente desea salir?", "Alerta",MessageBoxButtons.YesNo,  MessageBoxIcon.Warning) == DialogResult.No) 
              //  Sintetizador.Speak("Adios");
            {
              e.Cancel = true; Sintetizador.Speak("te has quedado en el programa");
            } else
        Sintetizador.Speak("Adios");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (MessageBox.Show("seguro que desea salir del programa?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            //{
            //}
            //else
            //{
            //    Application.Restart();
            //}
            //MessageBox.Show("Mensaje informativo con botones Sí, No y Cancelar","Titulo Ventana", MessageBoxButtons.YesNoCancel);
           
        }

        private void fondo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pic1.Visible = true;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
        }

        private void fondo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pic1.Visible = false;
            pic2.Visible = true;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = false;
        }

        private void fondo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = true;
            pic4.Visible = false;
            pic5.Visible = false;
        }

        private void fondo4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = true;
            pic5.Visible = false;
        }

        private void fondo5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            pic5.Visible = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnretroceso_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text.Length > 0)
                txtpantalla.Text = txtpantalla.Text.Remove(txtpantalla.Text.Length - 1,1);

            if (txtpantalla.Text.Length == -1)
            {
                txtpantalla.Text = "";
              
            }

            if (txtpantalla.Text == "") { }
            Sintetizador.Speak(txtpantalla.Text);
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text != "")
            a = Convert.ToDouble(txtpantalla.Text);
            txtpantalla.Text = Convert.ToString(1 / a);
            Sintetizador.Speak(txtpantalla.Text);
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text != "")
                a = Convert.ToDouble(txtpantalla.Text);
            if (a >= 0)
            {
                txtpantalla.Text = "√ " + a;
                txtpantalla.Text = Convert.ToString(Math.Sqrt(a));
                Sintetizador.Speak(txtpantalla.Text);
            }

            else
                txtpantalla.Text = "Error";
        }

        public void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            //try               este codigo copia lo de el tex box al portapaeles banderita v
            //{
            //    Clipboard.SetDataObject(txtpantalla.Text, true);
            //    MessageBox.Show("Texto copiado al portapapeles de Windows.",
            //        "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show("Error al copiar texto al portapapeles: " +
            //        Environment.NewLine + err.Message, "Error al copiar",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            if (txtpantalla.SelectionLength > 0)
                // Copy the selected text to the Clipboard.
                txtpantalla.Copy();

        }

        public void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Determine if any text is selected in the text box.
                if (txtpantalla.SelectionLength > 0)
                {
                    // Ask user if they want to paste over currently selected text.
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        // Move selection to the point after the current selection and paste.
                        txtpantalla.SelectionStart = txtpantalla.SelectionStart + txtpantalla.SelectionLength;
                }
                // Paste current text in Clipboard into text box.
                txtpantalla.Paste();
            }
        }

        private void btnporciento_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text != "")
                a = Convert.ToDouble(txtpantalla.Text);
            txtpantalla.Text = txtpantalla.Text + txtpantalla.Text;
            txtpantalla.Text = Convert.ToString(a /100);
            Sintetizador.Speak(txtpantalla.Text);
        }

        private void btnmasmenos_Click(object sender, EventArgs e)

        {
            if (txtpantalla.Text != "")
                a = Convert.ToDouble(this.txtpantalla.Text);
            double rawr = a * 2;
            double posho = a + a;

            if (a >= 0)
            {
                txtpantalla.Text = Convert.ToString(a-rawr);

            }
            if (a <= 0)
            {

                txtpantalla.Text = Convert.ToString(a-posho);
            }

        }

        private void acercaDeLaCalculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

         private void Form1_Load(object sender, EventArgs e)
        {
            Sintetizador.Speak("Bienvenido");
            Choices palabras = new Choices();
            
palabras.Add(new String[] { "uno", "dos", "tres", "cuatro", "cinco","seis", "siete", "ocho" ,"nueve ","cero", 
"entre", "por", "mas", "menos", "mostrar", "raiz", "porciento", "uno entre", "punto", "retroceso", "borrar", "borrar todo", "cambiar signo",
"fondo primero", "fondo segundo" ,"fondo tercero", "fondo cuarto", "fondo quinto"});

            Grammar gramática = new Grammar(new GrammarBuilder(palabras));
            try
            {

                Reconocedor.SetInputToDefaultAudioDevice();
                Reconocedor.LoadGrammar(gramática);
                Reconocedor.LoadGrammar(new DictationGrammar());
                Reconocedor.SpeechRecognized += Reconocedor_SpeechRecognized;
                Reconocedor.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }

        private void Reconocedor_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)

        {
            if (e.Result.Text == "uno")
            {
                btnN1.PerformClick();
            }
            else
         if (e.Result.Text == "dos")
            {
                btnN2.PerformClick();


            }
            else
                 if (e.Result.Text == "tres")
            {
                btnN3.PerformClick();

            }
            else
                 if (e.Result.Text == "cuatro")
            {
                btnN4.PerformClick();

            }
            else
                 if (e.Result.Text == "cinco")
            {
                btnN5.PerformClick();

            }
            else
                 if (e.Result.Text == "seis")
            {
                btnN6.PerformClick();

            }
            else


                 if (e.Result.Text == "siete")
            {
                btnN7.PerformClick();
            }
            else
                 if (e.Result.Text == "ocho")
            {
                btnN8.PerformClick();

            }
            else
                 if (e.Result.Text == "nueve")
            {
                btnN9.PerformClick();

            }
            else
                 if (e.Result.Text == "cero")
            {
                btnN0.PerformClick();

            }
            else
                 if (e.Result.Text == "entre")
            {
                btnDivision.PerformClick();

            }
            else
                 if (e.Result.Text == "por")
            {
                btnMultiplicacion.PerformClick();

            }
            else
                 if (e.Result.Text == "mas")
            {
                btnSuma.PerformClick();

            }
            else
                 if (e.Result.Text == "menos")
            {
                btnResta.PerformClick();

            }
            else if (e.Result.Text == "mostrar")
            {
                btnIgual.PerformClick();

            }
            else
                 if (e.Result.Text == "raiz")
            {
                btnsqrt.PerformClick();

            }
            else
                 if (e.Result.Text == "porciento")
            {
                btnporciento.PerformClick();

            }
            else
                 if (e.Result.Text == "uno entre")
            {
                btn1x.PerformClick();

            }
            else
                 if (e.Result.Text == "punto")
            {
                btnComa.PerformClick();

            }
            else
                 if (e.Result.Text == "retroceso")
            {
                btnretroceso.PerformClick();

            }
            else
               if (e.Result.Text == " borrar")
            {
                btnLimpiar.PerformClick();

            }
            else
                if (e.Result.Text == "borrar todo")
            {
                btnBorrar.PerformClick();

            }
            else
                if (e.Result.Text == "cambiar signo")
            {
                btnmasmenos.PerformClick();
            } else
                if (e.Result.Text == "fondo primero")
            {
                fondo1ToolStripMenuItem.PerformClick();
            }
            else
                if (e.Result.Text == "fondo segundo")
            {
                fondo2ToolStripMenuItem.PerformClick();
            }
            else
                if (e.Result.Text == "fondo tercero")
            {
                fondo3ToolStripMenuItem.PerformClick();
            }
            else
                if (e.Result.Text == "fondo cuarto")
            {
                fondo4ToolStripMenuItem.PerformClick();
            }
            else
                if (e.Result.Text == "fondo quinto")
            {
                fondo5ToolStripMenuItem.PerformClick();
            }
            
        }
        

        private void btnMC_Click(object sender, EventArgs e)
        {
            Memoria = 0;
            this.LblMemoria.Visible = false;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = Memoria.ToString();
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
                 if (txtpantalla.Text != "")
                Memoria = Memoria - Convert.ToDouble(txtpantalla.Text);
            this.LblMemoria.Visible = true;
        }

        private void btnMmas_Click(object sender, EventArgs e)
        {
            Memoria = Memoria + Convert.ToDouble(txtpantalla.Text);
            this.LblMemoria.Visible = true;
        }

        public void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtpantalla.SelectedText != "")
                // Cut the selected text in the control and paste it into the Clipboard.
                txtpantalla.Cut();
        }

        public void desToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtpantalla.CanUndo == true)
            {
                // Undo the last operation.
               txtpantalla.Undo();
                // Clear the undo buffer to prevent last action from being redone.
                txtpantalla.ClearUndo();
            }
        }

     

       

        private void desactivarVozToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pic6.Visible = false;
            pic7.Visible = true;
            Sintetizador.Volume = 0;
       
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            pic6.Visible = true;
            pic7.Visible = false;
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            pic6.Visible = false;
            pic7.Visible = true;
        }

        private void activarVozToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pic6.Visible = true;
            pic7.Visible = false;
            Sintetizador.Volume = 100;
            Sintetizador.Speak("Reconocimiento de voz activado");
          //  Reconocedor.;
           
        }
    }

    }
