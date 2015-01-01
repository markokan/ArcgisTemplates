

using Catel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
 
namespace Samuxi.Model
{
  
	[Serializable]
	public class Muokattava : ModelBase
	{
		#region Properties
        
						
		public long Objectid 
		{
            get { return GetValue<long>(ObjectidProperty); }
            set { SetValue(ObjectidProperty, value); }
        }
		public static readonly PropertyData ObjectidProperty = RegisterProperty("Objectid", typeof(long), null);
								
		public double? Id 
		{
            get { return GetValue<double?>(IdProperty); }
            set { SetValue(IdProperty, value); }
        }
		public static readonly PropertyData IdProperty = RegisterProperty("Id", typeof(double?), null);
								
		public int? Color 
		{
            get { return GetValue<int?>(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
		public static readonly PropertyData ColorProperty = RegisterProperty("Color", typeof(int?), null);
								
		public string Piirinimi 
		{
            get { return GetValue<string>(PiirinimiProperty); }
            set { SetValue(PiirinimiProperty, value); }
        }
		public static readonly PropertyData PiirinimiProperty = RegisterProperty("Piirinimi", typeof(string), null);
								
		public string Hahmotelmanimi 
		{
            get { return GetValue<string>(HahmotelmanimiProperty); }
            set { SetValue(HahmotelmanimiProperty, value); }
        }
		public static readonly PropertyData HahmotelmanimiProperty = RegisterProperty("Hahmotelmanimi", typeof(string), null);
						
		#endregion

		#region Constructor

		public Muokattava()
		{ 
		}

		/// <summary>
		/// Initializes a new object based on <see cref="SerializationInfo"/>.
		/// </summary>
		/// <param name="info"><see cref="SerializationInfo"/> that contains the information.</param>
		/// <param name="context"><see cref="StreamingContext"/>.</param>
		protected Muokattava(SerializationInfo info, StreamingContext context): base(info, context) { }

		#endregion

		#region Methods
		/// <summary>
		/// Validates the field values of this object. Override this method to enable
		/// validation of field values.
		/// </summary>
		/// <param name="validationResults">The validation results, add additional results to this list.</param>
		protected override void ValidateFields(List<IFieldValidationResult> validationResults)
		{
		}

		/// <summary>
		/// Validates the field values of this object. Override this method to enable
		/// validation of field values.
		/// </summary>
		/// <param name="validationResults">The validation results, add additional results to this list.</param>
		protected override void ValidateBusinessRules(List<IBusinessRuleValidationResult> validationResults)
		{
		}
		#endregion
	}
 
	[Serializable]
	public class Vesistotulva_1000_laatikko : ModelBase
	{
		#region Properties
        
						
		public long Fid 
		{
            get { return GetValue<long>(FidProperty); }
            set { SetValue(FidProperty, value); }
        }
		public static readonly PropertyData FidProperty = RegisterProperty("Fid", typeof(long), null);
								
		public object Shape 
		{
            get { return GetValue<object>(ShapeProperty); }
            set { SetValue(ShapeProperty, value); }
        }
		public static readonly PropertyData ShapeProperty = RegisterProperty("Shape", typeof(object), null);
								
		public int Kohdenro 
		{
            get { return GetValue<int>(KohdenroProperty); }
            set { SetValue(KohdenroProperty, value); }
        }
		public static readonly PropertyData KohdenroProperty = RegisterProperty("Kohdenro", typeof(int), null);
								
		public string Syvsuojluo 
		{
            get { return GetValue<string>(SyvsuojluoProperty); }
            set { SetValue(SyvsuojluoProperty, value); }
        }
		public static readonly PropertyData SyvsuojluoProperty = RegisterProperty("Syvsuojluo", typeof(string), null);
								
		public string Nimi 
		{
            get { return GetValue<string>(NimiProperty); }
            set { SetValue(NimiProperty, value); }
        }
		public static readonly PropertyData NimiProperty = RegisterProperty("Nimi", typeof(string), null);
								
		public string Tulvakarto 
		{
            get { return GetValue<string>(TulvakartoProperty); }
            set { SetValue(TulvakartoProperty, value); }
        }
		public static readonly PropertyData TulvakartoProperty = RegisterProperty("Tulvakarto", typeof(string), null);
								
		public string Maaritysqm 
		{
            get { return GetValue<string>(MaaritysqmProperty); }
            set { SetValue(MaaritysqmProperty, value); }
        }
		public static readonly PropertyData MaaritysqmProperty = RegisterProperty("Maaritysqm", typeof(string), null);
								
		public string Maarityswm 
		{
            get { return GetValue<string>(MaarityswmProperty); }
            set { SetValue(MaarityswmProperty, value); }
        }
		public static readonly PropertyData MaarityswmProperty = RegisterProperty("Maarityswm", typeof(string), null);
								
		public string Digpohja 
		{
            get { return GetValue<string>(DigpohjaProperty); }
            set { SetValue(DigpohjaProperty, value); }
        }
		public static readonly PropertyData DigpohjaProperty = RegisterProperty("Digpohja", typeof(string), null);
								
		public string Digorg 
		{
            get { return GetValue<string>(DigorgProperty); }
            set { SetValue(DigorgProperty, value); }
        }
		public static readonly PropertyData DigorgProperty = RegisterProperty("Digorg", typeof(string), null);
								
		public DateTime Muutospvm 
		{
            get { return GetValue<DateTime>(MuutospvmProperty); }
            set { SetValue(MuutospvmProperty, value); }
        }
		public static readonly PropertyData MuutospvmProperty = RegisterProperty("Muutospvm", typeof(DateTime), null);
								
		public double Shape_leng 
		{
            get { return GetValue<double>(Shape_lengProperty); }
            set { SetValue(Shape_lengProperty, value); }
        }
		public static readonly PropertyData Shape_lengProperty = RegisterProperty("Shape_leng", typeof(double), null);
								
		public double Shape_area 
		{
            get { return GetValue<double>(Shape_areaProperty); }
            set { SetValue(Shape_areaProperty, value); }
        }
		public static readonly PropertyData Shape_areaProperty = RegisterProperty("Shape_area", typeof(double), null);
						
		#endregion

		#region Constructor

		public Vesistotulva_1000_laatikko()
		{ 
		}

		/// <summary>
		/// Initializes a new object based on <see cref="SerializationInfo"/>.
		/// </summary>
		/// <param name="info"><see cref="SerializationInfo"/> that contains the information.</param>
		/// <param name="context"><see cref="StreamingContext"/>.</param>
		protected Vesistotulva_1000_laatikko(SerializationInfo info, StreamingContext context): base(info, context) { }

		#endregion

		#region Methods
		/// <summary>
		/// Validates the field values of this object. Override this method to enable
		/// validation of field values.
		/// </summary>
		/// <param name="validationResults">The validation results, add additional results to this list.</param>
		protected override void ValidateFields(List<IFieldValidationResult> validationResults)
		{
		}

		/// <summary>
		/// Validates the field values of this object. Override this method to enable
		/// validation of field values.
		/// </summary>
		/// <param name="validationResults">The validation results, add additional results to this list.</param>
		protected override void ValidateBusinessRules(List<IBusinessRuleValidationResult> validationResults)
		{
		}
		#endregion
	}
 }
 
