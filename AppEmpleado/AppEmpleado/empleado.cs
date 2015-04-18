using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmpleado
{
    class empleado
    {
        //atributos
        string nombre, apellido, fechanacimiento, fechaingreso;
        string sexo;
        float salario;



       
        

        //contructor vacio
        public  empleado()
        {

        }
        
        //contructor
        public empleado(string nombre, string apellido, string sexo, string fechanacimiento, string fechaingreso, float salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.fechanacimiento = fechanacimiento;
            this.fechaingreso = fechaingreso;
            this.salario = salario;

        }
        // metodo get set
        public string Fechaingreso
        {
            get { return fechaingreso; }
            set { fechaingreso = value; }
        }

        public string Fechanacimiento
        {
            get { return fechanacimiento; }
            set { fechanacimiento = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public float Salario
{
  get { return salario; }
  set { salario = value; }
}

    }
}
