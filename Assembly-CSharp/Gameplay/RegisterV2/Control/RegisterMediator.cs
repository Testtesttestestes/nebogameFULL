using System;
using Gameplay.RegisterV2.Events;
using Gameplay.RegisterV2.Model;
using Gameplay.RegisterV2.View;
using Gameplay.RegisterV2.View.GenderSelector;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth2;
using Protocol.Dic;
using UnityEngine.EventSystems;

namespace Gameplay.RegisterV2.Control
{
	// Token: 0x02000570 RID: 1392
	[Token(Token = "0x2000570")]
	public class RegisterMediator : AbstractViewMediator<RegisterModel, RegisterEvents, RegisterController, RegistrationView>
	{
		// Token: 0x06002178 RID: 8568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002178")]
		[Address(RVA = "0x72D7", Offset = "0x72D7", VA = "0x72D7")]
		public RegisterMediator(RegisterModel model, RegisterEvents events, RegisterController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_RegisterV2_Control_RegisterMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58395 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RegisterModel__RegisterEvents__RegisterController__RegistrationView__set_View__
		              );
		    DAT_ram_00a58395 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_RegisterV2_Control_RegisterMediator__SetupEvents(param1,uVar1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_RegisterV2_Control_RegisterMediator__ResetView(param1,uVar1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700061F RID: 1567
		// (set) Token: 0x06002179 RID: 8569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700061F")]
		public override RegistrationView View
		{
			[Token(Token = "0x6002179")]
			[Address(RVA = "0x72D8", Offset = "0x72D8", VA = "0x72D8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000620 RID: 1568
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000620")]
		public override RegisterEvents Events
		{
			[Token(Token = "0x600217A")]
			[Address(RVA = "0x72D9", Offset = "0x72D9", VA = "0x72D9", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217B")]
		[Address(RVA = "0x72DA", Offset = "0x72DA", VA = "0x72DA")]
		private void ResetEvents(RegisterEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_RegisterV2_Control_RegisterMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58398 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_RepeatedField_string___RegisterCmd_Types_Result__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleGeneratedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleInitEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleInvalidNickErrorEvent__);
		    DAT_ram_00a58398 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param2 + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleInitEvent__,0);
		  piVar2 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 8) = 0;
		  }
		  else if ((*piVar2 != System_Action_TypeInfo) || (*(int **)(param2 + 8) = piVar2, *piVar2 != iVar3)
		          ) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(iVar3);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleGeneratedEvent__
		             ,0);
		  piVar2 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar2) ||
		          (*(int **)(param2 + 0x14) = piVar2, *piVar2 != iVar3)) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417
		                    (System_Action_RepeatedField_string___RegisterCmd_Types_Result__TypeInfo);
		  System_Action_object__int___Invoke
		            (uVar1,param1,
		             Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleInvalidNickErrorEvent__,0);
		  iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  uVar1 = System_Action_RepeatedField_string___RegisterCmd_Types_Result__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar3,System_Action_RepeatedField_string___RegisterCmd_Types_Result__TypeInfo
		                      );
		  if (iVar4 != 0) {
		    *(int *)(param2 + 0x1c) = iVar4;
		    uVar1 = System_Action_RepeatedField_string___RegisterCmd_Types_Result__TypeInfo;
		    iVar4 = func_ii_1082(iVar3,
		                         System_Action_RepeatedField_string___RegisterCmd_Types_Result__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar3,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar3,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217C")]
		[Address(RVA = "0x72DB", Offset = "0x72DB", VA = "0x72DB")]
		private void SetupEvents(RegisterEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_RegisterV2_Control_RegisterMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int *param1_01;
		  int iVar3;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a58399 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterMediator_GenerateNick__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleForegroundClickEvent__);
		    DAT_ram_00a58399 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_RegisterV2_Control_RegisterMediator_GenerateNick__,0);
		  if (DAT_ram_00a5835d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5835d = '\x01';
		  }
		  param1_00 = *(int *)(param2 + 0x84);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,uVar2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar3 = func_ii_4329(param2 + 0x84,param1_01,param1_00);
		    bVar1 = iVar3 == param1_00;
		    param1_00 = iVar3;
		    if (bVar1) {
		      param1_02 = *(undefined4 *)(param2 + 0x68);
		      uVar2 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar2,param1,
		                 Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleForegroundClickEvent__,0)
		      ;
		      Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(param1_02,uVar2,0);
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

		// Token: 0x0600217D RID: 8573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217D")]
		[Address(RVA = "0x72DC", Offset = "0x72DC", VA = "0x72DC")]
		private void ResetView(RegistrationView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_RegisterV2_Control_RegisterMediator__ResetView
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  double param4;
		  undefined4 uVar7;
		  int *piVar8;
		  int iVar9;
		  undefined4 uVar10;
		  int *piVar11;
		  uint uVar12;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5839a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RegisterModel__RegisterEvents__RegisterController__RegistrationView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__get_Current__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleForegroundClickEvent__);
		    DAT_ram_00a5839a = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar7 = *(undefined4 *)(param2 + 0x44);
		  piVar8 = *(int **)(*(int *)(param1 + 8) + 0x34);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar12 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8 + 4) * 8 + iVar9 + 0x178);
		        goto code_r0x80ed98cc;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar12);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ed98cc:
		  uVar1 = CONCAT44(in_register_20000014,puVar2[1]);
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,uVar1);
		  uVar10 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetPortalStagesCount
		                    (uVar3,*(undefined4 *)(*(int *)(param1 + 8) + 0xc),0);
		  uVar3 = Core_Extensions_Dict_TutorialStepDicExt__GetDialog(uVar3,0);
		  Gameplay_Tutorial_Guide_View_DevGuideStepEditorToolView___c___Start_b__25_0(uVar7,uVar3,0);
		  uVar7 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar7,0,0);
		  uVar12 = 0;
		  uVar7 = Gameplay_RegisterV2_View_CultSelector_CultSelectorListArgs___ctor
		                    (*(undefined4 *)(param1 + 8),0);
		  Gameplay_UserInfo_View_PatternTextInput__get_Pattern(*(undefined4 *)(param2 + 0x14),uVar7,0);
		  piVar8 = *(int **)(*(int *)(param1 + 8) + 0x10);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8 + 4) * 8 + iVar9 + 0xd0);
		        goto code_r0x80ed999c;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar12);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80ed999c:
		  uVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,CONCAT44(uVar10,puVar2[1]));
		  iVar9 = Core_Extensions_Dict_DictExt__GetCaveLevel(uVar7,1,0);
		  uVar7 = Core_Extensions_Dict_ResourceSetExt__Less(*(undefined4 *)(iVar9 + 0x1c),0.0,0);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,uVar7,Method_System_Collections_Generic_List_Resources__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21f,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ed9c3e;
		    }
		    if (iVar4 == 0) goto code_r0x80ed9c94;
		    uVar7 = local_8._4_4_;
		    piVar8 = *(int **)(*(int *)(param1 + 8) + 0x10);
		    iVar6 = *piVar8;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar12 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar6 + 0x58) + uVar12 * 8);
		        if (Core_Dict_IDictProvider_TypeInfo == *piVar11) {
		          puVar5 = (undefined4 *)(piVar11[1] * 8 + iVar6 + 0xd0);
		          goto code_r0x80ed9ae4;
		        }
		        uVar12 = uVar12 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar12);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,
		                        Core_Dict_IDictProvider_TypeInfo,2);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ed9c04:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ed9c3e;
		    }
		code_r0x80ed9ae4:
		    DAT_ram_009d3e38 = 0;
		    uVar10 = import::env::invoke_iii(*puVar5,piVar8,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ed9c04;
		    DAT_ram_009d3e38 = 0;
		    uVar10 = import::env::invoke_iiii
		                       (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x334,uVar10,uVar7,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ed9c3e;
		    }
		    DAT_ram_009d3e38 = 0;
		    param4 = func_ii_6906(*(undefined4 *)(iVar9 + 0x1c),uVar7,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ed9c3e;
		    }
		    uVar3 = *(undefined4 *)(param2 + 0x5c);
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x335,uVar10,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ed9c3e;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viidi
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x151,uVar3,uVar7,param4,iVar6);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar6 != 1);
		  uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ed9c3e:
		  iVar9 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar6) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar7);
		    iVar6 = *piVar8;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar6;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		      if (iVar6 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80ed9c94:
		      DAT_ram_009d3e38 = 0;
		      uVar10 = *(undefined4 *)(param2 + 0x68);
		      uVar7 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar7,param1,
		                 Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleForegroundClickEvent__,0)
		      ;
		      Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(uVar10,uVar7,0);
		      return;
		    }
		    uVar7 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x152,&local_18);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar7);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217E")]
		[Address(RVA = "0x72DD", Offset = "0x72DD", VA = "0x72DD")]
		private void SetupView(RegistrationView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_RegisterV2_Control_RegisterMediator__SetupView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Elements_Filters_GenericFilter_GenericFilterView__SelectElement
		            (*(undefined4 *)(iVar1 + 0x30),0xffffffff,0);
		  return;
		}
		*/

		}

		// Token: 0x0600217F RID: 8575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600217F")]
		[Address(RVA = "0x72DE", Offset = "0x72DE", VA = "0x72DE")]
		private void HandleForegroundClickEvent(PointerEventData data)
		{
		/* --- GHIDRA: HandleForegroundClickEvent ---
		void Gameplay_RegisterV2_Control_RegisterMediator__HandleForegroundClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  if (DAT_ram_00a5839b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RegisterModel__RegisterEvents__RegisterController__RegistrationView__get_Model__
		              );
		    DAT_ram_00a5839b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = *(int *)(param1[2] + 0x1c);
		  if (DAT_ram_00a5836a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5836a = '\x01';
		  }
		  if (param2_00 == 0) {
		    param2_00 = StringLiteral_5;
		  }
		  TMPro_TMP_InputField__get_text(*(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x10),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002180 RID: 8576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002180")]
		[Address(RVA = "0x72DF", Offset = "0x72DF", VA = "0x72DF")]
		private void HandleGeneratedEvent()
		{
		/* --- GHIDRA: HandleGeneratedEvent ---
		void Gameplay_RegisterV2_Control_RegisterMediator__HandleGeneratedEvent
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  uint param2_01;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5839c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15268);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15269);
		    DAT_ram_00a5839c = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x38),0);
		  param2_01 = (uint)(param3 == 0x66 || param3 == 1);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,param2_01,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,param2_01,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x44),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,param2_01,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(iVar2 + 0x44),0);
		  func_ii_8007(uVar3,0,0);
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(iVar2 + 0x44),0);
		  local_4 = 0;
		  local_10 = 0;
		  local_c = 0x4348b333c36cb333;
		  local_18 = 0x4348b333c36cb333;
		  DG_Tweening_ShortcutExtensions__DOMoveZ(uVar3,&local_18,0.0,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_View_PatternTextInput__get_Status(*(undefined4 *)(iVar2 + 0x14),1,0);
		  if (param3 == 0x66) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x38);
		    puVar1 = &StringLiteral_15269;
		    iVar2 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  else {
		    if (param3 != 1) {
		      return;
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x38);
		    puVar1 = &StringLiteral_15268;
		    iVar2 = *(int *)(Core_GameLocalization_TypeInfo + 0x74);
		  }
		  if (iVar2 == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar1,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,param2_00,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_View_PatternTextInput__get_Status(*(undefined4 *)(iVar2 + 0x14),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06002181 RID: 8577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002181")]
		[Address(RVA = "0x72E0", Offset = "0x72E0", VA = "0x72E0")]
		private void HandleInvalidNickErrorEvent(RepeatedField<string> nickVariants, RegisterCmd.Types.Result result)
		{
		/* --- GHIDRA: HandleInvalidNickErrorEvent ---
		void Gameplay_RegisterV2_Control_RegisterMediator__HandleInvalidNickErrorEvent
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5839d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RegisterModel__RegisterEvents__RegisterController__RegistrationView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_CultDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterMediator_GenerateNick__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterMediator_OnCultChanged__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterMediator_OnNickChanged__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RegisterV2_Control_RegisterMediator_OnRegister__);
		    DAT_ram_00a5839d = '\x01';
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = unnamed_function_1417(System_Action_CultDic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,Method_Gameplay_RegisterV2_Control_RegisterMediator_OnCultChanged__,0);
		  if (DAT_ram_00a58352 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CultDic__TypeInfo);
		    DAT_ram_00a58352 = '\x01';
		  }
		  iVar8 = *(int *)(iVar4 + 0x70);
		  while( true ) {
		    iVar3 = 0;
		    iVar6 = UnityEngine_UI_Image__set_sprite(iVar8,uVar5,0);
		    uVar2 = System_Action_CultDic__TypeInfo;
		    if ((iVar6 != 0) && (iVar3 = func_ii_1082(iVar6,System_Action_CultDic__TypeInfo), iVar3 == 0))
		    break;
		    iVar3 = func_ii_4329(iVar4 + 0x70,iVar3,iVar8);
		    bVar1 = iVar3 == iVar8;
		    iVar8 = iVar3;
		    if (bVar1) {
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar5,param1,Method_Gameplay_RegisterV2_Control_RegisterMediator_OnRegister__,0);
		      if (DAT_ram_00a58354 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		        DAT_ram_00a58354 = '\x01';
		      }
		      iVar8 = *(int *)(iVar4 + 0x74);
		      while ((piVar7 = (int *)UnityEngine_UI_Image__set_sprite(iVar8,uVar5,0), piVar7 == (int *)0x0
		             || (System_Action_TypeInfo == *piVar7))) {
		        iVar3 = func_ii_4329(iVar4 + 0x74,piVar7,iVar8);
		        bVar1 = iVar3 == iVar8;
		        iVar8 = iVar3;
		        if (bVar1) {
		          iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          uVar5 = unnamed_function_1417(System_Action_string__TypeInfo);
		          UnityEngine_UIElements_VisualElement__get_layout
		                    (uVar5,param1,
		                     Method_Gameplay_RegisterV2_Control_RegisterMediator_OnNickChanged__,0);
		          if (DAT_ram_00a58358 == '\0') {
		            Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		            DAT_ram_00a58358 = '\x01';
		          }
		          iVar8 = *(int *)(iVar4 + 0x7c);
		          while( true ) {
		            iVar3 = 0;
		            iVar6 = UnityEngine_UI_Image__set_sprite(iVar8,uVar5,0);
		            uVar2 = System_Action_string__TypeInfo;
		            if ((iVar6 != 0) &&
		               (iVar3 = func_ii_1082(iVar6,System_Action_string__TypeInfo), iVar3 == 0)) break;
		            iVar3 = func_ii_4329(iVar4 + 0x7c,iVar3,iVar8);
		            bVar1 = iVar3 == iVar8;
		            iVar8 = iVar3;
		            if (bVar1) {
		              iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x15c));
		              uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		              UnityEngine_Events_UnityEvent__AddListener
		                        (uVar5,param1,
		                         Method_Gameplay_RegisterV2_Control_RegisterMediator_GenerateNick__,0);
		              if (DAT_ram_00a5835c == '\0') {
		                Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		                DAT_ram_00a5835c = '\x01';
		              }
		              iVar8 = *(int *)(iVar4 + 0x84);
		              while ((piVar7 = (int *)UnityEngine_UI_Image__set_sprite(iVar8,uVar5,0),
		                     piVar7 == (int *)0x0 || (System_Action_TypeInfo == *piVar7))) {
		                iVar3 = func_ii_4329(iVar4 + 0x84,piVar7,iVar8);
		                bVar1 = iVar3 == iVar8;
		                iVar8 = iVar3;
		                if (bVar1) {
		                  iVar4 = param1[2];
		                  if (DAT_ram_00a58384 == '\0') {
		                    Mono_Security_ASN1__get_Item
		                              (&
		                               Method_System_Collections_Generic_Dictionary_uint__List_AprDic___ContainsKey__
		                              );
		                    Mono_Security_ASN1__get_Item
		                              (&
		                               Method_System_Collections_Generic_Dictionary_uint__List_AprDic___get_Item__
		                              );
		                    DAT_ram_00a58384 = '\x01';
		                  }
		                  UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                            (*(undefined4 *)(iVar4 + 0x18),*(undefined4 *)(iVar4 + 0x24),
		                             Method_System_Collections_Generic_Dictionary_uint__List_AprDic___ContainsKey__
		                            );
		                  iVar4 = System_Collections_Generic_List_object___get_Item
		                                    (*(undefined4 *)(iVar4 + 0x18),*(undefined4 *)(iVar4 + 0x24),
		                                     Method_System_Collections_Generic_Dictionary_uint__List_AprDic___get_Item__
		                                    );
		                  iVar4 = UnityEngine_Random__Range(0,*(undefined4 *)(iVar4 + 0xc),0);
		                  param1[7] = iVar4;
		                  iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                    (param1,*(undefined4 *)(*param1 + 0x15c));
		                  iVar4 = *(int *)(param1[2] + 0x1c);
		                  if (DAT_ram_00a5836a == '\0') {
		                    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		                    DAT_ram_00a5836a = '\x01';
		                  }
		                  if (iVar4 == 0) {
		                    iVar4 = StringLiteral_5;
		                  }
		                  TMPro_TMP_InputField__get_text
		                            (*(undefined4 *)(*(int *)(iVar8 + 0x14) + 0x10),iVar4,0);
		                  iVar4 = *param1;
		                  uVar5 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x158) * 4))
		                                    (param1,*(undefined4 *)(iVar4 + 0x15c));
		                  Gameplay_RegisterV2_View_RegistrationView__DisposeMVC
		                            (uVar5,*(undefined4 *)(param1[2] + 0x14),iVar4);
		                  iVar4 = *param1;
		                  uVar5 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x158) * 4))
		                                    (param1,*(undefined4 *)(iVar4 + 0x15c));
		                  Gameplay_RegisterV2_View_RegistrationView__SetCults
		                            (uVar5,*(undefined4 *)(param1[2] + 0x24),iVar4);
		                  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                    (param1,*(undefined4 *)(*param1 + 0x15c));
		                  uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                                    (uVar5,0);
		                  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                            (uVar5,1,0);
		                  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                    (param1,*(undefined4 *)(*param1 + 0x15c));
		                  uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                                    (*(undefined4 *)(iVar4 + 0x44),0);
		                  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                            (uVar5,1,0);
		                  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                    (param1,*(undefined4 *)(*param1 + 0x15c));
		                  uVar5 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                                    (*(undefined4 *)(iVar4 + 0x44),0);
		                  func_ii_8007(uVar5,0,0);
		                  uVar5 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                                    (*(undefined4 *)(iVar4 + 0x44),0);
		                  local_4 = 0;
		                  local_10 = 0;
		                  local_c = 0xc38b800000000000;
		                  local_18 = 0xc38b800000000000;
		                  DG_Tweening_ShortcutExtensions__DOMoveZ(uVar5,&local_18,0.0,0,0);
		                  return;
		                }
		              }
		              System_Activator__CreateInstance(piVar7,System_Action_TypeInfo);
		              do {
		                halt_trap();
		              } while( true );
		            }
		          }
		          System_Activator__CreateInstance(iVar6,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      System_Activator__CreateInstance(piVar7,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(iVar6,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002182")]
		[Address(RVA = "0x72E1", Offset = "0x72E1", VA = "0x72E1")]
		private void HandleInitEvent()
		{
		/* --- GHIDRA: HandleInitEvent ---
		void Gameplay_RegisterV2_Control_RegisterMediator__HandleInitEvent(int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (DAT_ram_00a5838c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterController_OnNickGenerated__);
		    DAT_ram_00a5838c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param2_00,
		             Method_Gameplay_RegisterV2_Control_RegisterController_OnNickGenerated__,0);
		  Gameplay_RegisterV2_Control_RegisterController__OnNickGenerated(param2_00,0,param1_00,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x06002183 RID: 8579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002183")]
		[Address(RVA = "0x72E2", Offset = "0x72E2", VA = "0x72E2")]
		private void GenerateNick()
		{
		/* --- GHIDRA: GenerateNick ---
		void Gameplay_RegisterV2_Control_RegisterMediator__GenerateNick(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_RegisterV2_Control_RegisterController__SetNick(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002184 RID: 8580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002184")]
		[Address(RVA = "0x72E3", Offset = "0x72E3", VA = "0x72E3")]
		private void OnRegister()
		{
		/* --- GHIDRA: OnRegister ---
		void Gameplay_RegisterV2_Control_RegisterMediator__OnRegister
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5839e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RegisterModel__RegisterEvents__RegisterController__RegistrationView__get_Model__
		              );
		    DAT_ram_00a5839e = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		            (param2,1,0);
		  param1[6] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Gameplay_RegisterV2_View_GenderSelector_GenderListElement_GenderListElementArgs___ctor
		                    (*(undefined4 *)(iVar1 + 0x28),param1);
		  param1[7] = iVar1;
		  *(undefined4 *)(param1[2] + 0x28) = *(undefined4 *)(param2 + 0x1c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x2c);
		  param2_00 = UI_Wiki_WikiUriRouter__SetData(*(undefined4 *)(param2 + 0x1c),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002185 RID: 8581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002185")]
		[Address(RVA = "0x72E4", Offset = "0x72E4", VA = "0x72E4")]
		private void SelectGender(GenderListElement.GenderListElementArgs args)
		{
		/* --- GHIDRA: SelectGender ---
		void Gameplay_RegisterV2_Control_RegisterMediator__SelectGender(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a5839f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RegisterModel__RegisterEvents__RegisterController__RegistrationView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_AprDic__GenderListElement_GenderListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_GenderListElement_GenderListElementArgs___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_AprDic__GenderListElement_GenderListElementArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterMediator_ConstructGenderArgs__);
		    DAT_ram_00a5839f = '\x01';
		  }
		  iVar3 = param1[2];
		  if (DAT_ram_00a58384 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprDic___ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprDic___get_Item__);
		    DAT_ram_00a58384 = '\x01';
		  }
		  iVar1 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                    (*(undefined4 *)(iVar3 + 0x18),*(undefined4 *)(iVar3 + 0x24),
		                     Method_System_Collections_Generic_Dictionary_uint__List_AprDic___ContainsKey__)
		  ;
		  if (iVar1 != 0) {
		    uVar2 = System_Collections_Generic_List_object___get_Item
		                      (*(undefined4 *)(iVar3 + 0x18),*(undefined4 *)(iVar3 + 0x24),
		                       Method_System_Collections_Generic_Dictionary_uint__List_AprDic___get_Item__);
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Func_AprDic__GenderListElement_GenderListElementArgs__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (param1_00,param1,
		             Method_Gameplay_RegisterV2_Control_RegisterMediator_ConstructGenderArgs__,0);
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,param1_00,
		                     Method_System_Linq_Enumerable_Select_AprDic__GenderListElement_GenderListElementArgs___
		                    );
		  iVar3 = func_ii_6295(uVar2,
		                       Method_System_Linq_Enumerable_ToArray_GenderListElement_GenderListElementArgs___
		                      );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_RegisterV2_View_GenderSelector_GenderSelector__get_SelectedIndex
		            (*(undefined4 *)(iVar1 + 0x28),iVar3,param1);
		  Gameplay_RegisterV2_Control_RegisterMediator__OnRegister
		            (param1,*(undefined4 *)(iVar3 + param1[7] * 4 + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002186")]
		[Address(RVA = "0x72E5", Offset = "0x72E5", VA = "0x72E5")]
		private void UpdateGenderData()
		{
		/* --- GHIDRA: UpdateGenderData ---
		int Gameplay_RegisterV2_Control_RegisterMediator__UpdateGenderData
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a583a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GenderListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_RegisterV2_View_GenderSelector_GenderListElement_GenderListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_RegisterV2_Control_RegisterMediator_GenderListElementClickedEventHandler__
		              );
		    DAT_ram_00a583a0 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_RegisterV2_View_GenderSelector_GenderListElement_GenderListElementArgs_TypeInfo
		                        );
		  if (DAT_ram_00a58378 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_SelectableListElementArgs_GenderListElement___ctor__)
		    ;
		    DAT_ram_00a58378 = '\x01';
		  }
		  UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		            (param1_00,
		             Method_UI_Elements_GenericList_SelectableListElementArgs_GenderListElement___ctor__);
		  *(undefined4 *)(param1_00 + 0x1c) = param2;
		  param1_01 = unnamed_function_1417(System_Action_GenderListElement__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_RegisterV2_Control_RegisterMediator_GenderListElementClickedEventHandler__
		             ,0);
		  *(undefined4 *)(param1_00 + 0x18) = param1_01;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06002187 RID: 8583 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002187")]
		[Address(RVA = "0x72E6", Offset = "0x72E6", VA = "0x72E6")]
		private GenderListElement.GenderListElementArgs ConstructGenderArgs(AprDic dic)
		{
		/* --- GHIDRA: ConstructGenderArgs ---
		void Gameplay_RegisterV2_Control_RegisterMediator__ConstructGenderArgs
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a583a1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_GenderListElement_GenderListElementArgs__get_args__
		              );
		    DAT_ram_00a583a1 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_ClanMemberListElementArgs__get_Selected
		              (*(int *)(param1 + 0x18),0,0);
		  }
		  Gameplay_RegisterV2_Control_RegisterMediator__OnRegister
		            (param1,*(undefined4 *)(param2 + 0x18),param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002188")]
		[Address(RVA = "0x72E7", Offset = "0x72E7", VA = "0x72E7")]
		private void GenderListElementClickedEventHandler(GenderListElement element)
		{
		/* --- GHIDRA: GenderListElementClickedEventHandler ---
		void Gameplay_RegisterV2_Control_RegisterMediator__GenderListElementClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a583a2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RegisterModel__RegisterEvents__RegisterController__RegistrationView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_SpellDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_SpellDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_SpellDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_RegisterV2_Control_RegisterMediator___c__DisplayClass21_0__OnCultChanged_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_RegisterV2_Control_RegisterMediator___c__DisplayClass21_0_TypeInfo);
		    DAT_ram_00a583a2 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (Gameplay_RegisterV2_Control_RegisterMediator___c__DisplayClass21_0_TypeInfo);
		  *(int *)(iVar2 + 8) = param2;
		  *(undefined4 *)(param1[2] + 0x24) = *(undefined4 *)(param2 + 0xc);
		  Gameplay_RegisterV2_Control_RegisterMediator__SelectGender(param1,param2);
		  piVar5 = *(int **)(param1[2] + 0x10);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x80edacba;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80edacba:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar7 = *(undefined4 *)(iVar6 + 0x4c);
		  uVar4 = unnamed_function_1417(System_Func_SpellDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar4,iVar2,
		             Method_Gameplay_RegisterV2_Control_RegisterMediator___c__DisplayClass21_0__OnCultChanged_b__0__
		             ,0);
		  uVar4 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar7,uVar4,Method_System_Linq_Enumerable_Where_SpellDic___);
		  uVar4 = func_ii_6295(uVar4,Method_System_Linq_Enumerable_ToArray_SpellDic___);
		  uVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_RegisterV2_View_RegistrationView__SetEnableIncorrectNickMessage(uVar7,uVar4,uVar4);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar5 = *(int **)(iVar6 + 0x3c);
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetIconAssetId(*(undefined4 *)(iVar2 + 8),0);
		  iVar2 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar5,uVar4,*(undefined4 *)(iVar2 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002189")]
		[Address(RVA = "0x72E8", Offset = "0x72E8", VA = "0x72E8")]
		private void OnCultChanged(CultDic cultDic)
		{
		/* --- GHIDRA: OnCultChanged ---
		void Gameplay_RegisterV2_Control_RegisterMediator__OnCultChanged
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  uint param2_00;
		  undefined4 uVar3;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a583a3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RegisterModel__RegisterEvents__RegisterController__RegistrationView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_NickInputField_NickInputFiledStates__set_CurrentState__
		              );
		    DAT_ram_00a583a3 = '\x01';
		  }
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		  *(undefined4 *)(iVar2 + 0x1c) = param2;
		  param2_00 = System_Text_RegularExpressions_Regex__IsMatch
		                        (*(undefined4 *)(param1[2] + 0x40),param2,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x38),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,param2_00 ^ 1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,param2_00 ^ 1,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,param2_00,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(iVar2 + 0x44),0);
		  func_ii_8007(uVar3,0,0);
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(iVar2 + 0x44),0);
		  local_4 = 0;
		  local_10 = 0;
		  local_c = 0xc38b800000000000;
		  local_18 = 0xc38b800000000000;
		  DG_Tweening_ShortcutExtensions__DOMoveZ(uVar3,&local_18,0.0,0,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = 1;
		  if (param2_00 == 0) {
		    uVar3 = 2;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar2 + 0x40),uVar3,
		             Method_UI_MonoBehaviourWithStates_NickInputField_NickInputFiledStates__set_CurrentState__
		            );
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x44),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  if ((param2_00 == 0) &&
		     (iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                        (param2,0), iVar2 != 0)) {
		    Gameplay_RegisterV2_Control_RegisterMediator__OnNickChanged(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600218A RID: 8586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218A")]
		[Address(RVA = "0x72E9", Offset = "0x72E9", VA = "0x72E9")]
		private void OnNickChanged(string nick)
		{
		/* --- GHIDRA: OnNickChanged ---
		void Gameplay_RegisterV2_Control_RegisterMediator__OnNickChanged(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a583a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13131);
		    DAT_ram_00a583a4 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_View_PatternTextInput__get_Status(*(undefined4 *)(iVar1 + 0x14),1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 0x38);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13131,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,param2_00,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_UserInfo_View_PatternTextInput__get_Status(*(undefined4 *)(iVar1 + 0x14),0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x44),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(iVar1 + 0x44),0);
		  func_ii_8007(uVar2,0,0);
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(iVar1 + 0x44),0);
		  local_4 = 0;
		  local_10 = 0;
		  local_c = 0x4348b333c36cb333;
		  local_18 = 0x4348b333c36cb333;
		  DG_Tweening_ShortcutExtensions__DOMoveZ(uVar2,&local_18,0.0,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600218B RID: 8587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218B")]
		[Address(RVA = "0x72EA", Offset = "0x72EA", VA = "0x72EA")]
		private void HandleEmptyNick()
		{
		}

		// Token: 0x0400124C RID: 4684
		[Token(Token = "0x400124C")]
		[FieldOffset(Offset = "0x18")]
		private GenderListElement.GenderListElementArgs _selectedArgs;

		// Token: 0x0400124D RID: 4685
		[Token(Token = "0x400124D")]
		[FieldOffset(Offset = "0x1C")]
		private int _genderIndex;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_RegisterV2_Control_RegisterMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58396 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RegisterModel__RegisterEvents__RegisterController__RegistrationView__set_Events__
		              );
		    DAT_ram_00a58396 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    Gameplay_RegisterV2_Control_RegisterMediator__set_Events(param1,uVar2,param1);
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    Gameplay_RegisterV2_Control_RegisterMediator__ResetEvents(param1,uVar2,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_RegisterV2_Control_RegisterMediator__set_Events
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58397 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Action_RepeatedField_string___RegisterCmd_Types_Result__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleGeneratedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleInitEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleInvalidNickErrorEvent__);
		    DAT_ram_00a58397 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param2 + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleInitEvent__,0);
		  piVar2 = (int *)func_ii_7048(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 8) = 0;
		  }
		  else if ((*piVar2 != System_Action_TypeInfo) || (*(int **)(param2 + 8) = piVar2, *piVar2 != iVar3)
		          ) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(iVar3);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleGeneratedEvent__
		             ,0);
		  piVar2 = (int *)func_ii_7048(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar2) ||
		          (*(int **)(param2 + 0x14) = piVar2, *piVar2 != iVar3)) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417
		                    (System_Action_RepeatedField_string___RegisterCmd_Types_Result__TypeInfo);
		  System_Action_object__int___Invoke
		            (uVar1,param1,
		             Method_Gameplay_RegisterV2_Control_RegisterMediator_HandleInvalidNickErrorEvent__,0);
		  iVar3 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = System_Action_RepeatedField_string___RegisterCmd_Types_Result__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar3,System_Action_RepeatedField_string___RegisterCmd_Types_Result__TypeInfo
		                      );
		  if (iVar4 != 0) {
		    *(int *)(param2 + 0x1c) = iVar4;
		    uVar1 = System_Action_RepeatedField_string___RegisterCmd_Types_Result__TypeInfo;
		    iVar4 = func_ii_1082(iVar3,
		                         System_Action_RepeatedField_string___RegisterCmd_Types_Result__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar3,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar3,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
