using System;
using Il2CppDummyDll;

namespace UI.Elements.GenericList
{
	// Token: 0x02000230 RID: 560
	[Token(Token = "0x2000230")]
	public abstract class SelectedGenericListElement<TElementArgs> : GenericListElement<TElementArgs> where TElementArgs : GenericListElementArgs
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x00004170 File Offset: 0x00002370
		// (set) Token: 0x06000DEB RID: 3563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D7")]
		public virtual bool Selected
		{
			[Token(Token = "0x6000DEA")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DEB")]
			set
			{
			}
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEC")]
		protected SelectedGenericListElement()
		{
		}

		// Token: 0x040006DF RID: 1759
		[Token(Token = "0x40006DF")]
		[FieldOffset(Offset = "0x0")]
		private bool _selected;
	}
}
