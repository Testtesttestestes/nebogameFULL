using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Fresco.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Fresco;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007F3 RID: 2035
	[Token(Token = "0x20007F3")]
	public class FrescoFieldEditable : FrescoField
	{
		// Token: 0x14000168 RID: 360
		// (add) Token: 0x06002FCF RID: 12239 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002FD0 RID: 12240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000168")]
		public event Action<List<uint>> OnChangeSelected
		{
			[Token(Token = "0x6002FCF")]
			[Address(RVA = "0x8035", Offset = "0x8035", VA = "0x8035")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002FD0")]
			[Address(RVA = "0x8036", Offset = "0x8036", VA = "0x8036")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD1")]
		[Address(RVA = "0x8037", Offset = "0x8037", VA = "0x8037")]
		public void Init(Protocol.Fresco.Fresco fresco, Protocol.Dic.Fresco.Types.FrescoDic frescoDic, FrescoEditView view, FrescoModel model)
		{
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD2")]
		[Address(RVA = "0x8038", Offset = "0x8038", VA = "0x8038")]
		public void ClearSelection()
		{
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD3")]
		[Address(RVA = "0x8039", Offset = "0x8039", VA = "0x8039", Slot = "14")]
		public override void ClickHandler(FrescoFragment fragment)
		{
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD4")]
		[Address(RVA = "0x803A", Offset = "0x803A", VA = "0x803A")]
		private void ShowInfo(uint index)
		{
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD5")]
		[Address(RVA = "0x803B", Offset = "0x803B", VA = "0x803B", Slot = "15")]
		protected override void ValidateSize(int sizeX, int sizeY, FrescoSpriteSelectorSO.SpriteSelectorElement spriteElement)
		{
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD6")]
		[Address(RVA = "0x803C", Offset = "0x803C", VA = "0x803C")]
		public void SelectAll()
		{
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD7")]
		[Address(RVA = "0x803D", Offset = "0x803D", VA = "0x803D")]
		public FrescoFieldEditable()
		{
		}

		// Token: 0x04001A24 RID: 6692
		[Token(Token = "0x4001A24")]
		[FieldOffset(Offset = "0x58")]
		private FrescoEditView _view;

		// Token: 0x04001A25 RID: 6693
		[Token(Token = "0x4001A25")]
		[FieldOffset(Offset = "0x5C")]
		private FrescoModel _model;

		// Token: 0x04001A26 RID: 6694
		[Token(Token = "0x4001A26")]
		[FieldOffset(Offset = "0x60")]
		private readonly List<uint> _selectedCells;
	}
}
