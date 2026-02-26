using System;
using Gameplay.Inventory.View.Chest;
using Gameplay.Medals.Controller;
using Gameplay.Medals.Events;
using Gameplay.Medals.Model;
using Il2CppDummyDll;
using UI.Filters;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Medals.View
{
	// Token: 0x020005FB RID: 1531
	[Token(Token = "0x20005FB")]
	public class MedalsWindow : ClosableBaseWindow<MedalsWindowArgs>
	{
		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006F8")]
		public override string WindowId
		{
			[Token(Token = "0x600252C")]
			[Address(RVA = "0x7675", Offset = "0x7675", VA = "0x7675", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006F9")]
		public TabBar TabBarView
		{
			[Token(Token = "0x600252D")]
			[Address(RVA = "0x7676", Offset = "0x7676", VA = "0x7676")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006FA")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x600252E")]
			[Address(RVA = "0x7677", Offset = "0x7677", VA = "0x7677")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006FB")]
		public MedalsGridView MedalsGridView
		{
			[Token(Token = "0x600252F")]
			[Address(RVA = "0x7678", Offset = "0x7678", VA = "0x7678")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002530")]
		[Address(RVA = "0x7679", Offset = "0x7679", VA = "0x7679", Slot = "22")]
		protected override void OnShow(MedalsWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Medals_View_MedalsWindow__OnShow(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a57d98 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_MedalsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Events_MedalsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_MedalsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Controller_MedalsViewMediator_TypeInfo);
		    DAT_ram_00a57d98 = '\x01';
		  }
		  if (*(char *)(param1 + 0x48) == '\0') {
		    if (*(int *)(*(int *)(param1 + 0x5c) + 0x18) == *(int *)(*(int *)(param1 + 0x5c) + 0x1c)) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x130);
		            goto code_r0x80e59f57;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x80e59f57:
		      iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		      *(undefined4 *)(param1 + 0x4c) = *(undefined4 *)(iVar6 + 0x18);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x130);
		            goto code_r0x80e5a009;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x80e5a009:
		      iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		      *(undefined4 *)(param1 + 0x50) = *(undefined4 *)(iVar6 + 0x14);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x130);
		            goto code_r0x80e5a0bb;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x80e5a0bb:
		      iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		      uVar2 = *(undefined4 *)(iVar6 + 0x10);
		    }
		    else {
		      uVar2 = unnamed_function_1417(Gameplay_Medals_Events_MedalsEvents_TypeInfo);
		      *(undefined4 *)(param1 + 0x4c) = uVar2;
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar2 = *(undefined4 *)(*(int *)(param1 + 0x5c) + 0x1c);
		      uVar4 = *(undefined4 *)(*(int *)(param1 + 0x5c) + 0x18);
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x130);
		            goto code_r0x80e5a190;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x80e5a190:
		      iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		      uVar7 = *(undefined4 *)(iVar6 + 0x1c);
		      iVar6 = unnamed_function_1417(Gameplay_Medals_Model_MedalsModel_TypeInfo);
		      if (DAT_ram_00a57dab == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		        DAT_ram_00a57dab = '\x01';
		      }
		      Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar6,uVar4,0);
		      *(int **)(iVar6 + 0x28) = piVar5;
		      iVar8 = *piVar5;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		            goto code_r0x80e5a250;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e5a250:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		      *(undefined4 *)(iVar6 + 0x14) = uVar7;
		      *(undefined4 *)(iVar6 + 0x10) = uVar2;
		      *(undefined4 *)(iVar6 + 0xc) = uVar4;
		      *(int *)(param1 + 0x50) = iVar6;
		      uVar4 = *(undefined4 *)(param1 + 0x4c);
		      uVar2 = unnamed_function_1417(Gameplay_Medals_Controller_MedalsController_TypeInfo);
		      Gameplay_Medals_Controller_MedalsController__Dispose(uVar2,iVar6,uVar4,uVar4);
		    }
		    *(undefined4 *)(param1 + 0x58) = uVar2;
		    uVar4 = *(undefined4 *)(param1 + 0x50);
		    uVar7 = *(undefined4 *)(param1 + 0x4c);
		    piVar5 = (int *)unnamed_function_1417(Gameplay_Medals_Controller_MedalsViewMediator_TypeInfo);
		    Gameplay_Medals_Controller_MedalsController__HandleBuyMedalService
		              (piVar5,uVar4,uVar7,uVar2,piVar5);
		    *(int **)(param1 + 0x54) = piVar5;
		    (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x160) * 4))
		              (piVar5,param1,*(undefined4 *)(*piVar5 + 0x164));
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x58),0);
		    *(undefined1 *)(param1 + 0x48) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002531")]
		[Address(RVA = "0x767A", Offset = "0x767A", VA = "0x767A")]
		private void SetupMvc()
		{
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002532")]
		[Address(RVA = "0x767B", Offset = "0x767B", VA = "0x767B")]
		private void DestroyMvc()
		{
		/* --- GHIDRA: DestroyMvc ---
		void Gameplay_Medals_View_MedalsWindow__DestroyMvc(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 0x48) != '\0') {
		    if (*(int *)(*(int *)(param1 + 0x5c) + 0x18) != *(int *)(*(int *)(param1 + 0x5c) + 0x1c)) {
		      MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x58),0);
		      iVar1 = **(int **)(param1 + 0x50);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		                (*(int **)(param1 + 0x50),*(undefined4 *)(iVar1 + 0xec));
		    }
		    *(undefined4 *)(param1 + 0x58) = 0;
		    *(undefined4 *)(param1 + 0x50) = 0;
		    iVar1 = **(int **)(param1 + 0x54);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x160) * 4))
		              (*(int **)(param1 + 0x54),0,*(undefined4 *)(iVar1 + 0x164));
		    iVar1 = **(int **)(param1 + 0x54);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x140) * 4))
		              (*(int **)(param1 + 0x54),0,*(undefined4 *)(iVar1 + 0x144));
		    *(undefined4 *)(param1 + 0x4c) = 0;
		    *(undefined4 *)(param1 + 0x54) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002533")]
		[Address(RVA = "0x767C", Offset = "0x767C", VA = "0x767C")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Medals_View_MedalsWindow__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57d99 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_ClosableBaseWindow_MedalsWindowArgs___ctor__);
		    DAT_ram_00a57d99 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_MedalsWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002534")]
		[Address(RVA = "0x767D", Offset = "0x767D", VA = "0x767D")]
		public MedalsWindow()
		{
		}

		// Token: 0x04001454 RID: 5204
		[Token(Token = "0x4001454")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Medals/MedalsWindow";

		// Token: 0x04001455 RID: 5205
		[Token(Token = "0x4001455")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBarView;

		// Token: 0x04001456 RID: 5206
		[Token(Token = "0x4001456")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MedalsGridView _medalsGridView;

		// Token: 0x04001457 RID: 5207
		[Token(Token = "0x4001457")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x04001458 RID: 5208
		[Token(Token = "0x4001458")]
		[FieldOffset(Offset = "0x48")]
		private bool _isMvcInitialized;

		// Token: 0x04001459 RID: 5209
		[Token(Token = "0x4001459")]
		[FieldOffset(Offset = "0x4C")]
		private MedalsEvents _events;

		// Token: 0x0400145A RID: 5210
		[Token(Token = "0x400145A")]
		[FieldOffset(Offset = "0x50")]
		private MedalsModel _model;

		// Token: 0x0400145B RID: 5211
		[Token(Token = "0x400145B")]
		[FieldOffset(Offset = "0x54")]
		private MedalsViewMediator _mediator;

		// Token: 0x0400145C RID: 5212
		[Token(Token = "0x400145C")]
		[FieldOffset(Offset = "0x58")]
		private MedalsController _controller;

		// Token: 0x0400145D RID: 5213
		[Token(Token = "0x400145D")]
		[FieldOffset(Offset = "0x5C")]
		private MedalsWindowArgs _windowArgs;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MedalsGridView ---
		void Gameplay_Medals_View_MedalsWindow__get_MedalsGridView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57d97 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_ClosableBaseWindow_MedalsWindowArgs__OnShow__);
		    DAT_ram_00a57d97 = '\x01';
		  }
		  func_ii_7769(param1,param2,Method_UI_Windows_ClosableBaseWindow_MedalsWindowArgs__OnShow__);
		  *(undefined4 *)(param1 + 0x5c) = param2;
		  Gameplay_Medals_View_MedalsWindow__OnShow(param1,param1);
		  return;
		}
		*/

}
