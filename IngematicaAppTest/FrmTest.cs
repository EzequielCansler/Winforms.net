using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IngematicaAppTest.Model;
using IngematicaAppTest.Service;
using IngematicaAppTest.Business;




namespace IngematicaAppTest
{
    public partial class FrmTest : Form
    {
        private readonly CalculoService _calculoService;
        public FrmTest()
        {
            InitializeComponent();


            LocalidadBusiness localidadBusiness = new LocalidadBusiness();
            TipoTransporteBusiness tipoTransporteBusiness = new TipoTransporteBusiness();
            TipoTrayectoBusiness tipoTrayectoBusiness = new TipoTrayectoBusiness();

            // Inicializa CalculoBusiness con todos los parametros requeridos
            CalculoBusiness calculoBusiness = new CalculoBusiness(localidadBusiness, tipoTransporteBusiness, tipoTrayectoBusiness);

            _calculoService = new CalculoService(calculoBusiness);

            InitializeCombos();

            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click); // onClick calcular
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click); // onClick limpiar


        }


        private void InitializeCombos()
        {
            InitializeComboTipoTransporte();

            InitializeCoboLocalidad();

            InitializeComboTipoTrayecto();

        }

        

        private void InitializeComboTipoTransporte()
        {
            List<TipoTransporteModel> tipoTransporteList = new List<TipoTransporteModel>();
            TipoTransporteService tipoTransporteService = new TipoTransporteService();
            tipoTransporteList = tipoTransporteService.GetList();

            var bindingSourceTipoTransporte = new BindingSource();
            bindingSourceTipoTransporte.DataSource = tipoTransporteList;

            cbTipoTransporte.DataSource = bindingSourceTipoTransporte;
            cbTipoTransporte.DisplayMember = "Nombre";
            cbTipoTransporte.ValueMember = "IdTipoTransporte";
        }

        private void InitializeCoboLocalidad()
        {
            List<LocalidadModel> localidadList = new List<LocalidadModel>();
            LocalidadService localidadService = new LocalidadService();
            localidadList = localidadService.GetList();

            var bindingSourceLocalidad = new BindingSource();
            bindingSourceLocalidad.DataSource = localidadList;

            cbLocalidadDestino.DataSource = bindingSourceLocalidad;
            cbLocalidadDestino.DisplayMember = "Nombre";
            cbLocalidadDestino.ValueMember = "IdLocalidad";
        }

        private void InitializeComboTipoTrayecto()
        {
            List<TipoTrayectoModel> trayectoList = new List<TipoTrayectoModel>();
            TipoTrayectoService trayectoService = new TipoTrayectoService();
            trayectoList = trayectoService.GetList();

            var bindingSourcetrayecto = new BindingSource();
            bindingSourcetrayecto.DataSource = trayectoList;

            cbTipoTrayecto.DataSource = bindingSourcetrayecto;
            cbTipoTrayecto.DisplayMember = "Nombre";
            cbTipoTrayecto.ValueMember = "IdTipoTrayecto";
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
          
            // Obtener los valores del formulario ya que se pasan como objetos los convierto a int
            DateTime fechaInicial = dtpFechaInicial.Value;
            int localidadId = cbLocalidadDestino.SelectedValue != null
                      ? (int)cbLocalidadDestino.SelectedValue
                      : 0;

            int tipoTransporteId = cbTipoTransporte.SelectedValue != null
                                   ? (int)cbTipoTransporte.SelectedValue
                                   : 0;

            int tipoTrayectoId = cbTipoTrayecto.SelectedValue != null
                                 ? (int)cbTipoTrayecto.SelectedValue
                                 : 0;

            // Llamar al metodo calcular
            ResultadoModel resultado = _calculoService.Calcular(fechaInicial, localidadId, tipoTransporteId, tipoTrayectoId);

            // Mostrar los resultados en el formulario
            txtDiasDemora.Text = resultado.DiasDemora.ToString();
            txtFechaLlegada.Text = resultado.FechaLlegada.ToShortDateString();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtDiasDemora.Clear(); // limpio el campo demora
            txtFechaLlegada.Clear(); // limpio el campo llegada

            dtpFechaInicial.Value = DateTime.Now; // pongo la fecha de del dia actual

        }

    }
}
