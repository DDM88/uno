#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ShapeVisual : global::Windows.UI.Composition.ContainerVisual
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.CompositionViewBox ViewBox
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionViewBox ShapeVisual.ViewBox is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CompositionViewBox%20ShapeVisual.ViewBox");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.ShapeVisual", "CompositionViewBox ShapeVisual.ViewBox");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.CompositionShapeCollection Shapes
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionShapeCollection ShapeVisual.Shapes is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CompositionShapeCollection%20ShapeVisual.Shapes");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.ShapeVisual.Shapes.get
		// Forced skipping of method Windows.UI.Composition.ShapeVisual.ViewBox.get
		// Forced skipping of method Windows.UI.Composition.ShapeVisual.ViewBox.set
	}
}