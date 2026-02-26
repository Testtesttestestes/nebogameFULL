using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Collections.Controller;
using Il2CppDummyDll;
using TMPro;
using UI.Rewards;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Collections.View
{
	// Token: 0x020009C0 RID: 2496
	[Token(Token = "0x20009C0")]
	public class CollectionInfoWindow : ClosableBaseWindow<CollectionInfoWindow.CollectionInfoWindowArgs>
	{
		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06003BCD RID: 15309 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BCD")]
		public override string WindowId
		{
			[Token(Token = "0x6003BCD")]
			[Address(RVA = "0x8AA1", Offset = "0x8AA1", VA = "0x8AA1", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06003BCE RID: 15310 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BCE")]
		public Button UpgradeButton
		{
			[Token(Token = "0x6003BCE")]
			[Address(RVA = "0x8AA2", Offset = "0x8AA2", VA = "0x8AA2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06003BCF RID: 15311 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BCF")]
		public CollectionRequirementsDisplay Requirements
		{
			[Token(Token = "0x6003BCF")]
			[Address(RVA = "0x8AA3", Offset = "0x8AA3", VA = "0x8AA3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06003BD0 RID: 15312 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BD0")]
		public Button NextButton
		{
			[Token(Token = "0x6003BD0")]
			[Address(RVA = "0x8AA4", Offset = "0x8AA4", VA = "0x8AA4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06003BD1 RID: 15313 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BD1")]
		public Button PrevButton
		{
			[Token(Token = "0x6003BD1")]
			[Address(RVA = "0x8AA5", Offset = "0x8AA5", VA = "0x8AA5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06003BD2 RID: 15314 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BD2")]
		public GameObject Content
		{
			[Token(Token = "0x6003BD2")]
			[Address(RVA = "0x8AA6", Offset = "0x8AA6", VA = "0x8AA6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD3")]
		[Address(RVA = "0x8AA7", Offset = "0x8AA7", VA = "0x8AA7", Slot = "22")]
		protected override void OnShow(CollectionInfoWindow.CollectionInfoWindowArgs args)
		{
		/* --- GHIDRA: <UpdateWindow>g__HandleCollectionView|27_2 ---
		void Gameplay_Collections_View_CollectionInfoWindow___UpdateWindow_g__HandleCollectionView_27_2
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  UI_Windows_BaseWindowArgs__Dispose(param1,0);
		  *(undefined4 *)(param1 + 0x24) = param5;
		  *(undefined4 *)(param1 + 0x1c) = param4;
		  *(undefined4 *)(param1 + 0x18) = param3;
		  *(undefined4 *)(param1 + 0x20) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: <UpdateWindow>g__UpdateStatusText|27_1 ---
		void Gameplay_Collections_View_CollectionInfoWindow___UpdateWindow_g__UpdateStatusText_27_1
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a57e71 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_CollectionInfoWindow_CollectionInfoWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a57e71 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x3c);
		  uVar4 = *(undefined4 *)(param2 + 4);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_CollectionInfoWindow_CollectionInfoWindowArgs__get_WindowArgs__
		                      );
		  Gameplay_Collections_View_CollectionView__set_IgnoreAchieved
		            (uVar3,uVar4,*(undefined4 *)(iVar1 + 0x18),*(undefined4 *)(param2 + 8),param2);
		  uVar3 = *(undefined4 *)(param1 + 0x40);
		  iVar1 = Gameplay_Collections_Model_CollectionDicGroup___ctor
		                    (*(undefined4 *)(*(int *)(param2 + 4) + 0x18),*(undefined4 *)(param2 + 8),param2
		                    );
		  uVar4 = *(undefined4 *)(iVar1 + 0x28);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  uVar4 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar4,0);
		  UI_Rewards_AbstractRewardsRender__get_Rewards(uVar3,uVar4,0);
		  iVar1 = **(int **)(param1 + 0x40);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		            (*(int **)(param1 + 0x40),*(undefined4 *)(iVar1 + 0xf4));
		  uVar4 = *(undefined4 *)(param1 + 0x5c);
		  uVar3 = System_Xml_XsdCachingReader__get_Name(*(undefined4 *)(param2 + 4),0);
		  uVar3 = Core_Extensions_Dict_CollectionsDicExt__GetTitle(uVar3,0);
		  uVar2 = func_ii_4769(uVar3,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,uVar2 ^ 1,0);
		  uVar4 = *(undefined4 *)(param1 + 0x44);
		  uVar3 = System_Xml_XsdCachingReader__get_Name(*(undefined4 *)(param2 + 4),0);
		  uVar3 = Core_Extensions_Dict_CollectionsDicExt__GetTitle(uVar3,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar3,0);
		  return;
		}
		*/

		/* --- GHIDRA: <UpdateWindow>g__UpdateButtonText|27_0 ---
		void Gameplay_Collections_View_CollectionInfoWindow___UpdateWindow_g__UpdateButtonText_27_0
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a57e70 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4371);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4375);
		    DAT_ram_00a57e70 = '\x01';
		  }
		  uVar3 = *(int *)(*(int *)(param2 + 4) + 0x1c) + 1;
		  if (*(uint *)(param2 + 8) < uVar3) {
		    uVar2 = *(undefined4 *)(param1 + 0x58);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4375,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		    return;
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x58);
		  if (uVar3 < *(uint *)(param2 + 8)) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4371,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		    return;
		  }
		  UnityEngine_Component__GetComponentInChildren_object_
		            (uVar2,**(undefined4 **)(DAT_ram_00a66978 + 0x5c),0);
		  return;
		}
		*/

		/* --- GHIDRA: OnShow ---
		void Gameplay_Collections_View_CollectionInfoWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57e6c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CollectionInfoWindow_CollectionInfoWindowArgs__OnClose__
		              );
		    DAT_ram_00a57e6c = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_CollectionInfoWindow_CollectionInfoWindowArgs__OnClose__
		            );
		  if (*(char *)(param1 + 0x68) != '\0') {
		    iVar1 = **(int **)(param1 + 100);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 100),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 100) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD4")]
		[Address(RVA = "0x8AA8", Offset = "0x8AA8", VA = "0x8AA8", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Collections_View_CollectionInfoWindow__OnClose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined1 auStack_10 [4];
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  local_c = param1;
		  local_8 = param2;
		  local_4 = param3;
		  Gameplay_Collections_View_CollectionInfoWindow___ctor(param1,&local_c,auStack_10);
		  Gameplay_Collections_View_CollectionInfoWindow___UpdateWindow_g__UpdateStatusText_27_1
		            (param1,&local_c,auStack_10);
		  Gameplay_Collections_View_CollectionInfoWindow___UpdateWindow_g__UpdateButtonText_27_0
		            (param1,&local_c,auStack_10);
		  return;
		}
		*/

		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD5")]
		[Address(RVA = "0x8AA9", Offset = "0x8AA9", VA = "0x8AA9")]
		public void UpdateWindow(CollectionData data, uint rankToShow)
		{
		/* --- GHIDRA: UpdateWindow ---
		void Gameplay_Collections_View_CollectionInfoWindow__UpdateWindow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *param1_00;
		  int *param4;
		  int iVar2;
		  
		  if (DAT_ram_00a57e6d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_CollectionInfoWindow_CollectionInfoWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Controller_CollectionInfoViewMediator_TypeInfo);
		    DAT_ram_00a57e6d = '\x01';
		  }
		  if (*(char *)(param1 + 0x68) == '\0') {
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_CollectionInfoWindow_CollectionInfoWindowArgs__get_WindowArgs__
		                        );
		    param4 = *(int **)(iVar1 + 0x20);
		    param2_00 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x100) * 4))
		                          (param4,*(undefined4 *)(*param4 + 0x104));
		    param3 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x110) * 4))
		                       (param4,*(undefined4 *)(*param4 + 0x114));
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_CollectionInfoWindow_CollectionInfoWindowArgs__get_WindowArgs__
		                        );
		    iVar2 = *(int *)(iVar1 + 0x1c);
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_CollectionInfoWindow_CollectionInfoWindowArgs__get_WindowArgs__
		                        );
		    iVar1 = *(int *)(iVar1 + 0x24);
		    param1_00 = (int *)unnamed_function_1417
		                                 (
		                                 Gameplay_Collections_Controller_CollectionInfoViewMediator_TypeInfo
		                                 );
		    if (DAT_ram_00a57ed0 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionInfoWindow___ctor__
		                );
		      DAT_ram_00a57ed0 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (param1_00,param2_00,param3,param4,
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionInfoWindow___ctor__
		              );
		    param1_00[7] = iVar2;
		    param1_00[8] = iVar1;
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		              (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		    *(undefined1 *)(param1 + 0x68) = 1;
		    *(int **)(param1 + 100) = param1_00;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD6")]
		[Address(RVA = "0x8AAA", Offset = "0x8AAA", VA = "0x8AAA")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Collections_View_CollectionInfoWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 0x68) != '\0') {
		    iVar1 = **(int **)(param1 + 100);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 100),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 100) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD7")]
		[Address(RVA = "0x8AAB", Offset = "0x8AAB", VA = "0x8AAB")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Collections_View_CollectionInfoWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57e6e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CollectionInfoWindow_CollectionInfoWindowArgs___ctor__
		              );
		    DAT_ram_00a57e6e = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_CollectionInfoWindow_CollectionInfoWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD8")]
		[Address(RVA = "0x8AAC", Offset = "0x8AAC", VA = "0x8AAC")]
		public CollectionInfoWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Collections_View_CollectionInfoWindow___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int iVar1;
		  undefined4 *puVar2;
		  
		  if (DAT_ram_00a57e6f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4376);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3702);
		    DAT_ram_00a57e6f = '\x01';
		  }
		  param1_00 = UI_Rewards_AbstractRewardsRender__SetRewards
		                        (*(undefined4 *)(param1 + 0x48),
		                         Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  iVar1 = *(int *)(*(int *)(param2 + 4) + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar2 = &StringLiteral_3702;
		  if (iVar1 == 0) {
		    puVar2 = &StringLiteral_4376;
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar2,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD9")]
		[Address(RVA = "0x8AAD", Offset = "0x8AAD", VA = "0x8AAD")]
		[CompilerGenerated]
		private void <UpdateWindow>g__UpdateButtonText|27_0(ref CollectionInfoWindow.<>c__DisplayClass27_0 A_1)
		{
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BDA")]
		[Address(RVA = "0x8AAE", Offset = "0x8AAE", VA = "0x8AAE")]
		[CompilerGenerated]
		private void <UpdateWindow>g__UpdateStatusText|27_1(ref CollectionInfoWindow.<>c__DisplayClass27_0 A_1)
		{
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BDB")]
		[Address(RVA = "0x8AAF", Offset = "0x8AAF", VA = "0x8AAF")]
		[CompilerGenerated]
		private void <UpdateWindow>g__HandleCollectionView|27_2(ref CollectionInfoWindow.<>c__DisplayClass27_0 A_1)
		{
		}

		// Token: 0x040020F4 RID: 8436
		[Token(Token = "0x40020F4")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Collections/CollectionInfoWindow";

		// Token: 0x040020F5 RID: 8437
		[Token(Token = "0x40020F5")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CollectionView _collectionView;

		// Token: 0x040020F6 RID: 8438
		[Token(Token = "0x40020F6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RewardsRender _rewardsView;

		// Token: 0x040020F7 RID: 8439
		[Token(Token = "0x40020F7")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TextMeshProUGUI _descriptionLabel;

		// Token: 0x040020F8 RID: 8440
		[Token(Token = "0x40020F8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _upgradeButton;

		// Token: 0x040020F9 RID: 8441
		[Token(Token = "0x40020F9")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private CollectionRequirementsDisplay _requirements;

		// Token: 0x040020FA RID: 8442
		[Token(Token = "0x40020FA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _nextButton;

		// Token: 0x040020FB RID: 8443
		[Token(Token = "0x40020FB")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Button _prevButton;

		// Token: 0x040020FC RID: 8444
		[Token(Token = "0x40020FC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _statusText;

		// Token: 0x040020FD RID: 8445
		[Token(Token = "0x40020FD")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameObject _descriptionGroup;

		// Token: 0x040020FE RID: 8446
		[Token(Token = "0x40020FE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _content;

		// Token: 0x040020FF RID: 8447
		[Token(Token = "0x40020FF")]
		[FieldOffset(Offset = "0x64")]
		private CollectionInfoViewMediator _mediator;

		// Token: 0x04002100 RID: 8448
		[Token(Token = "0x4002100")]
		[FieldOffset(Offset = "0x68")]
		private bool _mvcSetUp;

		// Token: 0x020009C1 RID: 2497
		[Token(Token = "0x20009C1")]
		public class CollectionInfoWindowArgs : BaseWindowArgs
		{
			// Token: 0x06003BDC RID: 15324 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003BDC")]
			[Address(RVA = "0x8AB0", Offset = "0x8AB0", VA = "0x8AB0")]
			public CollectionInfoWindowArgs(CollectionsController controller, UserData user, uint collectionId, uint rank)
			{
			}

			// Token: 0x04002101 RID: 8449
			[Token(Token = "0x4002101")]
			[FieldOffset(Offset = "0x18")]
			public UserData User;

			// Token: 0x04002102 RID: 8450
			[Token(Token = "0x4002102")]
			[FieldOffset(Offset = "0x1C")]
			public readonly uint CollectionId;

			// Token: 0x04002103 RID: 8451
			[Token(Token = "0x4002103")]
			[FieldOffset(Offset = "0x20")]
			public readonly CollectionsController CollectionsController;

			// Token: 0x04002104 RID: 8452
			[Token(Token = "0x4002104")]
			[FieldOffset(Offset = "0x24")]
			public readonly uint Rank;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Content ---
		void Gameplay_Collections_View_CollectionInfoWindow__get_Content
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57e6b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CollectionInfoWindow_CollectionInfoWindowArgs__OnShow__
		              );
		    DAT_ram_00a57e6b = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_CollectionInfoWindow_CollectionInfoWindowArgs__OnShow__
		              );
		  Gameplay_Collections_View_CollectionInfoWindow__UpdateWindow(param1,param1);
		  return;
		}
		*/

}
