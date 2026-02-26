using System;
using Core.Net.Monitor.Responseability;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace UI.Informer.Network
{
	// Token: 0x020001D9 RID: 473
	[Token(Token = "0x20001D9")]
	public class LowNetworkResponseAbilityInformerView : MonoBehaviour
	{
		// Token: 0x06000C57 RID: 3159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x5F66", Offset = "0x5F66", VA = "0x5F66")]
		public void SetStatus(ResponseAbilityStatus status)
		{
		/* --- GHIDRA: SetStatus ---
		undefined4
		UI_Informer_Network_LowNetworkResponseAbilityInformerView__SetStatus
		          (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int param1_00;
		  int param1_01;
		  undefined4 uVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a63915 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
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
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_GameObject___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Informer_Network_LowNetworkResponseAbilityInformerView__TryNotifyAboutCriticalStatus_b__3_0__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2572);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2571);
		    DAT_ram_00a63915 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar3,0,0);
		  if (iVar1 == 0) {
		    if (param2 == 2) {
		      iVar1 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		      UI_Windows_Alert__Show(iVar1,param1);
		      *(undefined4 *)(iVar1 + 8) = 2;
		      iVar2 = Mono_Security_ASN1Convert__ToOid(UnityEngine_GameObject___TypeInfo,1);
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x10),0);
		      *(undefined4 *)(iVar2 + 0x10) = uVar3;
		      *(int *)(iVar1 + 0x20) = iVar2;
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar3 = func_ii_7508(StringLiteral_2572,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar1 + 0x18) = uVar3;
		      uVar3 = func_ii_7508(StringLiteral_2571,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar1 + 0x1c) = uVar3;
		      param1_00 = unnamed_function_1417
		                            (
		                            System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                            );
		      GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                (param1_00,
		                 Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		                );
		      param1_01 = unnamed_function_1417
		                            (
		                            UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                            );
		      UI_Windows_DialogWindow_DialogWindowArgs___ctor
		                (param1_01,
		                 Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		                );
		      uVar3 = UI_Windows_DialogWindow__get_NO_LABEL(0);
		      *(undefined4 *)(param1_01 + 8) = uVar3;
		      iVar2 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		      uVar3 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		                (uVar3,param1,
		                 Method_UI_Informer_Network_LowNetworkResponseAbilityInformerView__TryNotifyAboutCriticalStatus_b__3_0__
		                 ,0);
		      *(undefined4 *)(iVar2 + 8) = uVar3;
		      *(int *)(param1_01 + 0x14) = iVar2;
		      iVar2 = 
		      Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		      ;
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar4 = *(uint *)(param1_00 + 0xc);
		      if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		        *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = param1_01;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,param1_01,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		      }
		      *(int *)(iVar1 + 0x24) = param1_00;
		      uVar3 = UI_Windows_UnityInstantiator___ctor(iVar1,param1);
		      *(undefined4 *)(param1 + 0x14) = uVar3;
		      uVar3 = 1;
		    }
		    else {
		      uVar3 = 0;
		    }
		  }
		  else {
		    uVar3 = 1;
		  }
		  return uVar3;
		}
		*/

		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x5F67", Offset = "0x5F67", VA = "0x5F67")]
		private bool TryNotifyAboutCriticalStatus(ResponseAbilityStatus status)
		{
			return default(bool);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x5F68", Offset = "0x5F68", VA = "0x5F68")]
		public LowNetworkResponseAbilityInformerView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Informer_Network_LowNetworkResponseAbilityInformerView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  uint *puVar3;
		  int iVar4;
		  undefined1 auStack_8 [8];
		  
		  if (DAT_ram_00a63916 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGameRestart_TypeInfo);
		    DAT_ram_00a63916 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x14) = 0;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  if (**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c) != 0) {
		    uVar2 = System_Uri___ctor(0);
		    param1_00 = (int *)Core_Application_App__set_Auth(uVar2,0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    uVar2 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGameRestart_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8231b1da;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGameRestart_TypeInfo,0);
		code_r0x8231b1da:
		    (**(code **)((ulonglong)*puVar3 * 4))(auStack_8,param1_00,uVar2,puVar3[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x40005F2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private WarnIconView _warnImage;

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x40005F3")]
		[FieldOffset(Offset = "0x14")]
		private DialogWindow _dialog;
	}
}
