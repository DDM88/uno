#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContainerVisual : global::Windows.UI.Composition.Visual
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.VisualCollection Children
		{
			get
			{
				throw new global::System.NotImplementedException("The member VisualCollection ContainerVisual.Children is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=VisualCollection%20ContainerVisual.Children");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.ContainerVisual.Children.get
	}
}