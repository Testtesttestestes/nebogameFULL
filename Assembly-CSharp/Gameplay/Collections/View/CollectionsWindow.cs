using System;
using System.Collections.Generic;
using Core.Data;
using Core.Gameplay;
using Gameplay.Collections.Controller;
using Gameplay.Collections.Events;
using Gameplay.Collections.Model;
using Gameplay.Collections.Model.Factories;
using Il2CppDummyDll;
using UI.Filters;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Collections.View
{
	// Token: 0x020009CC RID: 2508
	[Token(Token = "0x20009CC")]
	public class CollectionsWindow : ClosableBaseWindow<CollectionsWindow.CollectionsWindowArgs>
	{
		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06003C11 RID: 15377 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BD8")]
		public override string WindowId
		{
			[Token(Token = "0x6003C11")]
			[Address(RVA = "0x8AE0", Offset = "0x8AE0", VA = "0x8AE0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06003C12 RID: 15378 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BD9")]
		public TabBar TabBarView
		{
			[Token(Token = "0x6003C12")]
			[Address(RVA = "0x8AE1", Offset = "0x8AE1", VA = "0x8AE1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06003C13 RID: 15379 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BDA")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x6003C13")]
			[Address(RVA = "0x8AE2", Offset = "0x8AE2", VA = "0x8AE2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06003C14 RID: 15380 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BDB")]
		public Button FrescoButton
		{
			[Token(Token = "0x6003C14")]
			[Address(RVA = "0x8AE3", Offset = "0x8AE3", VA = "0x8AE3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C15")]
		[Address(RVA = "0x8AE4", Offset = "0x8AE4", VA = "0x8AE4", Slot = "22")]
		protected override void OnShow(CollectionsWindow.CollectionsWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Collections_View_CollectionsWindow__OnShow(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57e9a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CollectionsWindow_CollectionsWindowArgs__OnClose__
		              );
		    DAT_ram_00a57e9a = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_CollectionsWindow_CollectionsWindowArgs__OnClose__
		            );
		  Gameplay_Collections_View_CollectionsWindow__SetupMVC(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C16")]
		[Address(RVA = "0x8AE5", Offset = "0x8AE5", VA = "0x8AE5", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Collections_View_CollectionsWindow__OnClose
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57e9b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__CollectionsViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_View_CollectionsWindow___c__DisplayClass21_0__Init_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_View_CollectionsWindow___c__DisplayClass21_0_TypeInfo);
		    DAT_ram_00a57e9b = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Collections_View_CollectionsWindow___c__DisplayClass21_0_TypeInfo)
		  ;
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  iVar2 = **(int **)(param1 + 0x3c);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x3b8) * 4))
		            (*(int **)(param1 + 0x3c),*(undefined4 *)(iVar2 + 0x3bc));
		  piVar1 = *(int **)(param1 + 0x3c);
		  if ((char)piVar1[0x14] != '\0') {
		    (**(code **)((ulonglong)
		                 *(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + *piVar1 + 0x10) * 4))
		              (piVar1,*(undefined4 *)(param2_00 + 0xc),
		               *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + *piVar1 + 0x14));
		    return;
		  }
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param2_00,
		             Method_Gameplay_Collections_View_CollectionsWindow___c__DisplayClass21_0__Init_b__0__,0
		            );
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x298) * 4))
		            (piVar1,param1_00,*(undefined4 *)(*piVar1 + 0x29c));
		  return;
		}
		*/

		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C17")]
		[Address(RVA = "0x8AE6", Offset = "0x8AE6", VA = "0x8AE6")]
		public void Init(IList<CollectionListElement.CollectionListElementArgs> items)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Collections_View_CollectionsWindow__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 param3;
		  undefined4 param4;
		  undefined4 param5;
		  
		  if (DAT_ram_00a57e9c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_CollectionsWindow_CollectionsWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_Factories_CollectionDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Controller_CollectionsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Events_CollectionsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Model_CollectionsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Controller_CollectionsViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57e9c = '\x01';
		  }
		  if (*(char *)(param1 + 0x60) == '\0') {
		    iVar2 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_CollectionsWindow_CollectionsWindowArgs__get_WindowArgs__
		                        );
		    iVar6 = *(int *)(iVar2 + 0x18);
		    iVar2 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_CollectionsWindow_CollectionsWindowArgs__get_WindowArgs__
		                        );
		    if (iVar6 == 0) {
		      piVar7 = *(int **)(iVar2 + 0x24);
		      iVar2 = *piVar7;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		            goto code_r0x80e73b63;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e73b63:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		      uVar5 = unnamed_function_1417
		                        (Gameplay_Collections_Model_Factories_CollectionDataFactory_TypeInfo);
		      Gameplay_Collections_Model_Factories_CollectionDataFactory__Dispose(uVar5,uVar4,param1);
		      *(undefined4 *)(param1 + 0x4c) = uVar5;
		      iVar2 = func_ii_8093(param1,
		                           Method_UI_Windows_BaseWindow_CollectionsWindow_CollectionsWindowArgs__get_WindowArgs__
		                          );
		      param3 = *(undefined4 *)(iVar2 + 0x1c);
		      iVar2 = func_ii_8093(param1,
		                           Method_UI_Windows_BaseWindow_CollectionsWindow_CollectionsWindowArgs__get_WindowArgs__
		                          );
		      param4 = *(undefined4 *)(iVar2 + 0x20);
		      iVar2 = func_ii_8093(param1,
		                           Method_UI_Windows_BaseWindow_CollectionsWindow_CollectionsWindowArgs__get_WindowArgs__
		                          );
		      param5 = *(undefined4 *)(iVar2 + 0x24);
		      uVar4 = unnamed_function_1417(Gameplay_Collections_Model_CollectionsModel_TypeInfo);
		      Gameplay_Collections_Model_CollectionsModel__Dispose(uVar4,uVar5,param3,param4,param5,param1);
		      *(undefined4 *)(param1 + 0x50) = uVar4;
		      uVar4 = unnamed_function_1417(Gameplay_Collections_Events_CollectionsEvents_TypeInfo);
		      *(undefined4 *)(param1 + 0x54) = uVar4;
		      uVar5 = *(undefined4 *)(param1 + 0x50);
		      iVar2 = unnamed_function_1417(Gameplay_Collections_Controller_CollectionsController_TypeInfo);
		      if (DAT_ram_00a57ed7 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_MVC_AbstractController_CollectionsModel__CollectionsEvents___ctor__);
		        Mono_Security_ASN1__get_Item
		                  (&Method_Core_Net_ServiceFactory_GetService_CollectionsService___);
		        Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		        DAT_ram_00a57ed7 = '\x01';
		      }
		      Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		                (iVar2,uVar5,uVar4,
		                 Method_MVC_AbstractController_CollectionsModel__CollectionsEvents___ctor__);
		      if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		      }
		      uVar4 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                        (Method_Core_Net_ServiceFactory_GetService_CollectionsService___);
		      *(undefined4 *)(iVar2 + 0x18) = uVar4;
		      *(int *)(param1 + 0x58) = iVar2;
		      uVar4 = *(undefined4 *)(param1 + 0x54);
		    }
		    else {
		      piVar7 = *(int **)(iVar2 + 0x18);
		      *(int **)(param1 + 0x58) = piVar7;
		      uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x100) * 4))
		                        (piVar7,*(undefined4 *)(*piVar7 + 0x104));
		      *(undefined4 *)(param1 + 0x50) = uVar4;
		      iVar2 = **(int **)(param1 + 0x58);
		      uVar4 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                        (*(int **)(param1 + 0x58),*(undefined4 *)(iVar2 + 0x114));
		      *(undefined4 *)(param1 + 0x54) = uVar4;
		      iVar2 = *(int *)(param1 + 0x58);
		    }
		    uVar5 = *(undefined4 *)(param1 + 0x50);
		    piVar7 = (int *)unnamed_function_1417
		                              (Gameplay_Collections_Controller_CollectionsViewMediator_TypeInfo);
		    Gameplay_Collections_Controller_CollectionsController__Dispose(piVar7,uVar5,uVar4,iVar2,param1);
		    (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x160) * 4))
		              (piVar7,param1,*(undefined4 *)(*piVar7 + 0x164));
		    *(int **)(param1 + 0x5c) = piVar7;
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x58),0);
		    *(undefined1 *)(param1 + 0x60) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C18")]
		[Address(RVA = "0x8AE7", Offset = "0x8AE7", VA = "0x8AE7")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Collections_View_CollectionsWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 0x60) != '\0') {
		    iVar1 = **(int **)(param1 + 0x5c);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x5c),*(undefined4 *)(iVar1 + 0x134));
		    if (*(char *)(*(int *)(param1 + 0x50) + 0x18) == '\0') {
		      MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x58),0);
		      iVar1 = **(int **)(param1 + 0x58);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		                (*(int **)(param1 + 0x58),*(undefined4 *)(iVar1 + 0xec));
		      iVar1 = **(int **)(param1 + 0x50);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		                (*(int **)(param1 + 0x50),*(undefined4 *)(iVar1 + 0xec));
		      iVar1 = *(int *)(param1 + 0x4c);
		      if (DAT_ram_00a57eca == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__CollectionRanksDic___Clear__
		                  );
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__MedalDic___Clear__
		                  );
		        DAT_ram_00a57eca = '\x01';
		      }
		      System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                (*(undefined4 *)(iVar1 + 8),
		                 Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__MedalDic___Clear__
		                );
		      System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                (*(undefined4 *)(iVar1 + 0xc),
		                 Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__CollectionRanksDic___Clear__
		                );
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    *(undefined8 *)(param1 + 0x4c) = 0;
		    *(undefined4 *)(param1 + 0x5c) = 0;
		    *(undefined8 *)(param1 + 0x54) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C19")]
		[Address(RVA = "0x8AE8", Offset = "0x8AE8", VA = "0x8AE8")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Collections_View_CollectionsWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57e9d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CollectionsWindow_CollectionsWindowArgs___ctor__
		              );
		    DAT_ram_00a57e9d = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_CollectionsWindow_CollectionsWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C1A")]
		[Address(RVA = "0x8AE9", Offset = "0x8AE9", VA = "0x8AE9")]
		public CollectionsWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Collections_View_CollectionsWindow___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  UI_Windows_BaseWindowArgs__Dispose(param1,0);
		  *(undefined4 *)(param1 + 0x24) = param4;
		  *(undefined4 *)(param1 + 0x20) = param3;
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  return;
		}
		*/

		}

		// Token: 0x04002124 RID: 8484
		[Token(Token = "0x4002124")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Collections/CollectionsWindow";

		// Token: 0x04002125 RID: 8485
		[Token(Token = "0x4002125")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CollectionsOSAView _collectionsOSAView;

		// Token: 0x04002126 RID: 8486
		[Token(Token = "0x4002126")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TabBar _tabBarView;

		// Token: 0x04002127 RID: 8487
		[Token(Token = "0x4002127")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x04002128 RID: 8488
		[Token(Token = "0x4002128")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _frescoButton;

		// Token: 0x04002129 RID: 8489
		[Token(Token = "0x4002129")]
		[FieldOffset(Offset = "0x4C")]
		private CollectionDataFactory _collectionDataFactory;

		// Token: 0x0400212A RID: 8490
		[Token(Token = "0x400212A")]
		[FieldOffset(Offset = "0x50")]
		private CollectionsModel _model;

		// Token: 0x0400212B RID: 8491
		[Token(Token = "0x400212B")]
		[FieldOffset(Offset = "0x54")]
		private CollectionsEvents _events;

		// Token: 0x0400212C RID: 8492
		[Token(Token = "0x400212C")]
		[FieldOffset(Offset = "0x58")]
		private CollectionsController _controller;

		// Token: 0x0400212D RID: 8493
		[Token(Token = "0x400212D")]
		[FieldOffset(Offset = "0x5C")]
		private CollectionsViewMediator _mediator;

		// Token: 0x0400212E RID: 8494
		[Token(Token = "0x400212E")]
		[FieldOffset(Offset = "0x60")]
		private bool _mvcSetUp;

		// Token: 0x020009CD RID: 2509
		[Token(Token = "0x20009CD")]
		public class CollectionsWindowArgs : BaseWindowArgs
		{
			// Token: 0x06003C1B RID: 15387 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C1B")]
			[Address(RVA = "0x8AEA", Offset = "0x8AEA", VA = "0x8AEA")]
			public CollectionsWindowArgs(UserData owner, UserData loggedUser, IGame game)
			{
			}

			// Token: 0x06003C1C RID: 15388 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C1C")]
			[Address(RVA = "0x8AEB", Offset = "0x8AEB", VA = "0x8AEB")]
			public CollectionsWindowArgs(CollectionsController controller)
			{
			}

			// Token: 0x0400212F RID: 8495
			[Token(Token = "0x400212F")]
			[FieldOffset(Offset = "0x18")]
			public readonly CollectionsController Controller;

			// Token: 0x04002130 RID: 8496
			[Token(Token = "0x4002130")]
			[FieldOffset(Offset = "0x1C")]
			public readonly UserData Owner;

			// Token: 0x04002131 RID: 8497
			[Token(Token = "0x4002131")]
			[FieldOffset(Offset = "0x20")]
			public readonly UserData LoggedUser;

			// Token: 0x04002132 RID: 8498
			[Token(Token = "0x4002132")]
			[FieldOffset(Offset = "0x24")]
			public readonly IGame Game;

			// Token: 0x04002133 RID: 8499
			[Token(Token = "0x4002133")]
			[FieldOffset(Offset = "0x28")]
			public Predicate<CollectionData> CustomFilter;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_FrescoButton ---
		void Gameplay_Collections_View_CollectionsWindow__get_FrescoButton
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57e99 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CollectionsWindow_CollectionsWindowArgs__OnShow__
		              );
		    DAT_ram_00a57e99 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_CollectionsWindow_CollectionsWindowArgs__OnShow__
		              );
		  Gameplay_Collections_View_CollectionsWindow__Init(param1,param1);
		  return;
		}
		*/

}
