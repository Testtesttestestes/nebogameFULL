using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClassTab;
using Gameplay.School.Model;
using Gameplay.UserInfo.View.Equipment;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Dic;
using UI.Elements.Buildings;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A76 RID: 2678
	[Token(Token = "0x2000A76")]
	public class ClassViewMediator : AbstractViewMediator<ClassModel, ClassEvents, ClassController, ClassView>, IHideableMediator
	{
		// Token: 0x06003FB9 RID: 16313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FB9")]
		[Address(RVA = "0x8E73", Offset = "0x8E73", VA = "0x8E73")]
		public ClassViewMediator(ClassModel model, ClassEvents events, ClassController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a576aa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClassModel__ClassEvents__ClassController__ClassView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_SubFilterListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UserEquipmentSlotConfig__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__add_SlotClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__remove_SlotClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_ClassFilterClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_CloseSpellDescButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_DeselectSpellEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_EquipmentViewOnSlotClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_InfoButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClassViewMediator_SelectSpellEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClassViewMediator_TabChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_SpellItemArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_SpellItemArgs__AddListener__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_SpellItemArgs__RemoveListener__);
		    DAT_ram_00a576aa = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x24);
		    uVar1 = unnamed_function_1417(System_Action_SubFilterListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_ClassFilterClickedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_GenericSubFilterView__add_ClickedEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x20);
		    uVar1 = unnamed_function_1417(System_Action_UserEquipmentSlotConfig__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_EquipmentViewOnSlotClickedEventHandler__
		               ,0);
		    Gameplay_UserInfo_View_Equipment_BaseEquipmentView___Il2CppFullySharedGenericType___get_Artifacts
		              (uVar3,uVar1,
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__remove_SlotClickedEvent__
		              );
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x2c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_TabChangedEventHandler__,0)
		    ;
		    UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x38) + 0x18);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_SpellItemArgs__TypeInfo);
		    func_ii_7054(uVar1,param1,
		                 Method_Gameplay_Clans_Office_Controller_ClassViewMediator_SelectSpellEventHandler__
		                 ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_SpellItemArgs__RemoveListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x38) + 0x24);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_SpellItemArgs__TypeInfo);
		    func_ii_7054(uVar1,param1,
		                 Method_Gameplay_Clans_Office_Controller_ClassViewMediator_DeselectSpellEventHandler__
		                 ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_SpellItemArgs__AddListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_CloseSpellDescButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_InfoButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x24);
		    uVar1 = unnamed_function_1417(System_Action_SubFilterListElement__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_ClassFilterClickedEventHandler__
		               ,0);
		    UI_Elements_Filters_GenericFilter_GenericFilterView___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x20);
		    uVar1 = unnamed_function_1417(System_Action_UserEquipmentSlotConfig__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_EquipmentViewOnSlotClickedEventHandler__
		               ,0);
		    Gameplay_UserInfo_View_Equipment_BaseEquipmentView_object___SlotOnClickEvent
		              (uVar3,uVar1,
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__add_SlotClickedEvent__
		              );
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x2c);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_TabChangedEventHandler__,0)
		    ;
		    UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x38) + 0x18);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_SpellItemArgs__TypeInfo);
		    func_ii_7054(uVar1,param1,
		                 Method_Gameplay_Clans_Office_Controller_ClassViewMediator_SelectSpellEventHandler__
		                 ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_SpellItemArgs__AddListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x38) + 0x24);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_SpellItemArgs__TypeInfo);
		    func_ii_7054(uVar1,param1,
		                 Method_Gameplay_Clans_Office_Controller_ClassViewMediator_DeselectSpellEventHandler__
		                 ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		              (uVar3,uVar1,Method_UnityEngine_Events_UnityEvent_SpellItemArgs__AddListener__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_CloseSpellDescButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_InfoButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_Clans_Office_Controller_ClassViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CA9 RID: 3241
		// (set) Token: 0x06003FBA RID: 16314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA9")]
		public override ClassView View
		{
			[Token(Token = "0x6003FBA")]
			[Address(RVA = "0x8E74", Offset = "0x8E74", VA = "0x8E74", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FBB")]
		[Address(RVA = "0x8E75", Offset = "0x8E75", VA = "0x8E75")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__Init(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)));
		  iVar2 = *param1;
		  if (*(char *)(*(int *)(iVar1 + 0x48) + 0x14) == '\0') {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x148) * 4))
		                          (param1,*(undefined4 *)(iVar2 + 0x14c));
		    Gameplay_Clans_Office_Controller_ClassController__GetDollSlotsResultHandler
		              (param1_00,*(undefined8 *)(*(int *)(param1[7] + 0xc) + 0x10),param1);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar2 + 0x15c));
		  Gameplay_UserInfo_View_BaseInfoBox__get_Visible(*(undefined4 *)(iVar1 + 0x48),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FBC")]
		[Address(RVA = "0x8E76", Offset = "0x8E76", VA = "0x8E76")]
		private void InfoButtonClickedEventHandler()
		{
		/* --- GHIDRA: InfoButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__InfoButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  byte bVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a576ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClassView_Tab__set_CurrentState__);
		    DAT_ram_00a576ac = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar2 + 0x2c),0);
		  bVar1 = *(byte *)(iVar2 + 0x14);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_MonoBehaviourWithStates_ByteEnum___remove_CurrentStateChangedEvent
		            (param1_00,(uint)bVar1,
		             Method_UI_MonoBehaviourWithStates_ClassView_Tab__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FBD")]
		[Address(RVA = "0x8E77", Offset = "0x8E77", VA = "0x8E77")]
		private void TabChangedEventHandler()
		{
		/* --- GHIDRA: TabChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__TabChangedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data
		            (*(undefined4 *)(param1 + 0x18),0,0);
		  Gameplay_Clans_Office_Controller_ClassViewMediator__ClassFilterClickedEventHandler
		            (param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FBE")]
		[Address(RVA = "0x8E78", Offset = "0x8E78", VA = "0x8E78")]
		private void ClassFilterClickedEventHandler(SubFilterListElement element)
		{
		/* --- GHIDRA: ClassFilterClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__ClassFilterClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  undefined4 param1_01;
		  undefined8 uVar4;
		  
		  if (DAT_ram_00a576ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClassModel__ClassEvents__ClassController__ClassView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ClassModel_DollData__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_DollsInfoDic_TypeInfo);
		    DAT_ram_00a576ad = '\x01';
		  }
		  Gameplay_VortexRating_View_GreatPrizesTab_FilterListElement__set_Data(param2,1,0);
		  param1[6] = param2;
		  iVar2 = Protocol_Dic_DollsInfoDic_TypeInfo;
		  param1_00 = *(int **)(param2 + 0x20);
		  if (param1_00 == (int *)0x0) {
		    param1[7] = 0;
		  }
		  else if ((Protocol_Dic_DollsInfoDic_TypeInfo != *param1_00) ||
		          (param1[7] = (int)param1_00, *param1_00 != iVar2)) {
		    System_Activator__CreateInstance(param1_00,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar4);
		  uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  Gameplay_Clans_Office_View_ClassTab_ClassView__get_InfoButton(uVar1,param1[7],0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x15c)));
		  param1_01 = *(undefined4 *)(iVar2 + 0x1c);
		  uVar4 = *(undefined8 *)(*(int *)(param1[7] + 0xc) + 0x10);
		  iVar2 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                    (*(undefined4 *)(param1[2] + 0x2c),uVar4,
		                     Method_System_Collections_Generic_Dictionary_ulong__ClassModel_DollData__get_Item__
		                    );
		  uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar1 = UI_Wiki_WikiUriRouter__SetData
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar2 + 8) + 0x38) + 0x10),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_01,uVar1,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x14c)));
		  uVar4 = *(undefined8 *)(*(int *)(param1[7] + 0xc) + 0x10);
		  Gameplay_Clans_Office_Controller_ClassController__DollItemsChangedEventHandler(uVar3,uVar4,param1)
		  ;
		  uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  Gameplay_WorldAxis_Controller_WorldAxisController__FromDollToGolemResultHandler
		            (*(undefined4 *)(*(int *)(param1[2] + 0x14) + 0x1c),param1[7],0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x14c)));
		  Gameplay_Clans_Office_Controller_ClassController__GetDollSkillsResultHandler
		            (uVar3,*(undefined8 *)(*(int *)(param1[7] + 0xc) + 0x10),param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar2 + 0x48) + 0x14) != '\0') {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_Clans_Office_Controller_ClassController__GetDollSlotsResultHandler
		              (uVar3,*(undefined8 *)(*(int *)(param1[7] + 0xc) + 0x10),param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FBF")]
		[Address(RVA = "0x8E79", Offset = "0x8E79", VA = "0x8E79")]
		private void SelectFilter(SubFilterListElement element)
		{
		/* --- GHIDRA: SelectFilter ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__SelectFilter
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a576ae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClassModel__ClassEvents__ClassController__ClassView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_School_View_SpellCurrentDescriptionTitledListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__AddElement_SpellCurrentDescriptionTitledListElement___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__Clear__
		              );
		    DAT_ram_00a576ae = '\x01';
		  }
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1[2] + 0x20),*(undefined4 *)(param2 + 0xc),
		                     Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__)
		  ;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_object___AddElement
		            (*(undefined4 *)(iVar2 + 0x3c),
		             Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__Clear__)
		  ;
		  Gameplay_Clans_Office_Controller_ClassViewMediator__SelectSpellEventHandler(param1,uVar1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar2 + 0x3c);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_School_View_SpellCurrentDescriptionTitledListElementArgs_TypeInfo)
		  ;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,uVar1,0);
		  func_ii_8512(param1_01,param1_00,
		               Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__AddElement_SpellCurrentDescriptionTitledListElement___
		              );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar2 + 0x44),0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x3c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC0")]
		[Address(RVA = "0x8E7A", Offset = "0x8E7A", VA = "0x8E7A")]
		private void SelectSpellEventHandler(SpellItemArgs spellItemArgs)
		{
		/* --- GHIDRA: SelectSpellEventHandler ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__SelectSpellEventHandler
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a576af == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__get_Title__
		              );
		    DAT_ram_00a576af = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x10);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xf4));
		  Gameplay_School_View_SpellTitle__set_Title(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x10);
		  uVar2 = Gameplay_School_Model_SchoolSpellData__get_Level(param2,0);
		  Gameplay_School_View_SpellCurrentDescriptionTitledListElementArgs___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x3c) + 0x10);
		  uVar2 = Core_Extensions_Dict_SpellDicExt__GetAnimationOnAvatarCanvasAssetId(param2[3],0);
		  Gameplay_Antiq_View_Grid_GridList__SetData(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC1")]
		[Address(RVA = "0x8E7B", Offset = "0x8E7B", VA = "0x8E7B")]
		private void SetSpellToTitleList(SchoolSpellData schoolSpellData)
		{
		/* --- GHIDRA: SetSpellToTitleList ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__SetSpellToTitleList
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x44),1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x3c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC2")]
		[Address(RVA = "0x8E7C", Offset = "0x8E7C", VA = "0x8E7C")]
		private void DeselectSpellEventHandler(SpellItemArgs args)
		{
		/* --- GHIDRA: DeselectSpellEventHandler ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__DeselectSpellEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x44),1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x3c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC3")]
		[Address(RVA = "0x8E7D", Offset = "0x8E7D", VA = "0x8E7D")]
		private void HandleSpellDeselected()
		{
		/* --- GHIDRA: HandleSpellDeselected ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__HandleSpellDeselected
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x44),0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x3c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC4")]
		[Address(RVA = "0x8E7E", Offset = "0x8E7E", VA = "0x8E7E")]
		private void HandleSpellSelected()
		{
		/* --- GHIDRA: HandleSpellSelected ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__HandleSpellSelected
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a576b0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_SpellListArgs__SpellItem__SpellItemArgs__Deselect__
		              );
		    DAT_ram_00a576b0 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_GenericList_SelectorGenericList_object__object__object____ctor
		            (*(undefined4 *)(iVar1 + 0x38),
		             Method_UI_Elements_GenericList_SelectorGenericList_SpellListArgs__SpellItem__SpellItemArgs__Deselect__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(iVar1 + 0x44),1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x3c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC5")]
		[Address(RVA = "0x8E7F", Offset = "0x8E7F", VA = "0x8E7F")]
		private void CloseSpellDescButtonClickedEventHandler()
		{
		/* --- GHIDRA: CloseSpellDescButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__CloseSpellDescButtonClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a576b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClassModel__ClassEvents__ClassController__ClassView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_DollSkillsRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_DollSpellsRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClassViewMediator_SlotsChangedEventHandler__
		              );
		    DAT_ram_00a576b1 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_SlotsChangedEventHandler__,
		               0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_DollSpellsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		    func_ii_6877(uVar3,param1,
		                 Method_Gameplay_Clans_Office_Controller_ClassViewMediator_DollSkillsRequestedEventHandler__
		                 ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_ulong__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar5;
		      uVar3 = System_Action_ulong__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_SlotsChangedEventHandler__,
		               0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator_DollSpellsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar3 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		    func_ii_6877(uVar3,param1,
		                 Method_Gameplay_Clans_Office_Controller_ClassViewMediator_DollSkillsRequestedEventHandler__
		                 ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_ulong__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		      return;
		    }
		    iVar5 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x20) = iVar5;
		    uVar3 = System_Action_ulong__TypeInfo;
		    iVar1 = func_ii_1082(iVar2,System_Action_ulong__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CAA RID: 3242
		// (set) Token: 0x06003FC6 RID: 16326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAA")]
		public override ClassEvents Events
		{
			[Token(Token = "0x6003FC6")]
			[Address(RVA = "0x8E80", Offset = "0x8E80", VA = "0x8E80", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC7")]
		[Address(RVA = "0x8E81", Offset = "0x8E81", VA = "0x8E81")]
		private void DollSkillsRequestedEventHandler(ulong dollId)
		{
		/* --- GHIDRA: DollSkillsRequestedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__DollSkillsRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a576b3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClassModel__ClassEvents__ClassController__ClassView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__SpellListArgs__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_SpellListArgs__SpellItem__SpellItemArgs__set_Data__
		              );
		    DAT_ram_00a576b3 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)));
		  param1_00 = *(undefined4 *)(iVar1 + 0x38);
		  param2_00 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                        (*(undefined4 *)(param1[2] + 0x1c),
		                         *(undefined8 *)(*(int *)(param1[7] + 0xc) + 0x10),
		                         Method_System_Collections_Generic_Dictionary_ulong__SpellListArgs__get_Item__
		                        );
		  UI_Elements_GenericList_SelectorGenericList_object__object__object___get_SelectedIndex
		            (param1_00,param2_00,
		             Method_UI_Elements_GenericList_SelectorGenericList_SpellListArgs__SpellItem__SpellItemArgs__set_Data__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC8")]
		[Address(RVA = "0x8E82", Offset = "0x8E82", VA = "0x8E82")]
		private void DollSpellsRequestedEventHandler()
		{
		/* --- GHIDRA: DollSpellsRequestedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__DollSpellsRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a576b4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClassModel__ClassEvents__ClassController__ClassView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__set_Artifacts__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ClassModel_DollData__get_Item__)
		    ;
		    DAT_ram_00a576b4 = '\x01';
		  }
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Gameplay_UserInfo_View_Equipment_BaseEquipmentView_object___remove_SlotClickedEvent
		            (*(undefined4 *)(iVar3 + 0x20),0,
		             Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__set_Artifacts__
		            );
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x15c)));
		  Gameplay_UserInfo_View_Equipment_BaseEquipmentView_object___remove_SlotClickedEvent
		            (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(param1[2] + 0x24),
		             Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__set_Artifacts__
		            );
		  iVar3 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                    (*(undefined4 *)(param1[2] + 0x2c),
		                     *(undefined8 *)(*(int *)(param1[7] + 0xc) + 0x10),
		                     Method_System_Collections_Generic_Dictionary_ulong__ClassModel_DollData__get_Item__
		                    );
		  *(undefined1 *)(iVar3 + 0x10) = 1;
		  return;
		}
		*/

		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC9")]
		[Address(RVA = "0x8E83", Offset = "0x8E83", VA = "0x8E83")]
		private void SlotsChangedEventHandler()
		{
		/* --- GHIDRA: SlotsChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__SlotsChangedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int param2_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a576b5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClassModel__ClassEvents__ClassController__ClassView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentSlotConfig_EquipmentSlotIds__get_EquipmentSlotId__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__4951224AD8957FEE46C269CF9A898C71CEBD4B60C871C3714021DC82E580FFDD
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClassViewMediator___c__DisplayClass21_0__EquipmentViewOnSlotClickedEventHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClassViewMediator___c__DisplayClass21_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9094);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17783);
		    DAT_ram_00a576b5 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_Controller_ClassViewMediator___c__DisplayClass21_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 8) = param2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x238);
		        goto code_r0x80dc7201;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80dc7201:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  if (*(int *)(iVar6 + 0x10) != 0) {
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
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x238);
		          goto code_r0x80dc72b2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80dc72b2:
		    iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    if (*(int *)(*(int *)(iVar6 + 0x10) + 0x58) != 0) {
		      *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x14) + 0x14) + 0x2c) =
		           *(undefined4 *)(*(int *)(param2_00 + 8) + 8);
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
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x238);
		            goto code_r0x80dc73cf;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80dc73cf:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      uVar4 = Mono_Security_ASN1Convert__ToOid
		                        (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,3);
		      System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		                (uVar4,
		                 Field__PrivateImplementationDetails__4951224AD8957FEE46C269CF9A898C71CEBD4B60C871C3714021DC82E580FFDD
		                 ,0);
		      iVar6 = Mono_Security_ASN1Convert__ToOid
		                        (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,1);
		      *(undefined4 *)(iVar6 + 0x10) = 0x23;
		      param1_00 = unnamed_function_1417
		                            (
		                            Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		                            );
		      Gameplay_Inventory_View_Chest_InventoryChestWindowOptions___ctor
		                (param1_00,param2_00,
		                 Method_Gameplay_Clans_Office_Controller_ClassViewMediator___c__DisplayClass21_0__EquipmentViewOnSlotClickedEventHandler_b__0__
		                 ,0);
		      Core_Gameplay_Managers_Inventory_GolemInventoryManager__Init(uVar3,uVar4,iVar6,param1_00,0);
		      return;
		    }
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9094,1,0,1,0,0,0,0);
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17783,1,0,1,0,0,0,0);
		  UI_Windows_DialogWindow__Show(uVar3,uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCA")]
		[Address(RVA = "0x8E84", Offset = "0x8E84", VA = "0x8E84")]
		private void EquipmentViewOnSlotClickedEventHandler(UserEquipmentSlotConfig slotConfig)
		{
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCB")]
		[Address(RVA = "0x8E85", Offset = "0x8E85", VA = "0x8E85", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x040023B4 RID: 9140
		[Token(Token = "0x40023B4")]
		[FieldOffset(Offset = "0x18")]
		private SubFilterListElement _selectedFilter;

		// Token: 0x040023B5 RID: 9141
		[Token(Token = "0x40023B5")]
		[FieldOffset(Offset = "0x1C")]
		private DollsInfoDic _selectedDoll;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  uint param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  longlong local_20;
		  undefined4 local_18;
		  undefined4 local_10;
		  uint local_c;
		  undefined4 local_8;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a576ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClassModel__ClassEvents__ClassController__ClassView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Array_IndexOf_DollsInfoDic___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentSlotConfig_EquipmentSlotIds__get_EquipmentSlotId__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentSlotConfig_EquipmentSlotIds__get_Slot__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__GetSlots__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__SetArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_RightPanel_TitledList_TitledListWithCustomTitleArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__6AF77D2ED3286B481481082E8495A5A553EA7E1E35863D980746FD184E737BA0
		              );
		    DAT_ram_00a576ab = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x3c);
		  uVar2 = unnamed_function_1417
		                    (UI_Elements_RightPanel_TitledList_TitledListWithCustomTitleArgs_TypeInfo);
		  UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_object___Clear
		            (uVar3,uVar2,
		             Method_UI_Elements_RightPanel_TitledList_TitledListWithCustomTitle_SpellTitle__Init__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_Filters_GenericFilter_GenericSubFilterView__remove_ClickedEvent
		            (*(undefined4 *)(iVar1 + 0x24),*(undefined4 *)(param1[2] + 0x28),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x2c);
		  uVar2 = Gameplay_Clans_Office_Model_ClassModel__set_DollDataById(param1[2],0);
		  UI_Tabs_TabBar__HandleSelected(uVar3,uVar2,0);
		  iVar1 = *(int *)(*(int *)(param1[2] + 0x14) + 0x14);
		  iVar6 = *(int *)(iVar1 + 0x24);
		  param1[7] = iVar6;
		  uVar2 = LunarConsolePlugin_CVar__set_Value
		                    (*(undefined4 *)(iVar1 + 0x28),iVar6,Method_System_Array_IndexOf_DollsInfoDic___
		                    );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = UI_Elements_Filters_GenericFilter_GenericSubFilterView__SelectByIndexSilent
		                    (*(undefined4 *)(iVar1 + 0x24),uVar2,0);
		  Gameplay_Clans_Office_Controller_ClassViewMediator__ClassFilterClickedEventHandler(param1,uVar2,0)
		  ;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar1 + 0x2c),0,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x20);
		  param1_00 = Mono_Security_ASN1Convert__ToOid
		                        (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,3);
		  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		            (param1_00,
		             Field__PrivateImplementationDetails__6AF77D2ED3286B481481082E8495A5A553EA7E1E35863D980746FD184E737BA0
		             ,0);
		  local_18 = 0;
		  local_8 = 0;
		  local_10 = 0;
		  local_20 = (ulonglong)param1_00 << 0x20;
		  local_c = param1_00;
		  Gameplay_UserInfo_View_Equipment_BaseEquipmentView_object___OnDestroy
		            (uVar2,&local_20,
		             Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__SetArgs__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Gameplay_UserInfo_View_Equipment_BaseEquipmentView_object___Awake
		                    (*(undefined4 *)(iVar1 + 0x20),
		                     Method_Gameplay_UserInfo_View_Equipment_BaseEquipmentView_UserEquipmentSlotConfig__GetSlots__
		                    );
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar4 = *(int *)(iVar1 + iVar5 * 4 + 0x10);
		      iVar6 = Gameplay_Inventory_View_EquipmentSlotView__set_ArtifactViewArgs
		                        (*(undefined4 *)(iVar4 + 0xc),0);
		      uVar2 = Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c__DisplayClass29_0___AddClansList_b__0
		                        (param1[2],0);
		      uVar2 = Core_Extensions_Dict_DictExt__GetAccountOptionsDicByOptionId
		                        (uVar2,*(undefined4 *)(iVar4 + 8),0);
		      uVar2 = Core_Extensions_Dict_UserSkillDicExt__GetToolTipFormattedTitleWhitValue(uVar2,0);
		      *(undefined4 *)(iVar6 + 0x28) = uVar2;
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar1 + 0xc));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Office_Controller_ClassViewMediator__set_Events
		               (int *param1,longlong param2,undefined4 param3)
		
		{
		  undefined4 uVar2;
		  undefined8 uVar1;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a576b2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClassModel__ClassEvents__ClassController__ClassView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ClassModel_DollData__get_Item__)
		    ;
		    DAT_ram_00a576b2 = '\x01';
		  }
		  if (param2 == *(longlong *)(*(int *)(param1[7] + 0xc) + 0x10)) {
		    iVar3 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                      (*(undefined4 *)(param1[2] + 0x2c),param2,
		                       Method_System_Collections_Generic_Dictionary_ulong__ClassModel_DollData__get_Item__
		                      );
		    uVar2 = (undefined4)((ulonglong)param2 >> 0x20);
		    uVar4 = Gameplay_Clans_Office_Model_ClanWarsOfficeModel___c__DisplayClass29_0___AddClansList_b__0
		                      (param1[2],0);
		    uVar4 = Core_Extensions_Dict_DictExt__TryGetArtikulOptionsDic
		                      (uVar4,*(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x18),0);
		    uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x15c));
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    Gameplay_WorldAxis_ColossusInfo_View_DollSkillRow___ctor
		              (*(undefined4 *)(iVar5 + 0x48),*(undefined4 *)(iVar3 + 0xc),uVar4,
		               *(undefined4 *)(param1[2] + 0x18),0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x15c)));
		    Gameplay_UserInfo_View_BaseInfoBox__get_Visible(*(undefined4 *)(iVar3 + 0x48),1,0);
		  }
		  return;
		}
		*/

}
