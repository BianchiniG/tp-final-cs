using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNutricion.db
{
    public partial class DietaPaciente : CommonObj, IAccessDB<DietaPaciente>, ITable, IAutoIncrement                        
    {
        private string[] _columns = { "codigo","cod_dieta","dni_paciente","fecha","fecha_fin" };
        public List<DietaPaciente> findAll()
        {
            return this.findAll(null);
        }
        public List<DietaPaciente> findAll(string criterio)
        {
            return ManagerDB<DietaPaciente>.findAll(criterio);
        }
        public DietaPaciente findbykey(params object[] key)
        {
            DietaPaciente dp =(DietaPaciente)ManagerDB<DietaPaciente>.findbyKey(key);
            this.Codigo = dp.Codigo;
            this.CodigoDieta = dp.CodigoDieta;
            this.DniPaciente = dp.DniPaciente;
            this.Fecha = dp.Fecha;
            this.FechaFin = dp.FechaFin;
            this.IsNew = false;
            return this;
        }
        public bool saveObj()
        {
            return ManagerDB<DietaPaciente>.saveObject(this);
        }

        public string TableName
        {
            get { return "dieta_paciente"; }
        }

        public string KeyTable
        {
            get { return "codigo"; }
        }

        public void initialize(System.Data.DataRow dr)
        { 
            this._codigo = Int32.Parse(dr[_columns[0]].ToString());
			this._codigoDieta = Int32.Parse(dr[_columns[1]].ToString());
			this._dniPaciente = Int32.Parse(dr[_columns[2]].ToString());
            this._fecha = DateTime.Parse(dr[_columns[3]].ToString());
			this._fechaFin = DateTime.Parse(dr[_columns[4]].ToString());
            this.IsNew = false;
        }
        public string[] columns
        {
            get { return _columns; }
        }
        private string[] list_values()
        {
            //"codigo","cod_dieta","dni_paciente","fecha","fecha_fin"
            string[] values = { (this.IsNew?"":_columns[0] + "=")+this._codigo.ToString(),
								(this.IsNew?"":_columns[1] + "=")+this._codigoDieta.ToString(),
								(this.IsNew?"":_columns[2] + "=")+this._dniPaciente.ToString(),                                
								(this.IsNew?"":_columns[3] + "=")+String.Format("'{0}'",this._fecha.ToString("yyyy-MM-dd")),//formato cadena '
                                (this.IsNew?"":_columns[4] + "=")+String.Format("'{0}'",this._fechaFin.ToString("yyyy-MM-dd"))//formato cadena '
                              };
            return values;
        }

        public string SqlString
        {
            get
            {
                string vvalues = String.Join(",", this.list_values());
                string sqliu = (this.IsNew ? "insert into {0} ({1}) values ({2})" : "update  {0} set {1} where {2}");
                return String.Format(sqliu, this.TableName, (this.IsNew ? String.Join(",", _columns) : vvalues), (this.IsNew ? vvalues : String.Format("codigo = {0}", this.Codigo)));
            }
        }
        // propiedad seteada por implementar IAutoIncrement
        public void setKeyValue(object valueId)
        {
            this._codigo = Convert.ToInt32(valueId);
        }
        
        public string sqlKeyWhere(params object[] values)
        {
            return String.Format("codigo={0}", values[0]);
        }
    }
}
