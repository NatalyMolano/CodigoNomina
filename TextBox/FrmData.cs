namespace TextBox
{
    public partial class FrmData : Form
    {
        List<Clslista> MiLista = new List<Clslista>();
        Clslista myempleado = new Clslista();
        
        
        public FrmData()
        {
            InitializeComponent();
            tslConsultar.Enabled = false;
            tslEliminar.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDoment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros mayores a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxfirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Advetencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Letras", "Advetencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros mayores a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxWorkDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros mayores a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myempleado.Document1 = Convert.ToDouble(textBoxDoment.Text);
            myempleado.FirstName1 = textBoxfirstName.Text;
            myempleado.LastName1 = textBoxLastName.Text;
            myempleado.Salary1 = Convert.ToDouble(textBoxSalary.Text);
            myempleado.WorkDays1 = Convert.ToInt32(textBoxWorkDays.Text);

            MessageBox.Show("The record was saved successfully");


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTotalIncome.Text = myempleado.Total(Convert.ToDouble(myempleado.Salary1)).ToString();
            txttotal.Text = myempleado.CalculatePayroll(Convert.ToInt32(myempleado.WorkDays1), Convert.ToDouble(myempleado.Total_income1)).ToString();
            txtHealth.Text = myempleado.Salud(Convert.ToInt32(myempleado.WorkDays1), Convert.ToDouble(myempleado.Salary1)).ToString();
            txtPension.Text = myempleado.pension(Convert.ToInt32(myempleado.WorkDays1), Convert.ToDouble(myempleado.Salary1)).ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxfirstName.Clear();
            textBoxDoment.Clear();
            textBoxfirstName.Clear();
            textBoxSalary.Clear();
            textBoxWorkDays.Clear();
            txttotal.Clear();
            txtHealth.Clear();
            txtPension.Clear();
            textBoxLastName.Clear();
            txtTotalIncome.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtHealth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPension_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIncome_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tslRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarDocumento() == false)
            {
                return;
            }
            if (ValidarNombre() == false)
            {
                return;
            }
            if (ValidarApellido() == false)
            {
                return ;
            } 
            if(ValidarSalario() == false)
            {
                return;
            }
            if(ValidarDiasTrabajados() == false)
            {
                return;
            }
            Clslista miempleado = new Clslista();
            miempleado.FirstName1 = textBoxfirstName.Text;
            miempleado.LastName1 = textBoxLastName.Text;
            miempleado.Document1 = double.Parse(textBoxDoment.Text);
            miempleado.Salary1 = double.Parse(textBoxSalary.Text);
            miempleado.WorkDays1 = int.Parse(textBoxWorkDays.Text);
            miempleado.Devengo1 = double.Parse(txttotal.Text);
            miempleado.Health1 = double.Parse(txtHealth.Text);
            miempleado.Pension1 = double.Parse(txtPension.Text);
            miempleado.Total_income1 = double.Parse(txtTotalIncome.Text);

            //miempleado.Pension1 = double.Parse(txtPension.Text);
            
            MiLista.Add(miempleado);
            dgvdata.DataSource = null;
            dgvdata.DataSource = MiLista;
            LimpiarControles();
            textBoxfirstName.Focus();
            tslConsultar.Enabled = true;

        }

        private bool ValidarDiasTrabajados()
        {
            int dias;
            if (!int.TryParse(textBoxWorkDays.Text, out dias) || textBoxWorkDays.Text == "")
            {
                erpError.SetError(textBoxWorkDays, "Debe ingresar el numero de dias trabajados");
                return false;

            }
            else
            {
                erpError.SetError(textBoxWorkDays, "");
                return true;
            }
        }

        private bool ValidarSalario()
        {
            double salario;
            if (!double.TryParse(textBoxSalary.Text, out salario) || textBoxSalary.Text == "")
            {
                erpError.SetError(textBoxSalary, "Debe ingresar su salario");
                return false;

            }
            else
            {
                erpError.SetError(textBoxSalary, "");
                return true;
            }
        }

        private bool ValidarApellido()
        {
            if (string.IsNullOrEmpty(textBoxLastName.Text))
            {
                erpError.SetError(textBoxLastName, "Debe ingresar un apellido");
                return false;
            }
            else
            {
                erpError.SetError(textBoxLastName, "");
                return true;
            }
        }

        private bool ValidarDocumento()
        {
            double documento; 
            if(!double.TryParse(textBoxDoment.Text,out documento) || textBoxDoment.Text == "")
            {
                erpError.SetError(textBoxDoment, "Debe ingresar el numero del documento");
                return false;

            }
            else
            {
                erpError.SetError(textBoxDoment, "");
                return true;
            }
            
        }

        //Validar nombre

        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(textBoxfirstName.Text))
            {
                erpError.SetError(textBoxfirstName, "Debe ingresar un nombre");
                return false;
            }
            else
            {
                erpError.SetError(textBoxfirstName, "");
                return true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LimpiarControles()
        {
            textBoxDoment.Clear();
            textBoxfirstName.Clear();
            textBoxLastName.Clear();
            textBoxSalary.Clear();
            textBoxWorkDays.Clear();
            txtHealth.Clear();
            txtPension.Clear();
            textBoxLastName.Clear();
            txttotal.Clear();
            txtTotalIncome.Clear();
        }

        private void tslConsultar_Click(object sender, EventArgs e)
        {
            if(ValidarNombre() == false)
            {
                return;
            }
            Clslista miEmpleado = GetEmpleado(textBoxfirstName.Text);
            if (miEmpleado == null)
            {
                erpError.SetError(textBoxfirstName, "El empleado no esta registrado en la lista ");
                LimpiarControles();
                textBoxfirstName.Focus();
            }
            else
            {
                erpError.SetError(textBoxfirstName, "");
                textBoxfirstName.Text = miEmpleado.FirstName1;
                textBoxLastName.Text = miEmpleado.LastName1;
                textBoxSalary.Text = miEmpleado.Salary1.ToString();
                textBoxWorkDays.Text = miEmpleado.WorkDays1.ToString();
                textBoxDoment.Text = miEmpleado.Document1.ToString();
                txttotal.Text = miEmpleado.Devengo1.ToString();
                txtHealth.Text = miEmpleado.Health1.ToString();
                txtPension.Text = miEmpleado.Pension1.ToString();
                txtTotalIncome.Text = miEmpleado.Total_income1.ToString();
                tslEliminar.Enabled= true;
            }
        }

        private Clslista GetEmpleado(string nombre)
        {
            return MiLista.Find(empleado => empleado.FirstName1.Contains(nombre));
        }

        private void txtTotalIncome_TextChanged(object sender, EventArgs e)
        {

        }
        //Metodo consultar empleado

    }
}