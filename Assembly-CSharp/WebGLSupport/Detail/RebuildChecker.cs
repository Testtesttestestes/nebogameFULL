using System;
using Il2CppDummyDll;

namespace WebGLSupport.Detail
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public class RebuildChecker
	{
		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x56B6", Offset = "0x56B6", VA = "0x56B6")]
		public RebuildChecker(IInputField input)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x56B7", Offset = "0x56B7", VA = "0x56B7")]
		public bool NeedRebuild(bool debug = false)
		{
			return default(bool);
		}

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x8")]
		private IInputField input;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0xC")]
		private string beforeString;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x10")]
		private int beforeCaretPosition;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x14")]
		private int beforeSelectionFocusPosition;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x18")]
		private int beforeSelectionAnchorPosition;
	}
}
