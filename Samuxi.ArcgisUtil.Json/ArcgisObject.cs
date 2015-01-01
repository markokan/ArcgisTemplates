using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuxi.ArcgisUtil.Json
{
    public class ArcgisObject
    {
        private string jsonPath { get; set; }

        public ArcgisObject(string jsonFilePath)
        {
            jsonPath = jsonFilePath;
            Read();
        }

        public JsonArcgisObject JsonArcgisObject { get; set; }

        private void Read()
        {
            var output = JsonConvert.DeserializeObject<JsonArcgisObject>(File.ReadAllText(jsonPath));            

            foreach (var item in output.fields)
            {
                switch (item.type.ToLower())
                {
                    case "esrifieldtypeoid":
                        item.EsriType = EsriTypes.esriFieldTypeOID;
                        item.CodeType = "long";
                        break;
                    case "esrifieldtypeguid":
                        item.EsriType = EsriTypes.esriFieldTypeGuid;
                        item.CodeType = "Guid";
                        break;
                    case "esrifieldtypeglobalid":
                        item.EsriType = EsriTypes.esriFieldTypeGlobalId;
                        item.CodeType = "Guid";
                        break;
                    case "esrifieldtypedouble":
                        item.EsriType = EsriTypes.esriFieldTypeDouble;
                        item.CodeType = "double";
                        break;
                    case "esrifieldtypestring":
                        item.EsriType = EsriTypes.esriFieldTypeString;
                        item.CodeType = "string";
                        break;
                    case "esrifieldtypeinteger":
                        item.EsriType = EsriTypes.esriFieldTypeInteger;
                        item.CodeType = "int";
                        break;     
                    case "esrifieldtypedate":
                        item.EsriType = EsriTypes.esriFieldTypeDate;
                        item.CodeType = "DateTime";
                        break;
                    case "esrifieldtypegeometry":
                        item.EsriType = EsriTypes.esriFieldTypeGeometry;
                        item.CodeType = "object";
                        break;
                }
            }

            JsonArcgisObject = output;
        }
    }

    public enum EsriTypes
    {
        esriFieldTypeOID = 0,
        esriFieldTypeGuid,
        esriFieldTypeGlobalId,
        esriFieldTypeDouble,
        esriFieldTypeString,
        esriFieldTypeInteger,
        esriFieldTypeDate,
        esriFieldTypeGeometry
    }

    public class SpatialReference
    {
        public int wkid { get; set; }
        public int latestWkid { get; set; }
    }

    public class Extent
    {
        public double xmin { get; set; }
        public double ymin { get; set; }
        public double xmax { get; set; }
        public double ymax { get; set; }
        public SpatialReference spatialReference { get; set; }
    }

    public class Outline
    {
        public string type { get; set; }
        public string style { get; set; }
        public List<int> color { get; set; }
        public double width { get; set; }
    }

    public class Symbol
    {
        public string type { get; set; }
        public string style { get; set; }
        public List<int> color { get; set; }
        public Outline outline { get; set; }
    }

    public class Renderer
    {
        public string type { get; set; }
        public Symbol symbol { get; set; }
        public string label { get; set; }
        public string description { get; set; }
    }

    public class DrawingInfo
    {
        public Renderer renderer { get; set; }
        public int transparency { get; set; }
        public object labelingInfo { get; set; }
    }

    public class Field
    {
        private string _name;
        public string name 
        {
            get { return _name; }
            set
            {
                _name = value.First().ToString().ToUpper() + value.Substring(1).ToLowerInvariant();
            }
        }
        public string type { get; set; }
        public string alias { get; set; }
        public object domain { get; set; }
        public bool editable { get; set; }
        public bool nullable { get; set; }
        public int? length { get; set; }
        public EsriTypes EsriType { get; set; }
        public string CodeType { get; set; }
    }


    public class JsonArcgisObject
    {
        public double currentVersion { get; set; }
        public int id { get; set; }
        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                _name = value.First().ToString().ToUpper() + value.Substring(1).ToLowerInvariant();
            }
        }
        public string type { get; set; }
        public string description { get; set; }
        public string copyrightText { get; set; }
        public bool defaultVisibility { get; set; }
        public object editFieldsInfo { get; set; }
        public object ownershipBasedAccessControlForFeatures { get; set; }
        public bool syncCanReturnChanges { get; set; }
        public List<object> relationships { get; set; }
        public bool isDataVersioned { get; set; }
        public bool supportsRollbackOnFailureParameter { get; set; }
        public bool supportsStatistics { get; set; }
        public bool supportsAdvancedQueries { get; set; }
        public string geometryType { get; set; }
        public int minScale { get; set; }
        public int maxScale { get; set; }
        public Extent extent { get; set; }
        public DrawingInfo drawingInfo { get; set; }
        public bool hasM { get; set; }
        public bool hasZ { get; set; }
        public bool allowGeometryUpdates { get; set; }
        public bool hasAttachments { get; set; }
        public string htmlPopupType { get; set; }
        public string objectIdField { get; set; }
        public string globalIdField { get; set; }
        public string displayField { get; set; }
        public string typeIdField { get; set; }
        public List<Field> fields { get; set; }
        public List<object> types { get; set; }
        
        public int maxRecordCount { get; set; }
        public string supportedQueryFormats { get; set; }
        public string capabilities { get; set; }
        public bool useStandardizedQueries { get; set; }
    }
}
