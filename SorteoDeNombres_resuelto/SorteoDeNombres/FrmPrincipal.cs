using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorteoDeNombres
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && txtNombre.Text.Length >= 3)
            {
                listBoxNombres.Items.Add(txtNombre.Text.Trim());
                txtNombre.Text = string.Empty;
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Es necesario agregar un nombre de por lo menos 3 digitos","Validación",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.listBoxNombres.Items.Count == 0)
            {
                MessageBox.Show("No hay nombres que eliminar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (this.listBoxNombres.SelectedItem == null)
            {
                MessageBox.Show("Es necesario seleccionar un nombre de la lista para eliminarlo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.listBoxNombres.Items.Remove(this.listBoxNombres.SelectedItem);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!this.bgwSorteo.IsBusy)
            {
                if (this.listBoxNombres.Items.Count != 0)
                {
                    List<string> listaNombres = new List<string>();
                    foreach (object item in this.listBoxNombres.Items)
                    {
                        listaNombres.Add(item.ToString());
                    }

                    this.bgwSorteo.RunWorkerAsync(new object[] {rbRandom.Checked ? Opciones.Random : Opciones.Manual, listaNombres});
                }
                else
                {
                    MessageBox.Show("No hay nombres para revolver", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("El sistema ya esta ejecutandose", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bgwSorteo_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] arg = e.Argument as object[];

            Opciones opc = (Opciones)arg[0];
            List<string> listaNombres = arg[1] as List<string>;

            if (opc == Opciones.Manual)
            {
                int conta = 0;
                bool continua = true;
                while (continua)
                {
                    if (this.bgwSorteo.CancellationPending)
                    {
                        continua = false;
                    }
                    this.bgwSorteo.ReportProgress(0, listaNombres[conta]);
                    Thread.Sleep(TimeSpan.FromMilliseconds(70));
                    conta++;

                    if (conta == listaNombres.Count)
                    {
                        conta = 0;
                    }
                }
            }
            else
            {
                Random ran = new Random(DateTime.Now.Millisecond);
                int milisegundos = ran.Next(1000, 8000);

                int conta = 0;
                int sumaMili = 0;
                while (milisegundos > sumaMili)
                {
                    if (this.bgwSorteo.CancellationPending)
                    {
                        milisegundos = 0;
                    }
                    this.bgwSorteo.ReportProgress(0, listaNombres[conta]);
                    Thread.Sleep(TimeSpan.FromMilliseconds(70));
                    sumaMili += 70;
                    conta++;

                    if (conta == listaNombres.Count)
                    {
                        conta = 0;
                    }
                }
            }
            e.Result = opc;
        }

        private void bgwSorteo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblNombreGanador.Text = e.UserState.ToString();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            this.bgwSorteo.CancelAsync();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnAgregar_Click(sender, new EventArgs());
            }
        }

        private void rbRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManual.Checked)
            {
                this.btnDetener.Enabled = true;
            }
            else
            {
                this.btnDetener.Enabled = false;
            }
        }

        private void bgwSorteo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((Opciones)e.Result == Opciones.Random)
            {
                MessageBox.Show("El ganador es: "+ lblNombreGanador.Text, "Ganador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
