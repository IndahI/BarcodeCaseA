using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BarcodeCaseA.Model
{
    public class CaseModel
    {
        public string id;
        public string date;
        public string modelNumber;
        public string globalCodeId;
        public string adjustment;
        public string modelCode;
        public string inspectorId;
        public string inspector;
        public string scanResult;

        // Properties
        [DisplayName("ID")]
        [Browsable(false)]
        public string Id
        {
            get => id;
            set => id = value;
        }
        [DisplayName("Date")]
        public string Date
        {
            get => date;
            set => date = value;
        }

        [DisplayName("Model Code")]
        public string ModelCode
        {
            get => modelCode;
            set => modelCode = value;
        }

        [DisplayName("Model Number")]
        public string ModelNumber
        {
            get => modelNumber;
            set => modelNumber = value;
        }

        [DisplayName("GlobalCodeId")]
        public string GlobalCodeId
        {
            get => globalCodeId;
            set => globalCodeId = value;
        }

        [DisplayName("Scan Result")]
        public string ScanResult
        {
            get => scanResult;
            set => scanResult = value;
        }

        [DisplayName("Adjustment")]
        public string Adjustment
        {
            get => adjustment;
            set => adjustment = value;
        }

        [DisplayName("InspectorId")]
        [Browsable(false)]
        public string InspectorId
        {
            get => inspectorId;
            set => inspectorId = value;
        }

        [DisplayName("Inspector")]
        //[Browsable(false)]
        public string Inspector
        {
            get => inspector;
            set => inspector = value;
        }
    }
}
