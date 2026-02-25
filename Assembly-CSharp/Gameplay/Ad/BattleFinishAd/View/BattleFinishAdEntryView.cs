using System;
using System.Collections;
using Core.Gameplay;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Ad.BattleFinishAd.View
{
	// Token: 0x02000DB2 RID: 3506
	[Token(Token = "0x2000DB2")]
	public class BattleFinishAdEntryView : MonoBehaviour
	{
		// Token: 0x060055A5 RID: 21925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055A5")]
		[Address(RVA = "0xA345", Offset = "0xA345", VA = "0xA345")]
		public void Init(GameOverData gameOverData)
		{
		}

		// Token: 0x060055A6 RID: 21926 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60055A6")]
		[Address(RVA = "0xA346", Offset = "0xA346", VA = "0xA346")]
		private IEnumerator HandleAdAvailability(BattleFinishAdPlacementManager placementManager, GameOverData gameOverData, IGame game)
		{
			return null;
		}

		// Token: 0x060055A7 RID: 21927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055A7")]
		[Address(RVA = "0xA347", Offset = "0xA347", VA = "0xA347")]
		public BattleFinishAdEntryView()
		{
		}

		// Token: 0x04002E5F RID: 11871
		[Token(Token = "0x4002E5F")]
		public const string PREFAB_PATH = "Prefabs/UI/Ad/BattleFinishAdView";

		// Token: 0x04002E60 RID: 11872
		[Token(Token = "0x4002E60")]
		[FieldOffset(Offset = "0x10")]
		private bool _adAvailable;
	}
}
