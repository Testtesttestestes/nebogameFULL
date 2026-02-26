using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B7F RID: 2943
	[Token(Token = "0x2000B7F")]
	public class BossTeamAssistantView : MonoBehaviour
	{
		// Token: 0x140001C3 RID: 451
		// (add) Token: 0x06004776 RID: 18294 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004777 RID: 18295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C3")]
		public event Action<TeamData.TeamAssistantData> ClickEvent
		{
			[Token(Token = "0x6004776")]
			[Address(RVA = "0x9606", Offset = "0x9606", VA = "0x9606")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004777")]
			[Address(RVA = "0x9607", Offset = "0x9607", VA = "0x9607")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004778 RID: 18296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004778")]
		[Address(RVA = "0x9608", Offset = "0x9608", VA = "0x9608")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Boss_View_CaptainTab_BossTeamAssistantView__Awake
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57a4d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_ContextMenu_BossMenuContext_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ContextMenu_ContextMenuController_Show_IBossMenuContext__UserContextMenu___
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_InputSystem_InputControl_Vector2__ReadValue__);
		    DAT_ram_00a57a4d = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x34);
		  if ((iVar2 == 0) || (*(char *)(param1 + 0x2c) != '\0')) {
		    iVar3 = *(int *)(param1 + 0x30);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),iVar2,*(undefined4 *)(iVar3 + 0x14));
		      iVar2 = *(int *)(param1 + 0x34);
		    }
		    if (iVar2 == 0) {
		      return;
		    }
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = Google_Protobuf_Reflection_EnumValueDescriptor__get_Name(uVar1,0);
		  iVar2 = unnamed_function_1417(Gameplay_Boss_Model_ContextMenu_BossMenuContext_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = *(undefined4 *)(param1 + 0x34);
		  if (DAT_ram_00a5a202 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_InputSystem_Pointer_TypeInfo);
		    DAT_ram_00a5a202 = '\x01';
		  }
		  UnityEngine_InputSystem_InputControl_Vector2___ReadUnprocessedValue
		            (&local_8,*(undefined4 *)
		                       (**(int **)(UnityEngine_InputSystem_Pointer_TypeInfo + 0x5c) + 0xe8),
		             Method_UnityEngine_InputSystem_InputControl_Vector2__ReadValue__);
		  local_10 = local_8;
		  UI_ContextMenu_ContextMenuController___Show_b__13_0___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		            (uVar1,1,iVar2,&local_10,
		             Method_UI_ContextMenu_ContextMenuController_Show_IBossMenuContext__UserContextMenu___);
		  return;
		}
		*/

		}

		// Token: 0x06004779 RID: 18297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004779")]
		[Address(RVA = "0x9609", Offset = "0x9609", VA = "0x9609")]
		private void ClickHandlerOnOnClickEvent(PointerEventData obj)
		{
		/* --- GHIDRA: ClickHandlerOnOnClickEvent ---
		void Gameplay_Boss_View_CaptainTab_BossTeamAssistantView__ClickHandlerOnOnClickEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57a4e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossTeamAssistantView_ClickHandlerOnOnClickEvent__
		              );
		    DAT_ram_00a57a4e = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossTeamAssistantView_ClickHandlerOnOnClickEvent__
		             ,0);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600477A RID: 18298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600477A")]
		[Address(RVA = "0x960A", Offset = "0x960A", VA = "0x960A")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x0600477B RID: 18299 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600477C RID: 18300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E4B")]
		public TeamData.TeamAssistantData AssistantData
		{
			[Token(Token = "0x600477B")]
			[Address(RVA = "0x960B", Offset = "0x960B", VA = "0x960B")]
			get
			{
				return null;
			}
			[Token(Token = "0x600477C")]
			[Address(RVA = "0x960C", Offset = "0x960C", VA = "0x960C")]
			set
			{
			}
		}

		// Token: 0x0600477D RID: 18301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600477D")]
		[Address(RVA = "0x960D", Offset = "0x960D", VA = "0x960D")]
		public BossTeamAssistantView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_CaptainTab_BossTeamAssistantView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57a50 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossTeamCaptainView_ClickHandlerOnOnClickEvent__
		              );
		    DAT_ram_00a57a50 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossTeamCaptainView_ClickHandlerOnOnClickEvent__,0
		            );
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x04002740 RID: 10048
		[Token(Token = "0x4002740")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x04002741 RID: 10049
		[Token(Token = "0x4002741")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandler;

		// Token: 0x04002742 RID: 10050
		[Token(Token = "0x4002742")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkillIconValue _skillBonusView;

		// Token: 0x04002743 RID: 10051
		[Token(Token = "0x4002743")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private SimpleIconValue _cultBonusView;

		// Token: 0x04002744 RID: 10052
		[Token(Token = "0x4002744")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _timeIcon;

		// Token: 0x04002745 RID: 10053
		[Token(Token = "0x4002745")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _backtimeGroup;

		// Token: 0x04002746 RID: 10054
		[Token(Token = "0x4002746")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04002747 RID: 10055
		[Token(Token = "0x4002747")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _disableContextMenu;

		// Token: 0x04002749 RID: 10057
		[Token(Token = "0x4002749")]
		[FieldOffset(Offset = "0x34")]
		private TeamData.TeamAssistantData _assistantData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Boss_View_CaptainTab_BossTeamAssistantView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a4b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamData_TeamAssistantData__TypeInfo);
		    DAT_ram_00a57a4b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_TeamData_TeamAssistantData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TeamData_TeamAssistantData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_Boss_View_CaptainTab_BossTeamAssistantView__remove_ClickEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57a4c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossTeamAssistantView_ClickHandlerOnOnClickEvent__
		              );
		    DAT_ram_00a57a4c = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossTeamAssistantView_ClickHandlerOnOnClickEvent__
		             ,0);
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(param1_01,param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_AssistantData ---
		void Gameplay_Boss_View_CaptainTab_BossTeamAssistantView__get_AssistantData
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  float fVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57a4f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1235);
		    DAT_ram_00a57a4f = '\x01';
		  }
		  *(int **)(param1 + 0x34) = param2;
		  if (param2 == (int *)0x0) {
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(param1 + 0x10),0,0);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x24),0,0);
		  }
		  else {
		    uVar4 = *(undefined4 *)(param1 + 0x10);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                      (param2,*(undefined4 *)(*param2 + 0xe4));
		    uVar3 = Core_Extensions_Dict_AprDicExt__GetAttackAssetId
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x38) + 0x10),0);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar4,uVar3,0);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(*(int *)(*(int *)(param1 + 0x34) + 0x24) != 0),0);
		    func_ii_7072(*(undefined4 *)(param1 + 0x18),*(undefined4 *)(*(int *)(param1 + 0x34) + 0x24),
		                 param1);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x20),0);
		    uVar4 = Gameplay_Boss_Model_TeamData_TeamAssistantData__get_IsAbsent
		                      (*(undefined4 *)(param1 + 0x34),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,uVar4,0);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,1,0);
		    uVar4 = *(undefined4 *)(param1 + 0x1c);
		    iVar1 = **(int **)(param1 + 0x34);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe0) * 4))
		                      (*(int **)(param1 + 0x34),*(undefined4 *)(iVar1 + 0xe4));
		    uVar3 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                      (*(undefined4 *)(iVar1 + 0x4c),0);
		    Core_Extensions_Dict_ResourcesDicExt__GetIconForResourceBar64AssetId(uVar4,uVar3,0);
		    uVar4 = *(undefined4 *)(param1 + 0x1c);
		    local_4 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0x28);
		    uVar3 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar3 = func_ii_4419(StringLiteral_1235,uVar3,0);
		    Utils_StringUtils__GetNumberStringWithSpaces(uVar4,uVar3,0);
		    uVar3 = *(undefined4 *)(param1 + 0x24);
		    fVar2 = func_ii_7103(*(undefined4 *)(*(int *)(param1 + 0x34) + 0x2c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(0.0 < fVar2),0);
		    UI_Elements_RightPanel_TitleWithLevel__set_Level
		              (*(undefined4 *)(param1 + 0x28),*(undefined4 *)(*(int *)(param1 + 0x34) + 0x2c),0);
		  }
		  return;
		}
		*/

}
