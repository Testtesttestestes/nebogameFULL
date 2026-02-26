using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;

namespace UI.Rewards.Renderers
{
	// Token: 0x020001A8 RID: 424
	[Token(Token = "0x20001A8")]
	public class ArtifactsStackableRewardRender : ArtifactRewardRender
	{
		// Token: 0x17000182 RID: 386
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000182")]
		public override RewardData Reward
		{
			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0x5EA7", Offset = "0x5EA7", VA = "0x5EA7", Slot = "7")]
			protected set
			{
			}
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x5EA8", Offset = "0x5EA8", VA = "0x5EA8", Slot = "10")]
		protected override ArtikulData CreateArtikul(int index, uint artikulId)
		{
		/* --- GHIDRA: CreateArtikul ---
		void UI_Rewards_Renderers_ArtifactsStackableRewardRender__CreateArtikul
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59a2c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_long___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_long__TypeInfo);
		    DAT_ram_00a59a2c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_long__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_long___ctor__);
		  *(undefined4 *)(param1 + 0x4c) = param1_00;
		  UI_Rewards_Renderers_ArtifactRewardRender__Dispose(param1,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x5EA9", Offset = "0x5EA9", VA = "0x5EA9")]
		public ArtifactsStackableRewardRender()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_Renderers_ArtifactsStackableRewardRender___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a59a2d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_GameRawImageRender___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59a2d = '\x01';
		  }
		  piVar5 = (int *)param1[5];
		  iVar6 = param1[4];
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar7 = *piVar5;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0xe8) * 4))
		                    (piVar5,iVar6,uVar2,*(undefined4 *)(iVar7 + 0xec));
		  iVar6 = func_ii_5677(uVar2,Method_UnityEngine_Component_GetComponent_GameRawImageRender___);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar5;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x810ae669;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x810ae669:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  uVar4 = func_ii_8038(uVar4,0);
		  iVar7 = Core_Extensions_Dict_DictExt__GetRatingKindDic(uVar2,uVar4,0);
		  if (iVar7 != 0) {
		    uVar2 = Core_Extensions_Dict_ResourcesExt__GetTextSpriteName(iVar7,0);
		    iVar7 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar6 + 0x2c),uVar2,0);
		    if (iVar7 == 0) {
		      *(undefined4 *)(iVar6 + 0x2c) = uVar2;
		      Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(iVar6 + 0x28),uVar2,0)
		      ;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0x4C")]
		private List<long> _artifactCountsByIndex;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Reward ---
		int UI_Rewards_Renderers_ArtifactsStackableRewardRender__set_Reward
		              (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined8 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a59a2b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_long__get_Item__);
		    DAT_ram_00a59a2b = '\x01';
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
		        goto code_r0x810ae4de;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x810ae4de:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar4 = Core_Data_ArtikulDataCustom__SetCurrentDurability(param3,param2_00,0);
		  uVar3 = System_Collections_Generic_List_ulong___get_Count
		                    (*(undefined4 *)(param1 + 0x4c),param2,
		                     Method_System_Collections_Generic_List_long__get_Item__);
		  *(int *)(iVar4 + 0x38) = (int)uVar3;
		  return iVar4;
		}
		*/

}
