using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.GenericList;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Collections.View
{
	// Token: 0x020009C3 RID: 2499
	[Token(Token = "0x20009C3")]
	public class CollectionListElement : GenericListElement<CollectionListElement.CollectionListElementArgs>, IToolTipDataProvider
	{
		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06003BDD RID: 15325 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BD3")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6003BDD")]
			[Address(RVA = "0x8AB1", Offset = "0x8AB1", VA = "0x8AB1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (set) Token: 0x06003BDE RID: 15326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD4")]
		private CollectionListElement.CollectionListElementArgs Args
		{
			[Token(Token = "0x6003BDE")]
			[Address(RVA = "0x8AB2", Offset = "0x8AB2", VA = "0x8AB2")]
			set
			{
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06003BDF RID: 15327 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003BE0 RID: 15328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD5")]
		public CollectionListElement.CollectionListElementArgs Data
		{
			[Token(Token = "0x6003BDF")]
			[Address(RVA = "0x8AB3", Offset = "0x8AB3", VA = "0x8AB3")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BE0")]
			[Address(RVA = "0x8AB4", Offset = "0x8AB4", VA = "0x8AB4")]
			set
			{
			}
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE1")]
		[Address(RVA = "0x8AB5", Offset = "0x8AB5", VA = "0x8AB5")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Collections_View_CollectionListElement__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57e77 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_View_CollectionListElement_OnClickEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_View_CollectionListElement_UpgradeButtonClicked__);
		    Mono_Security_ASN1__get_Item
		              (&
		               UnityEngine_Events_UnityAction_CollectionListElement_CollectionListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UnityEngine_Events_UnityEvent_CollectionListElement_CollectionListElementArgs__RemoveListener__
		              );
		    DAT_ram_00a57e77 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = unnamed_function_1417
		                    (
		                    UnityEngine_Events_UnityAction_CollectionListElement_CollectionListElementArgs__TypeInfo
		                    );
		  func_ii_7054(uVar1,param1,
		               Method_Gameplay_Collections_View_CollectionListElement_OnClickEventHandler__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,
		             Method_UnityEngine_Events_UnityEvent_CollectionListElement_CollectionListElementArgs__RemoveListener__
		            );
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Collections_View_CollectionListElement_UpgradeButtonClicked__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  Gameplay_Collections_View_CollectionListElement__get_GuideTarget(param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE2")]
		[Address(RVA = "0x8AB6", Offset = "0x8AB6", VA = "0x8AB6")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Collections_View_CollectionListElement__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Collections_View_CollectionListElement__OnInit(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE3")]
		[Address(RVA = "0x8AB7", Offset = "0x8AB7", VA = "0x8AB7")]
		private void DataChangedEventHandler()
		{
		/* --- GHIDRA: DataChangedEventHandler ---
		void Gameplay_Collections_View_CollectionListElement__DataChangedEventHandler
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param2 + 0x10);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003BE4 RID: 15332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE4")]
		[Address(RVA = "0x8AB8", Offset = "0x8AB8", VA = "0x8AB8")]
		private void OnClickEventHandler(CollectionListElement.CollectionListElementArgs args)
		{
		/* --- GHIDRA: OnClickEventHandler ---
		void Gameplay_Collections_View_CollectionListElement__OnClickEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57e78 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs__get_args__
		              );
		    DAT_ram_00a57e78 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x18) + 0x10);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(int *)(param1 + 0x18),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE5")]
		[Address(RVA = "0x8AB9", Offset = "0x8AB9", VA = "0x8AB9")]
		private void UpgradeButtonClicked()
		{
		/* --- GHIDRA: UpgradeButtonClicked ---
		void Gameplay_Collections_View_CollectionListElement__UpgradeButtonClicked
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int *param1_01;
		  int param2_00;
		  
		  if (DAT_ram_00a57e79 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_View_CollectionListElement_DataChangedEventHandler__);
		    DAT_ram_00a57e79 = '\x01';
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Collections_View_CollectionListElement_DataChangedEventHandler__,0);
		  if (DAT_ram_00a57e7f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57e7f = '\x01';
		  }
		  param1_00 = *(int *)(param2 + 0x20);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    param2_00 = func_ii_4329(param2 + 0x20,param1_01,param1_00);
		    bVar1 = param2_00 == param1_00;
		    param1_00 = param2_00;
		    if (bVar1) {
		      Gameplay_Collections_View_CollectionListElement__OnInit(param1,param2_00);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE6")]
		[Address(RVA = "0x8ABA", Offset = "0x8ABA", VA = "0x8ABA", Slot = "4")]
		protected override void OnInit(CollectionListElement.CollectionListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void Gameplay_Collections_View_CollectionListElement__OnInit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int param5;
		  undefined4 uVar5;
		  undefined4 param3;
		  
		  if (DAT_ram_00a57e7a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    DAT_ram_00a57e7a = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x20);
		  param5 = *(int *)(param1 + 0x18);
		  uVar5 = *(undefined4 *)(param5 + 0xc);
		  param3 = *(undefined4 *)(param5 + 0x18);
		  iVar2 = Core_Data_CollectionData__get_NextRank(uVar5,0);
		  Gameplay_Collections_View_CollectionView__set_IgnoreAchieved
		            (uVar4,uVar5,param3,*(undefined4 *)(iVar2 + 0x38),param5);
		  Gameplay_Collections_View_CollectionListElement__UpdateProgress(param1,uVar5,param5);
		  Gameplay_Collections_View_CollectionListElement__ApplyArgs(param1,param5);
		  if (DAT_ram_00a57e72 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a57e72 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x30);
		  if (param1_00 == (int *)0x0) {
		    param1_00 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___
		                                   );
		  }
		  *(int **)(param1 + 0x30) = param1_00;
		  uVar1 = 0;
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		        goto code_r0x80e72110;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,4
		                               );
		code_r0x80e72110:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  if (DAT_ram_00a57e72 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a57e72 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x30);
		  if (iVar2 == 0) {
		    iVar2 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		  }
		  *(int *)(param1 + 0x30) = iVar2;
		  uVar5 = Core_Data_CollectionData__IncreaseRank(uVar5,iVar2,0);
		  UnityEngine_Object__op_Implicit(uVar4,uVar5,0);
		  return;
		}
		*/

		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE7")]
		[Address(RVA = "0x8ABB", Offset = "0x8ABB", VA = "0x8ABB")]
		private void ApplyArgs()
		{
		/* --- GHIDRA: ApplyArgs ---
		void Gameplay_Collections_View_CollectionListElement__ApplyArgs(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param3;
		  float fVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int local_4;
		  
		  if (DAT_ram_00a57e7b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_4376);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4374);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3702);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28642);
		    DAT_ram_00a57e7b = '\x01';
		  }
		  fVar2 = *(float *)(*(int *)(param1 + 0x18) + 0x1c) * 100.0;
		  if (fVar2 < 99.0) {
		    if (DAT_ram_00a63a16 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		      DAT_ram_00a63a16 = '\x01';
		    }
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    fVar2 = CEIL(fVar2);
		  }
		  else {
		    if (DAT_ram_00a648ed == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		      DAT_ram_00a648ed = '\x01';
		    }
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    fVar2 = FLOOR(fVar2);
		  }
		  if (ABS(fVar2) < 2.1474836e+09) {
		    iVar3 = (int)fVar2;
		  }
		  else {
		    iVar3 = -0x80000000;
		  }
		  if (iVar3 < 100) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4374,1,0,1,0,0,0,0);
		    param1_00 = UI_Rewards_AbstractRewardsRender__SetRewards
		                          (*(undefined4 *)(param1 + 0x28),
		                           Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    local_4 = iVar3;
		    param3 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_28642,uVar1,param3,0);
		    UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar1,0);
		  }
		  else {
		    iVar3 = *(int *)(*(int *)(*(int *)(param1 + 0x18) + 0xc) + 0x1c);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    puVar4 = &StringLiteral_3702;
		    if (iVar3 == 0) {
		      puVar4 = &StringLiteral_4376;
		    }
		    iVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar4,1,0,1,0,0,0,0);
		    uVar1 = UI_Rewards_AbstractRewardsRender__SetRewards
		                      (*(undefined4 *)(param1 + 0x28),
		                       Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    if (iVar3 == 0) {
		      iVar3 = StringLiteral_5;
		    }
		    UnityEngine_Component__GetComponentInChildren_object_(uVar1,iVar3,0);
		  }
		  UnityEngine_UI_Image__get_fillAmount
		            (*(undefined4 *)(param1 + 0x2c),*(float *)(*(int *)(param1 + 0x18) + 0x1c),0);
		  return;
		}
		*/

		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE8")]
		[Address(RVA = "0x8ABC", Offset = "0x8ABC", VA = "0x8ABC")]
		private void UpdateProgress()
		{
		/* --- GHIDRA: UpdateProgress ---
		void Gameplay_Collections_View_CollectionListElement__UpdateProgress
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  uint uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57e7c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs__get_args__
		              );
		    DAT_ram_00a57e7c = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x24),0);
		  param2_00 = func_ii_7264(param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  uVar2 = func_ii_7264(param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar2 ^ 1,0);
		  iVar3 = func_ii_7264(param2,0);
		  if (iVar3 == 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x28),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,(uint)*(byte *)(*(int *)(param1 + 0x18) + 0x14),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE9")]
		[Address(RVA = "0x8ABD", Offset = "0x8ABD", VA = "0x8ABD")]
		private void SetActiveObjects(CollectionData data)
		{
		/* --- GHIDRA: SetActiveObjects ---
		int Gameplay_Collections_View_CollectionListElement__SetActiveObjects(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  int iVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57e7d == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_Implementations_VO_CollectionToolTipVO_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_CollectionToolTipVO___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_CollectionToolTipVO__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_CollectionToolTipVO__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12531);
		    DAT_ram_00a57e7d = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_CollectionToolTipVO__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12531,
		             Method_UI_ToolTip_ToolTipData_CollectionToolTipVO___ctor__);
		  iVar1 = unnamed_function_1417(UI_ToolTip_Implementations_VO_CollectionToolTipVO_TypeInfo);
		  iVar2 = *(int *)(param1 + 0x18);
		  param1_01 = *(undefined4 *)(iVar2 + 0xc);
		  *(undefined4 *)(iVar1 + 8) = param1_01;
		  *(undefined4 *)(iVar1 + 0xc) = *(undefined4 *)(iVar2 + 0x18);
		  iVar2 = Core_Data_CollectionData__get_NextRank(param1_01,0);
		  *(undefined4 *)(iVar1 + 0x10) = *(undefined4 *)(iVar2 + 0x38);
		  *(int *)(param1_00 + 0x1c) = iVar1;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003BEA")]
		[Address(RVA = "0x8ABE", Offset = "0x8ABE", VA = "0x8ABE", Slot = "7")]
		public BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		void Gameplay_Collections_View_CollectionListElement__GetData(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57e7e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs___ctor__
		              );
		    DAT_ram_00a57e7e = '\x01';
		  }
		  UI_Elements_GenericList_GenericListArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BEB")]
		[Address(RVA = "0x8ABF", Offset = "0x8ABF", VA = "0x8ABF")]
		public CollectionListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Collections_View_CollectionListElement___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57e7f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57e7f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x20,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04002108 RID: 8456
		[Token(Token = "0x4002108")]
		private const int DECIMAL_TO_PERCENTAGE = 100;

		// Token: 0x04002109 RID: 8457
		[Token(Token = "0x4002109")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CollectionView _view;

		// Token: 0x0400210A RID: 8458
		[Token(Token = "0x400210A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _maxLevelText;

		// Token: 0x0400210B RID: 8459
		[Token(Token = "0x400210B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _upgradeButton;

		// Token: 0x0400210C RID: 8460
		[Token(Token = "0x400210C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Image _progressBar;

		// Token: 0x0400210D RID: 8461
		[Token(Token = "0x400210D")]
		[FieldOffset(Offset = "0x30")]
		private IGuideTarget _guideTarget;

		// Token: 0x020009C4 RID: 2500
		[Token(Token = "0x20009C4")]
		public class CollectionListElementArgs : GenericListElementArgs
		{
			// Token: 0x14000190 RID: 400
			// (add) Token: 0x06003BEC RID: 15340 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06003BED RID: 15341 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x14000190")]
			public event Action DataChangedEvent
			{
				[Token(Token = "0x6003BEC")]
				[Address(RVA = "0x8AC0", Offset = "0x8AC0", VA = "0x8AC0")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6003BED")]
				[Address(RVA = "0x8AC1", Offset = "0x8AC1", VA = "0x8AC1")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x06003BEE RID: 15342 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003BEE")]
			[Address(RVA = "0x8AC2", Offset = "0x8AC2", VA = "0x8AC2")]
			public void CallDataChangedEvent()
			{
			}

			// Token: 0x06003BEF RID: 15343 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003BEF")]
			[Address(RVA = "0x8AC3", Offset = "0x8AC3", VA = "0x8AC3")]
			public CollectionListElementArgs()
			{
			}

			// Token: 0x0400210E RID: 8462
			[Token(Token = "0x400210E")]
			[FieldOffset(Offset = "0xC")]
			public CollectionData CollectionData;

			// Token: 0x0400210F RID: 8463
			[Token(Token = "0x400210F")]
			[FieldOffset(Offset = "0x10")]
			public Action<CollectionListElement.CollectionListElementArgs> ClickEventHandler;

			// Token: 0x04002110 RID: 8464
			[Token(Token = "0x4002110")]
			[FieldOffset(Offset = "0x14")]
			public bool SameUser;

			// Token: 0x04002111 RID: 8465
			[Token(Token = "0x4002111")]
			[FieldOffset(Offset = "0x18")]
			public UserData Owner;

			// Token: 0x04002112 RID: 8466
			[Token(Token = "0x4002112")]
			[FieldOffset(Offset = "0x1C")]
			public float Progress;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GuideTarget ---
		void Gameplay_Collections_View_CollectionListElement__get_GuideTarget
		               (int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a57e73 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_View_CollectionListElement_DataChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs__set_args__
		              );
		    DAT_ram_00a57e73 = '\x01';
		  }
		  iVar6 = *(int *)(param1 + 0x18);
		  if (iVar6 != 0) {
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Collections_View_CollectionListElement_DataChangedEventHandler__,0);
		    if (DAT_ram_00a57e80 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a57e80 = '\x01';
		    }
		    iVar5 = *(int *)(iVar6 + 0x20);
		    do {
		      piVar4 = (int *)func_ii_7048(iVar5,uVar3,0);
		      if ((piVar4 != (int *)0x0) && (System_Action_TypeInfo != *piVar4)) {
		        System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(iVar6 + 0x20,piVar4,iVar5);
		      bVar1 = iVar2 != iVar5;
		      iVar5 = iVar2;
		    } while (bVar1);
		  }
		  *(int *)(param1 + 0x18) = param2;
		  if (param2 != 0) {
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Collections_View_CollectionListElement_DataChangedEventHandler__,0);
		    if (DAT_ram_00a57e7f == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a57e7f = '\x01';
		    }
		    iVar6 = *(int *)(param2 + 0x20);
		    do {
		      piVar4 = (int *)UnityEngine_UI_Image__set_sprite(iVar6,uVar3,0);
		      if ((piVar4 != (int *)0x0) && (System_Action_TypeInfo != *piVar4)) {
		        System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar5 = func_ii_4329(param2 + 0x20,piVar4,iVar6);
		      bVar1 = iVar5 != iVar6;
		      iVar6 = iVar5;
		    } while (bVar1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Args ---
		undefined4 Gameplay_Collections_View_CollectionListElement__set_Args(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57e74 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs__get_args__
		              );
		    DAT_ram_00a57e74 = '\x01';
		  }
		  return *(undefined4 *)(param1 + 0x18);
		}
		*/


		/* --- GHIDRA: get_Data ---
		void Gameplay_Collections_View_CollectionListElement__get_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57e75 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs__get_Initted__
		              );
		    DAT_ram_00a57e75 = '\x01';
		  }
		  if (*(char *)(param1 + 0x1c) == '\0') {
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (param1,param2,
		               Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs__Init__
		              );
		    return;
		  }
		  Gameplay_Collections_View_CollectionListElement__get_GuideTarget(param1,param2,param1);
		  Gameplay_Collections_View_CollectionListElement__OnInit(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_Collections_View_CollectionListElement__set_Data(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57e76 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_View_CollectionListElement_OnClickEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_View_CollectionListElement_UpgradeButtonClicked__);
		    Mono_Security_ASN1__get_Item
		              (&
		               UnityEngine_Events_UnityAction_CollectionListElement_CollectionListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UnityEngine_Events_UnityEvent_CollectionListElement_CollectionListElementArgs__AddListener__
		              );
		    DAT_ram_00a57e76 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = unnamed_function_1417
		                    (
		                    UnityEngine_Events_UnityAction_CollectionListElement_CollectionListElementArgs__TypeInfo
		                    );
		  func_ii_7054(uVar1,param1,
		               Method_Gameplay_Collections_View_CollectionListElement_OnClickEventHandler__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar2,uVar1,
		             Method_UnityEngine_Events_UnityEvent_CollectionListElement_CollectionListElementArgs__AddListener__
		            );
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Collections_View_CollectionListElement_UpgradeButtonClicked__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

}
