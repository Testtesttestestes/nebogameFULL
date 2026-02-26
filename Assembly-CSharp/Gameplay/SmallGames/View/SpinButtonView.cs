using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.Buttons;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View
{
	// Token: 0x02000523 RID: 1315
	[Token(Token = "0x2000523")]
	public class SpinButtonView : MonoBehaviour
	{
		// Token: 0x14000139 RID: 313
		// (add) Token: 0x06001F4E RID: 8014 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001F4F RID: 8015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000139")]
		public event Action<uint> AttemptsCountChangedEvent
		{
			[Token(Token = "0x6001F4E")]
			[Address(RVA = "0x70B4", Offset = "0x70B4", VA = "0x70B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001F4F")]
			[Address(RVA = "0x70B5", Offset = "0x70B5", VA = "0x70B5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005B9")]
		public ButtonWithCost SpinButton
		{
			[Token(Token = "0x6001F50")]
			[Address(RVA = "0x70B6", Offset = "0x70B6", VA = "0x70B6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x00006600 File Offset: 0x00004800
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BA")]
		public uint AttemptsCount
		{
			[Token(Token = "0x6001F51")]
			[Address(RVA = "0x70B7", Offset = "0x70B7", VA = "0x70B7")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F52")]
			[Address(RVA = "0x70B8", Offset = "0x70B8", VA = "0x70B8")]
			set
			{
			}
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x00006618 File Offset: 0x00004818
		[Token(Token = "0x6001F53")]
		[Address(RVA = "0x70B9", Offset = "0x70B9", VA = "0x70B9")]
		private uint GetStep(uint currentCount)
		{
		/* --- GHIDRA: GetStep ---
		void Gameplay_SmallGames_View_SpinButtonView__GetStep(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58680 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_SmallGames_View_SpinButtonView_DecreaseCount__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_SmallGames_View_SpinButtonView_IncreaseCount__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58680 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_SmallGames_View_SpinButtonView_IncreaseCount__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_SmallGames_View_SpinButtonView_DecreaseCount__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

			return 0U;
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F54")]
		[Address(RVA = "0x70BA", Offset = "0x70BA", VA = "0x70BA")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_SmallGames_View_SpinButtonView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58681 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_SmallGames_View_SpinButtonView_DecreaseCount__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_SmallGames_View_SpinButtonView_IncreaseCount__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58681 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_SmallGames_View_SpinButtonView_IncreaseCount__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_SmallGames_View_SpinButtonView_DecreaseCount__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x38),0);
		  if (iVar2 != 0) {
		    Gameplay_SmallGames_View_SpinButtonView__PickerWindowOnSelectedEvent(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F55")]
		[Address(RVA = "0x70BB", Offset = "0x70BB", VA = "0x70BB")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_SmallGames_View_SpinButtonView__OnDestroy(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58682 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Last_SlotMachineDic_Types_StepRange___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_SlotMachineDic_Types_StepRange__get_Item__
		              );
		    DAT_ram_00a58682 = '\x01';
		  }
		  *(int *)(param1 + 0x28) = param2;
		  iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param2 + 0x10),0,
		                     Method_Google_Protobuf_Collections_RepeatedField_SlotMachineDic_Types_StepRange__get_Item__
		                    );
		  *(undefined4 *)(param1 + 0x2c) = *(undefined4 *)(iVar1 + 0xc);
		  iVar1 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(param2 + 0x10),
		                     Method_System_Linq_Enumerable_Last_SlotMachineDic_Types_StepRange___);
		  *(undefined4 *)(param1 + 0x30) = *(undefined4 *)(iVar1 + 0x10);
		  return;
		}
		*/

		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F56")]
		[Address(RVA = "0x70BC", Offset = "0x70BC", VA = "0x70BC")]
		public void Init(SlotMachineDic slotMachine)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_SmallGames_View_SpinButtonView__Init(int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  uint param2_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58683 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13838);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28682);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13834);
		    DAT_ram_00a58683 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  param2_00 = param2 ^ 1;
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(param1 + 0x10) + 0xb8),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  uVar2 = StringLiteral_13838;
		  uVar1 = StringLiteral_13834;
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  if (param2 == 0) {
		    uVar2 = uVar1;
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar2,1,0,1,0,0,0,0);
		  local_4 = *(undefined4 *)(param1 + 0x24);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28682,uVar1,uVar2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F57")]
		[Address(RVA = "0x70BD", Offset = "0x70BD", VA = "0x70BD")]
		public void AdjustUI(bool isFreeSpin)
		{
		/* --- GHIDRA: AdjustUI ---
		void Gameplay_SmallGames_View_SpinButtonView__AdjustUI(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  iVar1 = *(int *)(param1 + 0x34) + 1;
		  *(int *)(param1 + 0x34) = iVar1;
		  if (iVar1 < 3) {
		    param2_00 = *(int *)(param1 + 0x24);
		    iVar1 = Gameplay_SmallGames_View_SpinButtonView__set_AttemptsCount(param1,param2_00,param1);
		    Gameplay_SmallGames_View_SpinButtonView__get_AttemptsCount(param1,iVar1 + param2_00,param1);
		    return;
		  }
		  Gameplay_SmallGames_View_SpinButtonView__DecreaseCount(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F58")]
		[Address(RVA = "0x70BE", Offset = "0x70BE", VA = "0x70BE")]
		private void IncreaseCount()
		{
		/* --- GHIDRA: IncreaseCount ---
		void Gameplay_SmallGames_View_SpinButtonView__IncreaseCount(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x34) + 1;
		  *(int *)(param1 + 0x34) = iVar1;
		  if (iVar1 < 3) {
		    iVar1 = Gameplay_SmallGames_View_SpinButtonView__set_AttemptsCount
		                      (param1,*(int *)(param1 + 0x24) + -1,param1);
		    Gameplay_SmallGames_View_SpinButtonView__get_AttemptsCount
		              (param1,*(int *)(param1 + 0x24) - iVar1,param1);
		    return;
		  }
		  Gameplay_SmallGames_View_SpinButtonView__DecreaseCount(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F59")]
		[Address(RVA = "0x70BF", Offset = "0x70BF", VA = "0x70BF")]
		private void DecreaseCount()
		{
		/* --- GHIDRA: DecreaseCount ---
		void Gameplay_SmallGames_View_SpinButtonView__DecreaseCount(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  undefined4 uVar7;
		  int iVar8;
		  undefined4 uVar9;
		  int iVar10;
		  uint uVar11;
		  undefined4 uVar12;
		  undefined4 uVar13;
		  int *piVar14;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58684 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SpinPickerDialogWindow_SpinPickerDialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SpinPickerDialogWindow_SpinPickerDialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_SlotMachineDic_Types_StepRange__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SpinPickerDialogWindow_SpinPickerDialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SpinPickerDialogWindow_SpinPickerDialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SpinPickerDialogWindow_SpinPickerDialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_SlotMachineDic_Types_StepRange__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_View_SpinButtonView_PickerWindowOnClose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_View_SpinButtonView_PickerWindowOnSelectedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_View_SpinPickerDialogWindow_SpinPickerDialogWindowArgs_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_13846);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13845);
		    DAT_ram_00a58684 = '\x01';
		  }
		  uVar9 = *(undefined4 *)(param1 + 0x38);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar9,0,0);
		  if (iVar2 != 0) {
		    return;
		  }
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_uint__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_uint___ctor__);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(*(int *)(param1 + 0x28) + 0x10),
		                              Method_Google_Protobuf_Collections_RepeatedField_SlotMachineDic_Types_StepRange__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80f1bc89:
		  piVar5 = local_4;
		  iVar10 = *local_4;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar14 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar14) {
		        puVar3 = (undefined4 *)(iVar10 + piVar14[1] * 8 + 0xc0);
		        goto code_r0x80f1bd1d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_IEnumerator_TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80f1bef4:
		    DAT_ram_009d3e38 = 0;
		    uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80f1bf10;
		  }
		code_r0x80f1bd1d:
		  DAT_ram_009d3e38 = 0;
		  iVar10 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		  piVar5 = local_4;
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80f1bef4;
		  if (iVar10 == 0) {
		    iVar4 = 7;
		    iVar10 = 0;
		    goto code_r0x80f1bf5d;
		  }
		  iVar10 = *local_4;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar14 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		      if (System_Collections_Generic_IEnumerator_SlotMachineDic_Types_StepRange__TypeInfo ==
		          *piVar14) {
		        puVar3 = (undefined4 *)(iVar10 + piVar14[1] * 8 + 0xc0);
		        goto code_r0x80f1bdf7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_Generic_IEnumerator_SlotMachineDic_Types_StepRange__TypeInfo
		                      ,0);
		  if (DAT_ram_009d3e38 != 1) {
		code_r0x80f1bdf7:
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f1befe;
		    uVar1 = *(uint *)(iVar10 + 0xc);
		    if (uVar1 <= *(uint *)(iVar10 + 0x10)) {
		      do {
		        iVar4 = Method_System_Collections_Generic_List_uint__Add__;
		        *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		        uVar11 = *(uint *)(iVar2 + 0xc);
		        if (uVar11 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		          *(uint *)(iVar2 + 0xc) = uVar11 + 1;
		          *(uint *)(*(int *)(iVar2 + 8) + uVar11 * 4 + 0x10) = uVar1;
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x37a,iVar2,uVar1,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) {
		            uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80f1bf10;
		          }
		        }
		        uVar1 = *(int *)(iVar10 + 0x14) + uVar1;
		      } while (uVar1 <= *(uint *)(iVar10 + 0x10));
		    }
		    goto code_r0x80f1bc89;
		  }
		code_r0x80f1befe:
		  DAT_ram_009d3e38 = 0;
		  uVar9 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f1bf10:
		  iVar10 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar9);
		    iVar10 = *piVar5;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar10;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x80f1bf5d:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar8 = *local_4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f1bfd5;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f1bfd5:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (iVar10 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar4 != 0) {
		        if (iVar4 == 1) {
		          return;
		        }
		        if (iVar4 == 2) {
		          return;
		        }
		        if (iVar4 == 3) {
		          return;
		        }
		        if (iVar4 == 4) {
		          return;
		        }
		        if (iVar4 == 5) {
		          return;
		        }
		        if (iVar4 == 6) {
		          return;
		        }
		        if (iVar4 != 7) {
		          return;
		        }
		      }
		      uVar12 = *(undefined4 *)(param1 + 0x24);
		      uVar9 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                        (iVar2,Method_System_Collections_Generic_List_uint__ToArray__);
		      uVar13 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0x18);
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      uVar13 = Core_Money_Money__op_Explicit(uVar13,0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar1 = 0;
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar2 = *piVar5;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar6 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x140);
		            goto code_r0x80f1c0d1;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f1c0d1:
		      uVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      uVar7 = func_ii_7112(uVar7,0);
		      iVar2 = unnamed_function_1417
		                        (
		                        Gameplay_SmallGames_View_SpinPickerDialogWindow_SpinPickerDialogWindowArgs_TypeInfo
		                        );
		      Gameplay_SmallGames_View_SpinPickerDialogWindow___ctor(iVar2,uVar12,uVar9,uVar13,uVar7,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar9 = func_ii_7508(StringLiteral_13846,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar2 + 0x18) = uVar9;
		      uVar9 = func_ii_7508(StringLiteral_13845,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar2 + 0x1c) = uVar9;
		      iVar4 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SpinPickerDialogWindow_SpinPickerDialogWindowArgs___TypeInfo
		                        );
		      GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                (iVar4,
		                 Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SpinPickerDialogWindow_SpinPickerDialogWindowArgs____ctor__
		                );
		      iVar8 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SpinPickerDialogWindow_SpinPickerDialogWindowArgs__TypeInfo
		                        );
		      UI_Windows_DialogWindow_DialogWindowArgs___ctor
		                (iVar8,
		                 Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SpinPickerDialogWindow_SpinPickerDialogWindowArgs___ctor__
		                );
		      uVar9 = UI_Windows_DialogWindow__get_OK_LABEL(0);
		      *(undefined4 *)(iVar8 + 8) = uVar9;
		      iVar10 = 
		      Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_SpinPickerDialogWindow_SpinPickerDialogWindowArgs___Add__
		      ;
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      uVar1 = *(uint *)(iVar4 + 0xc);
		      if (uVar1 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		        *(uint *)(iVar4 + 0xc) = uVar1 + 1;
		        *(int *)(*(int *)(iVar4 + 8) + uVar1 * 4 + 0x10) = iVar8;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar4,iVar8,*(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		      }
		      *(int *)(iVar2 + 0x24) = iVar4;
		      uVar9 = Gameplay_SmallGames_View_SpinPickerDialogWindow__HandleContent(iVar2,0);
		      *(undefined4 *)(param1 + 0x38) = uVar9;
		      uVar12 = unnamed_function_1417(System_Action_uint__TypeInfo);
		      func_ii_12322(uVar12,param1,
		                    Method_Gameplay_SmallGames_View_SpinButtonView_PickerWindowOnSelectedEvent__,0);
		      Gameplay_SmallGames_View_SpinPickerDialogWindow__set_SelectedAttemptsNum(uVar9,uVar12,0);
		      uVar12 = *(undefined4 *)(param1 + 0x38);
		      uVar9 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar9,param1,Method_Gameplay_SmallGames_View_SpinButtonView_PickerWindowOnClose__,0
		                );
		      UI_Windows_BaseWindow__get_IsActiveResourceBar(uVar12,uVar9,0);
		      return;
		    }
		    uVar9 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 400,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(uVar9);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5A")]
		[Address(RVA = "0x70C0", Offset = "0x70C0", VA = "0x70C0")]
		private void ShowValuePicker()
		{
		/* --- GHIDRA: ShowValuePicker ---
		void Gameplay_SmallGames_View_SpinButtonView__ShowValuePicker
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_SmallGames_View_SpinButtonView__get_AttemptsCount(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5B")]
		[Address(RVA = "0x70C1", Offset = "0x70C1", VA = "0x70C1")]
		private void PickerWindowOnSelectedEvent(uint attemptsNum)
		{
		/* --- GHIDRA: PickerWindowOnSelectedEvent ---
		void Gameplay_SmallGames_View_SpinButtonView__PickerWindowOnSelectedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58685 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_View_SpinButtonView_PickerWindowOnClose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_View_SpinButtonView_PickerWindowOnSelectedEvent__);
		    DAT_ram_00a58685 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x38);
		  uVar1 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar1,param1,
		                Method_Gameplay_SmallGames_View_SpinButtonView_PickerWindowOnSelectedEvent__,0);
		  Gameplay_SmallGames_View_SpinPickerDialogWindow__add_SelectedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x38);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_SmallGames_View_SpinButtonView_PickerWindowOnClose__,0);
		  UI_Windows_BaseWindow__add_onClose(uVar2,uVar1,0);
		  *(undefined4 *)(param1 + 0x38) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5C")]
		[Address(RVA = "0x70C2", Offset = "0x70C2", VA = "0x70C2")]
		private void PickerWindowOnClose()
		{
		/* --- GHIDRA: PickerWindowOnClose ---
		void Gameplay_SmallGames_View_SpinButtonView__PickerWindowOnClose(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x2c) = 0x6400000001;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5D")]
		[Address(RVA = "0x70C3", Offset = "0x70C3", VA = "0x70C3")]
		public SpinButtonView()
		{
		}

		// Token: 0x04001106 RID: 4358
		[Token(Token = "0x4001106")]
		private const string LOCALIZATION_ATTEMPTS = "SMALL_GAMES/ATTEMPTS";

		// Token: 0x04001107 RID: 4359
		[Token(Token = "0x4001107")]
		private const string LOCALIZATION_FREE_ATTEMPTS = "SMALL_GAMES/FREE_ATTEMPTS";

		// Token: 0x04001108 RID: 4360
		[Token(Token = "0x4001108")]
		private const int CLICKS_TO_OPEN_VALUE_PICKER = 3;

		// Token: 0x04001109 RID: 4361
		[Token(Token = "0x4001109")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ButtonWithCost _spinButton;

		// Token: 0x0400110A RID: 4362
		[Token(Token = "0x400110A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _incrementButton;

		// Token: 0x0400110B RID: 4363
		[Token(Token = "0x400110B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _decrementButton;

		// Token: 0x0400110C RID: 4364
		[Token(Token = "0x400110C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _scrollCountText;

		// Token: 0x0400110E RID: 4366
		[Token(Token = "0x400110E")]
		[FieldOffset(Offset = "0x24")]
		private uint _attemptsCount;

		// Token: 0x0400110F RID: 4367
		[Token(Token = "0x400110F")]
		[FieldOffset(Offset = "0x28")]
		private SlotMachineDic _slotMachine;

		// Token: 0x04001110 RID: 4368
		[Token(Token = "0x4001110")]
		[FieldOffset(Offset = "0x2C")]
		private uint _min;

		// Token: 0x04001111 RID: 4369
		[Token(Token = "0x4001111")]
		[FieldOffset(Offset = "0x30")]
		private uint _max;

		// Token: 0x04001112 RID: 4370
		[Token(Token = "0x4001112")]
		[FieldOffset(Offset = "0x34")]
		private int _changeButtonClickNum;

		// Token: 0x04001113 RID: 4371
		[Token(Token = "0x4001113")]
		[FieldOffset(Offset = "0x38")]
		private SpinPickerDialogWindow _pickerWindow;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_AttemptsCountChangedEvent ---
		void Gameplay_SmallGames_View_SpinButtonView__add_AttemptsCountChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5867d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    DAT_ram_00a5867d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_uint__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_uint__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: get_AttemptsCount ---
		void Gameplay_SmallGames_View_SpinButtonView__get_AttemptsCount
		               (int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  undefined4 param1_00;
		  float fVar2;
		  int iVar3;
		  float fVar4;
		  float fVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5867e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28682);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13834);
		    DAT_ram_00a5867e = '\x01';
		  }
		  if (*(uint *)(param1 + 0x24) != param2) {
		    fVar5 = (float)param2;
		    fVar4 = (float)*(uint *)(param1 + 0x30);
		    if (fVar5 <= (float)*(uint *)(param1 + 0x30)) {
		      fVar4 = fVar5;
		    }
		    fVar2 = (float)*(uint *)(param1 + 0x2c);
		    if ((float)*(uint *)(param1 + 0x2c) <= fVar5) {
		      fVar2 = fVar4;
		    }
		    if (fVar2 < 4.2949673e+09 && 0.0 <= fVar2) {
		      iVar3 = (int)fVar2;
		    }
		    else {
		      iVar3 = 0;
		    }
		    *(int *)(param1 + 0x24) = iVar3;
		    param1_00 = *(undefined4 *)(param1 + 0x1c);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13834,1,0,1,0,0,0,0);
		    local_4 = *(undefined4 *)(param1 + 0x24);
		    param3_00 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_28682,uVar1,param3_00,0);
		    UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar1,0);
		    iVar3 = *(int *)(param1 + 0x20);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(param1 + 0x24),
		                 *(undefined4 *)(iVar3 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_AttemptsCount ---
		undefined4
		Gameplay_SmallGames_View_SpinButtonView__set_AttemptsCount
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5867f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_SlotMachineDic_Types_StepRange___);
		    Mono_Security_ASN1__get_Item(&System_Func_SlotMachineDic_Types_StepRange__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_View_SpinButtonView___c__DisplayClass21_0__GetStep_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_View_SpinButtonView___c__DisplayClass21_0_TypeInfo);
		    DAT_ram_00a5867f = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_SmallGames_View_SpinButtonView___c__DisplayClass21_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0x10);
		  uVar2 = unnamed_function_1417(System_Func_SlotMachineDic_Types_StepRange__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Gameplay_SmallGames_View_SpinButtonView___c__DisplayClass21_0__GetStep_b__0__,0)
		  ;
		  iVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar2,
		                     Method_System_Linq_Enumerable_FirstOrDefault_SlotMachineDic_Types_StepRange___)
		  ;
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(iVar1 + 0x14);
		  }
		  return uVar2;
		}
		*/

}
