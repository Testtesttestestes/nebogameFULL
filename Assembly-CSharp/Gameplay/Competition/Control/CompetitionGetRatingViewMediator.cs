using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.Competition.View.GetRatingRewardWidget;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Control
{
	// Token: 0x02000905 RID: 2309
	[Token(Token = "0x2000905")]
	public class CompetitionGetRatingViewMediator : AbstractCozyViewMediator<CompetitionModel, CompetitionEvents, CompetitionController, CompetitionGetRatingView>
	{
		// Token: 0x06003644 RID: 13892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003644")]
		[Address(RVA = "0x8651", Offset = "0x8651", VA = "0x8651")]
		public CompetitionGetRatingViewMediator(CompetitionModel model, CompetitionEvents events, CompetitionController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_Control_CompetitionGetRatingViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63ade == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_ChangedFromTo_OwnerRating__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionGetRatingViewMediator_HandleOwnerRatingChangedEvent__
		              );
		    DAT_ram_00a63ade = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param2 + 0x18);
		  uVar1 = unnamed_function_1417(Core_ChangedFromTo_OwnerRating__TypeInfo);
		  UnityEngine_UIElements_ChangeEvent___Il2CppFullySharedGenericType___set_previousValue
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionGetRatingViewMediator_HandleOwnerRatingChangedEvent__
		             ,0);
		  param1_00 = func_ii_7048(param1_01,uVar1,0);
		  uVar1 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		    return;
		  }
		  iVar2 = func_ii_1082(param1_00,Core_ChangedFromTo_OwnerRating__TypeInfo);
		  if (iVar2 == 0) {
		    System_Activator__CreateInstance(param1_00,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(param2 + 0x18) = iVar2;
		  uVar1 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		  iVar2 = func_ii_1082(param1_00,Core_ChangedFromTo_OwnerRating__TypeInfo);
		  if (iVar2 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_Control_CompetitionGetRatingViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63ade == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_ChangedFromTo_OwnerRating__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionGetRatingViewMediator_HandleOwnerRatingChangedEvent__
		              );
		    DAT_ram_00a63ade = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param2 + 0x18);
		  uVar1 = unnamed_function_1417(Core_ChangedFromTo_OwnerRating__TypeInfo);
		  UnityEngine_UIElements_ChangeEvent___Il2CppFullySharedGenericType___set_previousValue
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionGetRatingViewMediator_HandleOwnerRatingChangedEvent__
		             ,0);
		  param1_00 = func_ii_7048(param1_01,uVar1,0);
		  uVar1 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		    return;
		  }
		  iVar2 = func_ii_1082(param1_00,Core_ChangedFromTo_OwnerRating__TypeInfo);
		  if (iVar2 == 0) {
		    System_Activator__CreateInstance(param1_00,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(param2 + 0x18) = iVar2;
		  uVar1 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		  iVar2 = func_ii_1082(param1_00,Core_ChangedFromTo_OwnerRating__TypeInfo);
		  if (iVar2 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003645 RID: 13893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003645")]
		[Address(RVA = "0x8652", Offset = "0x8652", VA = "0x8652")]
		public CompetitionGetRatingViewMediator(CompetitionGetRatingView view, CompetitionModel model, CompetitionEvents events, CompetitionController controller)
		{
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003646")]
		[Address(RVA = "0x8653", Offset = "0x8653", VA = "0x8653", Slot = "21")]
		protected override void ResetEvents(CompetitionEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Competition_Control_CompetitionGetRatingViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63adf == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_ChangedFromTo_OwnerRating__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionGetRatingViewMediator_HandleOwnerRatingChangedEvent__
		              );
		    DAT_ram_00a63adf = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param2 + 0x18);
		  uVar1 = unnamed_function_1417(Core_ChangedFromTo_OwnerRating__TypeInfo);
		  UnityEngine_UIElements_ChangeEvent___Il2CppFullySharedGenericType___set_previousValue
		            (uVar1,param1,
		             Method_Gameplay_Competition_Control_CompetitionGetRatingViewMediator_HandleOwnerRatingChangedEvent__
		             ,0);
		  param1_00 = UnityEngine_UI_Image__set_sprite(param1_01,uVar1,0);
		  uVar1 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		  if (param1_00 == 0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		    return;
		  }
		  iVar2 = func_ii_1082(param1_00,Core_ChangedFromTo_OwnerRating__TypeInfo);
		  if (iVar2 == 0) {
		    System_Activator__CreateInstance(param1_00,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(param2 + 0x18) = iVar2;
		  uVar1 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		  iVar2 = func_ii_1082(param1_00,Core_ChangedFromTo_OwnerRating__TypeInfo);
		  if (iVar2 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003647 RID: 13895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003647")]
		[Address(RVA = "0x8654", Offset = "0x8654", VA = "0x8654", Slot = "22")]
		protected override void SetupEvents(CompetitionEvents events)
		{
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003648")]
		[Address(RVA = "0x8655", Offset = "0x8655", VA = "0x8655", Slot = "23")]
		protected override void ResetView(CompetitionGetRatingView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Competition_Control_CompetitionGetRatingViewMediator__ResetView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63ae0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionGetRatingView__get_Model__
		              );
		    DAT_ram_00a63ae0 = '\x01';
		  }
		  if (*(int *)(param1[2] + 0x2c) != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar1 + 0x2c);
		    param2_00 = Core_Extensions_Dict_CompetitionDicExt__GetTitle
		                          (*(undefined4 *)(*(int *)(param1[2] + 0x2c) + 8),0);
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (param1_00,param2_00,
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Tweens_TweeningValue__Display
		            (*(undefined4 *)(iVar1 + 0x14),(float)*(ulonglong *)(*(int *)(param1[2] + 0x30) + 0x10),
		             0);
		  return;
		}
		*/

		}

		// Token: 0x06003649 RID: 13897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003649")]
		[Address(RVA = "0x8656", Offset = "0x8656", VA = "0x8656", Slot = "24")]
		protected override void SetupView(CompetitionGetRatingView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Competition_Control_CompetitionGetRatingViewMediator__SetupView
		               (int *param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  longlong lVar7;
		  longlong lVar8;
		  int *piVar9;
		  uint uVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a63ae1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_ulong__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&float___TypeInfo);
		    DAT_ram_00a63ae1 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_12174(uVar1,0);
		  if (iVar2 == 0) {
		    return;
		  }
		  lVar8 = *(longlong *)(param2 + 0x10);
		  local_4 = (int *)LunarConsolePluginInternal_Iterator___Il2CppFullySharedGenericType___TrySkip
		                             (*(undefined4 *)(param3 + 0x18),
		                              Method_System_Collections_ObjectModel_ReadOnlyCollection_ulong__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar2 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x8233c4ec;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8233c6f3:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8233c6fb;
		    }
		code_r0x8233c4ec:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8233c6f3;
		    if (iVar2 == 0) {
		      iVar2 = 0;
		      goto code_r0x8233c744;
		    }
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8);
		        if (System_Collections_Generic_IEnumerator_ulong__TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar2 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x8233c5c6;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ulong__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8233c6cb:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8233c6fb;
		    }
		code_r0x8233c5c6:
		    DAT_ram_009d3e38 = 0;
		    lVar7 = unnamed_function_184054(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8233c6cb;
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8233c6fb;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,float___TypeInfo,1);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8233c6fb;
		    }
		    *(float *)(iVar4 + 0x10) = (float)(ulonglong)(lVar7 - lVar8);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s___Scripting__Unity__IO__Archive__ram_00004472 + 0x2f,uVar1,iVar4,iVar4);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    lVar8 = lVar7;
		  } while (iVar2 != 1);
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8233c6fb:
		  iVar2 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar1);
		    iVar2 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar2;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x8233c744:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar10 = 0;
		        iVar4 = *local_4;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar10 * 8)) {
		              puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x8233c7bc;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar10);
		        }
		        puVar6 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x8233c7bc:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (iVar2 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x30,&local_c);
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
		*/

		}

		// Token: 0x0600364A RID: 13898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364A")]
		[Address(RVA = "0x8657", Offset = "0x8657", VA = "0x8657")]
		private void HandleOwnerRatingChangedEvent(OwnerRating from, OwnerRating to)
		{
		/* --- GHIDRA: HandleOwnerRatingChangedEvent ---
		void Gameplay_Competition_Control_CompetitionGetRatingViewMediator__HandleOwnerRatingChangedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a63ae2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionView___ctor__
		              );
		    DAT_ram_00a63ae2 = '\x01';
		  }
		  MVC_AbstractController_object__object___set_Model
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractCozyViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionView___ctor__
		            );
		  return;
		}
		*/

		}
	}
}
