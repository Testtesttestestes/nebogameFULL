using System;
using System.Runtime.CompilerServices;
using Gameplay.Aprs.Controller;
using Gameplay.Aprs.Events;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UI.Filters;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D55 RID: 3413
	[Token(Token = "0x2000D55")]
	public class AprsWindow : ClosableBaseWindow<AprsWindowArgs>
	{
		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x060053B3 RID: 21427 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001100")]
		public override string WindowId
		{
			[Token(Token = "0x60053B3")]
			[Address(RVA = "0xA172", Offset = "0xA172", VA = "0xA172", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x060053B4 RID: 21428 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001101")]
		public AprsOsaGridView AprsOsaGridView
		{
			[Token(Token = "0x60053B4")]
			[Address(RVA = "0xA173", Offset = "0xA173", VA = "0xA173")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001FF RID: 511
		// (add) Token: 0x060053B5 RID: 21429 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060053B6 RID: 21430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001FF")]
		public event Action<AprData> AprClickEvent
		{
			[Token(Token = "0x60053B5")]
			[Address(RVA = "0xA174", Offset = "0xA174", VA = "0xA174")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60053B6")]
			[Address(RVA = "0xA175", Offset = "0xA175", VA = "0xA175")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x060053B7 RID: 21431 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001102")]
		public TabBar TabBarView
		{
			[Token(Token = "0x60053B7")]
			[Address(RVA = "0xA176", Offset = "0xA176", VA = "0xA176")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x060053B8 RID: 21432 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001103")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x60053B8")]
			[Address(RVA = "0xA177", Offset = "0xA177", VA = "0xA177")]
			get
			{
				return null;
			}
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B9")]
		[Address(RVA = "0xA178", Offset = "0xA178", VA = "0xA178", Slot = "24")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Aprs_View_AprsWindow__Awake(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x48);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x130) * 4))
		                      (param2,*(undefined4 *)(*param2 + 0x134));
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060053BA RID: 21434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BA")]
		[Address(RVA = "0xA179", Offset = "0xA179", VA = "0xA179")]
		private void AprGridViewOnSelectEvent(AprGridView aprGridView)
		{
		/* --- GHIDRA: AprGridViewOnSelectEvent ---
		void Gameplay_Aprs_View_AprsWindow__AprGridViewOnSelectEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5941b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_ClosableBaseWindow_AprsWindowArgs__OnShow__);
		    DAT_ram_00a5941b = '\x01';
		  }
		  func_ii_7769(param1,param2,Method_UI_Windows_ClosableBaseWindow_AprsWindowArgs__OnShow__);
		  *(undefined4 *)(param1 + 0x60) = param2;
		  Gameplay_Aprs_View_AprsWindow__OnShow(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060053BB RID: 21435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BB")]
		[Address(RVA = "0xA17A", Offset = "0xA17A", VA = "0xA17A", Slot = "22")]
		protected override void OnShow(AprsWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Aprs_View_AprsWindow__OnShow(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  int *param1_00;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a5941c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Controller_AprsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Events_AprsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Model_AprsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Controller_AprsViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5941c = '\x01';
		  }
		  if (*(char *)(param1 + 0x4c) == '\0') {
		    if (*(int *)(*(int *)(param1 + 0x60) + 0x18) == *(int *)(*(int *)(param1 + 0x60) + 0x1c)) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x138);
		            goto code_r0x80fff6c7;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0xf);
		code_r0x80fff6c7:
		      iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		      *(undefined4 *)(param1 + 0x50) = *(undefined4 *)(iVar7 + 0x18);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x138);
		            goto code_r0x80fff779;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0xf);
		code_r0x80fff779:
		      iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		      *(undefined4 *)(param1 + 0x54) = *(undefined4 *)(iVar7 + 0x14);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x138);
		            goto code_r0x80fff82b;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0xf);
		code_r0x80fff82b:
		      iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		      uVar2 = *(undefined4 *)(iVar7 + 0x10);
		    }
		    else {
		      uVar2 = unnamed_function_1417(Gameplay_Aprs_Events_AprsEvents_TypeInfo);
		      *(undefined4 *)(param1 + 0x50) = uVar2;
		      uVar2 = *(undefined4 *)(*(int *)(param1 + 0x60) + 0x1c);
		      uVar5 = *(undefined4 *)(*(int *)(param1 + 0x60) + 0x18);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		            goto code_r0x80fff900;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80fff900:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar7 = *param1_00;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x138);
		            goto code_r0x80fff9ac;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0xf);
		code_r0x80fff9ac:
		      iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		      uVar8 = *(undefined4 *)(iVar7 + 0x24);
		      iVar7 = unnamed_function_1417(Gameplay_Aprs_Model_AprsModel_TypeInfo);
		      Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar7,uVar5,0);
		      *(undefined4 *)(iVar7 + 0x18) = uVar8;
		      *(undefined4 *)(iVar7 + 0x14) = uVar2;
		      *(undefined4 *)(iVar7 + 0xc) = uVar4;
		      *(int **)(iVar7 + 0x10) = piVar6;
		      *(int *)(param1 + 0x54) = iVar7;
		      uVar5 = *(undefined4 *)(param1 + 0x50);
		      uVar2 = unnamed_function_1417(Gameplay_Aprs_Controller_AprsController_TypeInfo);
		      Gameplay_Aprs_Controller_AprsController__Dispose(uVar2,iVar7,uVar5,iVar7);
		    }
		    *(undefined4 *)(param1 + 0x5c) = uVar2;
		    uVar5 = *(undefined4 *)(param1 + 0x54);
		    uVar4 = *(undefined4 *)(param1 + 0x50);
		    piVar6 = (int *)unnamed_function_1417(Gameplay_Aprs_Controller_AprsViewMediator_TypeInfo);
		    Gameplay_Aprs_Controller_AprsController__ValidateInit(piVar6,uVar5,uVar4,uVar2,piVar6);
		    *(int **)(param1 + 0x58) = piVar6;
		    (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x160) * 4))
		              (piVar6,param1,*(undefined4 *)(*piVar6 + 0x164));
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x5c),0);
		    *(undefined1 *)(param1 + 0x4c) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060053BC RID: 21436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BC")]
		[Address(RVA = "0xA17B", Offset = "0xA17B", VA = "0xA17B")]
		private void SetupMvc()
		{
		/* --- GHIDRA: SetupMvc ---
		void Gameplay_Aprs_View_AprsWindow__SetupMvc(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 0x4c) != '\0') {
		    if (*(int *)(*(int *)(param1 + 0x60) + 0x18) != *(int *)(*(int *)(param1 + 0x60) + 0x1c)) {
		      MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x5c),0);
		      iVar1 = **(int **)(param1 + 0x54);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		                (*(int **)(param1 + 0x54),*(undefined4 *)(iVar1 + 0xec));
		    }
		    *(undefined4 *)(param1 + 0x5c) = 0;
		    *(undefined4 *)(param1 + 0x54) = 0;
		    iVar1 = **(int **)(param1 + 0x58);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x160) * 4))
		              (*(int **)(param1 + 0x58),0,*(undefined4 *)(iVar1 + 0x164));
		    iVar1 = **(int **)(param1 + 0x58);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x140) * 4))
		              (*(int **)(param1 + 0x58),0,*(undefined4 *)(iVar1 + 0x144));
		    *(undefined4 *)(param1 + 0x50) = 0;
		    *(undefined4 *)(param1 + 0x58) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060053BD RID: 21437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BD")]
		[Address(RVA = "0xA17C", Offset = "0xA17C", VA = "0xA17C")]
		private void DestroyMvc()
		{
		/* --- GHIDRA: DestroyMvc ---
		void Gameplay_Aprs_View_AprsWindow__DestroyMvc(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5941d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprGridView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_View_AprsWindow_AprGridViewOnSelectEvent__);
		    DAT_ram_00a5941d = '\x01';
		  }
		  if (*(char *)(param1 + 0x4c) != '\0') {
		    if (*(int *)(*(int *)(param1 + 0x60) + 0x18) != *(int *)(*(int *)(param1 + 0x60) + 0x1c)) {
		      MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x5c),0);
		      iVar1 = **(int **)(param1 + 0x54);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		                (*(int **)(param1 + 0x54),*(undefined4 *)(iVar1 + 0xec));
		    }
		    *(undefined4 *)(param1 + 0x5c) = 0;
		    *(undefined4 *)(param1 + 0x54) = 0;
		    iVar1 = **(int **)(param1 + 0x58);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x160) * 4))
		              (*(int **)(param1 + 0x58),0,*(undefined4 *)(iVar1 + 0x164));
		    iVar1 = **(int **)(param1 + 0x58);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x140) * 4))
		              (*(int **)(param1 + 0x58),0,*(undefined4 *)(iVar1 + 0x144));
		    *(undefined4 *)(param1 + 0x50) = 0;
		    *(undefined4 *)(param1 + 0x58) = 0;
		  }
		  param1_00 = unnamed_function_1417(System_Action_AprGridView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Gameplay_Aprs_View_AprsWindow_AprGridViewOnSelectEvent__,0);
		  Gameplay_Aprs_View_AprGridView__add_SelectEvent(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x060053BE RID: 21438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BE")]
		[Address(RVA = "0xA17D", Offset = "0xA17D", VA = "0xA17D")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Aprs_View_AprsWindow__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5941e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_ClosableBaseWindow_AprsWindowArgs___ctor__);
		    DAT_ram_00a5941e = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_AprsWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060053BF RID: 21439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BF")]
		[Address(RVA = "0xA17E", Offset = "0xA17E", VA = "0xA17E")]
		public AprsWindow()
		{
		}

		// Token: 0x04002D59 RID: 11609
		[Token(Token = "0x4002D59")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Aprs/AprsWindow";

		// Token: 0x04002D5A RID: 11610
		[Token(Token = "0x4002D5A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBarView;

		// Token: 0x04002D5B RID: 11611
		[Token(Token = "0x4002D5B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x04002D5C RID: 11612
		[Token(Token = "0x4002D5C")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private AprsOsaGridView _aprsOsaGridView;

		// Token: 0x04002D5E RID: 11614
		[Token(Token = "0x4002D5E")]
		[FieldOffset(Offset = "0x4C")]
		private bool _isMvcInitialized;

		// Token: 0x04002D5F RID: 11615
		[Token(Token = "0x4002D5F")]
		[FieldOffset(Offset = "0x50")]
		private AprsEvents _events;

		// Token: 0x04002D60 RID: 11616
		[Token(Token = "0x4002D60")]
		[FieldOffset(Offset = "0x54")]
		private AprsModel _model;

		// Token: 0x04002D61 RID: 11617
		[Token(Token = "0x4002D61")]
		[FieldOffset(Offset = "0x58")]
		private AprsViewMediator _mediator;

		// Token: 0x04002D62 RID: 11618
		[Token(Token = "0x4002D62")]
		[FieldOffset(Offset = "0x5C")]
		private AprsController _controller;

		// Token: 0x04002D63 RID: 11619
		[Token(Token = "0x4002D63")]
		[FieldOffset(Offset = "0x60")]
		private AprsWindowArgs _windowArgs;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AprsOsaGridView ---
		void Gameplay_Aprs_View_AprsWindow__get_AprsOsaGridView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a59418 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprData__TypeInfo);
		    DAT_ram_00a59418 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x48);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_AprData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_AprData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x48,iVar2,param1_00);
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


		/* --- GHIDRA: add_AprClickEvent ---
		void Gameplay_Aprs_View_AprsWindow__add_AprClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a59419 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprData__TypeInfo);
		    DAT_ram_00a59419 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x48);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_AprData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_AprData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x48,iVar2,param1_00);
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


		/* --- GHIDRA: get_FiltersView ---
		void Gameplay_Aprs_View_AprsWindow__get_FiltersView(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5941a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprGridView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_View_AprsWindow_AprGridViewOnSelectEvent__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_ClosableBaseWindow_AprsWindowArgs__Awake__);
		    DAT_ram_00a5941a = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object____ctor
		            (param1,Method_UI_Windows_ClosableBaseWindow_AprsWindowArgs__Awake__);
		  param1_00 = unnamed_function_1417(System_Action_AprGridView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Gameplay_Aprs_View_AprsWindow_AprGridViewOnSelectEvent__,0);
		  Gameplay_Aprs_View_AprDiscountView___ctor(param1_00,param1);
		  return;
		}
		*/

}
