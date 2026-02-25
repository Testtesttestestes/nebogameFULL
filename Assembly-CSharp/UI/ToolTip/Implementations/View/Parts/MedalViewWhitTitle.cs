using System;
using AssetContent;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Parts
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	public class MedalViewWhitTitle : MedalView
	{
		// Token: 0x060009C3 RID: 2499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x5D2B", Offset = "0x5D2B", VA = "0x5D2B", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x5D2C", Offset = "0x5D2C", VA = "0x5D2C")]
		public void SetMedalRankDic(MedalRanks medalRanksDic)
		{
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x5D2D", Offset = "0x5D2D", VA = "0x5D2D")]
		public void SetTitle(string value)
		{
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x5D2E", Offset = "0x5D2E", VA = "0x5D2E")]
		public void SetSubTitle(string value)
		{
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x5D2F", Offset = "0x5D2F", VA = "0x5D2F")]
		public MedalViewWhitTitle()
		{
		}

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private MedalView _medalView;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TextMeshProUGUI _subtitle;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameRawImage _background;
	}
}
