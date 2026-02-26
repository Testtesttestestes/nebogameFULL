using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Collections.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Collections.View
{
	// Token: 0x020009BD RID: 2493
	[Token(Token = "0x20009BD")]
	public class CollectionConfirmationWindow : ClosableBaseWindow<CollectionConfirmationWindow.CollectionConfirmationWindowArgs>
	{
		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06003BB7 RID: 15287 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BC8")]
		public override string WindowId
		{
			[Token(Token = "0x6003BB7")]
			[Address(RVA = "0x8A8D", Offset = "0x8A8D", VA = "0x8A8D", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB8")]
		[Address(RVA = "0x8A8E", Offset = "0x8A8E", VA = "0x8A8E", Slot = "24")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Collections_View_CollectionConfirmationWindow__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57e64 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CollectionConfirmationWindow_CollectionConfirmationWindowArgs__OnClickBack__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_View_CollectionConfirmationWindow_UpgradeButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57e64 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x58) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_UI_Windows_ClosableBaseWindow_CollectionConfirmationWindow_CollectionConfirmationWindowArgs__OnClickBack__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x54) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Collections_View_CollectionConfirmationWindow_UpgradeButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x54) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_UI_Windows_ClosableBaseWindow_CollectionConfirmationWindow_CollectionConfirmationWindowArgs__OnClickBack__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB9")]
		[Address(RVA = "0x8A8F", Offset = "0x8A8F", VA = "0x8A8F")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Collections_View_CollectionConfirmationWindow__OnDestroy
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57e65 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CollectionConfirmationWindow_CollectionConfirmationWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4376);
		    Mono_Security_ASN1__get_Item(&StringLiteral_56);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3702);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4373);
		    Mono_Security_ASN1__get_Item(&StringLiteral_576);
		    DAT_ram_00a57e65 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_CollectionConfirmationWindow_CollectionConfirmationWindowArgs__OnShow__
		              );
		  iVar4 = *(int *)(param2 + 0x18);
		  Gameplay_Collections_View_CollectionConfirmationWindow__OnShow
		            (param1,*(undefined4 *)(param2 + 0x20),iVar4,param2);
		  Gameplay_Collections_View_CollectionListElement_CollectionListElementArgs___ctor
		            (*(undefined4 *)(param1 + 0x4c),*(undefined4 *)(param2 + 0x1c),
		             *(undefined4 *)(param2 + 0x20),1,param2);
		  uVar1 = System_Xml_XsdCachingReader__get_Name(*(undefined4 *)(param2 + 0x18),0);
		  uVar1 = Core_Extensions_Dict_CollectionRankInfoDicExt__GetAvatarRibbonAssetId(uVar1,0);
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0x3c),uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x40);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4373,1,0,1,0,0,0,0);
		  uVar1 = System_Int32__ToString(param1_00,StringLiteral_56,uVar1,StringLiteral_576,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar1 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(param1 + 0x54),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  iVar4 = *(int *)(iVar4 + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar3 = &StringLiteral_3702;
		  if (iVar4 == 0) {
		    puVar3 = &StringLiteral_4376;
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar3,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBA")]
		[Address(RVA = "0x8A90", Offset = "0x8A90", VA = "0x8A90", Slot = "22")]
		protected override void OnShow(CollectionConfirmationWindow.CollectionConfirmationWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Collections_View_CollectionConfirmationWindow__OnShow
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x48);
		  *(undefined1 *)(*(int *)(param1_00 + 0x1c) + 0x30) = 1;
		  *(undefined1 *)(*(int *)(*(int *)(param1 + 0x44) + 0x1c) + 0x30) = 1;
		  uVar1 = Core_Data_CollectionData__get_MaxRank(param3,0);
		  Gameplay_Collections_View_CollectionView__set_IgnoreAchieved(param1_00,param3,param2,uVar1,param3)
		  ;
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x50),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(int *)(param3 + 0x1c) != 0),0);
		  if (*(int *)(param3 + 0x1c) == 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x44),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    return;
		  }
		  Gameplay_Collections_View_CollectionView__set_IgnoreAchieved
		            (*(undefined4 *)(param1 + 0x44),param3,param2,*(int *)(param3 + 0x1c),param3);
		  return;
		}
		*/

		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBB")]
		[Address(RVA = "0x8A91", Offset = "0x8A91", VA = "0x8A91")]
		private void SetCollectionViews(UserData user, CollectionData data)
		{
		/* --- GHIDRA: SetCollectionViews ---
		void Gameplay_Collections_View_CollectionConfirmationWindow__SetCollectionViews
		               (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57e66 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_CollectionConfirmationWindow_CollectionConfirmationWindowArgs__get_WindowArgs__
		              );
		    DAT_ram_00a57e66 = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_CollectionConfirmationWindow_CollectionConfirmationWindowArgs__get_WindowArgs__
		                      );
		  iVar1 = *(int *)(iVar1 + 0x24);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBC")]
		[Address(RVA = "0x8A92", Offset = "0x8A92", VA = "0x8A92")]
		private void UpgradeButtonClickedEventHandler()
		{
		/* --- GHIDRA: UpgradeButtonClickedEventHandler ---
		void Gameplay_Collections_View_CollectionConfirmationWindow__UpgradeButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57e67 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CollectionConfirmationWindow_CollectionConfirmationWindowArgs___ctor__
		              );
		    DAT_ram_00a57e67 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_CollectionConfirmationWindow_CollectionConfirmationWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBD")]
		[Address(RVA = "0x8A93", Offset = "0x8A93", VA = "0x8A93")]
		public CollectionConfirmationWindow()
		{
		}

		// Token: 0x040020DA RID: 8410
		[Token(Token = "0x40020DA")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Collections/CollectionConfirmationWindow";

		// Token: 0x040020DB RID: 8411
		[Token(Token = "0x40020DB")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040020DC RID: 8412
		[Token(Token = "0x40020DC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _confirmationText;

		// Token: 0x040020DD RID: 8413
		[Token(Token = "0x40020DD")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private CollectionView _currentCollection;

		// Token: 0x040020DE RID: 8414
		[Token(Token = "0x40020DE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CollectionView _nextCollection;

		// Token: 0x040020DF RID: 8415
		[Token(Token = "0x40020DF")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private CollectionRequirementsDisplay _requirements;

		// Token: 0x040020E0 RID: 8416
		[Token(Token = "0x40020E0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _transitionImage;

		// Token: 0x040020E1 RID: 8417
		[Token(Token = "0x40020E1")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Button _upgradeButton;

		// Token: 0x040020E2 RID: 8418
		[Token(Token = "0x40020E2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _cancelButton;

		// Token: 0x020009BE RID: 2494
		[Token(Token = "0x20009BE")]
		public class CollectionConfirmationWindowArgs : BaseWindowArgs
		{
			// Token: 0x06003BBE RID: 15294 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003BBE")]
			[Address(RVA = "0x8A94", Offset = "0x8A94", VA = "0x8A94")]
			public CollectionConfirmationWindowArgs()
			{
			}

			// Token: 0x040020E3 RID: 8419
			[Token(Token = "0x40020E3")]
			[FieldOffset(Offset = "0x18")]
			public CollectionData CollectionData;

			// Token: 0x040020E4 RID: 8420
			[Token(Token = "0x40020E4")]
			[FieldOffset(Offset = "0x1C")]
			public List<CollectionsModel.CollectionMaterial> Materials;

			// Token: 0x040020E5 RID: 8421
			[Token(Token = "0x40020E5")]
			[FieldOffset(Offset = "0x20")]
			public UserData User;

			// Token: 0x040020E6 RID: 8422
			[Token(Token = "0x40020E6")]
			[FieldOffset(Offset = "0x24")]
			public Action CollectionUpgradeRequestedEvent;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Collections_View_CollectionConfirmationWindow__get_WindowId
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57e63 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CollectionConfirmationWindow_CollectionConfirmationWindowArgs__Awake__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_CollectionConfirmationWindow_CollectionConfirmationWindowArgs__OnClickBack__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_View_CollectionConfirmationWindow_UpgradeButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57e63 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object____ctor
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_CollectionConfirmationWindow_CollectionConfirmationWindowArgs__Awake__
		            );
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x58) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_UI_Windows_ClosableBaseWindow_CollectionConfirmationWindow_CollectionConfirmationWindowArgs__OnClickBack__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x54) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Collections_View_CollectionConfirmationWindow_UpgradeButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x54) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_UI_Windows_ClosableBaseWindow_CollectionConfirmationWindow_CollectionConfirmationWindowArgs__OnClickBack__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

}
