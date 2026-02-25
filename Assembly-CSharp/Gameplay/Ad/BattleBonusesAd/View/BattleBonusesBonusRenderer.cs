using System;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.Ad.BattleBonusesAd.View
{
	// Token: 0x02000DBE RID: 3518
	[Token(Token = "0x2000DBE")]
	public class BattleBonusesBonusRenderer : AbstractDataRenderer<MedalData>
	{
		// Token: 0x060055D3 RID: 21971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D3")]
		[Address(RVA = "0xA373", Offset = "0xA373", VA = "0xA373", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D4")]
		[Address(RVA = "0xA374", Offset = "0xA374", VA = "0xA374")]
		private void RenderDuration()
		{
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D5")]
		[Address(RVA = "0xA375", Offset = "0xA375", VA = "0xA375")]
		public BattleBonusesBonusRenderer()
		{
		}

		// Token: 0x04002E83 RID: 11907
		[Token(Token = "0x4002E83")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x04002E84 RID: 11908
		[Token(Token = "0x4002E84")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _backtimePrefix;

		// Token: 0x04002E85 RID: 11909
		[Token(Token = "0x4002E85")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private AbstractBacktimeView _backtimeView;
	}
}
