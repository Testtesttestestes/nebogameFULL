using System;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006CE RID: 1742
	[Token(Token = "0x20006CE")]
	public class DismantleArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x00008010 File Offset: 0x00006210
		[Token(Token = "0x170007F3")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A11")]
			[Address(RVA = "0x7AB4", Offset = "0x7AB4", VA = "0x7AB4", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x00008028 File Offset: 0x00006228
		[Token(Token = "0x6002A12")]
		[Address(RVA = "0x7AB5", Offset = "0x7AB5", VA = "0x7AB5", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_DismantleArtifactContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  int *param1_00;
		  int param1_01;
		  int *piVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a5a19e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_ContextMenu_DismantleArtifactContextMenuElement___c__DisplayClass3_0__Handle_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_ContextMenu_DismantleArtifactContextMenuElement___c__DisplayClass3_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_12639);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9115);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6154);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9116);
		    DAT_ram_00a5a19e = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Inventory_ContextMenu_DismantleArtifactContextMenuElement___c__DisplayClass3_0_TypeInfo
		                    );
		  *(int **)(iVar2 + 0xc) = param2;
		  *(undefined4 *)(iVar2 + 8) = param1;
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd0);
		        goto code_r0x811dc518;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dc518:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  iVar8 = Core_Data_ArtikulData__get_IsDismantleManufactureAssistant(uVar4,0);
		  if (iVar8 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar7;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x140);
		          goto code_r0x811dc5c6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811dc5c6:
		    uVar1 = 0;
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		    uVar4 = func_ii_7112(uVar4,0);
		    piVar7 = (int *)Mono_Security_ASN1Convert__ToOid(Core_Data_ArtifactData___TypeInfo,1);
		    param1_00 = *(int **)(iVar2 + 0xc);
		    iVar8 = *param1_00;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd0);
		          goto code_r0x811dc660;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dc660:
		    iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    if ((iVar8 != 0) && (iVar5 = func_ii_1082(iVar8,*(undefined4 *)(*piVar7 + 0x20)), iVar5 == 0)) {
		      uVar4 = func_ii_1083();
		      func_ii_1050(uVar4,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar7[4] = iVar8;
		    iVar8 = unnamed_function_1417
		                      (
		                      Gameplay_Inventory_View_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs_TypeInfo
		                      );
		    Gameplay_Inventory_View_GeneralArtifactsDialogWindow___ctor(iVar8,uVar4,piVar7,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9116,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar8 + 0x18) = uVar4;
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9115,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar8 + 0x1c) = uVar4;
		    param1_01 = *(int *)(iVar8 + 0x24);
		    iVar5 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs__TypeInfo
		                      );
		    UI_Windows_DialogWindow_DialogWindowArgs___ctor
		              (iVar5,
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs___ctor__
		              );
		    uVar4 = func_ii_7508(StringLiteral_6154,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar5 + 8) = uVar4;
		    iVar6 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs__TypeInfo
		                      );
		    uVar4 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs__TypeInfo
		                      );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		              (uVar4,iVar2,
		               Method_Gameplay_Inventory_ContextMenu_DismantleArtifactContextMenuElement___c__DisplayClass3_0__Handle_b__0__
		               ,0);
		    *(undefined4 *)(iVar6 + 8) = uVar4;
		    *(int *)(iVar5 + 0x14) = iVar6;
		    iVar2 = 
		    Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs___Add__
		    ;
		    *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		    uVar1 = *(uint *)(param1_01 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		      *(uint *)(param1_01 + 0xc) = uVar1 + 1;
		      *(int *)(*(int *)(param1_01 + 8) + uVar1 * 4 + 0x10) = iVar5;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_01,iVar5,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		          goto code_r0x811dc86c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x811dc86c:
		    piVar7 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		    uVar1 = 0;
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe8);
		          goto code_r0x811dc8ee;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Application_IApp_TypeInfo,5);
		code_r0x811dc8ee:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		    UI_Windows_PopupController__set_TopWindow(uVar4,StringLiteral_12639,iVar8,0,0);
		    return;
		  }
		  piVar7 = *(int **)(iVar2 + 0xc);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x811dc982;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dc982:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  Gameplay_Inventory_ContextMenu_DismantleArtifactContextMenuElement__Handle(puVar3,uVar4,puVar3);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A13")]
		[Address(RVA = "0x7AB6", Offset = "0x7AB6", VA = "0x7AB6", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		/* --- GHIDRA: Handle ---
		void Gameplay_Inventory_ContextMenu_DismantleArtifactContextMenuElement__Handle
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a19f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a19f = '\x01';
		  }
		  if (*(int *)(param2 + 0x80) == 2) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x150);
		          goto code_r0x811dca74;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x811dca74:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    Gameplay_ArtifactDrop_Control_ArtifactDropController__EquipArtifact
		              (*(undefined4 *)(iVar4 + 0x10),param2,0,0,0);
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x120);
		        goto code_r0x811dcb2d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811dcb2d:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  Core_Gameplay_Managers_Inventory_InventoryManager__Equip(param1_00,param2,0,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A14")]
		[Address(RVA = "0x7AB7", Offset = "0x7AB7", VA = "0x7AB7")]
		private void Dismantle(ArtifactData artifactData)
		{
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A15")]
		[Address(RVA = "0x7AB8", Offset = "0x7AB8", VA = "0x7AB8")]
		public DismantleArtifactContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Inventory_ContextMenu_DismantleArtifactContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *param1_01;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a5a19d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a19d = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar5 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x811dc2c2;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dc2c2:
		  iVar3 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  iVar2 = Core_Data_ArtifactData__get_Rank(iVar3,0);
		  if (iVar2 == 0) {
		    iVar2 = Core_Data_ArtikulData__get_IsRepairable(iVar3,0);
		    if (iVar2 == 0) {
		      uVar5 = 0;
		    }
		    else {
		      iVar2 = Core_Data_ArtikulData__get_IsDollItem(iVar3,0);
		      if (iVar2 == 0) {
		        iVar2 = Core_Data_ArtifactData__get_IsTemporaryWithCriticalLifetime(iVar3,0);
		        if (iVar2 == 0) {
		          iVar2 = *(int *)(iVar3 + 0x80);
		          iVar3 = *(int *)(iVar3 + 0x70);
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          iVar4 = *param1_01;
		          if (*(ushort *)(iVar4 + 0xb6) != 0) {
		            uVar5 = 0;
		            do {
		              if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		                puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 +
		                                 0x140);
		                goto code_r0x811dc3b9;
		              }
		              uVar5 = uVar5 + 1;
		            } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		          }
		          puVar1 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811dc3b9:
		          param1_00 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,puVar1[1]);
		          iVar4 = func_ii_7112(param1_00,0);
		          uVar5 = (uint)(iVar4 == iVar3 && iVar2 - 1U < 2);
		        }
		        else {
		          uVar5 = 0;
		        }
		      }
		      else {
		        uVar5 = 0;
		      }
		    }
		  }
		  else {
		    uVar5 = 0;
		  }
		  return uVar5;
		}
		*/

}
