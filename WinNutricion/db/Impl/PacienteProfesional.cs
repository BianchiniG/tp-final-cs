using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class PacienteProfesional : CommonObj, IAccessDB<PacienteProfesional>, ITable
    {
        private string[] _columns = { "dni_paciente","dni_medico","fecha_desde","fecha_hasta" };
        public List<PacienteProfesional> findAll()
        {
            return this.findAll(null);
        }
        public List<PacienteProfesional> findAll(string criterio)
        {
            return ManagerDB<PacienteProfesional>.findAll(criterio);
        }
        public PacienteProfesional findbykey(params object[] key)
        {
            PacienteProfesional pf = (PacienteProfesional)ManagerDB<PacienteProfesional>.findbyKey(key);
            this.DniMedico = pf.DniMedico;
            this.DniPaciente = pf.DniPaciente;
            this.FechaDesde = pf.FechaDesde;
            this.FechaHasta = pf.FechaHasta;
            this.IsNew = false;
            return this;
        }
        public bool saveObj()
        {
            return ManagerDB<PacienteProfesional>.saveObject(this);
        }

        public string TableName
        {
            get { return "paciente_profesional"; }
        }

        public string KeyTable
        {
            get { return "codigo"; }
        }

        public void initialize(System.Data.DataRow dr)
        {
			// "dni_paciente","dni_medico","fecha_desde","fecha_hasta"
            this._dniPaciente = Int32.Parse(dr[_columns[0]].ToString());
			this._dniMedico = Int32.Parse(dr[_columns[1]].ToString());
			this._fechaDesde = DateTime.Parse(dr[_columns[2]].ToString());
            this._fechaHasta = DateTime.Parse(dr[_columns[3]].ToString());
            this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            // "dni_paciente","dni_medico","fecha_desde","fecha_hasta"
            string[] values = { (this.IsNew?"":_columns[0] + "=")+this._dniPaciente.ToString(),
								(this.IsNew?"":_columns[1] + "=")+this._dniMedico.ToString(),
								(this.IsNew?"":_columns[2] + "=")+String.Format("'{0}'",this._fechaDesde.ToString("yyyy-MM-dd")),//formato cadena '
								(this.IsNew?"":_columns[3] + "=")+String.Format("'{0}'",this._fechaHasta.ToString("yyyy-MM-dd"))//formato cadena '
                              };
            return values;
        }

        public string SqlString
        {
            get
            {
                string vvalues = String.Join(",", this.list_values());
                string sqliu = (this.IsNew ? "insert into {0} ({1}) values ({2})" : "update  {0} set {1} where {2}");
                return String.Format(sqliu, this.TableName, (this.IsNew ? String.Join(",", _columns) : vvalues), (this.IsNew ? vvalues : String.Format("dni_paciente = {0} and dni_medico= {1} and to_char(fecha_desde, 'YYYY-MM-DD')='{2}'", this.DniPaciente, this.DniMedico,this.FechaDesde)));
            }
        }

        public void setKeyValue(object valueId)
        {
            throw new NotImplementedException();
        }

        public string sqlKeyWhere(params object[] values)
        {
            return String.Format("dni_paciente = {0} and dni_medico = {1} and to_char(fecha_desde, 'YYYY-MM-DD')='{2}'", values[0], values[1], values[2]);
        }
    }
}
