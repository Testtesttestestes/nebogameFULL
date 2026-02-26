using System;
using AssetContent;
using Core.Data;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.Price;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004A4 RID: 1188
	[Token(Token = "0x20004A4")]
	public class TournamentBank : MonoBehaviour
	{
		// Token: 0x06001C11 RID: 7185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C11")]
		[Address(RVA = "0x6D90", Offset = "0x6D90", VA = "0x6D90")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Tournaments_View_TournamentBank__Start
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a584ec == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a584ec = '\x01';
		  }
		  UI_Price_Price__SetColor(*(undefined4 *)(param1 + 0x14),0,param3,0);
		  UI_Price_Price__SetColor(*(undefined4 *)(param1 + 0x18),0,param4,0);
		  UI_Rewards_AbstractRewardsRender__get_Rewards(*(undefined4 *)(param1 + 0x10),param2,0);
		  iVar4 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xf0) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar4 + 0xf4));
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80efb10b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80efb10b:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__GetValue(uVar3,param5,0);
		  uVar3 = Core_Extensions_Dict_NullableResourceSetExt__GetResourcesesIds(uVar3,0);
		  AssetContent_GameImage__get_AssetId(param1_00,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C12")]
		[Address(RVA = "0x6D91", Offset = "0x6D91", VA = "0x6D91")]
		public void RenderRewards(RewardData[] rewards, Money gladiatorsResources, Money viewersResources, Protocol.Consts.Resources betResource)
		{
		/* --- GHIDRA: RenderRewards ---
		void Gameplay_Tournaments_View_TournamentBank__RenderRewards
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Price_Price__SetColor(*(undefined4 *)(param1 + 0x14),0,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C13")]
		[Address(RVA = "0x6D92", Offset = "0x6D92", VA = "0x6D92")]
		public void ChangeGladiatorsBank(Money resources)
		{
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C14")]
		[Address(RVA = "0x6D93", Offset = "0x6D93", VA = "0x6D93")]
		public TournamentBank()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tournaments_View_TournamentBank___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a584ed == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserInfo__TypeInfo);
		    DAT_ram_00a584ed = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_UserInfo__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_UserInfo__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04000F2A RID: 3882
		[Token(Token = "0x4000F2A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RewardsRender _gladiatorsRewards;

		// Token: 0x04000F2B RID: 3883
		[Token(Token = "0x4000F2B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Price _gladiatorsBank;

		// Token: 0x04000F2C RID: 3884
		[Token(Token = "0x4000F2C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Price _viewersBank;

		// Token: 0x04000F2D RID: 3885
		[Token(Token = "0x4000F2D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameImage _resourceImage;
	}
}
