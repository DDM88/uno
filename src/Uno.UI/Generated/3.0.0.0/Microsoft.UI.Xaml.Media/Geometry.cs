#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Geometry : global::Microsoft.UI.Xaml.DependencyObject
	{
		// Skipping already declared property Transform
		// Skipping already declared property Bounds
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.Media.Geometry Empty
		{
			get
			{
				throw new global::System.NotImplementedException("The member Geometry Geometry.Empty is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Geometry%20Geometry.Empty");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static double StandardFlatteningTolerance
		{
			get
			{
				throw new global::System.NotImplementedException("The member double Geometry.StandardFlatteningTolerance is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=double%20Geometry.StandardFlatteningTolerance");
			}
		}
		#endif
		// Skipping already declared property TransformProperty
		// Forced skipping of method Microsoft.UI.Xaml.Media.Geometry.Transform.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Geometry.Transform.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.Geometry.Bounds.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Geometry.Empty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Geometry.StandardFlatteningTolerance.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.Geometry.TransformProperty.get
	}
}