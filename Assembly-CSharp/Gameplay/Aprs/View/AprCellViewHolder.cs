using System;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D4C RID: 3404
	[Token(Token = "0x2000D4C")]
	public class AprCellViewHolder : CellViewsHolder
	{
		// Token: 0x0600535D RID: 21341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600535D")]
		[Address(RVA = "0xA11C", Offset = "0xA11C", VA = "0xA11C", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x0600535E RID: 21342 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600535F RID: 21343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010ED")]
		public AprData AprData
		{
			[Token(Token = "0x600535E")]
			[Address(RVA = "0xA11D", Offset = "0xA11D", VA = "0xA11D")]
			get
			{
				return null;
			}
			[Token(Token = "0x600535F")]
			[Address(RVA = "0xA11E", Offset = "0xA11E", VA = "0xA11E")]
			set
			{
			}
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005360")]
		[Address(RVA = "0xA11F", Offset = "0xA11F", VA = "0xA11F")]
		public AprCellViewHolder()
		{
		}

		// Token: 0x04002D26 RID: 11558
		[Token(Token = "0x4002D26")]
		[FieldOffset(Offset = "0x18")]
		private AprGridView _aprGridView;
	}
}
