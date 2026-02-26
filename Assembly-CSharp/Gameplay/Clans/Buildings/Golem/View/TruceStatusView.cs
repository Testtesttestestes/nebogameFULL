using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Price;
using UI.Requirements;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Clans.Buildings.Golem.View
{
	// Token: 0x02000ACC RID: 2764
	[Token(Token = "0x2000ACC")]
	public class TruceStatusView : MonoBehaviourWithStates<TruceStatusView.State>
	{
		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06004291 RID: 17041 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D1C")]
		public TextMeshProUGUI StatusTitle
		{
			[Token(Token = "0x6004291")]
			[Address(RVA = "0x9145", Offset = "0x9145", VA = "0x9145")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06004292 RID: 17042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D1D")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6004292")]
			[Address(RVA = "0x9146", Offset = "0x9146", VA = "0x9146")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06004293 RID: 17043 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D1E")]
		public Button ShieldButton
		{
			[Token(Token = "0x6004293")]
			[Address(RVA = "0x9147", Offset = "0x9147", VA = "0x9147")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06004294 RID: 17044 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D1F")]
		public Button WarButton
		{
			[Token(Token = "0x6004294")]
			[Address(RVA = "0x9148", Offset = "0x9148", VA = "0x9148")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06004295 RID: 17045 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D20")]
		public RequirementsView RequirementsView
		{
			[Token(Token = "0x6004295")]
			[Address(RVA = "0x9149", Offset = "0x9149", VA = "0x9149")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06004296 RID: 17046 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D21")]
		public Price Price
		{
			[Token(Token = "0x6004296")]
			[Address(RVA = "0x914A", Offset = "0x914A", VA = "0x914A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004297")]
		[Address(RVA = "0x914B", Offset = "0x914B", VA = "0x914B")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Clans_Buildings_Golem_View_TruceStatusView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x48),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004298 RID: 17048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004298")]
		[Address(RVA = "0x914C", Offset = "0x914C", VA = "0x914C")]
		public void PrepareView()
		{
		/* --- GHIDRA: PrepareView ---
		void Gameplay_Clans_Buildings_Golem_View_TruceStatusView__PrepareView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  undefined4 local_4;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x40);
		  local_4 = param2;
		  param2_00 = func_ii_4443(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004299 RID: 17049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004299")]
		[Address(RVA = "0x914D", Offset = "0x914D", VA = "0x914D")]
		public void SetHonor(int honor)
		{
		/* --- GHIDRA: SetHonor ---
		void Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetHonor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5784a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    DAT_ram_00a5784a = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(param2,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,param2_00,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600429A RID: 17050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600429A")]
		[Address(RVA = "0x914E", Offset = "0x914E", VA = "0x914E")]
		public void SetStatusDescriptionKey(string localizationKey)
		{
		/* --- GHIDRA: SetStatusDescriptionKey ---
		void Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetStatusDescriptionKey
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5784b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    DAT_ram_00a5784b = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x28);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(param2,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,param2_00,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600429B RID: 17051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600429B")]
		[Address(RVA = "0x914F", Offset = "0x914F", VA = "0x914F")]
		public void SetStatusAnnotationKey(string localizationKey)
		{
		/* --- GHIDRA: SetStatusAnnotationKey ---
		void Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetStatusAnnotationKey
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0x28),param2,0);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600429C RID: 17052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600429C")]
		[Address(RVA = "0x9150", Offset = "0x9150", VA = "0x9150")]
		public void SetStatusAnnotationText(string text)
		{
		/* --- GHIDRA: SetStatusAnnotationText ---
		void Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetStatusAnnotationText
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Elements_RightPanel_TitleWithLevel__set_Level(*(undefined4 *)(param1 + 0x38),param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x48),1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600429D RID: 17053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600429D")]
		[Address(RVA = "0x9151", Offset = "0x9151", VA = "0x9151")]
		public void SetBacktime(BackTime backtime)
		{
		/* --- GHIDRA: SetBacktime ---
		void Gameplay_Clans_Buildings_Golem_View_TruceStatusView__SetBacktime
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5784c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_TruceStatusView_State__HandleCurrentStateChanged__
		              );
		    DAT_ram_00a5784c = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x48),0,0);
		  UI_MonoBehaviourWithStates_Int32Enum____ctor
		            (param1,param2,param3,
		             Method_UI_MonoBehaviourWithStates_TruceStatusView_State__HandleCurrentStateChanged__);
		  return;
		}
		*/

		}

		// Token: 0x0600429E RID: 17054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600429E")]
		[Address(RVA = "0x9152", Offset = "0x9152", VA = "0x9152", Slot = "4")]
		protected override void HandleCurrentStateChanged(TruceStatusView.State fromState, TruceStatusView.State toState)
		{
		/* --- GHIDRA: HandleCurrentStateChanged ---
		void Gameplay_Clans_Buildings_Golem_View_TruceStatusView__HandleCurrentStateChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5784d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_TruceStatusView_State___ctor__);
		    DAT_ram_00a5784d = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_TruceStatusView_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600429F RID: 17055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600429F")]
		[Address(RVA = "0x9153", Offset = "0x9153", VA = "0x9153")]
		public TruceStatusView()
		{
		}

		// Token: 0x040024B8 RID: 9400
		[Token(Token = "0x40024B8")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _statusTitle;

		// Token: 0x040024B9 RID: 9401
		[Token(Token = "0x40024B9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _statusDescription;

		// Token: 0x040024BA RID: 9402
		[Token(Token = "0x40024BA")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040024BB RID: 9403
		[Token(Token = "0x40024BB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _statusAnnotation;

		// Token: 0x040024BC RID: 9404
		[Token(Token = "0x40024BC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _shieldButton;

		// Token: 0x040024BD RID: 9405
		[Token(Token = "0x40024BD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _warButton;

		// Token: 0x040024BE RID: 9406
		[Token(Token = "0x40024BE")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private RequirementsView _requirements;

		// Token: 0x040024BF RID: 9407
		[Token(Token = "0x40024BF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x040024C0 RID: 9408
		[Token(Token = "0x40024C0")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Price _price;

		// Token: 0x040024C1 RID: 9409
		[Token(Token = "0x40024C1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _honor;

		// Token: 0x040024C2 RID: 9410
		[Token(Token = "0x40024C2")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameRawImage _honorIcon;

		// Token: 0x040024C3 RID: 9411
		[Token(Token = "0x40024C3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _backtimeGroup;

		// Token: 0x02000ACD RID: 2765
		[Token(Token = "0x2000ACD")]
		public enum State
		{
			// Token: 0x040024C5 RID: 9413
			[Token(Token = "0x40024C5")]
			UNKNOWN_STATE,
			// Token: 0x040024C6 RID: 9414
			[Token(Token = "0x40024C6")]
			ALL_ENABLED,
			// Token: 0x040024C7 RID: 9415
			[Token(Token = "0x40024C7")]
			ALL_DISABLED,
			// Token: 0x040024C8 RID: 9416
			[Token(Token = "0x40024C8")]
			BASE_INFO,
			// Token: 0x040024C9 RID: 9417
			[Token(Token = "0x40024C9")]
			COMBAT
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Price ---
		void Gameplay_Clans_Buildings_Golem_View_TruceStatusView__get_Price(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a57849 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57849 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x44);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80de7b3c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80de7b3c:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetUserRatingKindDic(uVar3,4,0);
		  uVar3 = Core_Extensions_Dict_ClanLeagueDicExt__GetIconAssetId(uVar3,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,uVar3,0);
		  return;
		}
		*/

}
