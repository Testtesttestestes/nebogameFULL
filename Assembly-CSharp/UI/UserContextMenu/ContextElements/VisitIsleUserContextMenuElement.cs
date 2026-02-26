using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace UI.UserContextMenu.ContextElements
{
	// Token: 0x0200012E RID: 302
	[Token(Token = "0x200012E")]
	public class VisitIsleUserContextMenuElement : AbstractUserContextMenuElement
	{
		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x17000133")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x5CB9", Offset = "0x5CB9", VA = "0x5CB9", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x5CBA", Offset = "0x5CBA", VA = "0x5CBA", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
		/* --- GHIDRA: Validate ---
		void UI_UserContextMenu_ContextElements_VisitIsleUserContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  undefined8 uVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a5b8ca == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_UserContextMenu_IUserMenuContext_TypeInfo);
		    DAT_ram_00a5b8ca = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x8138eb21;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8138eb21:
		  uVar1 = 0;
		  uVar4 = CONCAT44(in_register_20000014,puVar2[1]);
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,uVar4);
		  uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (UI_UserContextMenu_IUserMenuContext_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8138eba5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,UI_UserContextMenu_IUserMenuContext_TypeInfo,0);
		code_r0x8138eba5:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,CONCAT44(uVar3,puVar2[1]));
		  uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar3,0);
		  Core_Gameplay_Managers_WorldManager__GoHome(param1_00,uVar4,0);
		  iVar5 = System_Uri___ctor(0);
		  func_ii_8753(*(undefined4 *)(*(int *)(iVar5 + 0x18) + 0x14),0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x5CBB", Offset = "0x5CBB", VA = "0x5CBB", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x5CBC", Offset = "0x5CBC", VA = "0x5CBC")]
		public VisitIsleUserContextMenuElement()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		UI_UserContextMenu_ContextElements_VisitIsleUserContextMenuElement___ctor
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5b8cb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_ResourceColorElement___);
		    Mono_Security_ASN1__get_Item(&System_Func_ResourceColorElement__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_UIController_ResourceBarColorSO___c__DisplayClass1_0__GetColor_b__0__);
		    Mono_Security_ASN1__get_Item(&UI_UIController_ResourceBarColorSO___c__DisplayClass1_0_TypeInfo);
		    DAT_ram_00a5b8cb = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (UI_UIController_ResourceBarColorSO___c__DisplayClass1_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0xc);
		  uVar1 = unnamed_function_1417(System_Func_ResourceColorElement__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_UI_UIController_ResourceBarColorSO___c__DisplayClass1_0__GetColor_b__0__,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_FirstOrDefault_ResourceColorElement___);
		  return uVar1;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint UI_UserContextMenu_ContextElements_VisitIsleUserContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  longlong lVar7;
		  int iVar8;
		  uint uVar9;
		  
		  if (DAT_ram_00a5b8c9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_UserContextMenu_IUserMenuContext_TypeInfo);
		    DAT_ram_00a5b8c9 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar9 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x8138e879;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar9);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8138e879:
		  iVar5 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		  iVar5 = *(int *)(*(int *)(iVar5 + 0x14) + 0x24);
		  if (iVar5 == 0) {
		    return 1;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x8138e932;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8138e932:
		  uVar9 = 0;
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		  iVar6 = func_ii_7112(uVar2,0);
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (UI_UserContextMenu_IUserMenuContext_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		        puVar1 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8138e9ba;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,UI_UserContextMenu_IUserMenuContext_TypeInfo,0);
		code_r0x8138e9ba:
		  iVar8 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  if (iVar8 == iVar6) {
		    return 0;
		  }
		  uVar9 = 0;
		  lVar7 = *(longlong *)(iVar5 + 0x18);
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (UI_UserContextMenu_IUserMenuContext_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8)) {
		        puVar1 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8138ea46;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar9);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,UI_UserContextMenu_IUserMenuContext_TypeInfo,0);
		code_r0x8138ea46:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar2,0);
		  return (uint)(lVar3 != lVar7);
		}
		*/

}
