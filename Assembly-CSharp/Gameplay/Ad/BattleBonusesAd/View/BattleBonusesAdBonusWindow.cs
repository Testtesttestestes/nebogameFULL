using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Ad.BattleBonusesAd.View
{
	// Token: 0x02000DB9 RID: 3513
	[Token(Token = "0x2000DB9")]
	public class BattleBonusesAdBonusWindow : BaseDialogWindow<BattleBonusesAdBonusWindow.BattleBonusesAdBonusWindowArgs>
	{
		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x060055C1 RID: 21953 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700116E")]
		public override string WindowId
		{
			[Token(Token = "0x60055C1")]
			[Address(RVA = "0xA361", Offset = "0xA361", VA = "0xA361", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060055C2 RID: 21954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C2")]
		[Address(RVA = "0xA362", Offset = "0xA362", VA = "0xA362", Slot = "28")]
		protected override void HandleContent()
		{
		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C3")]
		[Address(RVA = "0xA363", Offset = "0xA363", VA = "0xA363")]
		public BattleBonusesAdBonusWindow()
		{
		}

		// Token: 0x04002E74 RID: 11892
		[Token(Token = "0x4002E74")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Ad/BattleBonusesAdBonusWindow";

		// Token: 0x04002E75 RID: 11893
		[Token(Token = "0x4002E75")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BattleBonusesBonusRenderer _bonusRendererPrefab;

		// Token: 0x04002E76 RID: 11894
		[Token(Token = "0x4002E76")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Transform _bonusesContainer;

		// Token: 0x02000DBA RID: 3514
		[Token(Token = "0x2000DBA")]
		public class BattleBonusesAdBonusWindowArgs : BaseDialogWindow<BattleBonusesAdBonusWindow.BattleBonusesAdBonusWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x060055C4 RID: 21956 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60055C4")]
			[Address(RVA = "0xA364", Offset = "0xA364", VA = "0xA364")]
			public BattleBonusesAdBonusWindowArgs()
			{
			}

			// Token: 0x04002E77 RID: 11895
			[Token(Token = "0x4002E77")]
			[FieldOffset(Offset = "0x2C")]
			public IEnumerable<MedalData> BonusMedalsData;
		}
	}
}
