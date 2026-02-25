using System;
using System.Collections;
using Il2CppDummyDll;
using Utils;

namespace UI.Elements.GenericList
{
	// Token: 0x02000228 RID: 552
	[Token(Token = "0x2000228")]
	public class PooledSelectorGenericList<TArgs, TElement, TElementArgs> : PooledGenericList<TArgs, TElement, TElementArgs> where TArgs : SelectedGenericListArgs<TElementArgs>, new() where TElement : SelectedGenericListElement<TElementArgs>, new() where TElementArgs : GenericListElementArgs
	{
		// Token: 0x170001CE RID: 462
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CE")]
		public TArgs Data
		{
			[Token(Token = "0x6000DB7")]
			set
			{
			}
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB8")]
		public override void Init(TArgs args)
		{
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000DB9")]
		private IEnumerator StartSelect(int index)
		{
			return null;
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBA")]
		protected override void OnClickElement(TElementArgs elementArgs)
		{
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBB")]
		public void SelectByIndex(int index)
		{
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBC")]
		public void SelectByIndex(int index, bool silent)
		{
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBD")]
		public PooledSelectorGenericList()
		{
		}

		// Token: 0x040006CB RID: 1739
		[Token(Token = "0x40006CB")]
		[FieldOffset(Offset = "0x0")]
		private int _selectedIndex;

		// Token: 0x040006CC RID: 1740
		[Token(Token = "0x40006CC")]
		[FieldOffset(Offset = "0x0")]
		public TypedUnityEvent<TElementArgs> onDeselect;

		// Token: 0x040006CD RID: 1741
		[Token(Token = "0x40006CD")]
		[FieldOffset(Offset = "0x0")]
		private TArgs _data;
	}
}
