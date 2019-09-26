using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdate']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapStatusUpdate", DoNotGenerateAcw=true)]
	public sealed partial class MapStatusUpdate : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MapStatusUpdate", typeof (MapStatusUpdate));
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

		internal MapStatusUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
