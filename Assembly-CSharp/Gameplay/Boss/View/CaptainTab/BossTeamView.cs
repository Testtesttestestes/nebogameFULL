using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B84 RID: 2948
	[Token(Token = "0x2000B84")]
	public class BossTeamView : MonoBehaviour
	{
		// Token: 0x140001C6 RID: 454
		// (add) Token: 0x060047A0 RID: 18336 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060047A1 RID: 18337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C6")]
		public event Action<TeamData.TeamAssistantData> AssistantClickedEvent
		{
			[Token(Token = "0x60047A0")]
			[Address(RVA = "0x1B4B", Offset = "0x1B4B", VA = "0x1B4B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60047A1")]
			[Address(RVA = "0x962F", Offset = "0x962F", VA = "0x962F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A2")]
		[Address(RVA = "0x9630", Offset = "0x9630", VA = "0x9630")]
		private void Awake()
		{
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A3")]
		[Address(RVA = "0x9631", Offset = "0x9631", VA = "0x9631")]
		private void AOnClickEvent(TeamData.TeamAssistantData data)
		{
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x060047A4 RID: 18340 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047A5 RID: 18341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E54")]
		public TeamData TeamInfoData
		{
			[Token(Token = "0x60047A4")]
			[Address(RVA = "0x9632", Offset = "0x9632", VA = "0x9632")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047A5")]
			[Address(RVA = "0x1B4C", Offset = "0x1B4C", VA = "0x1B4C")]
			set
			{
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x060047A6 RID: 18342 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047A7 RID: 18343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E55")]
		public BossInfo BossInfo
		{
			[Token(Token = "0x60047A6")]
			[Address(RVA = "0x9633", Offset = "0x9633", VA = "0x9633")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047A7")]
			[Address(RVA = "0x1B61", Offset = "0x1B61", VA = "0x1B61")]
			set
			{
			}
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A8")]
		[Address(RVA = "0x9634", Offset = "0x9634", VA = "0x9634")]
		private void TeamInfoDataOnCaptainRatingChangedEvent()
		{
		/* --- GHIDRA: TeamInfoDataOnCaptainRatingChangedEvent ---
		void Gameplay_Boss_View_CaptainTab_BossTeamView__TeamInfoDataOnCaptainRatingChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57a69 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21060);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3636);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21059);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3635);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21058);
		    DAT_ram_00a57a69 = '\x01';
		  }
		  if (*(int *)(param1 + 0x3c) != 0) {
		    uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar1,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    local_8 = Gameplay_Boss_Model_TeamData__get_TeamId(*(undefined4 *)(param1 + 0x3c),0);
		    uVar2 = func_ii_8783(&local_8,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar1,StringLiteral_21059,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    local_8 = *(undefined8 *)(*(int *)(param1 + 0x3c) + 0x28);
		    uVar2 = func_ii_8783(&local_8,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar1,StringLiteral_21060,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    piVar3 = *(int **)(*(int *)(param1 + 0x3c) + 0x18);
		    iVar5 = *piVar3;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe0) * 4))
		                      (piVar3,*(undefined4 *)(iVar5 + 0xe4));
		    uVar2 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(uVar2,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar1,StringLiteral_21058,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    puVar4 = &StringLiteral_3635;
		    if (*(char *)(*(int *)(param1 + 0x3c) + 0x30) == '\0') {
		      puVar4 = &StringLiteral_3636;
		    }
		    uVar2 = *puVar4;
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar2,1,0,1,0,0,0,0);
		    uVar1 = Core_GameLocalization__GetTranslation(uVar2,uVar1,0);
		    iVar5 = **(int **)(param1 + 0x28);
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		              (*(int **)(param1 + 0x28),uVar1,*(undefined4 *)(iVar5 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A9")]
		[Address(RVA = "0x9635", Offset = "0x9635", VA = "0x9635")]
		private void RenderCaptainPlace()
		{
		/* --- GHIDRA: RenderCaptainPlace ---
		void Gameplay_Boss_View_CaptainTab_BossTeamView__RenderCaptainPlace(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int param1_00;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  
		  iVar2 = 0;
		  iVar5 = 0;
		  if (DAT_ram_00a57a6a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamData_TeamAssistantData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Boss_View_CaptainTab_BossTeamView_AOnClickEvent__)
		    ;
		    DAT_ram_00a57a6a = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar4 = *(int *)(iVar3 + iVar5 * 4 + 0x10);
		      param1_01 = unnamed_function_1417(System_Action_TeamData_TeamAssistantData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_01,param1,Method_Gameplay_Boss_View_CaptainTab_BossTeamView_AOnClickEvent__,
		                 0);
		      if (DAT_ram_00a57a4b == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_TeamData_TeamAssistantData__TypeInfo);
		        DAT_ram_00a57a4b = '\x01';
		      }
		      param1_00 = *(int *)(iVar4 + 0x30);
		      do {
		        iVar2 = 0;
		        param1_02 = func_ii_7048(param1_00,param1_01,0);
		        param2_00 = System_Action_TeamData_TeamAssistantData__TypeInfo;
		        if ((param1_02 != 0) &&
		           (iVar2 = func_ii_1082(param1_02,System_Action_TeamData_TeamAssistantData__TypeInfo),
		           iVar2 == 0)) {
		          System_Activator__CreateInstance(param1_02,param2_00);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar2 = func_ii_4329(iVar4 + 0x30,iVar2,param1_00);
		        bVar1 = iVar2 != param1_00;
		        param1_00 = iVar2;
		      } while (bVar1);
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar3 + 0xc));
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__add_AssistantClickedEvent(param1,0,iVar2);
		  return;
		}
		*/

		}

		// Token: 0x060047AA RID: 18346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047AA")]
		[Address(RVA = "0x9636", Offset = "0x9636", VA = "0x9636")]
		private void OnDestroy()
		{
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047AB")]
		[Address(RVA = "0x9637", Offset = "0x9637", VA = "0x9637")]
		private void ClickHandlerOnOnClickEvent(PointerEventData eventData)
		{
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047AC")]
		[Address(RVA = "0x9638", Offset = "0x9638", VA = "0x9638")]
		public BossTeamView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_CaptainTab_BossTeamView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a6b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    DAT_ram_00a57a6b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_UserData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_UserData__TypeInfo), iVar2 == 0)) break;
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

		}

		// Token: 0x04002756 RID: 10070
		[Token(Token = "0x4002756")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BossTeamAssistantView[] _assistantViews;

		// Token: 0x04002757 RID: 10071
		[Token(Token = "0x4002757")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BossTeamCaptainView _captainView;

		// Token: 0x04002758 RID: 10072
		[Token(Token = "0x4002758")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04002759 RID: 10073
		[Token(Token = "0x4002759")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _totalSkillBonusLabel;

		// Token: 0x0400275A RID: 10074
		[Token(Token = "0x400275A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SkillIconValue _totalSkillBonus;

		// Token: 0x0400275B RID: 10075
		[Token(Token = "0x400275B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _backtimeGroup;

		// Token: 0x0400275C RID: 10076
		[Token(Token = "0x400275C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400275D RID: 10077
		[Token(Token = "0x400275D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _dominateCultTitle;

		// Token: 0x0400275E RID: 10078
		[Token(Token = "0x400275E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameImageLoader _dominateCultIcon;

		// Token: 0x0400275F RID: 10079
		[Token(Token = "0x400275F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private GameObject _dominateCultContainer;

		// Token: 0x04002761 RID: 10081
		[Token(Token = "0x4002761")]
		[FieldOffset(Offset = "0x3C")]
		private TeamData _teamInfoData;

		// Token: 0x04002762 RID: 10082
		[Token(Token = "0x4002762")]
		[FieldOffset(Offset = "0x40")]
		private BossInfo _bossInfo;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_AssistantClickedEvent ---
		void Gameplay_Boss_View_CaptainTab_BossTeamView__add_AssistantClickedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  float fVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 param1_00;
		  int iVar5;
		  int param3_00;
		  
		  if (DAT_ram_00a57a67 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossTeamView_TeamInfoDataOnCaptainRatingChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData__ToArray__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3956);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3650);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3630);
		    DAT_ram_00a57a67 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x3c);
		  if (iVar3 != 0) {
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Boss_View_CaptainTab_BossTeamView_TeamInfoDataOnCaptainRatingChangedEvent__
		               ,0);
		    Gameplay_Boss_Model_TeamData__add_CaptainRatingChangedEvent(iVar3,uVar1,0);
		  }
		  *(int *)(param1 + 0x3c) = param2;
		  if (param2 == 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x24),0,0);
		    return;
		  }
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossTeamView_TeamInfoDataOnCaptainRatingChangedEvent__
		             ,0);
		  Gameplay_Boss_Model_TeamData__get_HasEmptySlots(param2,uVar1,0);
		  iVar3 = *(int *)(param1 + 0x14);
		  piVar4 = *(int **)(*(int *)(param1 + 0x3c) + 0x18);
		  if (DAT_ram_00a57a53 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a57a53 = '\x01';
		  }
		  *(int **)(iVar3 + 0x18) = piVar4;
		  if (piVar4 != (int *)0x0) {
		    param1_00 = *(undefined4 *)(iVar3 + 0x10);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xe0) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0xe4));
		    uVar1 = Core_Extensions_Dict_AprDicExt__GetAttackAssetId
		                      (*(undefined4 *)(*(int *)(iVar3 + 0x38) + 0x10),0);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,uVar1,0);
		  }
		  iVar3 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (*(undefined4 *)(*(int *)(param1 + 0x3c) + 0x14),
		                     Method_System_Collections_Generic_List_TeamData_TeamAssistantData__ToArray__);
		  if ((iVar3 != 0) && (*(int *)(*(int *)(param1 + 0x10) + 0xc) < *(int *)(iVar3 + 0xc))) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(StringLiteral_3956,0);
		  }
		  iVar5 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar5 + 0xc)) {
		    param3_00 = 0;
		    do {
		      if (param3_00 < *(int *)(iVar3 + 0xc)) {
		        uVar1 = *(undefined4 *)(iVar3 + param3_00 * 4 + 0x10);
		      }
		      else {
		        uVar1 = 0;
		      }
		      Gameplay_Boss_View_CaptainTab_BossTeamAssistantView__get_AssistantData
		                (*(undefined4 *)(iVar5 + param3_00 * 4 + 0x10),uVar1,param3_00);
		      param3_00 = param3_00 + 1;
		      iVar5 = *(int *)(param1 + 0x10);
		    } while (param3_00 < *(int *)(iVar5 + 0xc));
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x24);
		  fVar2 = func_ii_7103(*(undefined4 *)(*(int *)(param1 + 0x3c) + 0xc),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(0.0 < fVar2),0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(*(int *)(param1 + 0x3c) + 0xc),0);
		  piVar4 = *(int **)(param1 + 0x1c);
		  if (0 < *(longlong *)(*(int *)(*(int *)(param1 + 0x3c) + 0x10) + 0x10)) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3630,1,0,1,0,0,0,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x2d0) * 4))
		              (piVar4,uVar1,*(undefined4 *)(*piVar4 + 0x2d4));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    func_ii_7072(*(undefined4 *)(param1 + 0x20),*(undefined4 *)(*(int *)(param1 + 0x3c) + 0x10),
		                 piVar4);
		    Gameplay_Boss_View_CaptainTab_BossTeamView__TeamInfoDataOnCaptainRatingChangedEvent
		              (param1,piVar4);
		    return;
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3650,1,0,1,0,0,0,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x2d0) * 4))
		            (piVar4,uVar1,*(undefined4 *)(*piVar4 + 0x2d4));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__TeamInfoDataOnCaptainRatingChangedEvent(param1,piVar4)
		  ;
		  return;
		}
		*/


		/* --- GHIDRA: remove_AssistantClickedEvent ---
		void Gameplay_Boss_View_CaptainTab_BossTeamView__remove_AssistantClickedEvent
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a57a66 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamData_TeamAssistantData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Boss_View_CaptainTab_BossTeamView_AOnClickEvent__)
		    ;
		    DAT_ram_00a57a66 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar4 = *(int *)(iVar3 + iVar5 * 4 + 0x10);
		      param1_01 = unnamed_function_1417(System_Action_TeamData_TeamAssistantData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_01,param1,Method_Gameplay_Boss_View_CaptainTab_BossTeamView_AOnClickEvent__,
		                 0);
		      if (DAT_ram_00a57a4a == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_TeamData_TeamAssistantData__TypeInfo);
		        DAT_ram_00a57a4a = '\x01';
		      }
		      param1_00 = *(int *)(iVar4 + 0x30);
		      do {
		        iVar2 = 0;
		        param1_02 = UnityEngine_UI_Image__set_sprite(param1_00,param1_01,0);
		        param2_00 = System_Action_TeamData_TeamAssistantData__TypeInfo;
		        if ((param1_02 != 0) &&
		           (iVar2 = func_ii_1082(param1_02,System_Action_TeamData_TeamAssistantData__TypeInfo),
		           iVar2 == 0)) {
		          System_Activator__CreateInstance(param1_02,param2_00);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar2 = func_ii_4329(iVar4 + 0x30,iVar2,param1_00);
		        bVar1 = iVar2 != param1_00;
		        param1_00 = iVar2;
		      } while (bVar1);
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_TeamInfoData ---
		void Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData(int *param1,int param2,int param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int iVar1;
		  int local_8;
		  int local_4;
		  
		  local_4 = param1[6];
		  param1_00 = func_ii_1081(*(undefined4 *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 0x10),&local_4
		                          );
		  local_8 = param2;
		  param2_00 = func_ii_1081(*(undefined4 *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 0x10),&local_8
		                          );
		  iVar1 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName(param1_00,param2_00,0);
		  if (iVar1 == 0) {
		    iVar1 = param1[6];
		    param1[6] = param2;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		              (param1,iVar1,param2,*(undefined4 *)(*param1 + 0xe4));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_BossInfo ---
		void Gameplay_Boss_View_CaptainTab_BossTeamView__get_BossInfo(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Boss_View_CaptainTab_BossTeamView__TeamInfoDataOnCaptainRatingChangedEvent(param1,param1)
		  ;
		  return;
		}
		*/


		/* --- GHIDRA: set_BossInfo ---
		void Gameplay_Boss_View_CaptainTab_BossTeamView__set_BossInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a578ae == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossController_CaptainInvitesChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossController_MyTeamsInfoChangedEvent__);
		    DAT_ram_00a578ae = '\x01';
		  }
		  iVar4 = *(int *)(param2 + 0x10);
		  uVar5 = *(undefined4 *)(iVar4 + 0x30);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Boss_Controller_BossController_CaptainInvitesChangedEvent__,0);
		  piVar3 = (int *)func_ii_7048(uVar5,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x30) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(iVar4 + 0x30) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = *(int *)(param2 + 0x10);
		  uVar5 = *(undefined4 *)(iVar4 + 0x34);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_Boss_Controller_BossController_MyTeamsInfoChangedEvent__,0
		            );
		  piVar3 = (int *)func_ii_7048(uVar5,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 0x34) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) ||
		          (*(int **)(iVar4 + 0x34) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Boss_Model_BossModel__AddBoss(uVar2,param2,param1);
		  return;
		}
		*/

}
