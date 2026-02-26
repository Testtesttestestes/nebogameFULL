using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D0 RID: 4560
	[Token(Token = "0x20011D0")]
	public class CaveBuilding : AbstractPathNode
	{
		// Token: 0x06006C99 RID: 27801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C99")]
		[Address(RVA = "0xB785", Offset = "0xB785", VA = "0xB785", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		/* --- GHIDRA: ExecuteTransition ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_CaveBuilding__ExecuteTransition
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a70d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a70d = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x8125f9bb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125f9bb:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Gameplay_Isles_Base_Model_BaseIsleModel__GetBuildingLevel
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x14) + 0x20) + 0x10),5,&local_4,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x00014070 File Offset: 0x00012270
		[Token(Token = "0x6006C9A")]
		[Address(RVA = "0xB786", Offset = "0xB786", VA = "0xB786", Slot = "4")]
		public override bool Check()
		{
			return default(bool);
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C9B")]
		[Address(RVA = "0xB787", Offset = "0xB787", VA = "0xB787", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C9C")]
		[Address(RVA = "0xB788", Offset = "0xB788", VA = "0xB788")]
		public CaveBuilding()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_CaveBuilding___ctor
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 in_register_20000014;
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  longlong lVar5;
		  undefined8 uVar6;
		  int iVar7;
		  undefined4 param1_00;
		  longlong lVar8;
		  int iVar9;
		  int iVar10;
		  uint uVar11;
		  
		  if (DAT_ram_00a5a70e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_ClanHome_MovCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13095);
		    DAT_ram_00a5a70e = '\x01';
		  }
		  iVar9 = *param2;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8 + 4) * 8 + iVar9 + 0x140);
		        goto code_r0x8125fab0;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar11);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8125fab0:
		  uVar6 = CONCAT44(in_register_20000014,puVar1[1]);
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param2,uVar6);
		  uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar9 = func_ii_7112(uVar2,0);
		  if (*(int *)(iVar9 + 0x68) == 0) {
		    iVar9 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		    UI_Windows_Alert__Show(iVar9,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = func_ii_7508(StringLiteral_13095,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar9 + 0x1c) = uVar3;
		    UI_Windows_UnityInstantiator___ctor(iVar9,0);
		    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_ClanHome__TransitionCanceled
		              (param1,iVar9);
		    return;
		  }
		  iVar9 = *param2;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8 + 4) * 8 + iVar9 + 0x140);
		        goto code_r0x8125fb92;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar11);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8125fb92:
		  uVar11 = 0;
		  uVar6 = CONCAT44(uVar3,puVar1[1]);
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param2,uVar6);
		  uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar9 = func_ii_7112(uVar2,0);
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8 + 4) * 8 + iVar10 + 0x110);
		        goto code_r0x8125fc20;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125fc20:
		  uVar6 = CONCAT44(uVar3,puVar1[1]);
		  iVar10 = (**(code **)((ulonglong)*puVar1 * 4))(param2,uVar6);
		  uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar10 = *(int *)(*(int *)(iVar10 + 0x14) + 0x28);
		  if ((iVar10 != 0) &&
		     (lVar8 = *(longlong *)(iVar10 + 0x18),
		     lVar5 = Gameplay_World_Model_ClanData__set_ClanCultDic(*(undefined4 *)(iVar9 + 0x68),0),
		     lVar8 == lVar5)) {
		    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_ClanHome__TransitionCanceled
		              (param1,iVar10);
		    return;
		  }
		  *(undefined4 *)(param1 + 0x18) = param4;
		  uVar11 = 0;
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8 + 4) * 8 + iVar10 + 0x110);
		        goto code_r0x8125fcc1;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125fcc1:
		  uVar6 = CONCAT44(uVar3,puVar1[1]);
		  iVar10 = (**(code **)((ulonglong)*puVar1 * 4))(param2,uVar6);
		  uVar2 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar7 = *(int *)(iVar10 + 8);
		  param1_00 = *(undefined4 *)(iVar7 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_ClanHome_MovCompleteEvent__
		             ,0);
		  iVar10 = UnityEngine_UI_Image__set_sprite(param1_00,uVar3,0);
		  uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar10 == 0) {
		    *(undefined4 *)(iVar7 + 0xc) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar10,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar10,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0xc) = iVar4;
		    uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar7 = func_ii_1082(iVar10,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar10,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar11 = 0;
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8 + 4) * 8 + iVar10 + 0x110);
		        goto code_r0x8125fdad;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125fdad:
		  uVar3 = (**(code **)((ulonglong)*puVar1 * 4))(param2,CONCAT44(uVar2,puVar1[1]));
		  uVar6 = Gameplay_World_Model_ClanData__set_ClanCultDic(*(undefined4 *)(iVar9 + 0x68),0);
		  Core_Gameplay_Managers_WorldManager__GoToUserIsleById(uVar3,uVar6,0);
		  return;
		}
		*/

		}
	}
}
