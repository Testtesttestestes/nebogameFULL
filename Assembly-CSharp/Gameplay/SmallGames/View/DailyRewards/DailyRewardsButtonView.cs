using System;
using AssetContent;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.SmallGames.View.DailyRewards
{
	// Token: 0x0200052C RID: 1324
	[Token(Token = "0x200052C")]
	public class DailyRewardsButtonView : MonoBehaviour
	{
		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005BF")]
		public GameAnimatedButton GameAnimatedButton
		{
			[Token(Token = "0x6001F7C")]
			[Address(RVA = "0x70E1", Offset = "0x70E1", VA = "0x70E1")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x00006678 File Offset: 0x00004878
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C0")]
		public bool HasReward
		{
			[Token(Token = "0x6001F7D")]
			[Address(RVA = "0x70E2", Offset = "0x70E2", VA = "0x70E2")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F7E")]
			[Address(RVA = "0x70E3", Offset = "0x70E3", VA = "0x70E3")]
			set
			{
			}
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F7F")]
		[Address(RVA = "0x70E4", Offset = "0x70E4", VA = "0x70E4")]
		private void DetermineAnimation()
		{
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F80")]
		[Address(RVA = "0x70E5", Offset = "0x70E5", VA = "0x70E5")]
		public DailyRewardsButtonView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_SmallGames_View_DailyRewards_DailyRewardsButtonView___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58294 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12665);
		    DAT_ram_00a58294 = '\x01';
		  }
		  return StringLiteral_12665;
		}
		*/

		}

		// Token: 0x04001133 RID: 4403
		[Token(Token = "0x4001133")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject _redLabel;

		// Token: 0x04001134 RID: 4404
		[Token(Token = "0x4001134")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameAnimatedButton _gameAnimatedButton;

		// Token: 0x04001135 RID: 4405
		[Token(Token = "0x4001135")]
		[FieldOffset(Offset = "0x18")]
		private bool _hasReward;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_HasReward ---
		void Gameplay_SmallGames_View_DailyRewards_DailyRewardsButtonView__get_HasReward
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(char *)(param1 + 0x18) = (char)param2;
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x10),param2,0);
		  Gameplay_SmallGames_View_DailyRewards_DailyRewardsButtonView__set_HasReward(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_HasReward ---
		void Gameplay_SmallGames_View_DailyRewards_DailyRewardsButtonView__set_HasReward
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 param1_01;
		  undefined4 *puVar5;
		  
		  if (DAT_ram_00a58293 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10738);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10737);
		    DAT_ram_00a58293 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80ec51c5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ec51c5:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  puVar5 = &StringLiteral_10738;
		  if (*(char *)(param1 + 0x18) == '\0') {
		    puVar5 = &StringLiteral_10737;
		  }
		  uVar3 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar3,*puVar5,0);
		  AssetContent_GameAnimatedButton__get_AssetId(param1_01,uVar3,0);
		  return;
		}
		*/

}
