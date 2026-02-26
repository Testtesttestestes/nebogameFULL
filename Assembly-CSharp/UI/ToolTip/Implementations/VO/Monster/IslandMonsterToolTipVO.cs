using System;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;

namespace UI.ToolTip.Implementations.VO.Monster
{
	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	public class IslandMonsterToolTipVO : AbstractMonsterToolTipVO
	{
		// Token: 0x06000A06 RID: 2566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x5D62", Offset = "0x5D62", VA = "0x5D62")]
		public IslandMonsterToolTipVO(IDictProvider dictProvider, UserData loggedUser, MonsterData monster)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		UI_ToolTip_Implementations_VO_Monster_IslandMonsterToolTipVO___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl(*(undefined4 *)(param1 + 8),0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x5D63", Offset = "0x5D63", VA = "0x5D63", Slot = "4")]
		public override uint GetLevel()
		{
		/* --- GHIDRA: GetLevel ---
		undefined4
		UI_ToolTip_Implementations_VO_Monster_IslandMonsterToolTipVO__GetLevel(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59991 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a59991 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x8109b6fe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8109b6fe:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar4 = Core_Extensions_Dict_DictExt__GetDismantleInfoDic
		                    (uVar3,*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 8) + 0xc),&local_4,0);
		  if (iVar4 == 0) {
		    uVar3 = AssetContent_GameAssetViewRawImage__set_AssetId
		                      (*(undefined4 *)(*(int *)(param1 + 8) + 8),0);
		  }
		  else {
		    uVar3 = Core_Extensions_Dict_GameEventExt__GetEntryPointIconAssetId(local_4,0);
		  }
		  return uVar3;
		}
		*/

			return 0U;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x5D64", Offset = "0x5D64", VA = "0x5D64", Slot = "5")]
		public override string GetTitle()
		{
		/* --- GHIDRA: GetTitle ---
		undefined4
		UI_ToolTip_Implementations_VO_Monster_IslandMonsterToolTipVO__GetTitle(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59992 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a59992 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x8109b7f8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8109b7f8:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar4 = Core_Extensions_Dict_DictExt__GetDismantleInfoDic
		                    (uVar3,*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 8) + 0xc),&local_4,0);
		  if (iVar4 == 0) {
		    uVar3 = Core_Data_MonsterData__get_Title(*(undefined4 *)(param1 + 8),0);
		  }
		  else {
		    uVar3 = Core_Extensions_Dict_HordeDicExt__GetTitle(local_4,0);
		  }
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x5D65", Offset = "0x5D65", VA = "0x5D65", Slot = "6")]
		public override string GetDescription()
		{
		/* --- GHIDRA: GetDescription ---
		undefined4
		UI_ToolTip_Implementations_VO_Monster_IslandMonsterToolTipVO__GetDescription
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Data_MonsterData__GetDifficulty
		                    (*(undefined4 *)(param1 + 8),*(undefined4 *)(param1 + 0xc),0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x5D66", Offset = "0x5D66", VA = "0x5D66", Slot = "7")]
		public override string GetDifficultyLocaleKey()
		{
		/* --- GHIDRA: GetDifficultyLocaleKey ---
		void UI_ToolTip_Implementations_VO_Monster_IslandMonsterToolTipVO__GetDifficultyLocaleKey
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a59993 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IToolTipSource__TypeInfo);
		    DAT_ram_00a59993 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IToolTipSource__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IToolTipSource__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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

			return null;
		}
	}
}
