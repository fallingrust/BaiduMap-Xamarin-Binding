using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']"
	[global::Android.Runtime.Register ("com/baidu/location/Address", DoNotGenerateAcw=true)]
	public sealed partial class Address : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='adcode']"
		[Register ("adcode")]
		public string Adcode {
			get {
				const string __id = "adcode.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "adcode.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='Addresses']"
		[Register ("Addresses")]
		public string Addresses {
			get {
				const string __id = "Addresses.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "Addresses.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='city']"
		[Register ("city")]
		public string City {
			get {
				const string __id = "city.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "city.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='cityCode']"
		[Register ("cityCode")]
		public string CityCode {
			get {
				const string __id = "cityCode.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cityCode.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='country']"
		[Register ("country")]
		public string Country {
			get {
				const string __id = "country.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "country.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='countryCode']"
		[Register ("countryCode")]
		public string CountryCode {
			get {
				const string __id = "countryCode.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "countryCode.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='district']"
		[Register ("district")]
		public string District {
			get {
				const string __id = "district.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "district.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='province']"
		[Register ("province")]
		public string Province {
			get {
				const string __id = "province.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "province.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='street']"
		[Register ("street")]
		public string Street {
			get {
				const string __id = "street.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "street.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='streetNumber']"
		[Register ("streetNumber")]
		public string StreetNumber {
			get {
				const string __id = "streetNumber.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "streetNumber.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='Address']/field[@name='town']"
		[Register ("town")]
		public string Town {
			get {
				const string __id = "town.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "town.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']"
		[global::Android.Runtime.Register ("com/baidu/location/Address$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/location/Address$Builder", typeof (Builder));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/constructor[@name='Address.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_adcode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAdcode_Ljava_lang_String_Handler ()
			{
				if (cb_adcode_Ljava_lang_String_ == null)
					cb_adcode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Adcode_Ljava_lang_String_);
				return cb_adcode_Ljava_lang_String_;
			}

			static IntPtr n_Adcode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Adcode (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='adcode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("adcode", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetAdcode_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder Adcode (string p0)
			{
				const string __id = "adcode.(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/baidu/location/Address;", "GetBuildHandler")]
			public virtual unsafe global::Com.Baidu.Location.Address Build ()
			{
				const string __id = "build.()Lcom/baidu/location/Address;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_city_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCity_Ljava_lang_String_Handler ()
			{
				if (cb_city_Ljava_lang_String_ == null)
					cb_city_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_City_Ljava_lang_String_);
				return cb_city_Ljava_lang_String_;
			}

			static IntPtr n_City_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.City (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='city' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("city", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetCity_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder City (string p0)
			{
				const string __id = "city.(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_cityCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCityCode_Ljava_lang_String_Handler ()
			{
				if (cb_cityCode_Ljava_lang_String_ == null)
					cb_cityCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CityCode_Ljava_lang_String_);
				return cb_cityCode_Ljava_lang_String_;
			}

			static IntPtr n_CityCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CityCode (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='cityCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("cityCode", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetCityCode_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder CityCode (string p0)
			{
				const string __id = "cityCode.(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_country_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCountry_Ljava_lang_String_Handler ()
			{
				if (cb_country_Ljava_lang_String_ == null)
					cb_country_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Country_Ljava_lang_String_);
				return cb_country_Ljava_lang_String_;
			}

			static IntPtr n_Country_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Country (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='country' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("country", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetCountry_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder Country (string p0)
			{
				const string __id = "country.(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_countryCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetCountryCode_Ljava_lang_String_Handler ()
			{
				if (cb_countryCode_Ljava_lang_String_ == null)
					cb_countryCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CountryCode_Ljava_lang_String_);
				return cb_countryCode_Ljava_lang_String_;
			}

			static IntPtr n_CountryCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CountryCode (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='countryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("countryCode", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetCountryCode_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder CountryCode (string p0)
			{
				const string __id = "countryCode.(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_district_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDistrict_Ljava_lang_String_Handler ()
			{
				if (cb_district_Ljava_lang_String_ == null)
					cb_district_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_District_Ljava_lang_String_);
				return cb_district_Ljava_lang_String_;
			}

			static IntPtr n_District_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.District (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='district' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("district", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetDistrict_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder District (string p0)
			{
				const string __id = "district.(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_province_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetProvince_Ljava_lang_String_Handler ()
			{
				if (cb_province_Ljava_lang_String_ == null)
					cb_province_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Province_Ljava_lang_String_);
				return cb_province_Ljava_lang_String_;
			}

			static IntPtr n_Province_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Province (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='province' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("province", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetProvince_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder Province (string p0)
			{
				const string __id = "province.(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_street_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetStreet_Ljava_lang_String_Handler ()
			{
				if (cb_street_Ljava_lang_String_ == null)
					cb_street_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Street_Ljava_lang_String_);
				return cb_street_Ljava_lang_String_;
			}

			static IntPtr n_Street_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Street (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='street' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("street", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetStreet_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder Street (string p0)
			{
				const string __id = "street.(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_streetNumber_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetStreetNumber_Ljava_lang_String_Handler ()
			{
				if (cb_streetNumber_Ljava_lang_String_ == null)
					cb_streetNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StreetNumber_Ljava_lang_String_);
				return cb_streetNumber_Ljava_lang_String_;
			}

			static IntPtr n_StreetNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StreetNumber (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='streetNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("streetNumber", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetStreetNumber_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder StreetNumber (string p0)
			{
				const string __id = "streetNumber.(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_town_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetTown_Ljava_lang_String_Handler ()
			{
				if (cb_town_Ljava_lang_String_ == null)
					cb_town_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Town_Ljava_lang_String_);
				return cb_town_Ljava_lang_String_;
			}

			static IntPtr n_Town_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Location.Address.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Town (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Address.Builder']/method[@name='town' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("town", "(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;", "GetTown_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Baidu.Location.Address.Builder Town (string p0)
			{
				const string __id = "town.(Ljava/lang/String;)Lcom/baidu/location/Address$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/location/Address", typeof (Address));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal Address (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
