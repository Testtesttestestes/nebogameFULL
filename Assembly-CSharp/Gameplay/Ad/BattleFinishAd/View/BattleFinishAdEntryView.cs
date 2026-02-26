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
		/* --- GHIDRA: Init ---
		int Gameplay_Ad_BattleFinishAd_View_BattleFinishAdEntryView__Init
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		              undefined4 param5)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58852 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Ad_BattleFinishAd_View_BattleFinishAdEntryView__HandleAdAvailability_d__3_TypeInfo
		              );
		    DAT_ram_00a58852 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Ad_BattleFinishAd_View_BattleFinishAdEntryView__HandleAdAvailability_d__3_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x18) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x1c) = param4;
		  *(undefined4 *)(iVar1 + 0x14) = param3;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

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
