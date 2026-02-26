using System;
using System.Collections.Generic;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Medals.Events;
using Gameplay.Medals.Model;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Medals.Controller
{
	// Token: 0x0200060A RID: 1546
	[Token(Token = "0x200060A")]
	public class MedalInfoViewMediator : AbstractViewMediator<MedalsModel, MedalsEvents, MedalsController, MedalInfoWindow>
	{
		// Token: 0x0600257C RID: 9596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600257C")]
		[Address(RVA = "0x76C1", Offset = "0x76C1", VA = "0x76C1")]
		public MedalInfoViewMediator(MedalsModel model, MedalsEvents events, MedalsController controller)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Medals_Controller_MedalInfoViewMediator___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57db1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2581);
		    DAT_ram_00a57db1 = '\x01';
		  }
		  iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0x24),0);
		  if (iVar1 == 0) {
		    return *(undefined4 *)(param1 + 0x24);
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2581,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1 + 0x24) = uVar2;
		  return uVar2;
		}
		*/

		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600257D RID: 9597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700070F")]
		private string DurationPrefix
		{
			[Token(Token = "0x600257D")]
			[Address(RVA = "0x76C2", Offset = "0x76C2", VA = "0x76C2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (set) Token: 0x0600257E RID: 9598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000710")]
		public override MedalInfoWindow View
		{
			[Token(Token = "0x600257E")]
			[Address(RVA = "0x76C3", Offset = "0x76C3", VA = "0x76C3", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600257F")]
		[Address(RVA = "0x76C4", Offset = "0x76C4", VA = "0x76C4")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Medals_Controller_MedalInfoViewMediator__Init
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a57db4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalInfoWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Medals_Events_MedalsEvents_MedalChangedEventDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalInfoViewMediator_MedalChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalInfoViewMediator_MedalRemovedEventHandler__);
		    DAT_ram_00a57db4 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Medals_Controller_MedalInfoViewMediator_MedalRemovedEventHandler__
		                  ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar4;
		      uVar2 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x14);
		    uVar2 = unnamed_function_1417
		                      (Gameplay_Medals_Events_MedalsEvents_MedalChangedEventDelegate_TypeInfo);
		    Gameplay_Medals_Events_MedalsEvents___ctor
		              (uVar2,param1,
		               Method_Gameplay_Medals_Controller_MedalInfoViewMediator_MedalChangedEventHandler__,
		               param1);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = Gameplay_Medals_Events_MedalsEvents_MedalChangedEventDelegate_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x14) = 0;
		    }
		    else if ((Gameplay_Medals_Events_MedalsEvents_MedalChangedEventDelegate_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x14) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar2,param1,
		                  Method_Gameplay_Medals_Controller_MedalInfoViewMediator_MedalRemovedEventHandler__
		                  ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_uint__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar4;
		      uVar2 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x14);
		    uVar2 = unnamed_function_1417
		                      (Gameplay_Medals_Events_MedalsEvents_MedalChangedEventDelegate_TypeInfo);
		    Gameplay_Medals_Events_MedalsEvents___ctor
		              (uVar2,param1,
		               Method_Gameplay_Medals_Controller_MedalInfoViewMediator_MedalChangedEventHandler__,
		               param1);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = Gameplay_Medals_Events_MedalsEvents_MedalChangedEventDelegate_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x14) = 0;
		      return;
		    }
		    if ((Gameplay_Medals_Events_MedalsEvents_MedalChangedEventDelegate_TypeInfo != *piVar5) ||
		       (*(int **)(iVar3 + 0x14) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000711 RID: 1809
		// (set) Token: 0x06002580 RID: 9600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000711")]
		public override MedalsEvents Events
		{
			[Token(Token = "0x6002580")]
			[Address(RVA = "0x76C5", Offset = "0x76C5", VA = "0x76C5", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002581")]
		[Address(RVA = "0x76C6", Offset = "0x76C6", VA = "0x76C6")]
		private void MedalChangedEventHandler(MedalData medalData, uint medalId)
		{
		/* --- GHIDRA: MedalChangedEventHandler ---
		void Gameplay_Medals_Controller_MedalInfoViewMediator__MedalChangedEventHandler
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  float param3_00;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57db5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalViewSelectable__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalViewSelectable__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalViewSelectable__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalViewSelectable__GetEnumerator__);
		    DAT_ram_00a57db5 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_List_MedalViewSelectable__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    do {
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar1 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                           Method_System_Collections_Generic_List_Enumerator_MedalViewSelectable__MoveNext__
		                          );
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e5fe37;
		        }
		        if (iVar1 == 0) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        iVar1 = local_8._4_4_;
		        iVar4 = **(int **)(local_8._4_4_ + 0x10);
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii
		                          (*(undefined4 *)(iVar4 + 0x130),*(int **)(local_8._4_4_ + 0x10),
		                           *(undefined4 *)(iVar4 + 0x134));
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e5fe37;
		        }
		      } while (*(int *)(*(int *)(iVar2 + 0x10) + 0xc) != param3);
		      piVar3 = *(int **)(iVar1 + 0x10);
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_iii
		                        (*(undefined4 *)(*piVar3 + 0x130),piVar3,*(undefined4 *)(*piVar3 + 0x134));
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e5fe37;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x89,param2,
		                         *(undefined4 *)(*(int *)(iVar1 + 0x10) + 0x20),0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e5fe1b;
		      *(char *)(piVar3 + 0x14) = (char)iVar4;
		      DAT_ram_009d3e38 = 0;
		      param3_00 = 0.0;
		      if (iVar4 == 0) {
		        param3_00 = 1.0;
		      }
		      import::env::invoke_vifi
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x8a,piVar3[9],param3_00,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e5fe1b;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vifi
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x8a,piVar3[10],param3_00,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e5fe1b;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vifi
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x8a,piVar3[0xb],param3_00,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e5fe1b;
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (*(undefined4 *)(*piVar3 + 0x130),piVar3,*(undefined4 *)(*piVar3 + 0x134));
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e5fe1b;
		    } while (iVar4 == 0);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x8b,piVar3,auStack_20);
		  } while (DAT_ram_009d3e38 != 1);
		code_r0x80e5fe1b:
		  DAT_ram_009d3e38 = 0;
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e5fe37:
		  iVar4 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		      if (iVar1 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x8c,&local_18);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 != 1) {
		    import::env::__resumeException(param1_00);
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

		// Token: 0x06002582 RID: 9602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002582")]
		[Address(RVA = "0x76C7", Offset = "0x76C7", VA = "0x76C7")]
		private void ValidateAchievedMedals(MedalData medalData, uint medalId)
		{
		/* --- GHIDRA: ValidateAchievedMedals ---
		void Gameplay_Medals_Controller_MedalInfoViewMediator__ValidateAchievedMedals
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined1 auStack_10 [12];
		  int local_4;
		  
		  if (DAT_ram_00a57db6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14326);
		    DAT_ram_00a57db6 = '\x01';
		  }
		  if (DAT_ram_00a57db7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_MedalData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalInfoViewMediator_HandleBuyMedalConfirmation__
		              );
		    DAT_ram_00a57db7 = '\x01';
		  }
		  local_4 = *(int *)(*(int *)(param1 + 8) + 0x24);
		  if (local_4 < 1) {
		    param1_00 = *(undefined4 *)(param1 + 0x20);
		    uVar1 = unnamed_function_1417(System_Action_MedalData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Medals_Controller_MedalInfoViewMediator_HandleBuyMedalConfirmation__,
		               0);
		    Gameplay_Medals_View_ConfirmBuyMedalWindow__HandleContent(param1_00,uVar1,auStack_10);
		  }
		  else {
		    uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar1 = func_ii_4419(StringLiteral_14326,uVar1,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002583")]
		[Address(RVA = "0x76C8", Offset = "0x76C8", VA = "0x76C8")]
		private void BuyButtonClickedEventHandler()
		{
		/* --- GHIDRA: BuyButtonClickedEventHandler ---
		uint Gameplay_Medals_Controller_MedalInfoViewMediator__BuyButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57db7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_MedalData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalInfoViewMediator_HandleBuyMedalConfirmation__
		              );
		    DAT_ram_00a57db7 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 8) + 0x24);
		  if (iVar1 < 1) {
		    param1_01 = *(undefined4 *)(param1 + 0x20);
		    param1_00 = unnamed_function_1417(System_Action_MedalData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_Medals_Controller_MedalInfoViewMediator_HandleBuyMedalConfirmation__,
		               0);
		    Gameplay_Medals_View_ConfirmBuyMedalWindow__HandleContent(param1_01,param1_00,param1);
		  }
		  return (uint)(iVar1 < 1);
		}
		*/

		}

		// Token: 0x06002584 RID: 9604 RVA: 0x00007278 File Offset: 0x00005478
		[Token(Token = "0x6002584")]
		[Address(RVA = "0x76C9", Offset = "0x76C9", VA = "0x76C9")]
		private bool TryShowBuyMedalConfirmation()
		{
		/* --- GHIDRA: TryShowBuyMedalConfirmation ---
		void Gameplay_Medals_Controller_MedalInfoViewMediator__TryShowBuyMedalConfirmation
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57db8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_MedalInfoViewMediator__HandleBuyMedalConfirmation_d__18___
		              );
		    DAT_ram_00a57db8 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_34,0);
		  local_18 = local_2c;
		  local_24 = 0xffffffff;
		  local_20 = local_34;
		  local_10 = param1;
		  local_c = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_LoggedManager__Register_d__52_
		            (&local_20,&local_24,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_MedalInfoViewMediator__HandleBuyMedalConfirmation_d__18___
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002585")]
		[Address(RVA = "0x76CA", Offset = "0x76CA", VA = "0x76CA")]
		private void HandleBuyMedalConfirmation(MedalData data)
		{
		/* --- GHIDRA: HandleBuyMedalConfirmation ---
		void Gameplay_Medals_Controller_MedalInfoViewMediator__HandleBuyMedalConfirmation
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param3_00;
		  
		  if (DAT_ram_00a57db9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    DAT_ram_00a57db9 = '\x01';
		  }
		  param3_00 = **(int **)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(param3_00 + 0x130) * 4))
		                    (*(int **)(param2 + 0x10),*(undefined4 *)(param3_00 + 0x134));
		  Gameplay_Medals_Controller_MedalInfoViewMediator__HandleCollectionView
		            (param1,*(undefined4 *)(*(int *)(iVar1 + 0x10) + 0x20),param3_00);
		  return;
		}
		*/

		}

		// Token: 0x06002586 RID: 9606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002586")]
		[Address(RVA = "0x76CB", Offset = "0x76CB", VA = "0x76CB")]
		private void MedalSelectedEventHandler(MedalViewSelectable medalView)
		{
		/* --- GHIDRA: MedalSelectedEventHandler ---
		void Gameplay_Medals_Controller_MedalInfoViewMediator__MedalSelectedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57dba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Item__);
		    DAT_ram_00a57dba = '\x01';
		  }
		  iVar1 = System_Collections_Generic_SortedList_uint__object___get_Count
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x20) + 8) + 8),
		                     *(undefined4 *)(param1 + 0x1c),
		                     Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Item__)
		  ;
		  Gameplay_Medals_Controller_MedalInfoViewMediator__MedalChangedEventHandler
		            (param1,*(undefined4 *)(param1 + 0x20),*(undefined4 *)(*(int *)(iVar1 + 0x10) + 0xc),
		             param1);
		  if (param2 == *(int *)(*(int *)(iVar1 + 0x10) + 0xc)) {
		    Gameplay_Medals_Controller_MedalInfoViewMediator__MedalRemovedEventHandler(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002587 RID: 9607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002587")]
		[Address(RVA = "0x76CC", Offset = "0x76CC", VA = "0x76CC")]
		private void MedalRemovedEventHandler(uint medalId)
		{
		/* --- GHIDRA: MedalRemovedEventHandler ---
		void Gameplay_Medals_Controller_MedalInfoViewMediator__MedalRemovedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  undefined4 param2_01;
		  float param2_02;
		  int iVar6;
		  
		  if (DAT_ram_00a57dbb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13144);
		    DAT_ram_00a57dbb = '\x01';
		  }
		  param2_00 = System_Collections_Generic_SortedList_uint__object___get_Count
		                        (*(undefined4 *)(*(int *)(param1[8] + 8) + 8),param1[7],
		                         Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Item__
		                        );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar6 = **(int **)(iVar1 + 0x48);
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x138) * 4))
		            (*(int **)(iVar1 + 0x48),param2_00,*(undefined4 *)(iVar6 + 0x13c));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  *(int *)(*(int *)(iVar1 + 0x48) + 0x48) = param1[8];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar4 = *(int **)(iVar1 + 0x48);
		  iVar1 = func_ii_7183(param1[8],*(undefined4 *)(*(int *)(param2_00 + 0x10) + 0x20),0);
		  *(char *)(piVar4 + 0x14) = (char)iVar1;
		  param2_02 = 0.0;
		  if (iVar1 == 0) {
		    param2_02 = 1.0;
		  }
		  Core_Data_MedalData__IsMedalAchieved(piVar4[9],param2_02,0);
		  Core_Data_MedalData__IsMedalAchieved(piVar4[10],param2_02,0);
		  Core_Data_MedalData__IsMedalAchieved(piVar4[0xb],param2_02,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x130) * 4))
		                    (piVar4,*(undefined4 *)(*piVar4 + 0x134));
		  if (iVar1 != 0) {
		    UI_RawImageWithGrayscale__SetGrayscale(piVar4,param1);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar4 = *(int **)(iVar1 + 0x3c);
		  uVar2 = func_ii_14054(*(undefined4 *)(param2_00 + 0x10),0);
		  iVar1 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = Gameplay_Medals_Controller_MedalInfoViewMediator__HandleSale(param1,param1);
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(iVar1 + 0x40),uVar2,0);
		  uVar5 = *(undefined4 *)(iVar1 + 0x50);
		  uVar3 = func_ii_4769(uVar2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar5,uVar3 ^ 1,0);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1[2] + 0xc),0);
		  uVar2 = Core_Extensions_Dict_DictExt__TryGetArtikulDismantleInfoDic
		                    (uVar2,*(undefined4 *)(*(int *)(param2_00 + 0x10) + 0x20),0);
		  uVar2 = Core_Extensions_Dict_MedalDicExt__GetMaxRank(uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (*(undefined4 *)(iVar1 + 0x4c),uVar2,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  uVar2 = *(undefined4 *)(*(int *)(param2_00 + 0x10) + 0x2c);
		  uVar5 = *(undefined4 *)(param1[2] + 0x10);
		  param2_01 = *(undefined4 *)(param1[2] + 8);
		  iVar1 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___ctor(iVar1,param2_01,uVar5,uVar2,0)
		  ;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_13144,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x24) = uVar2;
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Requirements_RequirementsView__get_Data(*(undefined4 *)(iVar6 + 0x60),iVar1,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar1 + 100);
		  uVar5 = *(undefined4 *)(*(int *)(param2_00 + 0x10) + 0x28);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  uVar5 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar5,0);
		  piVar4 = (int *)func_ii_7307(uVar2,uVar5,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xf0) * 4))(piVar4,*(undefined4 *)(*piVar4 + 0xf4));
		  Gameplay_Medals_Controller_MedalInfoViewMediator__GetFullDescription(param1,param2_00,param1);
		  Gameplay_Medals_Controller_MedalInfoViewMediator__HandlePrice(param1,param1);
		  Gameplay_Medals_Controller_MedalInfoViewMediator__HandleDurationView(param1,param2_00,param1);
		  if ((char)param1[0xc] != '\0') {
		    Gameplay_Medals_Controller_MedalInfoViewMediator__RenderCurrentMedal(param1,param2_00,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002588 RID: 9608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002588")]
		[Address(RVA = "0x76CD", Offset = "0x76CD", VA = "0x76CD")]
		private void RenderCurrentMedal()
		{
		/* --- GHIDRA: RenderCurrentMedal ---
		void Gameplay_Medals_Controller_MedalInfoViewMediator__RenderCurrentMedal
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 param1_00;
		  int iVar6;
		  uint uVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  uVar7 = 0;
		  if (DAT_ram_00a57dbc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalViewSelectable__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalViewSelectable__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalViewSelectable__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalViewSelectable__GetEnumerator__);
		    DAT_ram_00a57dbc = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if ((*(int *)(param1[2] + 0x10) == *(int *)(param1[2] + 8)) && ((char)param1[0xc] != '\0')) {
		    uVar7 = Core_Extensions_Dict_ResourceSetExt__GetDelta
		                      (*(undefined4 *)(*(int *)(param2 + 0x10) + 0x24),0);
		    uVar7 = uVar7 ^ 1;
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,param1[6],
		             Method_System_Collections_Generic_List_MedalViewSelectable__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  if (uVar7 == 0) {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_MedalViewSelectable__MoveNext__
		                        );
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e5f704;
		      }
		      if (iVar2 == 0) goto code_r0x80e5f75a;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,
		                 *(undefined4 *)(*(int *)(local_8._4_4_ + 0x10) + 0x3c),0,0);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		    } while (iVar5 != 1);
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_MedalViewSelectable__MoveNext__
		                        );
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e5f704;
		      }
		      if (iVar2 == 0) goto code_r0x80e5f75a;
		      piVar4 = *(int **)(local_8._4_4_ + 0x10);
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (*(undefined4 *)(*piVar4 + 0x130),piVar4,*(undefined4 *)(*piVar4 + 0x134));
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e5f704;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,piVar4[0xf],
		                 (uint)(*(int *)(param1[8] + 0x14) == *(int *)(*(int *)(iVar2 + 0x10) + 0x20)),0);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		    } while (iVar5 != 1);
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		code_r0x80e5f704:
		  iVar5 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e5f75a:
		      DAT_ram_009d3e38 = 0;
		      iVar2 = *(int *)(param1[8] + 0x14);
		      iVar6 = *(int *)(*(int *)(param2 + 0x10) + 0x20);
		      uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		      uVar7 = uVar7 & iVar2 == iVar6;
		      uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(*(int *)(iVar5 + 0x48) + 0x3c),uVar7,0);
		      uVar1 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x15c));
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		      uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar5 + 0x6c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,uVar7,0);
		      if (uVar7 != 0) {
		        iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x15c)));
		        Gameplay_DailyQuests_Controller_QuestsTriggerObserver_Quests___ctor
		                  (*(undefined4 *)(iVar5 + 0x6c),*(double *)(param1 + 10),1,0);
		      }
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x88,&local_18);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 == 1) {
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

		// Token: 0x06002589 RID: 9609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002589")]
		[Address(RVA = "0x76CE", Offset = "0x76CE", VA = "0x76CE")]
		private void HandleSale(MedalDicWrapper medal)
		{
		/* --- GHIDRA: HandleSale ---
		undefined4
		Gameplay_Medals_Controller_MedalInfoViewMediator__HandleSale(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 param3_00;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57dbd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21071);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10732);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25329);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27904);
		    DAT_ram_00a57dbd = '\x01';
		  }
		  iVar1 = System_Collections_Generic_SortedList_uint__object___get_Count
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x20) + 8) + 8),
		                     *(undefined4 *)(param1 + 0x1c),
		                     Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Item__)
		  ;
		  uVar2 = Core_Extensions_Dict_MedalDicExt__GetIconAssetId(*(undefined4 *)(iVar1 + 0x10),0);
		  param3 = System_Linq_Enumerable__Any_KeyValuePair_uint__object__
		                     (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x20) + 8) + 0x1c),0);
		  param3_00 = Gameplay_Inventory_View_Chest_MedalsCategoryData___ctor
		                        (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x20) + 8) + 0x14),0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10732,1,0,1,0,0,0,0);
		  param1_01 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_01,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_01,StringLiteral_25329,uVar2,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_01,StringLiteral_27904,param3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_01,StringLiteral_21071,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = Core_GameLocalization__GetTranslation(param1_00,param1_01,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x0600258A RID: 9610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600258A")]
		[Address(RVA = "0x76CF", Offset = "0x76CF", VA = "0x76CF")]
		private string GetFullDescription()
		{
		/* --- GHIDRA: GetFullDescription ---
		void Gameplay_Medals_Controller_MedalInfoViewMediator__GetFullDescription
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57dbe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a57dbe = '\x01';
		  }
		  iVar1 = Core_Data_MedalData__get_CurrentMedal(param1[8],0);
		  if (((iVar1 == param2) &&
		      (iVar1 = Core_Extensions_Dict_ResourceSetExt__GetDelta
		                         (*(undefined4 *)(*(int *)(param2 + 0x10) + 0x24),0), iVar1 == 0)) &&
		     (*(int *)(param1[2] + 8) == *(int *)(param1[2] + 0x10))) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar1 + 0x54),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,1,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = *(undefined4 *)(iVar1 + 0x58);
		    uVar3 = *(undefined4 *)(*(int *)(param2 + 0x10) + 0x24);
		    param2_00 = *(undefined4 *)(param1[2] + 0x10);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		    UI_Price_Price__SetColor(uVar2,param2_00,uVar3,0);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x54),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600258B")]
		[Address(RVA = "0x76D0", Offset = "0x76D0", VA = "0x76D0")]
		private void HandlePrice(MedalDicWrapper medal)
		{
		/* --- GHIDRA: HandlePrice ---
		void Gameplay_Medals_Controller_MedalInfoViewMediator__HandlePrice(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  int iVar1;
		  undefined4 uVar2;
		  float param2_00;
		  int param1_00;
		  undefined8 param1_01;
		  
		  if (DAT_ram_00a57dbf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalInfoViewMediator_FormatDuration__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a57dbf = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (CONCAT44(in_register_20000004,param1),*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(int *)(iVar1 + 0x68);
		  iVar1 = func_ii_8766(param1[8],0);
		  if ((*(longlong *)(*(int *)(iVar1 + 0x10) + 0x40) == 0) && (*(int *)(param1[8] + 0x1c) == 0)) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1_00,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		    return;
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1_00,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  iVar1 = *(int *)(param1[8] + 0x1c);
		  if (iVar1 != 0) {
		    if (*(int *)(param1_00 + 0x14) == 0) {
		      uVar2 = unnamed_function_1417(UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		      UI_AbstractBacktimeView___ctor
		                (uVar2,param1,
		                 Method_Gameplay_Medals_Controller_MedalInfoViewMediator_FormatDuration__,0);
		      *(undefined4 *)(param1_00 + 0x14) = uVar2;
		      iVar1 = *(int *)(param1[8] + 0x1c);
		    }
		    UI_Elements_RightPanel_TitleWithLevel__set_Level(param1_00,iVar1,0);
		    return;
		  }
		  iVar1 = func_ii_8766(param1[8],0);
		  param1_01 = *(undefined8 *)(*(int *)(iVar1 + 0x10) + 0x40);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_StringUtils___cctor(param1_01,0);
		  uVar2 = Gameplay_Medals_Controller_MedalInfoViewMediator__SelectMedalByRank
		                    (param1,param2_00,param1);
		  UI_AbstractBacktimeView__set_FormatBackTimeCallback(param1_00,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600258C RID: 9612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600258C")]
		[Address(RVA = "0x76D1", Offset = "0x76D1", VA = "0x76D1")]
		private void HandleDurationView()
		{
		/* --- GHIDRA: HandleDurationView ---
		void Gameplay_Medals_Controller_MedalInfoViewMediator__HandleDurationView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a57dc0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57dc0 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar2 + 0x70);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x280);
		        goto code_r0x80e5f47b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x38);
		code_r0x80e5f47b:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  Gameplay_Collections_View_CollectionRequirementsDisplay___c__DisplayClass13_0___UpdateInstance_b__0
		            (param1_00,param2,*(undefined4 *)(iVar2 + 0x20),0);
		  return;
		}
		*/

		}

		// Token: 0x0600258D RID: 9613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600258D")]
		[Address(RVA = "0x76D2", Offset = "0x76D2", VA = "0x76D2")]
		private void HandleCollectionView(MedalDicWrapper medal)
		{
		/* --- GHIDRA: HandleCollectionView ---
		void Gameplay_Medals_Controller_MedalInfoViewMediator__HandleCollectionView
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57dc1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalViewSelectable__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalViewSelectable__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalViewSelectable__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalViewSelectable__GetEnumerator__);
		    DAT_ram_00a57dc1 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  *(int *)(param1 + 0x1c) = param2;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_List_MedalViewSelectable__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_MedalViewSelectable__MoveNext__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e5ebfd;
		    }
		    if (iVar1 == 0) goto code_r0x80e5ec53;
		    iVar1 = local_8._4_4_;
		    iVar5 = **(int **)(local_8._4_4_ + 0x10);
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (*(undefined4 *)(iVar5 + 0x130),*(int **)(local_8._4_4_ + 0x10),
		                       *(undefined4 *)(iVar5 + 0x134));
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e5ebfd;
		    }
		    *(bool *)(iVar1 + 0x18) = *(int *)(*(int *)(iVar2 + 0x10) + 0x20) == param2;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,
		                       *(undefined4 *)(iVar1 + 0x14),0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar3,
		               (uint)*(byte *)(iVar1 + 0x18),0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e5ebfd:
		  iVar5 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar1) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar1 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      iVar5 = 0;
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e5ec53:
		      DAT_ram_009d3e38 = 0;
		      Gameplay_Medals_Controller_MedalInfoViewMediator__MedalRemovedEventHandler(param1,iVar5);
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x87,&local_18);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 == 1) {
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

		// Token: 0x0600258E RID: 9614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600258E")]
		[Address(RVA = "0x76D3", Offset = "0x76D3", VA = "0x76D3")]
		private void SelectMedalByRank(uint rankId)
		{
		/* --- GHIDRA: SelectMedalByRank ---
		undefined4
		Gameplay_Medals_Controller_MedalInfoViewMediator__SelectMedalByRank
		          (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57dc2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a57dc2 = '\x01';
		  }
		  if (DAT_ram_00a57db1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2581);
		    DAT_ram_00a57db1 = '\x01';
		  }
		  iVar1 = func_ii_4769(*(undefined4 *)(param1 + 0x24),0);
		  if (iVar1 == 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x24);
		  }
		  else {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2581,1,0,1,0,0,0,0);
		    *(undefined4 *)(param1 + 0x24) = uVar2;
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param3_00 = Utils_TimeUtils__DateFormat((double)param2,0);
		  uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar2,StringLiteral_118,param3_00,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x0600258F RID: 9615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600258F")]
		[Address(RVA = "0x76D4", Offset = "0x76D4", VA = "0x76D4")]
		private string FormatDuration(float rawValue)
		{
			return null;
		}

		// Token: 0x04001486 RID: 5254
		[Token(Token = "0x4001486")]
		[FieldOffset(Offset = "0x18")]
		private List<MedalViewSelectable> _medalViews;

		// Token: 0x04001487 RID: 5255
		[Token(Token = "0x4001487")]
		[FieldOffset(Offset = "0x1C")]
		private uint _selectedRank;

		// Token: 0x04001488 RID: 5256
		[Token(Token = "0x4001488")]
		[FieldOffset(Offset = "0x20")]
		private MedalData _medalData;

		// Token: 0x04001489 RID: 5257
		[Token(Token = "0x4001489")]
		[FieldOffset(Offset = "0x24")]
		private string _durationPrefix;

		// Token: 0x0400148A RID: 5258
		[Token(Token = "0x400148A")]
		[FieldOffset(Offset = "0x28")]
		private double _priceCoeff;

		// Token: 0x0400148B RID: 5259
		[Token(Token = "0x400148B")]
		[FieldOffset(Offset = "0x30")]
		private bool _saleEnabled;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DurationPrefix ---
		void Gameplay_Medals_Controller_MedalInfoViewMediator__get_DurationPrefix
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57db2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalInfoWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Medals_Controller_MedalInfoViewMediator_BuyButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57db2 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x54) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Medals_Controller_MedalInfoViewMediator_BuyButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x54) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Medals_Controller_MedalInfoViewMediator_BuyButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_Medals_Controller_MedalInfoViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Medals_Controller_MedalInfoViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_00;
		  uint *puVar4;
		  int *piVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a57db3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MedalsModel__MedalsEvents__MedalsController__MedalInfoWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_MedalViewSelectable__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_MedalInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Controller_MedalInfoViewMediator_MedalSelectedEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Keys__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10730);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26057);
		    DAT_ram_00a57db3 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(uVar1,Method_UI_Windows_BaseWindow_MedalInfoWindowArgs__get_WindowArgs__);
		  param1[8] = *(int *)(iVar2 + 0x1c);
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1[2] + 0xc),0);
		  iVar2 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar1,StringLiteral_26057,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar5 = *(int **)(iVar3 + 0x44);
		  if (*(int *)(*(int *)(*(int *)(param1[8] + 8) + 8) + 0x10) < 2) {
		    uVar1 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  else {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10730,1,0,1,0,0,0,0);
		  }
		  iVar3 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar5,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  uVar6 = *(uint *)(*(int *)(*(int *)(param1[8] + 8) + 0x14) + 0xc);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = param1[8];
		  param1_00 = unnamed_function_1417(System_Action_MedalViewSelectable__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Medals_Controller_MedalInfoViewMediator_MedalSelectedEventHandler__,0);
		  if ((longlong)iVar2 == (ulonglong)uVar6) {
		    iVar2 = Gameplay_Medals_View_MedalInfoWindow__DrawMedals(uVar1,iVar3,param1_00,param1);
		  }
		  else {
		    iVar2 = Gameplay_Medals_View_MedalInfoWindow__SetDescription(uVar1,iVar3,param1_00,param1);
		  }
		  param1[6] = iVar2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(uVar1,Method_UI_Windows_BaseWindow_MedalInfoWindowArgs__get_WindowArgs__);
		  iVar2 = *(int *)(iVar2 + 0x20);
		  param1[7] = iVar2;
		  if (iVar2 == 0) {
		    piVar5 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_IDictionary_get_Item
		                              (*(undefined4 *)(*(int *)(param1[8] + 8) + 8),
		                               Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Keys__
		                              );
		    iVar2 = *piVar5;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar6 = 0;
		      do {
		        if (System_Collections_Generic_IList_uint__TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar6 * 8)) {
		          puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar6 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e5e9f1;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar6);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,System_Collections_Generic_IList_uint__TypeInfo,0);
		code_r0x80e5e9f1:
		    iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,0,puVar4[1]);
		  }
		  param1[7] = iVar2;
		  Gameplay_Medals_Controller_MedalInfoViewMediator__HandleCollectionView(param1,param1[7],param1);
		  Gameplay_Medals_Controller_MedalInfoViewMediator__MedalRemovedEventHandler(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Medals_Controller_MedalInfoViewMediator__set_Events
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  if (param2 == *(int *)(param1 + 0x20)) {
		    Gameplay_Medals_Controller_MedalInfoViewMediator__HandleCollectionView
		              (param1,*(undefined4 *)(param2 + 0x10),param1);
		    Gameplay_Medals_Controller_MedalInfoViewMediator__MedalChangedEventHandler
		              (param1,param2,param3,param1);
		  }
		  return;
		}
		*/

}
