using System;
using Gameplay.Isles.Axis.View;
using Gameplay.Isles.Base.View;
using Gameplay.Isles.Clan.Controller;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Isles.Clan.View
{
	// Token: 0x02000CF2 RID: 3314
	[Token(Token = "0x2000CF2")]
	public class ClanIsleView : BaseIsleView, IToolTipDataProvider
	{
		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x060050A3 RID: 20643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700104D")]
		public ColossusInWorldView ColossusView
		{
			[Token(Token = "0x60050A3")]
			[Address(RVA = "0x9EB2", Offset = "0x9EB2", VA = "0x9EB2")]
			get
			{
				return null;
			}
		}

		// Token: 0x060050A4 RID: 20644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A4")]
		[Address(RVA = "0x9EB3", Offset = "0x9EB3", VA = "0x9EB3")]
		public void Init(ClanIsle isle)
		{
		}

		// Token: 0x060050A5 RID: 20645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A5")]
		[Address(RVA = "0x9EB4", Offset = "0x9EB4", VA = "0x9EB4")]
		public void Deinit()
		{
		}

		// Token: 0x060050A6 RID: 20646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60050A6")]
		[Address(RVA = "0x9EB5", Offset = "0x9EB5", VA = "0x9EB5", Slot = "10")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060050A7 RID: 20647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050A7")]
		[Address(RVA = "0x9EB6", Offset = "0x9EB6", VA = "0x9EB6")]
		public ClanIsleView()
		{
		}

		// Token: 0x04002C0E RID: 11278
		[Token(Token = "0x4002C0E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ColossusInWorldView _colossusView;

		// Token: 0x04002C0F RID: 11279
		[Token(Token = "0x4002C0F")]
		[FieldOffset(Offset = "0x3C")]
		private ClanIsleViewMediator _mediator;
	}
}
