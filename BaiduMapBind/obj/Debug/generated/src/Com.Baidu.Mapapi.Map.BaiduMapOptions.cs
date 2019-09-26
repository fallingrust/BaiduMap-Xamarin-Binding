using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMapOptions", DoNotGenerateAcw=true)]
	public sealed partial class BaiduMapOptions : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/BaiduMapOptions", typeof (BaiduMapOptions));
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

		internal BaiduMapOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/constructor[@name='BaiduMapOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaiduMapOptions ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='compassEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("compassEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions CompassEnabled (bool p0)
		{
			const string __id = "compassEnabled.(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='logoPosition' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.LogoPosition']]"
		[Register ("logoPosition", "(Lcom/baidu/mapapi/map/LogoPosition;)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions LogoPosition (global::Com.Baidu.Mapapi.Map.LogoPosition p0)
		{
			const string __id = "logoPosition.(Lcom/baidu/mapapi/map/LogoPosition;)Lcom/baidu/mapapi/map/BaiduMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='mapStatus' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatus']]"
		[Register ("mapStatus", "(Lcom/baidu/mapapi/map/MapStatus;)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions MapStatus (global::Com.Baidu.Mapapi.Map.MapStatus p0)
		{
			const string __id = "mapStatus.(Lcom/baidu/mapapi/map/MapStatus;)Lcom/baidu/mapapi/map/BaiduMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='mapType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("mapType", "(I)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions MapType (int p0)
		{
			const string __id = "mapType.(I)Lcom/baidu/mapapi/map/BaiduMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='overlookingGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("overlookingGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions OverlookingGesturesEnabled (bool p0)
		{
			const string __id = "overlookingGesturesEnabled.(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='rotateGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("rotateGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions RotateGesturesEnabled (bool p0)
		{
			const string __id = "rotateGesturesEnabled.(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='scaleControlEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("scaleControlEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ScaleControlEnabled (bool p0)
		{
			const string __id = "scaleControlEnabled.(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='scaleControlPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("scaleControlPosition", "(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ScaleControlPosition (global::Android.Graphics.Point p0)
		{
			const string __id = "scaleControlPosition.(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/BaiduMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='scrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("scrollGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ScrollGesturesEnabled (bool p0)
		{
			const string __id = "scrollGesturesEnabled.(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((int) p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='zoomControlsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("zoomControlsEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ZoomControlsEnabled (bool p0)
		{
			const string __id = "zoomControlsEnabled.(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='zoomControlsPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("zoomControlsPosition", "(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ZoomControlsPosition (global::Android.Graphics.Point p0)
		{
			const string __id = "zoomControlsPosition.(Landroid/graphics/Point;)Lcom/baidu/mapapi/map/BaiduMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMapOptions']/method[@name='zoomGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("zoomGesturesEnabled", "(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMapOptions ZoomGesturesEnabled (bool p0)
		{
			const string __id = "zoomGesturesEnabled.(Z)Lcom/baidu/mapapi/map/BaiduMapOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMapOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
