#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class LayoutInformation 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.UIElement GetLayoutExceptionElement( object dispatcher)
		{
			throw new global::System.NotImplementedException("The member UIElement LayoutInformation.GetLayoutExceptionElement(object dispatcher) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=UIElement%20LayoutInformation.GetLayoutExceptionElement%28object%20dispatcher%29");
		}
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Primitives.LayoutInformation.GetLayoutSlot(Microsoft.UI.Xaml.FrameworkElement)
		// Skipping already declared method Microsoft.UI.Xaml.Controls.Primitives.LayoutInformation.GetAvailableSize(Microsoft.UI.Xaml.UIElement)
	}
}