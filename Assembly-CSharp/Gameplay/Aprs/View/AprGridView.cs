using System;
using System.Runtime.CompilerServices;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UI;
using UI.Price;
using UnityEngine;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D4E RID: 3406
	[Token(Token = "0x2000D4E")]
	public class AprGridView : AbstractDataRenderer<AprData>
	{
		// Token: 0x140001FC RID: 508
		// (add) Token: 0x06005367 RID: 21351 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005368 RID: 21352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001FC")]
		public static event Action<AprGridView> SelectEvent
		{
			[Token(Token = "0x6005367")]
			[Address(RVA = "0xA126", Offset = "0xA126", VA = "0xA126")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005368")]
			[Address(RVA = "0xA127", Offset = "0xA127", VA = "0xA127")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06005369 RID: 21353 RVA: 0x0000F168 File Offset: 0x0000D368
		[Token(Token = "0x170010F0")]
		protected override bool ValidateDataImmediately
		{
			[Token(Token = "0x6005369")]
			[Address(RVA = "0xA128", Offset = "0xA128", VA = "0xA128", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536A")]
		[Address(RVA = "0xA129", Offset = "0xA129", VA = "0xA129", Slot = "9")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Aprs_View_AprGridView__Awake(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a593e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_AprData__Dispose__);
		    Mono_Security_ASN1__get_Item(&System_Action_AprView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_View_AprGridView_AprViewOnClickEvent__);
		    DAT_ram_00a593e6 = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x24);
		  if (DAT_ram_00a593fa == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a593fa = '\x01';
		  }
		  *(undefined4 *)(iVar4 + 0x4c) = 0;
		  uVar5 = *(undefined4 *)(iVar4 + 0x3c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar3 = UnityEngine_Component__GetComponent_object_(0,0);
		  UI_ToolTip_ToolTip__get_enabled(uVar5,uVar3,0);
		  iVar4 = *(int *)(param1 + 0x24);
		  uVar5 = unnamed_function_1417(System_Action_AprView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,Method_Gameplay_Aprs_View_AprGridView_AprViewOnClickEvent__,0);
		  if (DAT_ram_00a593f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprView__TypeInfo);
		    DAT_ram_00a593f6 = '\x01';
		  }
		  param1_00 = *(int *)(iVar4 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,uVar5,0);
		    uVar3 = System_Action_AprView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_AprView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar4 + 0x44,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      UI_AbstractDataRenderer_object___CommitProperties
		                (param1,Method_UI_AbstractDataRenderer_AprData__Dispose__);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600536B RID: 21355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536B")]
		[Address(RVA = "0xA12A", Offset = "0xA12A", VA = "0xA12A", Slot = "10")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Aprs_View_AprGridView__Dispose(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a593e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_View_AprGridView_TypeInfo);
		    DAT_ram_00a593e7 = '\x01';
		  }
		  iVar1 = **(int **)(Gameplay_Aprs_View_AprGridView_TypeInfo + 0x5c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600536C RID: 21356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536C")]
		[Address(RVA = "0xA12B", Offset = "0xA12B", VA = "0xA12B")]
		private void AprViewOnClickEvent(AprView aprView)
		{
		/* --- GHIDRA: AprViewOnClickEvent ---
		void Gameplay_Aprs_View_AprGridView__AprViewOnClickEvent(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int *piVar2;
		  int iVar3;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar1 != 0) {
		    piVar2 = (int *)param1[9];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x138) * 4))
		              (piVar2,*(undefined4 *)(iVar1 + 0x1c),*(undefined4 *)(iVar3 + 0x13c));
		    iVar3 = param1[9];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    if (DAT_ram_00a59431 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_SortedList_uint__MedalInfo__get_Count__);
		      DAT_ram_00a59431 = '\x01';
		    }
		    *(bool *)(iVar3 + 0x55) = 0 < *(int *)(*(int *)(iVar1 + 0x28) + 0x10);
		    Gameplay_Aprs_View_AprView__HandleIsPointerOverChanged(iVar3,param1);
		    param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x134));
		    Gameplay_Aprs_View_AprGridView__HandleDataChanged(param1,param2_00,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600536D RID: 21357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536D")]
		[Address(RVA = "0xA12C", Offset = "0xA12C", VA = "0xA12C", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Aprs_View_AprGridView__HandleDataChanged(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a593e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a593e8 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 0x10) + 0x24);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  if (*(int *)(param2 + 0x24) == *(int *)(param2 + 0x20)) {
		    if (DAT_ram_00a59431 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_SortedList_uint__MedalInfo__get_Count__);
		      DAT_ram_00a59431 = '\x01';
		    }
		    if ((*(int *)(*(int *)(param2 + 0x28) + 0x10) < 1) &&
		       (iVar1 = Core_Money_Money__op_Multiply(uVar2,0), iVar1 == 0)) {
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(param1 + 0x28),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,1,0);
		      UI_Price_Price__SetColor
		                (*(undefined4 *)(param1 + 0x28),*(undefined4 *)(param2 + 0x24),uVar2,0);
		      return;
		    }
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600536E RID: 21358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536E")]
		[Address(RVA = "0xA12D", Offset = "0xA12D", VA = "0xA12D")]
		private void HandlePrice([NotNull] AprData aprData)
		{
		/* --- GHIDRA: HandlePrice ---
		void Gameplay_Aprs_View_AprGridView__HandlePrice(undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int param4;
		  
		  if (DAT_ram_00a593e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_AprData__StartListenEvents__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_View_AprGridView_HandleCurrentMedalChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo);
		    DAT_ram_00a593e9 = '\x01';
		  }
		  param1_01 = unnamed_function_1417(Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo);
		  Gameplay_Aprs_Model_AprData___InvalidateSaleMarkerInfo_b__53_0
		            (param1_01,param1,Method_Gameplay_Aprs_View_AprGridView_HandleCurrentMedalChangedEvent__
		             ,0);
		  if (DAT_ram_00a59428 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo);
		    DAT_ram_00a59428 = '\x01';
		  }
		  param1_00 = *(int *)(param2 + 8);
		  while ((param1_02 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param1_01,0),
		         param1_02 == (int *)0x0 ||
		         (Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo == *param1_02))) {
		    param4 = func_ii_4329(param2 + 8,param1_02,param1_00);
		    bVar1 = param4 == param1_00;
		    param1_00 = param4;
		    if (bVar1) {
		      Gameplay_Aprs_View_AprGridView__StopListenEvents
		                (param1,0,*(undefined4 *)(param2 + 0x14),param4);
		      return;
		    }
		  }
		  System_Activator__CreateInstance
		            (param1_02,Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600536F RID: 21359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536F")]
		[Address(RVA = "0xA12E", Offset = "0xA12E", VA = "0xA12E", Slot = "17")]
		protected override void StartListenEvents(AprData data)
		{
		/* --- GHIDRA: StartListenEvents ---
		void Gameplay_Aprs_View_AprGridView__StartListenEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int param4;
		  
		  if (DAT_ram_00a593ea == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_AprData__StopListenEvents__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_View_AprGridView_HandleCurrentMedalChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo);
		    DAT_ram_00a593ea = '\x01';
		  }
		  param1_01 = unnamed_function_1417(Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo);
		  Gameplay_Aprs_Model_AprData___InvalidateSaleMarkerInfo_b__53_0
		            (param1_01,param1,Method_Gameplay_Aprs_View_AprGridView_HandleCurrentMedalChangedEvent__
		             ,0);
		  if (DAT_ram_00a59429 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo);
		    DAT_ram_00a59429 = '\x01';
		  }
		  param1_00 = *(int *)(param2 + 8);
		  while ((param1_02 = (int *)func_ii_7048(param1_00,param1_01,0), param1_02 == (int *)0x0 ||
		         (Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo == *param1_02))) {
		    param4 = func_ii_4329(param2 + 8,param1_02,param1_00);
		    bVar1 = param4 == param1_00;
		    param1_00 = param4;
		    if (bVar1) {
		      Gameplay_Aprs_View_AprGridView__StopListenEvents
		                (param1,*(undefined4 *)(param2 + 0x14),0,param4);
		      return;
		    }
		  }
		  System_Activator__CreateInstance
		            (param1_02,Gameplay_Aprs_Model_AprData_CurrentMedalChanged_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005370 RID: 21360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005370")]
		[Address(RVA = "0xA12F", Offset = "0xA12F", VA = "0xA12F", Slot = "18")]
		protected override void StopListenEvents(AprData data)
		{
		/* --- GHIDRA: StopListenEvents ---
		void Gameplay_Aprs_View_AprGridView__StopListenEvents
		               (undefined4 param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a593eb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__add_DataChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__remove_DataChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_View_AprGridView_HandleCurrentMedalWrapperDataChangedEvent__);
		    DAT_ram_00a593eb = '\x01';
		  }
		  if (param2 != 0) {
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Aprs_View_AprGridView_HandleCurrentMedalWrapperDataChangedEvent__,0);
		    Core_Dict_DictWrappers_Base_AbstractDictWrapper_object__uint___get_Id
		              (param2,uVar1,
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__remove_DataChangedEvent__
		              );
		  }
		  if (param3 != 0) {
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Aprs_View_AprGridView_HandleCurrentMedalWrapperDataChangedEvent__,0);
		    Core_Dict_DictWrappers_Base_AbstractDictWrapper_object__uint___Dispose
		              (param3,uVar1,
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__add_DataChangedEvent__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005371 RID: 21361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005371")]
		[Address(RVA = "0xA130", Offset = "0xA130", VA = "0xA130")]
		private void HandleCurrentMedalChangedEvent(MedalDicWrapper from, MedalDicWrapper to)
		{
		/* --- GHIDRA: HandleCurrentMedalChangedEvent ---
		void Gameplay_Aprs_View_AprGridView__HandleCurrentMedalChangedEvent(int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		  Gameplay_Aprs_View_AprGridView__HandleDataChanged(param1,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06005372 RID: 21362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005372")]
		[Address(RVA = "0xA131", Offset = "0xA131", VA = "0xA131")]
		private void HandleCurrentMedalWrapperDataChangedEvent()
		{
		/* --- GHIDRA: HandleCurrentMedalWrapperDataChangedEvent ---
		void Gameplay_Aprs_View_AprGridView__HandleCurrentMedalWrapperDataChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a593ec == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_AprData___ctor__);
		    DAT_ram_00a593ec = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_AprData___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06005373 RID: 21363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005373")]
		[Address(RVA = "0xA132", Offset = "0xA132", VA = "0xA132")]
		public AprGridView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Aprs_View_AprGridView___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a593ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2581);
		    DAT_ram_00a593ed = '\x01';
		  }
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(param1 + 0x30),0);
		  if (iVar1 == 0) {
		    return *(undefined4 *)(param1 + 0x30);
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2581,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x30) = uVar2;
		  return uVar2;
		}
		*/

		}

		// Token: 0x04002D2A RID: 11562
		[Token(Token = "0x4002D2A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected AprView _aprView;

		// Token: 0x04002D2B RID: 11563
		[Token(Token = "0x4002D2B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected Price _price;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SelectEvent ---
		void Gameplay_Aprs_View_AprGridView__add_SelectEvent(undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a593e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprGridView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_View_AprGridView_TypeInfo);
		    DAT_ram_00a593e4 = '\x01';
		  }
		  param1_00 = **(int **)(Gameplay_Aprs_View_AprGridView_TypeInfo + 0x5c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param1,0);
		    param2_00 = System_Action_AprGridView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_AprGridView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(*(undefined4 *)(Gameplay_Aprs_View_AprGridView_TypeInfo + 0x5c),iVar2,
		                         param1_00);
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


		/* --- GHIDRA: get_ValidateDataImmediately ---
		void Gameplay_Aprs_View_AprGridView__get_ValidateDataImmediately(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a593e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_View_AprGridView_AprViewOnClickEvent__);
		    DAT_ram_00a593e5 = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x24);
		  if (DAT_ram_00a593fa == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a593fa = '\x01';
		  }
		  *(int *)(iVar4 + 0x4c) = param1;
		  uVar5 = *(undefined4 *)(iVar4 + 0x3c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar3 = UnityEngine_Component__GetComponent_object_(param1,0);
		  UI_ToolTip_ToolTip__get_enabled(uVar5,uVar3,0);
		  iVar4 = *(int *)(param1 + 0x24);
		  *(undefined4 *)(iVar4 + 0x58) = 1;
		  uVar5 = unnamed_function_1417(System_Action_AprView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,Method_Gameplay_Aprs_View_AprGridView_AprViewOnClickEvent__,0);
		  if (DAT_ram_00a593f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprView__TypeInfo);
		    DAT_ram_00a593f5 = '\x01';
		  }
		  param1_00 = *(int *)(iVar4 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,uVar5,0);
		    uVar3 = System_Action_AprView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_AprView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar4 + 0x44,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
