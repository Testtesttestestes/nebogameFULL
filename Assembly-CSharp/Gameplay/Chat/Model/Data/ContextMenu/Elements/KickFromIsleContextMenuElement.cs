using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;
using UI.Windows;

namespace Gameplay.Chat.Model.Data.ContextMenu.Elements
{
	// Token: 0x02000B20 RID: 2848
	[Token(Token = "0x2000B20")]
	public class KickFromIsleContextMenuElement : AbstractUserContextMenuElement
	{
		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x060044D1 RID: 17617 RVA: 0x0000CF90 File Offset: 0x0000B190
		[Token(Token = "0x17000DA8")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60044D1")]
			[Address(RVA = "0x9377", Offset = "0x9377", VA = "0x9377", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044D2")]
		[Address(RVA = "0x9378", Offset = "0x9378", VA = "0x9378", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		/* --- GHIDRA: Handle ---
		uint Gameplay_Chat_Model_Data_ContextMenu_Elements_KickFromIsleContextMenuElement__Handle
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  int *param1_00;
		  uint *puVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  longlong lVar6;
		  longlong lVar7;
		  int iVar8;
		  int iVar9;
		  uint uVar10;
		  undefined4 local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a57b66 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_UserContextMenu_IUserMenuContext_TypeInfo);
		    DAT_ram_00a57b66 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = (int *)func_ii_1082(param2,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		  if (param1_00 != (int *)0x0) {
		    iVar8 = *param1_00;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		          goto code_r0x80e28f5b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,4);
		code_r0x80e28f5b:
		    uVar2 = CONCAT44(in_register_20000014,puVar3[1]);
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2);
		    uVar2 = CONCAT44((int)((ulonglong)uVar2 >> 0x20),*(undefined4 *)(*piVar4 + 0x104));
		    iVar8 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))(piVar4,uVar2);
		    if (*(int *)(iVar8 + 0x30) == 0) {
		      uVar1 = 0;
		    }
		    else {
		      uVar10 = 0;
		      uVar1 = 0;
		      lVar7 = *(longlong *)(*(int *)(*(int *)(*(int *)(iVar8 + 0x30) + 0x14) + 0xc) + 0x10);
		      uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		      lVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar8 + 8),0);
		      if (lVar7 == lVar6) {
		        iVar9 = *param1_00;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		                *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		              puVar3 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80e29017;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		        }
		        puVar3 = (uint *)func_ii_1080(param1_00,
		                                      Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo
		                                      ,0);
		code_r0x80e29017:
		        uVar2 = CONCAT44(uVar5,puVar3[1]);
		        iVar9 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2);
		        uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		        if (iVar9 == *(int *)(iVar8 + 0x2c)) {
		          uVar1 = 0;
		        }
		        else {
		          uVar1 = 0;
		          iVar9 = *param2;
		          if (*(ushort *)(iVar9 + 0xb6) != 0) {
		            do {
		              if (UI_UserContextMenu_IUserMenuContext_TypeInfo ==
		                  *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		                puVar3 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                 0xc0);
		                goto code_r0x80e290a0;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		          }
		          puVar3 = (uint *)func_ii_1080(param2,UI_UserContextMenu_IUserMenuContext_TypeInfo,0);
		code_r0x80e290a0:
		          uVar1 = 0;
		          uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param2,CONCAT44(uVar5,puVar3[1]));
		          lVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar5,0);
		          if (DAT_ram_00a57b3e == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&
		                       Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__
		                      );
		            DAT_ram_00a57b3e = '\x01';
		          }
		          if (lVar6 != 0) {
		            uVar1 = func_ii_7090(*(undefined4 *)(iVar8 + 0x3c),lVar6,&local_4,
		                                 Method_System_Collections_Generic_Dictionary_ulong__ChatVisitorData__TryGetValue__
		                                );
		          }
		        }
		      }
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		[Token(Token = "0x60044D3")]
		[Address(RVA = "0x9379", Offset = "0x9379", VA = "0x9379", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
		/* --- GHIDRA: Validate ---
		undefined4
		Gameplay_Chat_Model_Data_ContextMenu_Elements_KickFromIsleContextMenuElement__Validate
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  undefined4 uVar6;
		  undefined4 param3_00;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  int iVar10;
		  int param1_01;
		  int iVar11;
		  
		  if (DAT_ram_00a57b67 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Chat_Model_Data_ContextMenu_Elements_KickFromIsleContextMenuElement___c__DisplayClass4_0__ShowKickConfirmationWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Chat_Model_Data_ContextMenu_Elements_KickFromIsleContextMenuElement___c__DisplayClass4_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_4107);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26152);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24975);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26104);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4177);
		    DAT_ram_00a57b67 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Chat_Model_Data_ContextMenu_Elements_KickFromIsleContextMenuElement___c__DisplayClass4_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar2 + 8) = param2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x178);
		        goto code_r0x80e28b3e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e28b3e:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,CONCAT44(in_register_20000014,puVar3[1]));
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar4 = Core_Extensions_Dict_DictExt__GetBoolParameter(uVar4,StringLiteral_24975,0);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar4 = Core_Money_Money__op_Explicit(uVar4,0);
		  iVar10 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(iVar10,0);
		  *(undefined4 *)(iVar10 + 0x18) = *(undefined4 *)(param1 + 8);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4177,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  uVar6 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                    (*(undefined4 *)(iVar2 + 8),0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_26104,uVar6,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar6 = 0x7ff80000;
		  param3_00 = Core_Extensions_Dict_ResourceSetExt__ToNullableResourceSet
		                        (uVar4,NAN,0,StringLiteral_2556,0,0,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_26152,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar5 = Core_GameLocalization__GetTranslation(uVar5,param1_00,0);
		  *(undefined4 *)(iVar10 + 0x1c) = uVar5;
		  param1_01 = *(int *)(iVar10 + 0x24);
		  iVar7 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar7,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(iVar7 + 8) = *(undefined4 *)(param1 + 8);
		  iVar8 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  *(undefined4 *)(iVar8 + 8) = uVar4;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar11 = *piVar9;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0x140);
		        goto code_r0x80e28d3b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e28d3b:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar9,CONCAT44(uVar6,puVar3[1]));
		  uVar4 = func_ii_7112(uVar4,0);
		  *(undefined4 *)(iVar8 + 0xc) = uVar4;
		  *(int *)(iVar7 + 0x10) = iVar8;
		  iVar8 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar4,iVar2,
		             Method_Gameplay_Chat_Model_Data_ContextMenu_Elements_KickFromIsleContextMenuElement___c__DisplayClass4_0__ShowKickConfirmationWindow_b__0__
		             ,0);
		  *(undefined4 *)(iVar8 + 8) = uVar4;
		  *(int *)(iVar7 + 0x14) = iVar8;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar1 = *(uint *)(param1_01 + 0xc);
		  if (uVar1 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar1 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar1 * 4 + 0x10) = iVar7;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar7,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar8 = *(int *)(iVar10 + 0x24);
		  iVar7 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar7,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4107,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar7 + 8) = uVar4;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		  uVar1 = *(uint *)(iVar8 + 0xc);
		  if (uVar1 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		    *(uint *)(iVar8 + 0xc) = uVar1 + 1;
		    *(int *)(*(int *)(iVar8 + 8) + uVar1 * 4 + 0x10) = iVar7;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar8,iVar7,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar4 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (iVar10,0);
		  return uVar4;
		}
		*/

			return default(bool);
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60044D4")]
		[Address(RVA = "0x937A", Offset = "0x937A", VA = "0x937A")]
		private DialogWindow ShowKickConfirmationWindow(UserData user)
		{
			return null;
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044D5")]
		[Address(RVA = "0x937B", Offset = "0x937B", VA = "0x937B")]
		public KickFromIsleContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		void Gameplay_Chat_Model_Data_ContextMenu_Elements_KickFromIsleContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *param3_00;
		  undefined4 param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a57b65 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_UserContextMenu_IUserMenuContext_TypeInfo);
		    DAT_ram_00a57b65 = '\x01';
		  }
		  iVar2 = *param2;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (UI_UserContextMenu_IUserMenuContext_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param3_00 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e289a3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param3_00 = (uint *)func_ii_1080(param2,UI_UserContextMenu_IUserMenuContext_TypeInfo,0);
		code_r0x80e289a3:
		  param2_00 = (**(code **)((ulonglong)*param3_00 * 4))(param2,param3_00[1]);
		  Gameplay_Chat_Model_Data_ContextMenu_Elements_KickFromIsleContextMenuElement__Validate
		            (param1,param2_00,param3_00);
		  return;
		}
		*/

}
