using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModuloNomina
{
    public class Sentencias
    {

        Conexion con = new Conexion();

        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblCustom(string tabla, string clausula)//Leonel Dominguez
        {
            string sql = "SELECT * FROM " + tabla + " WHERE " + clausula + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public string[] Query(string campoSolicitado, string tabla, string clausula)//Leonel Dominguez
        {
            string[] respuesta = new string[100];
            string sql = "SELECT " + campoSolicitado + " FROM colchoneria." + tabla + " WHERE " + clausula + ";";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                Array.Resize(ref respuesta, reader.FieldCount);
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        respuesta[i] = reader.GetValue(i).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() +
                    " \n Error en query hacia la tabla de " + tabla);
            }
            return respuesta;
        }

        public string[] Select(string campoSolicitado, string tabla)//Leonel Dominguez
        {
            string[] respuesta = new string[100];
            string sql = "SELECT " + campoSolicitado + " FROM " + tabla + ";";
            int j = 0;
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        respuesta[j] = reader.GetValue(i).ToString();
                        j++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() +
                    " \n Error en SELECT hacia la tabla de " + tabla);
            }

            Array.Resize(ref respuesta, j);
            return respuesta;
        }

        public string[] SelectCustom(string campoSolicitado, string tabla, string clausula)//Leonel Dominguez
        {
            string[] respuesta = new string[999];
            string sql = "SELECT " + campoSolicitado + " FROM " + tabla + " WHERE " + clausula + ";";
            int j = 0;
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        respuesta[j] = reader.GetValue(i).ToString();
                        j++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() +
                    " \n Error en SELECT hacia la tabla de " + tabla);
            }

            Array.Resize(ref respuesta, j);
            return respuesta;
        }

        public Boolean Update(string campos, string tabla, string clausula)//Leonel Dominguez
        {
            Boolean respuesta = false;
            string sql = "UPDATE " + tabla + " SET " + campos + " WHERE " + clausula + ";";
            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            try
            {
                command.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception ex)
            {
                respuesta = false;
                Console.WriteLine(ex.Message.ToString() +
                    " \n Error en guardar registro en " + tabla);
            }
            return respuesta;
        }

        public Boolean Insert(string campos, string tabla, string datos)//Leonel Dominguez
        {
            Boolean respuesta = false;
            string sql = "INSERT INTO " + tabla + " (" + campos + ") values (" + datos + ");";
            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            try
            {
                command.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception ex)
            {
                respuesta = false;
                Console.WriteLine(ex.Message.ToString() +
                    " \n Error en guardar registro en " + tabla);
            }
            return respuesta;
        }

        public Boolean Delete(string tabla, string clausula)//Leonel Dominguez
        {
            Boolean respuesta = false;
            string sql = "DELETE FROM " + tabla + " WHERE " + clausula + ";";
            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            try
            {
                command.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception ex)
            {
                respuesta = false;
                Console.WriteLine(ex.Message.ToString() +
                    " \n Error en guardar registro en " + tabla);
            }
            return respuesta;
        }

        public int CountQuery(string tabla, string clausulas)
        {
            string sql = "SELECT COUNT(*) FROM colchoneria." + tabla + " WHERE " + clausulas + ";";
            OdbcCommand command = new OdbcCommand(sql, con.conexion());
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count;
        }

        public OdbcDataAdapter llenarListaPuesto(string tabla)
        {
            string sql = "select  pk_id_puesto as ID, nombre_puesto AS Puesto, estado_puesto as Estado from tbl_puestosdetrabajo where estado_puesto != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
        public OdbcDataAdapter llenarListaDepartamentos(string tabla)
        {
            string sql = "select pk_id_departamento as ID, nombre_departamento AS Departamento, descripcion_departamento as Descripcion from tbl_departamentos where estado_departamento != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenarListaPuesto2(string tabla)
        {
            string sql = "select  pk_id_puesto as ID, nombre_puesto AS Puesto, estado_puesto as Estado from tbl_puestosdetrabajo where estado_puesto != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenarListaTrabajador(string tabla)
        {
            string sql = "select pk_id_trabajador as ID, nombre_trabajador AS Trabajador, estado_trabajador AS Estado from tbl_trabajador where estado_trabajador != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenarListaContratos(string tabla)
        {
            string sql = "select  pk_id_contrato as ID, tipoPago_contrato AS TipoContrato, estado_contrato as Estado from tbl_contrato where estado_contrato != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenarListaTrabajador2(string tabla)
        {
            string sql = "select pk_id_trabajador as ID, nombre_trabajador AS Trabajador, estado_trabajador AS Estado from tbl_trabajador where estado_trabajador != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public void insertar(string dato, string tipo, string tabla)
        {
            string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
            try
            {

                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener");
            }
        }

        public OdbcDataAdapter llenarListaAsignaciones(string tabla, string id)
        {
            string sql = "Select *from " + tabla + " where ID = " + id + " ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public void eliminarAsiganaciones(string tabla, string condicion1, int campo1, string condicion2, int campo2)
        {
            try
            {
                string sql = "DELETE FROM " + tabla + " where (" + condicion1 + " = " + campo1 + ") and (" + condicion2 + " =" + campo2 + ");";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }
        }

        public OdbcDataAdapter llenarListas(string tabla)
        {
            string sql = "select  *from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenarListContratos(string tabla)
        {
            string sql = "select pk_id_contrato as Contrato , salario_contrato as Salario  from tbl_contrato where estado_contrato != 0;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
    }
}
