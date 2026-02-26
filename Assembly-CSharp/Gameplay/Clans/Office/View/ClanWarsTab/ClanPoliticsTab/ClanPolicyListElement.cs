using System;
using AssetContent;
using Gameplay.Clans.Office.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanPoliticsTab
{
	// Token: 0x02000A24 RID: 2596
	[Token(Token = "0x2000A24")]
	public class ClanPolicyListElement : ClanListElement<ClanPolicyListElement.ClanPolicyListElementArgs>
	{
		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06003D95 RID: 15765 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C3D")]
		public TextMeshProUGUI Place
		{
			[Token(Token = "0x6003D95")]
			[Address(RVA = "0x8C54", Offset = "0x8C54", VA = "0x8C54")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D96 RID: 15766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D96")]
		[Address(RVA = "0x8C55", Offset = "0x8C55", VA = "0x8C55", Slot = "7")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement__Awake
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57f5a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement_ClanInfoButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_ClanPolicyListElement_ClanPolicyListElementArgs__OnDestroy__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57f5a = '\x01';
		  }
		  UI_Elements_GenericList_SelectableListElement_object___DataChangedEventHandler
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElement_ClanPolicyListElement_ClanPolicyListElementArgs__OnDestroy__
		            );
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x4c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement_ClanInfoButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003D97 RID: 15767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D97")]
		[Address(RVA = "0x8C56", Offset = "0x8C56", VA = "0x8C56", Slot = "8")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57f5b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_ClanPolicyListElement_ClanPolicyListElementArgs__get_Data__
		              );
		    DAT_ram_00a57f5b = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		          goto code_r0x80e844ba;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e844ba:
		    param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		    Core_Gameplay_Managers_ClansManager__OpenClanTreasury
		              (param1_00,*(undefined4 *)(*(int *)(param1 + 0x18) + 0x1c),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D98")]
		[Address(RVA = "0x8C57", Offset = "0x8C57", VA = "0x8C57")]
		private void ClanInfoButtonClickedEventHandler()
		{
		/* --- GHIDRA: ClanInfoButtonClickedEventHandler ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement__ClanInfoButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  double param1_00;
		  
		  if (DAT_ram_00a57f5c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanPolicyListElement_ClanPolicyListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    DAT_ram_00a57f5c = '\x01';
		  }
		  iVar5 = *(int *)(param1[6] + 0x1c);
		  UnityEngine_Component__GetComponentInChildren_object_
		            (param1[9],*(undefined4 *)(*(int *)(iVar5 + 0x1c) + 0x18),0);
		  iVar4 = param1[0xb];
		  uVar2 = Core_Extensions_ClanInfoExt__GetClanRating
		                    (*(undefined4 *)(*(int *)(param1[6] + 0x1c) + 0x1c),0);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  param1_00 = (double)uVar2;
		  uVar3 = UI_SimpleIconValue__set_IconAssetId(param1_00,StringLiteral_28780,0);
		  uVar1 = (undefined4)((ulonglong)param1_00 >> 0x20);
		  UnityEngine_Component__GetComponentInChildren_object_(iVar4,uVar3,0);
		  iVar4 = param1[10];
		  uVar3 = func_ii_4443(param1[6] + 0x20,0);
		  UnityEngine_Component__GetComponentInChildren_object_(iVar4,uVar3,0);
		  iVar4 = param1[0xc];
		  uVar3 = Gameplay_World_Model_ClanData__ContainsCult(iVar5,0);
		  AssetContent_GameImage__get_AssetId(iVar4,uVar3,0);
		  iVar4 = param1[0x11];
		  uVar3 = Core_Extensions_Dict_ClanLeagueDicExt__GetDescription
		                    (*(undefined4 *)(*(int *)(param1[6] + 0x1c) + 0x20),0);
		  AssetContent_GameImage__get_AssetId(iVar4,uVar3,0);
		  iVar4 = param1[0x12];
		  uVar3 = Core_Extensions_Dict_ClanLeagueDicExt__GetBanner2AssetId
		                    (*(undefined4 *)(*(int *)(param1[6] + 0x1c) + 0x20),0);
		  AssetContent_GameImage__get_AssetId(iVar4,uVar3,0);
		  iVar4 = param1[0xd];
		  if (DAT_ram_00a57f5d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanPolicyListElement_ClanPolicyListElementArgs__get_args__
		              );
		    DAT_ram_00a57f5d = '\x01';
		  }
		  piVar6 = param1 + 0xe;
		  if ((-1 < *(int *)(*(int *)(param1[6] + 0x24) + 0xc)) &&
		     (piVar6 = param1 + 0xf, *(char *)(*(int *)(iVar5 + 0x1c) + 0x40) == '\0')) {
		    piVar6 = param1 + 0x10;
		  }
		  func_ii_7050(iVar4,*piVar6,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		            (CONCAT44(uVar1,param1),*(undefined1 *)(param1[6] + 0xc),
		             *(undefined4 *)(*param1 + 0x10c));
		  iVar5 = param1[0x14];
		  iVar4 = Gameplay_World_Model_ClanData__set_ClanLeagueDic(*(undefined4 *)(param1[6] + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (iVar5,(uint)(*(int *)(iVar4 + 0xc) != 0),0);
		  return;
		}
		*/

		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D99")]
		[Address(RVA = "0x8C58", Offset = "0x8C58", VA = "0x8C58", Slot = "11")]
		protected override void ApplyArgs()
		{
		/* --- GHIDRA: ApplyArgs ---
		undefined4
		Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement__ApplyArgs
		          (int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57f5d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanPolicyListElement_ClanPolicyListElementArgs__get_args__
		              );
		    DAT_ram_00a57f5d = '\x01';
		  }
		  if (*(int *)(*(int *)(*(int *)(param1 + 0x18) + 0x24) + 0xc) < 0) {
		    return *(undefined4 *)(param1 + 0x38);
		  }
		  if (*(char *)(*(int *)(param2 + 0x1c) + 0x40) != '\0') {
		    return *(undefined4 *)(param1 + 0x3c);
		  }
		  return *(undefined4 *)(param1 + 0x40);
		}
		*/

		}

		// Token: 0x06003D9A RID: 15770 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003D9A")]
		[Address(RVA = "0x8C59", Offset = "0x8C59", VA = "0x8C59")]
		private Sprite GetStatusSprite(ClanData data)
		{
			return null;
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D9B")]
		[Address(RVA = "0x8C5A", Offset = "0x8C5A", VA = "0x8C5A", Slot = "10")]
		protected override void CallElementClickedEvent(ClanPolicyListElement.ClanPolicyListElementArgs args)
		{
		/* --- GHIDRA: CallElementClickedEvent ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement__CallElementClickedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f5e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanListElement_ClanPolicyListElement_ClanPolicyListElementArgs___ctor__
		              );
		    DAT_ram_00a57f5e = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanListElementArgs___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_Gameplay_Clans_Office_View_ClanListElement_ClanPolicyListElement_ClanPolicyListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D9C")]
		[Address(RVA = "0x8C5B", Offset = "0x8C5B", VA = "0x8C5B")]
		public ClanPolicyListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f5f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanWarsOfficeModel_Policy__ClanPolicyListElement___ctor__
		              );
		    DAT_ram_00a57f5f = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanListElementArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_Gameplay_Clans_Office_View_ClanListElementArgs_ClanWarsOfficeModel_Policy__ClanPolicyListElement___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002268 RID: 8808
		[Token(Token = "0x4002268")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Image _statusIcon;

		// Token: 0x04002269 RID: 8809
		[Token(Token = "0x4002269")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _shieldSprite;

		// Token: 0x0400226A RID: 8810
		[Token(Token = "0x400226A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Sprite _blitzWarSprite;

		// Token: 0x0400226B RID: 8811
		[Token(Token = "0x400226B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _warSprite;

		// Token: 0x0400226C RID: 8812
		[Token(Token = "0x400226C")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameImage _leagueBanner;

		// Token: 0x0400226D RID: 8813
		[Token(Token = "0x400226D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameImage _leagueIcon;

		// Token: 0x0400226E RID: 8814
		[Token(Token = "0x400226E")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _clanInfoButton;

		// Token: 0x0400226F RID: 8815
		[Token(Token = "0x400226F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _restrictionsIndicator;

		// Token: 0x02000A25 RID: 2597
		[Token(Token = "0x2000A25")]
		public class ClanPolicyListElementArgs : ClanListElementArgs<ClanWarsOfficeModel.Policy, ClanPolicyListElement>
		{
			// Token: 0x06003D9D RID: 15773 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003D9D")]
			[Address(RVA = "0x8C5C", Offset = "0x8C5C", VA = "0x8C5C")]
			public ClanPolicyListElementArgs()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Place ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement__get_Place
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57f59 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement_ClanInfoButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_ClanPolicyListElement_ClanPolicyListElementArgs__Awake__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57f59 = '\x01';
		  }
		  UI_Elements_GenericList_SelectableListElement_object____ctor
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElement_ClanPolicyListElement_ClanPolicyListElementArgs__Awake__
		            );
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x4c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyListElement_ClanInfoButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
