using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Empleado : Usuario
    {
        private long id_empleado;
        private DateTime hora_entrada;
        private DateTime hora_salida;
        private int horasSemanales;
        private double Salario;

        //Constructor
        public Empleado(long id_usuario, string dni, string nombre, string apellidos, string password, string imagen, string tipo_Usuario, string correo, long id_empleado, DateTime hora_entrada, DateTime hora_salida,int horasSemanales, double salario) : base(id_usuario, dni, nombre, apellidos, password, imagen, tipo_Usuario, correo)
        {
            this.id_empleado = id_empleado;
            this.hora_entrada = hora_entrada;
            this.hora_salida = hora_salida;
            this.horasSemanales = horasSemanales;
            this.Salario = salario;

        }

        //getters
        public long getIdEmpleado()
        {
            return this.id_empleado;
        }
        public DateTime getHoraEntrada()
        {
            return this.hora_entrada;
        }

        public DateTime getHoraSalida()
        {
            return this.hora_salida;
        }

        public int getHorasSemanales()
        {
            return this.horasSemanales;
        }

        public double getSalario()
        {
            return this.Salario;
        }

        //Setters

        public void setIdEmpleado(long idEmpleado)
        {
            this.id_empleado = idEmpleado;
        }

        public void setHoraEntrada(DateTime horaEntrada)
        { 
            this.hora_entrada = horaEntrada;
        }

        public void setHoraSalida(DateTime horaSalida)
        {
            this.hora_salida = horaSalida;
        }

        public void setHorasSemanales(int horasSemanales)
        {
            this.horasSemanales = horasSemanales;
        }

        public void setSalario(double salario)
        {
            this.Salario = salario;
        }

        //ToString

        public String ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(" Empleado [ ");
            sb.Append("id_empleado = " + id_empleado);
            sb.Append(" ,hora_salida =  " + hora_salida);
            sb.Append(" ,hora_entrada = " + hora_entrada);
            sb.Append(" ,horas semanales = " + horasSemanales);
            sb.Append(" ,salario = " + Salario);
            sb.Append(base.ToString());

            return sb.ToString();
        }



    }
}
