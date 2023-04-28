#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Text
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ITextSelection : global::Microsoft.UI.Text.ITextRange
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Text.SelectionOptions Options
		{
			get;
			set;
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Microsoft.UI.Text.SelectionType Type
		{
			get;
		}
		#endif
		// Forced skipping of method Microsoft.UI.Text.ITextSelection.Options.get
		// Forced skipping of method Microsoft.UI.Text.ITextSelection.Options.set
		// Forced skipping of method Microsoft.UI.Text.ITextSelection.Type.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int EndKey( global::Microsoft.UI.Text.TextRangeUnit unit,  bool extend);
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int HomeKey( global::Microsoft.UI.Text.TextRangeUnit unit,  bool extend);
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int MoveDown( global::Microsoft.UI.Text.TextRangeUnit unit,  int count,  bool extend);
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int MoveLeft( global::Microsoft.UI.Text.TextRangeUnit unit,  int count,  bool extend);
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int MoveRight( global::Microsoft.UI.Text.TextRangeUnit unit,  int count,  bool extend);
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		int MoveUp( global::Microsoft.UI.Text.TextRangeUnit unit,  int count,  bool extend);
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		void TypeText( string value);
		#endif
	}
}