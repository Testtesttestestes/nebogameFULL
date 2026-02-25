using System;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Parts
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	public class ArtikulViewWhitTitle : ArtikulView
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000147")]
		public override ArtikulData Data
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x5D27", Offset = "0x5D27", VA = "0x5D27", Slot = "14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x5D28", Offset = "0x5D28", VA = "0x5D28", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x5D29", Offset = "0x5D29", VA = "0x5D29", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x5D2A", Offset = "0x5D2A", VA = "0x5D2A")]
		public ArtikulViewWhitTitle()
		{
		}

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextMeshProUGUI _title;
	}
}
