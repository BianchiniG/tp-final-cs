using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class PacienteControl : CommonObj, IAccessDB<PacienteControl>, ITable
    {
        private string[] _columns = { "dni_paciente","fecha","peso" };
        public List<PacienteControl> findAll()
        {
            return this.findAll(null);
        }
        public List<PacienteControl> findAll(string criterio)
        {
            return ManagerDB<PacienteControl>.findAll(criterio);
        }
        public PacienteControl findbykey(params object[] key)
        {
            PacienteControl pc =(PacienteControl)ManagerDB<PacienteControl>.findbyKey(key);
            this.DniPaciente = pc.DniPaciente;
            this.Fecha = pc.Fecha;
            this.Peso = pc.Peso;
            this.IsNew = false;
            return this;
        }
        public bool saveObj()
        {
            return ManagerDB<PacienteControl>.saveObject(this);
        }

        public string TableName
        {
            get { return "paciente_control"; }
        }

        public string KeyTable
        {
            get { return "codigo"; }
        }

        public void initialize(System.Data.DataRow dr)
        {
			// "dni_paciente","fecha","peso"
            this._dniPaciente = Int32.Parse(dr[_columns[0]].ToString());
			this._fecha = DateTime.Parse(dr[_columns[1]].ToString());
            this._peso = float.Parse(dr[_columns[2]].ToString());
            this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            // "dni_paciente","fecha","peso"
            string[] values = { (this.IsNew?"":_columns[0] + "=")+this._dniPaciente.ToString(),
								(this.IsNew?"":_columns[1] + "=")+String.Format("'{0}'",this._fecha.ToString("yyyy-MM-dd")),//formato cadena '
								(this.IsNew?"":_columns[2] + "=")+this._peso.ToString()
                              };
            return values;
        }

        public string SqlString
        {
            get
            {
                string vvalues = String.Join(",", this.list_values());
                string sqliu = (this.IsNew ? "insert into {0} ({1}) values ({2})" : "update  {0} set {1} where {2}");
                return String.Format(sqliu, this.TableName, (this.IsNew ? String.Join(",", _columns) : vvalues), (this.IsNew ? vvalues : String.Format("dni_paciente = {0} and and to_char(fecha, 'YYYY-MM-DD')= '{1}'", this.DniPaciente, this.Fecha)));
            }
        }

        public void setKeyValue(object valueId)
        {
            throw new NotImplementedException();
        }

        public string sqlKeyWhere(params object[] values)
        {
            return String.Format("dni_paciente = {0} and to_char(fecha, 'YYYY-MM-DD')='{1}'", values[0], values[1]);
        }
    }
}
