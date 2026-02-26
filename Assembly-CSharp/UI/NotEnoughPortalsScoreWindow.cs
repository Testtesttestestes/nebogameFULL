using System;
using Gameplay.Portals.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	// Token: 0x02000102 RID: 258
	[Token(Token = "0x2000102")]
	public class NotEnoughPortalsScoreWindow : BaseDialogWindow<NotEnoughPortalsScoreWindow.NotEnoughPortalsScoreWindowArgs>
	{
		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700010D")]
		public override string WindowId
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x5C14", Offset = "0x5C14", VA = "0x5C14", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x5C15", Offset = "0x5C15", VA = "0x5C15", Slot = "27")]
		protected override void HandleDescription()
		{
		/* --- GHIDRA: HandleDescription ---
		void UI_NotEnoughPortalsScoreWindow__HandleDescription(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5b882 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_NotEnoughPortalsScoreWindow_Close__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5b882 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x50) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(param1_00,param1,Method_UI_NotEnoughPortalsScoreWindow_Close__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x5C16", Offset = "0x5C16", VA = "0x5C16")]
		private void Start()
		{
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x5C17", Offset = "0x5C17", VA = "0x5C17")]
		private void Close()
		{
		/* --- GHIDRA: Close ---
		void UI_NotEnoughPortalsScoreWindow__Close(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b883 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_NotEnoughPortalsScoreWindow_NotEnoughPortalsScoreWindowArgs__OnDestroy__
		              );
		    DAT_ram_00a5b883 = '\x01';
		  }
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x50) + 0xb4),0);
		  UI_Windows_BaseDialogWindow_object___OnClose
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_NotEnoughPortalsScoreWindow_NotEnoughPortalsScoreWindowArgs__OnDestroy__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x5C18", Offset = "0x5C18", VA = "0x5C18", Slot = "29")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_NotEnoughPortalsScoreWindow__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b884 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_NotEnoughPortalsScoreWindow_NotEnoughPortalsScoreWindowArgs___ctor__
		              );
		    DAT_ram_00a5b884 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_NotEnoughPortalsScoreWindow_NotEnoughPortalsScoreWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x5C19", Offset = "0x5C19", VA = "0x5C19")]
		public NotEnoughPortalsScoreWindow()
		{
		/* --- GHIDRA: .ctor ---
		void UI_NotEnoughPortalsScoreWindow___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b885 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_NotEnoughPortalsScoreWindow_NotEnoughPortalsScoreWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NotEnoughPortalsScoreWindow_NotEnoughPortalsScoreWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NotEnoughPortalsScoreWindow_NotEnoughPortalsScoreWindowArgs___TypeInfo
		              );
		    DAT_ram_00a5b885 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_NotEnoughPortalsScoreWindow_NotEnoughPortalsScoreWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_PaymentBonusesDicExt__GetLocaleKeyForBank
		                    (*(undefined4 *)(param2 + 0x3c),0xc2,0);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = Core_Extensions_Dict_PaymentBonusesDicExt__GetLocaleKeyForBank
		                    (*(undefined4 *)(param2 + 0x3c),0xc1,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NotEnoughPortalsScoreWindow_NotEnoughPortalsScoreWindowArgs___TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_NotEnoughPortalsScoreWindow_NotEnoughPortalsScoreWindowArgs____ctor__
		            );
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _okButton;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Portals/NotEnoughPortalsScoreWindow";

		// Token: 0x02000103 RID: 259
		[Token(Token = "0x2000103")]
		public class NotEnoughPortalsScoreWindowArgs : BaseDialogWindow<NotEnoughPortalsScoreWindow.NotEnoughPortalsScoreWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000870 RID: 2160 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x5C1A", Offset = "0x5C1A", VA = "0x5C1A")]
			public NotEnoughPortalsScoreWindowArgs(PortalsModel portalsModel)
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void UI_NotEnoughPortalsScoreWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5b881 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_NotEnoughPortalsScoreWindow_NotEnoughPortalsScoreWindowArgs__get_DescriptionField__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_NotEnoughPortalsScoreWindow_NotEnoughPortalsScoreWindowArgs__get_WindowArgs__
		              );
		    DAT_ram_00a5b881 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x3c);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_NotEnoughPortalsScoreWindow_NotEnoughPortalsScoreWindowArgs__get_WindowArgs__
		                      );
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,*(undefined4 *)(iVar1 + 0x1c),*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

}
