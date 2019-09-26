using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comapi.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.location']/class[@name='CoordinateType']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comapi/location/CoordinateType", DoNotGenerateAcw=true)]
	public partial class CoordinateType : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.location']/class[@name='CoordinateType']/field[@name='BD09LL']"
		[Register ("BD09LL")]
		public const string Bd09ll = (string) "bd09ll";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.location']/class[@name='CoordinateType']/field[@name='BD09MC']"
		[Register ("BD09MC")]
		public const string Bd09mc = (string) "bd09mc";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.location']/class[@name='CoordinateType']/field[@name='GCJ02']"
		[Register ("GCJ02")]
		public const string Gcj02 = (string) "gcj02";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.location']/class[@name='CoordinateType']/field[@name='WGS84']"
		[Register ("WGS84")]
		public const string Wgs84 = (string) "wgs84";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comapi/location/CoordinateType", typeof (CoordinateType));
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

		protected CoordinateType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.location']/class[@name='CoordinateType']/constructor[@name='CoordinateType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CoordinateType ()
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

	}
}
