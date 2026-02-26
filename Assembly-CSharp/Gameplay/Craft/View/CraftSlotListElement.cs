using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Craft;
using Protocol.Dic;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Craft.View
{
	// Token: 0x020008B2 RID: 2226
	[Token(Token = "0x20008B2")]
	public class CraftSlotListElement : MonoBehaviourWithStates<CraftSlotListElement.State>
	{
		// Token: 0x1400016F RID: 367
		// (add) Token: 0x06003447 RID: 13383 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003448 RID: 13384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400016F")]
		public event Action<CraftSlotListElement> SelectedEvent
		{
			[Token(Token = "0x6003447")]
			[Address(RVA = "0x8474", Offset = "0x8474", VA = "0x8474")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003448")]
			[Address(RVA = "0x8475", Offset = "0x8475", VA = "0x8475")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06003449 RID: 13385 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600344A RID: 13386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5E")]
		public UserCraftSlotInfo SlotInfo
		{
			[Token(Token = "0x6003449")]
			[Address(RVA = "0x8476", Offset = "0x8476", VA = "0x8476")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600344A")]
			[Address(RVA = "0x8477", Offset = "0x8477", VA = "0x8477")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x0600344B RID: 13387 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600344C RID: 13388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5F")]
		public CraftSlotDic Dic
		{
			[Token(Token = "0x600344B")]
			[Address(RVA = "0x8478", Offset = "0x8478", VA = "0x8478")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600344C")]
			[Address(RVA = "0x8479", Offset = "0x8479", VA = "0x8479")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x0600344D RID: 13389 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600344E RID: 13390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A60")]
		public CraftSchemeData.CraftSchemeInfo SchemeInfo
		{
			[Token(Token = "0x600344D")]
			[Address(RVA = "0x847A", Offset = "0x847A", VA = "0x847A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600344E")]
			[Address(RVA = "0x847B", Offset = "0x847B", VA = "0x847B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x0600344F RID: 13391 RVA: 0x0000AA40 File Offset: 0x00008C40
		// (set) Token: 0x06003450 RID: 13392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A61")]
		public bool ManufactureSlot
		{
			[Token(Token = "0x600344F")]
			[Address(RVA = "0x847C", Offset = "0x847C", VA = "0x847C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003450")]
			[Address(RVA = "0x847D", Offset = "0x847D", VA = "0x847D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003451")]
		[Address(RVA = "0x847E", Offset = "0x847E", VA = "0x847E")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Craft_View_CraftSlotListElement__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57cf2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_View_CraftSlotListElement_ButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57cf2 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Craft_View_CraftSlotListElement_ButtonClickedEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  *(undefined4 *)(param1 + 0x40) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06003452 RID: 13394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003452")]
		[Address(RVA = "0x847F", Offset = "0x847F", VA = "0x847F")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Craft_View_CraftSlotListElement__OnDestroy
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0x40) = param3;
		  *(undefined4 *)(param1 + 0x48) = param2;
		  *(undefined1 *)(*(int *)(param1 + 0x2c) + 0x44) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06003453 RID: 13395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003453")]
		[Address(RVA = "0x8480", Offset = "0x8480", VA = "0x8480")]
		public void Init(CraftSlotDic dic, Action<CraftSlotListElement> selectCallback)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Craft_View_CraftSlotListElement__Init(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57cf3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_Image___);
		    DAT_ram_00a57cf3 = '\x01';
		  }
		  param1_00 = func_ii_6601(*(undefined4 *)(param1 + 0x34),
		                           Method_UnityEngine_GameObject_GetComponent_Image___);
		  func_ii_7050(param1_00,param2,0);
		  *(undefined1 *)(param1 + 0x50) = 1;
		  return;
		}
		*/

		}

		// Token: 0x06003454 RID: 13396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003454")]
		[Address(RVA = "0x8481", Offset = "0x8481", VA = "0x8481")]
		public void InitManufacture(Sprite manufactureBg)
		{
		/* --- GHIDRA: InitManufacture ---
		void Gameplay_Craft_View_CraftSlotListElement__InitManufacture
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x30),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003455 RID: 13397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003455")]
		[Address(RVA = "0x4499", Offset = "0x4499", VA = "0x4499")]
		public void FillWithData(CraftSchemeData.CraftSchemeInfo schemeInfo, UserCraftSlotInfo info)
		{
		/* --- GHIDRA: FillWithData ---
		void Gameplay_Craft_View_CraftSlotListElement__FillWithData(int param1,undefined4 param2)
		
		{
		  char cVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  
		  if (DAT_ram_00a57cf5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftSlotListElement_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4446);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4461);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4462);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4473);
		    DAT_ram_00a57cf5 = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,1,
		             Method_UI_MonoBehaviourWithStates_CraftSlotListElement_State__set_CurrentState__);
		  uVar3 = *(undefined4 *)(param1 + 0x20);
		  cVar1 = *(char *)(param1 + 0x50);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar4 = &StringLiteral_4462;
		  if (cVar1 == '\0') {
		    puVar4 = &StringLiteral_4461;
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar4,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  uVar3 = *(undefined4 *)(param1 + 0x24);
		  puVar4 = &StringLiteral_4446;
		  if (cVar1 == '\0') {
		    puVar4 = &StringLiteral_4473;
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar4,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003456 RID: 13398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003456")]
		[Address(RVA = "0x8482", Offset = "0x8482", VA = "0x8482")]
		public void Select(bool isSelected)
		{
		/* --- GHIDRA: Select ---
		void Gameplay_Craft_View_CraftSlotListElement__Select(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x40);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003457")]
		[Address(RVA = "0x8483", Offset = "0x8483", VA = "0x8483")]
		private void ButtonClickedEventHandler()
		{
		/* --- GHIDRA: ButtonClickedEventHandler ---
		void Gameplay_Craft_View_CraftSlotListElement__ButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57cf7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftSlotListElement_State___ctor__);
		    DAT_ram_00a57cf7 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_CraftSlotListElement_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003458 RID: 13400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003458")]
		[Address(RVA = "0x449A", Offset = "0x449A", VA = "0x449A")]
		public void DisplayInactiveSlot()
		{
		/* --- GHIDRA: DisplayInactiveSlot ---
		int * Gameplay_Craft_View_CraftSlotListElement__DisplayInactiveSlot(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003459 RID: 13401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003459")]
		[Address(RVA = "0x4497", Offset = "0x4497", VA = "0x4497")]
		public void DisplayEmptySlot(UserCraftSlotInfo slotInfo)
		{
		/* --- GHIDRA: DisplayEmptySlot ---
		undefined4
		Gameplay_Craft_View_CraftSlotListElement__DisplayEmptySlot
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63a28 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_CraftSchemeData_CraftSchemeInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__CraftSchemeData_CraftSchemeInfo__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__CraftSchemeData_CraftSchemeInfo__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__CraftSchemeData_CraftSchemeInfo__set_Item__
		              );
		    DAT_ram_00a63a28 = '\x01';
		  }
		  iVar1 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                    (*(undefined4 *)(param1 + 0x30),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__CraftSchemeData_CraftSchemeInfo__ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    param1_00 = *(undefined4 *)(param1 + 0x30);
		    param2_00 = *(undefined4 *)(param1 + 0x10);
		    uVar2 = unnamed_function_1417(Core_Data_CraftSchemeData_CraftSchemeInfo_TypeInfo);
		    Core_Data_CraftSchemeData___ctor(uVar2,param2_00,param2,0);
		    System_Collections_Generic_Dictionary_uint__object___get_Item
		              (param1_00,param2,uVar2,
		               Method_System_Collections_Generic_Dictionary_uint__CraftSchemeData_CraftSchemeInfo__set_Item__
		              );
		  }
		  uVar2 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1 + 0x30),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__CraftSchemeData_CraftSchemeInfo__get_Item__
		                    );
		  return uVar2;
		}
		*/

		}

		// Token: 0x0600345A RID: 13402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600345A")]
		[Address(RVA = "0x8484", Offset = "0x8484", VA = "0x8484")]
		public CraftSlotListElement()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Craft_View_CraftSlotListElement___ctor
		              (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  int iVar8;
		  undefined4 param2_00;
		  int *piVar9;
		  int iVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57cf8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_CraftSlotDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_CraftSlotDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_CraftSlotDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CraftSlotListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_CraftSlotListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57cf8 = '\x01';
		  }
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_CraftSlotDic__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e48d15;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_CraftSlotDic__TypeInfo
		                                ,0);
		code_r0x80e48d15:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar8 = unnamed_function_1417(System_Collections_Generic_List_CraftSlotListElement__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar8,uVar3,Method_System_Collections_Generic_List_CraftSlotListElement___ctor__);
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_CraftSlotDic__TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e48db3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_CraftSlotDic__TypeInfo
		                                ,0);
		code_r0x80e48db3:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80e48dec:
		  do {
		    piVar6 = local_4;
		    iVar10 = *local_4;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar10 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80e48e80;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e490ed:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e490f5;
		    }
		code_r0x80e48e80:
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e490ed;
		    if (iVar10 == 0) goto code_r0x80e4913e;
		    iVar10 = *local_4;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_CraftSlotDic__TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar10 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80e48f5d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_CraftSlotDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e490c5:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e490f5;
		    }
		code_r0x80e48f5d:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e490c5;
		    uVar7 = *(undefined4 *)(param1 + 0x14);
		    param2_00 = *(undefined4 *)(param1 + 0x10);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e490f5;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00,uVar7,
		                       Method_UnityEngine_Object_Instantiate_CraftSlotListElement___);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e490f5;
		    }
		    *(undefined4 *)(iVar5 + 0x40) = param3;
		    *(undefined4 *)(iVar5 + 0x48) = uVar3;
		    *(undefined1 *)(*(int *)(iVar5 + 0x2c) + 0x44) = 0;
		    iVar10 = Method_System_Collections_Generic_List_CraftSlotListElement__Add__;
		    *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar8 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		      *(uint *)(iVar8 + 0xc) = uVar1 + 1;
		      *(int *)(*(int *)(iVar8 + 8) + uVar1 * 4 + 0x10) = iVar5;
		      goto code_r0x80e48dec;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,iVar5,
		               *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar10 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e490f5:
		  iVar10 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_c = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		code_r0x80e4913e:
		      DAT_ram_009d3e38 = 0;
		      piVar6 = *local_8;
		      if (piVar6 != (int *)0x0) {
		        uVar1 = 0;
		        iVar10 = *piVar6;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x80e491b9;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x80e491b9:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (local_c == 0) {
		        iVar10 = System_Linq_Enumerable__ToList_object_
		                           (iVar8,0,
		                            Method_System_Collections_Generic_List_CraftSlotListElement__get_Item__)
		        ;
		        uVar3 = *(undefined4 *)(param1 + 0x18);
		        if (DAT_ram_00a57cf3 == '\0') {
		          Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_Image___);
		          DAT_ram_00a57cf3 = '\x01';
		        }
		        uVar7 = func_ii_6601(*(undefined4 *)(iVar10 + 0x34),
		                             Method_UnityEngine_GameObject_GetComponent_Image___);
		        func_ii_7050(uVar7,uVar3,0);
		        *(undefined1 *)(iVar10 + 0x50) = 1;
		        return iVar8;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x4e,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04001C7A RID: 7290
		[Token(Token = "0x4001C7A")]
		private const string LOCALIZATION_OPEN_EXTRA_SLOT = "CRAFT/OPEN_EXTRA_SLOT";

		// Token: 0x04001C7B RID: 7291
		[Token(Token = "0x4001C7B")]
		private const string LOCALIZATION_INACTIVE_SLOT = "CRAFT/INACTIVE_SLOT";

		// Token: 0x04001C7C RID: 7292
		[Token(Token = "0x4001C7C")]
		private const string LOCALIZATION_ACTIVE_SLOT = "CRAFT/ACTIVE_SLOT";

		// Token: 0x04001C7D RID: 7293
		[Token(Token = "0x4001C7D")]
		private const string LOCALIZATION_CHOOSE_RECIPE = "CRAFT/CHOOSE_RECIPE";

		// Token: 0x04001C7E RID: 7294
		[Token(Token = "0x4001C7E")]
		private const string LOCALIZATION_MANUFACTURE_SLOT = "CRAFT/MANUFACTURE_SLOT";

		// Token: 0x04001C7F RID: 7295
		[Token(Token = "0x4001C7F")]
		private const string LOCALIZATION_STACK_PRODUCTION_AVAILABLE = "CRAFT/STACK_PRODUCTION_AVALIABLE";

		// Token: 0x04001C80 RID: 7296
		[Token(Token = "0x4001C80")]
		private const string LOCALIZATION_ACTIVATE_MANUFACTURE_ANNOTATION = "CRAFT/ACTIVATE_MANUFACTURE_ANNOTATION";

		// Token: 0x04001C81 RID: 7297
		[Token(Token = "0x4001C81")]
		private const string LOCALIZATION_MANUFACTURING = "CRAFT/MANUFACTURING";

		// Token: 0x04001C82 RID: 7298
		[Token(Token = "0x4001C82")]
		private const string LOCALIZATION_MANUFACTURING_COMPLETE = "CRAFT/MANUFACTURING_COMPLETE";

		// Token: 0x04001C83 RID: 7299
		[Token(Token = "0x4001C83")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _button;

		// Token: 0x04001C84 RID: 7300
		[Token(Token = "0x4001C84")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001C85 RID: 7301
		[Token(Token = "0x4001C85")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001C86 RID: 7302
		[Token(Token = "0x4001C86")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _statusText;

		// Token: 0x04001C87 RID: 7303
		[Token(Token = "0x4001C87")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x04001C88 RID: 7304
		[Token(Token = "0x4001C88")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectedImage;

		// Token: 0x04001C89 RID: 7305
		[Token(Token = "0x4001C89")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private GameObject _bg;

		// Token: 0x04001C8A RID: 7306
		[Token(Token = "0x4001C8A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _quantity;

		// Token: 0x04001C8B RID: 7307
		[Token(Token = "0x4001C8B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BacktimeViewUGUI _timer;

		// Token: 0x020008B3 RID: 2227
		[Token(Token = "0x20008B3")]
		public enum State
		{
			// Token: 0x04001C92 RID: 7314
			[Token(Token = "0x4001C92")]
			UNKNOWN_STATE,
			// Token: 0x04001C93 RID: 7315
			[Token(Token = "0x4001C93")]
			INACTIVE,
			// Token: 0x04001C94 RID: 7316
			[Token(Token = "0x4001C94")]
			EMPTY,
			// Token: 0x04001C95 RID: 7317
			[Token(Token = "0x4001C95")]
			FILLED
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SelectedEvent ---
		void Gameplay_Craft_View_CraftSlotListElement__add_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57cf0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CraftSlotListElement__TypeInfo);
		    DAT_ram_00a57cf0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_CraftSlotListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CraftSlotListElement__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
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


		/* --- GHIDRA: set_ManufactureSlot ---
		void Gameplay_Craft_View_CraftSlotListElement__set_ManufactureSlot(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57cf1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_View_CraftSlotListElement_ButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57cf1 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Craft_View_CraftSlotListElement_ButtonClickedEventHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
