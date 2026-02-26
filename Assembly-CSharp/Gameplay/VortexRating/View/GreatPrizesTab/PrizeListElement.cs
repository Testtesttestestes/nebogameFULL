using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.VortexRating.View.GreatPrizesTab
{
	// Token: 0x02000390 RID: 912
	[Token(Token = "0x2000390")]
	public class PrizeListElement : MonoBehaviour
	{
		// Token: 0x1400010D RID: 269
		// (add) Token: 0x06001533 RID: 5427 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001534 RID: 5428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400010D")]
		public event Action<PrizeListElement> ElementClickedEvent
		{
			[Token(Token = "0x6001533")]
			[Address(RVA = "0x66F5", Offset = "0x66F5", VA = "0x66F5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001534")]
			[Address(RVA = "0x66F6", Offset = "0x66F6", VA = "0x66F6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001536 RID: 5430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037E")]
		public RatingPrizeDic Prize
		{
			[Token(Token = "0x6001535")]
			[Address(RVA = "0x66F7", Offset = "0x66F7", VA = "0x66F7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001536")]
			[Address(RVA = "0x66F8", Offset = "0x66F8", VA = "0x66F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700037F RID: 895
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037F")]
		public bool Selected
		{
			[Token(Token = "0x6001537")]
			[Address(RVA = "0x66F9", Offset = "0x66F9", VA = "0x66F9")]
			set
			{
			}
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001538")]
		[Address(RVA = "0x66FA", Offset = "0x66FA", VA = "0x66FA")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a581be == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement_ButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a581be = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement_ButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001539")]
		[Address(RVA = "0x66FB", Offset = "0x66FB", VA = "0x66FB")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement__OnDestroy
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  undefined8 local_10;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a581bf == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26294);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17535);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28658);
		    DAT_ram_00a581bf = '\x01';
		  }
		  local_4 = 0;
		  *(int *)(param1 + 0x28) = param2;
		  iVar3 = *(int *)(param2 + 0x14);
		  if (iVar3 == *(int *)(param2 + 0x18)) {
		    local_4 = iVar3;
		    uVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  }
		  else {
		    local_10 = CONCAT44(local_10._4_4_,iVar3);
		    uVar1 = func_ii_1081(DAT_ram_00a66958,&local_10);
		    local_8 = *(undefined4 *)(param2 + 0x18);
		    uVar2 = func_ii_1081(DAT_ram_00a66958,&local_8);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_28658,uVar1,uVar2,0);
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x20);
		  uVar2 = Core_Extensions_Dict_ProtoGetUserSkillsAnsExt__ToSkillChangedEvt(param2,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,uVar2,0);
		  piVar4 = *(int **)(param1 + 0x14);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17535,1,0,1,0,0,0,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_26294,uVar1,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_10;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar3,0);
		  iVar3 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar4,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  if (*(int *)(param1 + 0x18) != 0) {
		    UnityEngine_Component__GetComponentInChildren_object_(*(int *)(param1 + 0x18),param3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153A")]
		[Address(RVA = "0x66FC", Offset = "0x66FC", VA = "0x66FC")]
		public void Init(RatingPrizeDic prize, string period)
		{
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153B")]
		[Address(RVA = "0x66FD", Offset = "0x66FD", VA = "0x66FD")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153C")]
		[Address(RVA = "0x66FE", Offset = "0x66FE", VA = "0x66FE")]
		public PrizeListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a581c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GreatUserView__TypeInfo);
		    DAT_ram_00a581c0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_GreatUserView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GreatUserView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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

		}

		// Token: 0x04000B45 RID: 2885
		[Token(Token = "0x4000B45")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject _selector;

		// Token: 0x04000B46 RID: 2886
		[Token(Token = "0x4000B46")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000B47 RID: 2887
		[Token(Token = "0x4000B47")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _timePeriod;

		// Token: 0x04000B48 RID: 2888
		[Token(Token = "0x4000B48")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _button;

		// Token: 0x04000B49 RID: 2889
		[Token(Token = "0x4000B49")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImage _bgImage;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ElementClickedEvent ---
		void Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement__add_ElementClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a581bc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PrizeListElement__TypeInfo);
		    DAT_ram_00a581bc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_PrizeListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_PrizeListElement__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: set_Prize ---
		void Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement__set_Prize
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x10),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Selected ---
		void Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement__set_Selected
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a581bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement_ButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a581bd = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement_ButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
