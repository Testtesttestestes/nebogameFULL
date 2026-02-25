using System;
using System.Collections;
using Il2CppDummyDll;
using Utils;

namespace UI.Elements.GenericList
{
	// Token: 0x0200022D RID: 557
	[Token(Token = "0x200022D")]
	public class SelectorGenericList<TArgs, TElement, TElementArgs> : GenericList<TArgs, TElement, TElementArgs> where TArgs : SelectedGenericListArgs<TElementArgs>, new() where TElement : SelectedGenericListElement<TElementArgs>, new() where TElementArgs : GenericListElementArgs
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x170001D3")]
		public int SelectedIndex
		{
			[Token(Token = "0x6000DD8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D4")]
		public TArgs Data
		{
			[Token(Token = "0x6000DD9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DDA")]
			set
			{
			}
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDB")]
		public override void Init(TArgs args)
		{
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000DDC")]
		private IEnumerator StartSelect(int index)
		{
			return null;
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDD")]
		protected override void OnClickElement(TElementArgs elementArgs)
		{
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDE")]
		public void SelectByIndex(int index)
		{
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDF")]
		public void Deselect()
		{
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE0")]
		public void SelectByIndex(int index, bool silent)
		{
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE1")]
		public SelectorGenericList()
		{
		}

		// Token: 0x040006D7 RID: 1751
		[Token(Token = "0x40006D7")]
		[FieldOffset(Offset = "0x0")]
		private int _selectedIndex;

		// Token: 0x040006D8 RID: 1752
		[Token(Token = "0x40006D8")]
		[FieldOffset(Offset = "0x0")]
		public TypedUnityEvent<TElementArgs> onDeselect;

		// Token: 0x040006D9 RID: 1753
		[Token(Token = "0x40006D9")]
		[FieldOffset(Offset = "0x0")]
		private TArgs _data;
	}
}
