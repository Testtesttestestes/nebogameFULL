using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Skills;
using Gameplay.ArtifactComparer.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.ArtifactComparer.Controller
{
	// Token: 0x02000CEA RID: 3306
	[Token(Token = "0x2000CEA")]
	public class ArtifactComparerController : AbstractController<ArtifactComparerModel, ArtifactComparerEvents>
	{
		// Token: 0x06005069 RID: 20585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005069")]
		[Address(RVA = "0x9E7A", Offset = "0x9E7A", VA = "0x9E7A")]
		public ArtifactComparerController(ArtifactComparerModel model, ArtifactComparerEvents events)
		{
		/* --- GHIDRA: <RecalculateArtifactPower>g__SetArtifactPower|13_0 ---
		int Gameplay_ArtifactComparer_Controller_ArtifactComparerController___RecalculateArtifactPower_g__SetArtifactPower_13_0
		              (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint *puVar5;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a58a39 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__);
		    DAT_ram_00a58a39 = '\x01';
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(*(int *)(param2 + 0xc) + 0x14),
		                              Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar4 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(iVar6 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80f64cc6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f64d0e:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f64e92:
		      iVar7 = global_1;
		      iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar6) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar7 = *piVar4;
		        iVar6 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_c = iVar7;
		        import::env::invoke_v(0x123);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) break;
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x226,&local_c);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
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
		code_r0x80f64cc6:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar2,piVar4,puVar2[1]);
		    piVar4 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f64d0e;
		    if (iVar6 == 0) {
		      iVar6 = 0;
		      break;
		    }
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(iVar6 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80f64db3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f64e76:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f64e92;
		    }
		code_r0x80f64db3:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(*puVar2,piVar4,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f64e76;
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f64e92;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x225,
		                       *(undefined4 *)(iVar9 + 0x10),uVar3,0);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f64e92;
		    }
		  } while (iVar6 == 0);
		  piVar4 = local_4;
		  DAT_ram_009d3e38 = 0;
		  if (local_4 != (int *)0x0) {
		    uVar1 = 0;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f64f57;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f64f57:
		    (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		  }
		  if (iVar7 == 0) {
		    return iVar6;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerController___ctor
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a58a32 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_ArtifactReforgedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_InventoryChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_InventoryControllerInitEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_NewEquipEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_UserOnUserSkillsChangedEvent__
		              );
		    DAT_ram_00a58a32 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar5 = *(int *)(iVar1 + 0x14);
		  uVar6 = *(undefined4 *)(iVar5 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_InventoryChangedEvent__
		             ,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) ||
		          (*(int **)(iVar5 + 0x14) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar5 = *(int *)(iVar1 + 0x14);
		  uVar6 = *(undefined4 *)(iVar5 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_ArtifactData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_ArtifactReforgedEvent__
		             ,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		  uVar2 = System_Action_ArtifactData__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar5 + 0x20) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar1,System_Action_ArtifactData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar5 + 0x20) = iVar4;
		    uVar2 = System_Action_ArtifactData__TypeInfo;
		    iVar5 = func_ii_1082(iVar1,System_Action_ArtifactData__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar5 = *(int *)(iVar1 + 0x14);
		  uVar6 = *(undefined4 *)(iVar5 + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_InventoryControllerInitEvent__
		             ,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) || (*(int **)(iVar5 + 8) = piVar3, *piVar3 != iVar1))
		  {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar5 = *(int *)(iVar1 + 0x14);
		  uVar6 = *(undefined4 *)(iVar5 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_NewEquipEvent__,
		             0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x24) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) ||
		          (*(int **)(iVar5 + 0x24) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar6 = *(undefined4 *)(iVar1 + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_UserOnUserSkillsChangedEvent__
		             ,0);
		  Core_Data_UserData__remove_OnUserTreeLevelChangedEvent(uVar6,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600506A RID: 20586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506A")]
		[Address(RVA = "0x9E7B", Offset = "0x9E7B", VA = "0x9E7B", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerController__HandleRun
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerController__RecalculateTargetArtifactPowerIfNeeded
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600506B RID: 20587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506B")]
		[Address(RVA = "0x9E7C", Offset = "0x9E7C", VA = "0x9E7C")]
		private void ArtifactReforgedEvent(ArtifactData artifactData)
		{
		}

		// Token: 0x0600506C RID: 20588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506C")]
		[Address(RVA = "0x9E7D", Offset = "0x9E7D", VA = "0x9E7D")]
		private void NewEquipEvent()
		{
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506D")]
		[Address(RVA = "0x9E7E", Offset = "0x9E7E", VA = "0x9E7E")]
		private void InventoryControllerInitEvent()
		{
		/* --- GHIDRA: InventoryControllerInitEvent ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerController__InventoryControllerInitEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerController__RecalculateTargetArtifactPowerIfNeeded
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600506E RID: 20590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506E")]
		[Address(RVA = "0x9E7F", Offset = "0x9E7F", VA = "0x9E7F")]
		private void UserOnUserSkillsChangedEvent()
		{
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506F")]
		[Address(RVA = "0x9E80", Offset = "0x9E80", VA = "0x9E80")]
		private void InventoryChangedEvent()
		{
		/* --- GHIDRA: InventoryChangedEvent ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerController__InventoryChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a58a33 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_ArtifactReforgedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_InventoryChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_InventoryControllerInitEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_NewEquipEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_UserOnUserSkillsChangedEvent__
		              );
		    DAT_ram_00a58a33 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar5 = *(int *)(iVar1 + 0x14);
		  uVar6 = *(undefined4 *)(iVar5 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_InventoryChangedEvent__
		             ,0);
		  piVar3 = (int *)func_ii_7048(uVar6,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) ||
		          (*(int **)(iVar5 + 0x14) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar5 = *(int *)(iVar1 + 0x14);
		  uVar6 = *(undefined4 *)(iVar5 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_ArtifactData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_ArtifactReforgedEvent__
		             ,0);
		  iVar1 = func_ii_7048(uVar6,uVar2,0);
		  uVar2 = System_Action_ArtifactData__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar5 + 0x20) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar1,System_Action_ArtifactData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar5 + 0x20) = iVar4;
		    uVar2 = System_Action_ArtifactData__TypeInfo;
		    iVar5 = func_ii_1082(iVar1,System_Action_ArtifactData__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar5 = *(int *)(iVar1 + 0x14);
		  uVar6 = *(undefined4 *)(iVar5 + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_InventoryControllerInitEvent__
		             ,0);
		  piVar3 = (int *)func_ii_7048(uVar6,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) || (*(int **)(iVar5 + 8) = piVar3, *piVar3 != iVar1))
		  {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar5 = *(int *)(iVar1 + 0x14);
		  uVar6 = *(undefined4 *)(iVar5 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_NewEquipEvent__,
		             0);
		  piVar3 = (int *)func_ii_7048(uVar6,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x24) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) ||
		          (*(int **)(iVar5 + 0x24) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar6 = *(undefined4 *)(iVar1 + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_ArtifactComparer_Controller_ArtifactComparerController_UserOnUserSkillsChangedEvent__
		             ,0);
		  Core_Data_UserData__add_UserSkillsChangedEvent(uVar6,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06005070 RID: 20592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005070")]
		[Address(RVA = "0x9E81", Offset = "0x9E81", VA = "0x9E81", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerController__HandleStop
		               (int *param1,int *param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  uint uVar10;
		  undefined8 uVar11;
		  int local_30;
		  undefined8 *local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58a34 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_ArtifactComparer_Model_ComparedSkillData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_int__SkillData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_int__SkillData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_int__SkillData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_int__Contains__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_int__SkillData__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ComparedSkillData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ComparedSkillData___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ComparedSkillData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_int__SkillData__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_1072);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1145);
		    DAT_ram_00a58a34 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_ComparedSkillData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_ComparedSkillData___ctor__);
		  *param2 = iVar1;
		  *param3 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar9 = *(int *)(iVar1 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar9 == 0) {
		    uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x50),
		                       Method_System_Collections_Generic_Dictionary_int__SkillData__get_Values__);
		    System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		              (&local_10,uVar2,
		               Method_System_Collections_Generic_Dictionary_ValueCollection_int__SkillData__GetEnumerator__
		              );
		    local_30 = 0;
		    local_2c = &local_10;
		code_r0x80f636dd:
		    do {
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x152,&local_10,
		                           Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__MoveNext__
		                          );
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f64422;
		        }
		        iVar1 = local_30;
		        if (iVar9 == 0) goto code_r0x80f6446b;
		        DAT_ram_009d3e38 = 0;
		        iVar9 = local_8._4_4_;
		        iVar4 = func_ii_7588(local_8._4_4_,0);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f64422;
		        }
		      } while (iVar4 != 0);
		      iVar4 = *param2;
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         Gameplay_ArtifactComparer_Model_ComparedSkillData_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f63902:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64422;
		      }
		      DAT_ram_009d3e38 = 0;
		      Unity_Services_Core_Environments_Internal_Environments__get_Current
		                (iVar1,*(undefined4 *)(iVar9 + 8),0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f63902;
		      *(undefined8 *)(iVar1 + 0x10) = *(undefined8 *)(iVar9 + 0x10);
		      uVar11 = *(undefined8 *)(iVar9 + 0x18);
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		      *(undefined8 *)(iVar1 + 0x18) = uVar11;
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64422;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x220,
		                         *(undefined4 *)(iVar6 + 0x20),*(undefined4 *)(iVar9 + 8),
		                         Method_System_Collections_Generic_HashSet_int__Contains__);
		      if (DAT_ram_009d3e38 == 1) break;
		      *(char *)(iVar1 + 0x24) = (char)uVar2;
		      iVar9 = Method_System_Collections_Generic_List_ComparedSkillData__Add__;
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      uVar10 = *(uint *)(iVar4 + 0xc);
		      if (uVar10 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		        *(uint *)(iVar4 + 0xc) = uVar10 + 1;
		        *(int *)(*(int *)(iVar4 + 8) + uVar10 * 4 + 0x10) = iVar1;
		        goto code_r0x80f636dd;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,iVar1,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		    } while (DAT_ram_009d3e38 != 1);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f64422:
		    iVar1 = global_1;
		    iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar1 == iVar9) {
		      piVar8 = (int *)import::env::__cxa_begin_catch(uVar2);
		      iVar1 = *piVar8;
		      DAT_ram_009d3e38 = 0;
		      local_30 = iVar1;
		      import::env::invoke_v(0x123);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 != 1) {
		code_r0x80f6446b:
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 0) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar2 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x222,&local_30);
		  }
		  else {
		    func_ii_7580(param1,*(int *)(iVar1 + 0x14),param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    func_ii_7580(param1,*(undefined4 *)(iVar1 + 0x18),param1);
		    iVar1 = unnamed_function_1417(System_Collections_Generic_List_ComparedSkillData__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (iVar1,Method_System_Collections_Generic_List_ComparedSkillData___ctor__);
		    *param3 = iVar1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar2 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x50),
		                       Method_System_Collections_Generic_Dictionary_int__SkillData__get_Keys__);
		    System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		              (&local_30,uVar2,
		               Method_System_Collections_Generic_Dictionary_KeyCollection_int__SkillData__GetEnumerator__
		              );
		    local_18 = local_28;
		    local_20 = CONCAT44(local_2c,local_30);
		    local_30 = 0;
		    local_2c = &local_20;
		code_r0x80f639e2:
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x213,&local_20,
		                         Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_int__SkillData__MoveNext__
		                        );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      iVar1 = local_30;
		      if (iVar9 == 0) goto code_r0x80f643ca;
		      DAT_ram_009d3e38 = 0;
		      uVar2 = local_18._4_4_;
		      iVar9 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32,
		                         *(undefined4 *)(*(int *)(iVar9 + 0x14) + 0x50),uVar2,
		                         Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar9 = func_ii_7588(uVar3,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      if (iVar9 != 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104))
		        ;
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f64381;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32,
		                           *(undefined4 *)(*(int *)(iVar9 + 0x18) + 0x50),uVar2,
		                           Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f64381;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar9 = func_ii_7588(uVar3,0);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f64381;
		        }
		        if (iVar9 != 0) goto code_r0x80f639e2;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32,
		                         *(undefined4 *)(*(int *)(iVar9 + 0x14) + 0x58),uVar2,
		                         Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32,
		                         *(undefined4 *)(*(int *)(iVar4 + 0x14) + 0x50),uVar2,
		                         Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         Gameplay_ArtifactComparer_Model_ComparedSkillData_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f63e0e:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      DAT_ram_009d3e38 = 0;
		      Unity_Services_Core_Environments_Internal_Environments__get_Current
		                (iVar1,*(undefined4 *)(iVar4 + 8),0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f63e0e;
		      *(undefined8 *)(iVar1 + 0x10) = *(undefined8 *)(iVar4 + 0x10);
		      *(undefined8 *)(iVar1 + 0x18) = *(undefined8 *)(iVar4 + 0x18);
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      if (*(char *)(iVar5 + 0xc) == '\0') {
		        uVar3 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26e,iVar9 + 0x10,0);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f64381;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iiiii
		                          (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x26e,
		                           StringLiteral_1072,uVar3,StringLiteral_1145,0);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f64381;
		        }
		      }
		      *(undefined4 *)(iVar1 + 0x28) = uVar3;
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32,
		                         *(undefined4 *)(*(int *)(iVar5 + 0x18) + 0x58),uVar2,
		                         Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32,
		                         *(undefined4 *)(*(int *)(iVar6 + 0x18) + 0x50),uVar2,
		                         Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         Gameplay_ArtifactComparer_Model_ComparedSkillData_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f640b4:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      DAT_ram_009d3e38 = 0;
		      Unity_Services_Core_Environments_Internal_Environments__get_Current
		                (iVar4,*(undefined4 *)(iVar6 + 8),0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f640b4;
		      *(undefined8 *)(iVar4 + 0x10) = *(undefined8 *)(iVar6 + 0x10);
		      *(undefined8 *)(iVar4 + 0x18) = *(undefined8 *)(iVar6 + 0x18);
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      if (*(char *)(iVar7 + 0xc) == '\0') {
		        uVar2 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26e,iVar5 + 0x10,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f64381;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iiiii
		                          (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x26e,
		                           StringLiteral_1072,uVar2,StringLiteral_1145,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f64381;
		        }
		      }
		      *(undefined4 *)(iVar4 + 0x28) = uVar2;
		      if (*(longlong *)(iVar5 + 0x10) < *(longlong *)(iVar9 + 0x10)) {
		        *(undefined4 *)(iVar1 + 0x20) = 3;
		        uVar2 = 2;
		      }
		      else if (*(longlong *)(iVar9 + 0x10) < *(longlong *)(iVar5 + 0x10)) {
		        *(undefined4 *)(iVar1 + 0x20) = 2;
		        uVar2 = 3;
		      }
		      else {
		        *(undefined4 *)(iVar1 + 0x20) = 1;
		        uVar2 = 1;
		      }
		      *(undefined4 *)(iVar4 + 0x20) = uVar2;
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x220,
		                         *(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(iVar1 + 8),
		                         Method_System_Collections_Generic_HashSet_int__Contains__);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f64381;
		      }
		      *(char *)(iVar4 + 0x24) = (char)uVar2;
		      *(char *)(iVar1 + 0x24) = (char)uVar2;
		      iVar9 = Method_System_Collections_Generic_List_ComparedSkillData__Add__;
		      iVar5 = *param2;
		      *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		      uVar10 = *(uint *)(iVar5 + 0xc);
		      if (uVar10 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		        *(uint *)(iVar5 + 0xc) = uVar10 + 1;
		        *(int *)(*(int *)(iVar5 + 8) + uVar10 * 4 + 0x10) = iVar1;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar5,iVar1,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f64381;
		        }
		      }
		      iVar1 = Method_System_Collections_Generic_List_ComparedSkillData__Add__;
		      iVar9 = *param3;
		      *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		      uVar10 = *(uint *)(iVar9 + 0xc);
		      if (uVar10 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		        *(uint *)(iVar9 + 0xc) = uVar10 + 1;
		        *(int *)(*(int *)(iVar9 + 8) + uVar10 * 4 + 0x10) = iVar4;
		        goto code_r0x80f639e2;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar9,iVar4,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		    } while (iVar1 != 1);
		    uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f64381:
		    iVar1 = global_1;
		    iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar1 == iVar9) {
		      piVar8 = (int *)import::env::__cxa_begin_catch(uVar2);
		      iVar1 = *piVar8;
		      DAT_ram_009d3e38 = 0;
		      local_30 = iVar1;
		      import::env::invoke_v(0x123);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 != 1) {
		code_r0x80f643ca:
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 0) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar2 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x221,&local_30);
		  }
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005071 RID: 20593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005071")]
		[Address(RVA = "0x9E82", Offset = "0x9E82", VA = "0x9E82")]
		public void Compare(out List<ComparedSkillData> artifactSkills1, out List<ComparedSkillData> artifactSkills2)
		{
		/* --- GHIDRA: Compare ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerController__Compare
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58a35 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_int__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_int__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_int__Remove__);
		    DAT_ram_00a58a35 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = Core_Data_Skills_SkillData___ctor
		                    (*(undefined4 *)(iVar1 + 0x20),param2,
		                     Method_System_Collections_Generic_HashSet_int__Contains__);
		  if (param3 == 0) {
		    if (iVar1 != 0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      System_Collections_Generic_HashSet_uint___OnDeserialization
		                (*(undefined4 *)(iVar1 + 0x20),param2,
		                 Method_System_Collections_Generic_HashSet_int__Remove__);
		    }
		  }
		  else if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    func_ii_7578(*(undefined4 *)(iVar1 + 0x20),param2,
		                 Method_System_Collections_Generic_HashSet_int__Add__);
		  }
		  Gameplay_ArtifactComparer_Controller_ArtifactComparerController__RecalculateTargetArtifactPowerIfNeeded
		            (param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005072 RID: 20594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005072")]
		[Address(RVA = "0x9E83", Offset = "0x9E83", VA = "0x9E83")]
		public void SetSkillEnable(int skillId, bool enabled)
		{
		/* --- GHIDRA: SetSkillEnable ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerController__SetSkillEnable
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x14) = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x18) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x14) != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(*(int *)(iVar1 + 0x14) + 0x80) == 1) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar2 = *(int *)(*(int *)(iVar1 + 0x14) + 0x70);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      if (iVar2 == *(int *)(iVar1 + 8)) goto code_r0x80f6518a;
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    func_ii_7580(param1,*(undefined4 *)(iVar1 + 0x14),param1);
		  }
		code_r0x80f6518a:
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005073 RID: 20595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005073")]
		[Address(RVA = "0x9E84", Offset = "0x9E84", VA = "0x9E84")]
		public void SetTargetArtifact(ArtifactData targetArtifact)
		{
		/* --- GHIDRA: SetTargetArtifact ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerController__SetTargetArtifact
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x14) != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(*(int *)(iVar1 + 0x14) + 0x80) == 1) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar2 = *(int *)(*(int *)(iVar1 + 0x14) + 0x70);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      if (iVar2 == *(int *)(iVar1 + 8)) {
		        return;
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    func_ii_7580(param1,*(undefined4 *)(iVar1 + 0x14),param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005074 RID: 20596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005074")]
		[Address(RVA = "0x9E85", Offset = "0x9E85", VA = "0x9E85")]
		private void RecalculateTargetArtifactPowerIfNeeded()
		{
		/* --- GHIDRA: RecalculateTargetArtifactPowerIfNeeded ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerController__RecalculateTargetArtifactPowerIfNeeded
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  undefined4 *puVar7;
		  undefined4 uVar8;
		  int iVar9;
		  int *piVar10;
		  int local_38;
		  int **local_34;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  int *local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58a36 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ArtifactData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_string__ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtifactData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__ArtifactData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtifactData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__ArtifactData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__ArtifactData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtifactData__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtifactData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_string__ArtifactData__GetEnumerator__
		              );
		    DAT_ram_00a58a36 = '\x01';
		  }
		  local_8 = (int *)0x0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_ArtifactData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_ArtifactData___ctor__);
		  uVar3 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_string__ArtifactData__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar3,Method_System_Collections_Generic_Dictionary_string__ArtifactData___ctor__);
		  local_4 = uVar3;
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar9 = **(int **)(iVar4 + 0x10);
		  piVar5 = (int *)(**(code **)((ulonglong)*(uint *)(iVar9 + 0x120) * 4))
		                            (*(int **)(iVar4 + 0x10),*(undefined4 *)(iVar9 + 0x124));
		  iVar4 = *piVar5;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_ArtifactData__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f625fd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar5,System_Collections_Generic_IEnumerable_ArtifactData__TypeInfo
		                                ,0);
		code_r0x80f625fd:
		  local_8 = (int *)(**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		  local_38 = 0;
		  local_34 = &local_8;
		code_r0x80f6263e:
		  do {
		    piVar5 = local_8;
		    iVar4 = *local_8;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar7 = (undefined4 *)(iVar4 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80f626d2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f62907:
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f6290f;
		    }
		code_r0x80f626d2:
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		    piVar5 = local_8;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f62907;
		    if (iVar4 == 0) goto code_r0x80f62958;
		    iVar4 = *local_8;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ArtifactData__TypeInfo == *piVar10) {
		          puVar7 = (undefined4 *)(iVar4 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80f627af;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                        System_Collections_Generic_IEnumerator_ArtifactData__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f628df:
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f6290f;
		    }
		code_r0x80f627af:
		    DAT_ram_009d3e38 = 0;
		    uVar8 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f628df;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x216,param1,uVar8,uVar8);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f6290f;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x217,uVar8,&local_4,uVar8);
		    iVar9 = DAT_ram_009d3e38;
		    iVar4 = Method_System_Collections_Generic_List_ArtifactData__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f6290f;
		    }
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar2 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = uVar8;
		      goto code_r0x80f6263e;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,uVar8,
		               *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar4 != 1);
		  uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f6290f:
		  iVar4 = global_1;
		  iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar9) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar8);
		    local_38 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x80f62958:
		      DAT_ram_009d3e38 = 0;
		      piVar5 = *local_34;
		      if (piVar5 != (int *)0x0) {
		        uVar1 = 0;
		        iVar4 = *piVar5;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f629d3;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x80f629d3:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_38 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_38);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_38,iVar2,
		                 Method_System_Collections_Generic_List_ArtifactData__GetEnumerator__);
		      local_10 = local_30;
		      local_18 = CONCAT44(local_34,local_38);
		      local_38 = 0;
		      local_34 = (int **)&local_18;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                           Method_System_Collections_Generic_List_Enumerator_ArtifactData__MoveNext__
		                          );
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f62afe;
		        }
		        if (iVar4 == 0) goto code_r0x80f62b54;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x219,local_10._4_4_,0,0);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar2 != 1);
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f62afe:
		      iVar2 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar8);
		        iVar4 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_38 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		          if (iVar4 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80f62b54:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                            (uVar3,
		                             Method_System_Collections_Generic_Dictionary_string__ArtifactData__get_Values__
		                            );
		          System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                    (&local_28,uVar3,
		                     Method_System_Collections_Generic_Dictionary_ValueCollection_string__ArtifactData__GetEnumerator__
		                    );
		          local_38 = 0;
		          local_34 = (int **)&local_28;
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar4 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1a2,&local_28,
		                               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__ArtifactData__MoveNext__
		                              );
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 == 1) {
		              uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80f62c5e;
		            }
		            if (iVar4 == 0) goto code_r0x80f62cb6;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x219,local_20._4_4_,1,0);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		          } while (iVar2 != 1);
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f62c5e:
		          iVar2 = global_1;
		          iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar2 == iVar4) {
		            piVar5 = (int *)import::env::__cxa_begin_catch(uVar8);
		            iVar4 = *piVar5;
		            DAT_ram_009d3e38 = 0;
		            local_38 = iVar4;
		            import::env::invoke_v(0x123);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 != 1) {
		              if (iVar4 != 0) {
		                System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		                do {
		                  halt_trap();
		                } while( true );
		              }
		code_r0x80f62cb6:
		              DAT_ram_009d3e38 = 0;
		              iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x104));
		              if (*(int *)(iVar2 + 0x14) != 0) {
		                iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                                  (param1,*(undefined4 *)(*param1 + 0x104));
		                if (*(int *)(*(int *)(iVar2 + 0x14) + 0x80) == 1) {
		                  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                                    (param1,*(undefined4 *)(*param1 + 0x104));
		                  iVar4 = *(int *)(*(int *)(iVar2 + 0x14) + 0x70);
		                  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                                    (param1,*(undefined4 *)(*param1 + 0x104));
		                  if (iVar4 == *(int *)(iVar2 + 8)) goto code_r0x80f62d4f;
		                }
		                iVar4 = *param1;
		                iVar2 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                                  (param1,*(undefined4 *)(iVar4 + 0x104));
		                func_ii_7580(param1,*(undefined4 *)(iVar2 + 0x14),iVar4);
		              }
		code_r0x80f62d4f:
		              iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x114));
		              iVar2 = *(int *)(iVar2 + 0x24);
		              if (iVar2 != 0) {
		                (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                          (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		              }
		              return;
		            }
		            uVar8 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x21b,&local_38);
		          goto joined_r0x80f62dbb;
		        }
		        uVar8 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x21a,&local_38);
		      goto joined_r0x80f62dbb;
		    }
		    uVar8 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x218,&local_38);
		joined_r0x80f62dbb:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar8);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005075 RID: 20597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005075")]
		[Address(RVA = "0x9E86", Offset = "0x9E86", VA = "0x9E86")]
		private void RecalculateArtifactsPower()
		{
		/* --- GHIDRA: RecalculateArtifactsPower ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerController__RecalculateArtifactsPower
		               (int *param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 *puVar6;
		  undefined4 uVar7;
		  int iVar8;
		  undefined8 uVar9;
		  int iVar10;
		  float fVar11;
		  int *piVar12;
		  longlong lVar13;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58a38 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_int__SkillData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_int__SkillData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_int__SkillData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_int__Contains__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_int__SkillData__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_int__SkillData__GetEnumerator__
		              );
		    DAT_ram_00a58a38 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  uVar2 = Core_Data_Skills_SkillCollection__HasAnyAbsolute(param3,0);
		  uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (uVar2,Method_System_Collections_Generic_Dictionary_int__SkillData__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_30,uVar3,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_int__SkillData__GetEnumerator__
		            );
		  local_8 = local_28;
		  local_30 = 0;
		  puStack_2c = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x152,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_int__SkillData__MoveNext__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) break;
		    if (iVar4 == 0) goto code_r0x80f6478b;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = local_8._4_4_;
		    iVar8 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f64735;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x220,
		                       *(undefined4 *)(iVar8 + 0x20),*(undefined4 *)(iVar4 + 8),
		                       Method_System_Collections_Generic_HashSet_int__Contains__);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f64735;
		    }
		    if (iVar8 == 0) {
		      *(undefined8 *)(iVar4 + 0x10) = 0;
		    }
		  }
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f64735:
		  iVar10 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar4 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		      if (iVar4 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80f6478b:
		      DAT_ram_009d3e38 = 0;
		      *(undefined4 *)(param2 + 0x54) = uVar2;
		      uVar2 = Core_Data_Skills_SkillCollection__HasAnyAbsolute(uVar2,0);
		      uVar3 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                        (uVar2,
		                         Method_System_Collections_Generic_Dictionary_int__SkillData__get_Keys__);
		      System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                (&local_30,uVar3,
		                 Method_System_Collections_Generic_Dictionary_KeyCollection_int__SkillData__GetEnumerator__
		                );
		      local_18 = local_28;
		      local_20 = CONCAT44(puStack_2c,local_30);
		      local_30 = 0;
		      puStack_2c = &local_20;
		      while( true ) {
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x213,&local_20,
		                           Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_int__SkillData__MoveNext__
		                          );
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) break;
		        if (iVar4 == 0) goto code_r0x80f64b86;
		        uVar3 = local_18._4_4_;
		        if (DAT_ram_00a6456f == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80f64ae5;
		          }
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar10 = *piVar5;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar12) {
		              puVar6 = (undefined4 *)(piVar12[1] * 8 + iVar10 + 0x178);
		              goto code_r0x80f6494f;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                            Core_Gameplay_IGame_TypeInfo,0x17);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f64aab:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f64ae5;
		        }
		code_r0x80f6494f:
		        DAT_ram_009d3e38 = 0;
		        uVar7 = import::env::invoke_iii(*puVar6,piVar5,puVar6[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f64aab;
		        DAT_ram_009d3e38 = 0;
		        uVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar7,0);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f64ae5;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x33,uVar7,uVar3,0);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f64ae5;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32,uVar2,uVar3,
		                           Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f64ae5;
		        }
		        fVar11 = *(float *)(iVar4 + 0x10);
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32,uVar2,uVar3,
		                           Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f64ae5;
		        }
		        fVar11 = fVar11 * (float)*(longlong *)(iVar4 + 0x10);
		        if (ABS(fVar11) < 9.223372e+18) {
		          lVar13 = (longlong)fVar11;
		        }
		        else {
		          lVar13 = -0x8000000000000000;
		        }
		        *(longlong *)(iVar8 + 0x10) = lVar13;
		      }
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f64ae5:
		      iVar10 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar10 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar4 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 != 1) {
		          if (iVar4 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80f64b86:
		          DAT_ram_009d3e38 = 0;
		          *(undefined4 *)(param2 + 0x58) = uVar2;
		          uVar9 = Core_Data_Skills_SkillCollection__MultiplyByFloat(uVar2,0);
		          *(undefined8 *)(param2 + 0x60) = uVar9;
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x224,&local_30);
		      goto joined_r0x80f64b72;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x223,&local_30);
		joined_r0x80f64b72:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005076 RID: 20598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005076")]
		[Address(RVA = "0x1D9D", Offset = "0x1D9D", VA = "0x1D9D")]
		public void RecalculateArtifactPower(ArtifactData artifactData)
		{
		/* --- GHIDRA: RecalculateArtifactPower ---
		void Gameplay_ArtifactComparer_Controller_ArtifactComparerController__RecalculateArtifactPower
		               (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  longlong lVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58a37 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ArtifactData__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ArtifactData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ArtifactData__get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ArtifactData__set_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_string___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__GetEnumerator__);
		    DAT_ram_00a58a37 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar5 = *param2;
		  uVar1 = func_ii_7586(param1,0);
		  iVar2 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (uVar5,uVar1,
		                     Method_System_Collections_Generic_Dictionary_string__ArtifactData__ContainsKey__
		                    );
		  if (iVar2 == 0) {
		    uVar5 = *param2;
		    uVar1 = func_ii_7586(param1,0);
		    func_ii_2946(uVar5,uVar1,param1,
		                 Method_System_Collections_Generic_Dictionary_string__ArtifactData__set_Item__);
		  }
		  uVar1 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (*param2,
		                     Method_System_Collections_Generic_Dictionary_string__ArtifactData__get_Keys__);
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,Method_System_Linq_Enumerable_ToList_string___);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,uVar1,Method_System_Collections_Generic_List_string__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_string__MoveNext__);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f63180;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = local_8._4_4_;
		    uVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x21c,param1,0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x22e,uVar5,uVar1,0);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f63180;
		    }
		    if (-1 < iVar3) {
		      lVar6 = *(longlong *)(param1 + 0x60);
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x2ec,*param2,uVar1,
		                         Method_System_Collections_Generic_Dictionary_string__ArtifactData__get_Item__
		                        );
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f63180;
		      }
		      if (*(longlong *)(iVar3 + 0x60) < lVar6) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x84,*param2,uVar1,param1,
		                   Method_System_Collections_Generic_Dictionary_string__ArtifactData__set_Item__);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f63180:
		          iVar2 = global_1;
		          iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar2 == iVar3) {
		            piVar4 = (int *)import::env::__cxa_begin_catch(uVar1);
		            iVar3 = *piVar4;
		            DAT_ram_009d3e38 = 0;
		            local_18 = iVar3;
		            import::env::invoke_v(0x123);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 != 1) {
		              if (iVar3 == 0) {
		                DAT_ram_009d3e38 = 0;
		                return;
		              }
		              System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar1 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x21d,&local_18);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) {
		            import::env::__resumeException(uVar1);
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
		      }
		    }
		  }
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x80f63180;
		}
		*/

		}

		// Token: 0x06005077 RID: 20599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005077")]
		[Address(RVA = "0x1D9E", Offset = "0x1D9E", VA = "0x1D9E")]
		[CompilerGenerated]
		internal static void <RecalculateArtifactsPower>g__CheckIfBest|12_0(ArtifactData artifact, ref ArtifactComparerController.<>c__DisplayClass12_0 A_1)
		{
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005078")]
		[Address(RVA = "0x9E87", Offset = "0x9E87", VA = "0x9E87")]
		[CompilerGenerated]
		private void <RecalculateArtifactPower>g__SetArtifactPower|13_0(ArtifactData artifact, SkillCollection power)
		{
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005079")]
		[Address(RVA = "0x9E88", Offset = "0x9E88", VA = "0x9E88")]
		[CompilerGenerated]
		private ArtifactData <RecalculateArtifactPower>g__GetEquippedArtifactFor|13_1(ArtifactData artifact)
		{
			return null;
		}
	}
}
