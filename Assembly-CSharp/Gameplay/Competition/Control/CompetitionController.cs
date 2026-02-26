using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Competition;
using Protocol.Rating;
using ServicesNamespace;
using Utils;

namespace Gameplay.Competition.Control
{
	// Token: 0x02000903 RID: 2307
	[Token(Token = "0x2000903")]
	public class CompetitionController : AbstractController<CompetitionModel, Gameplay.Competition.Events.CompetitionEvents>
	{
		// Token: 0x06003626 RID: 13862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003626")]
		[Address(RVA = "0x8633", Offset = "0x8633", VA = "0x8633")]
		public CompetitionController(RatingService ratingService, CompetitionService competitionService, CompetitionModel model, Gameplay.Competition.Events.CompetitionEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_Control_CompetitionController___ctor(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Competition_Control_CompetitionController__StartListen(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003627 RID: 13863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003627")]
		[Address(RVA = "0x8634", Offset = "0x8634", VA = "0x8634", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Competition_Control_CompetitionController__HandleStop(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x20) = 2;
		  Gameplay_Competition_Control_CompetitionController__HandleGetOwnerRatingService(param1,param1);
		  Gameplay_Competition_Control_CompetitionController__HandleDictionariesChangedEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003628 RID: 13864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003628")]
		[Address(RVA = "0x8635", Offset = "0x8635", VA = "0x8635", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Competition_Control_CompetitionController__HandleRun(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  uint *puVar8;
		  int *piVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a63acc == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDailyQuest__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDailyQuest___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IDailyQuest__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__);
		    DAT_ram_00a63acc = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar2 + 0x2c) == 0) {
		    return;
		  }
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_IDailyQuest__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_IDailyQuest___ctor__);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x2c) + 8) + 0x10),
		                              Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x8233a79b:
		  do {
		    do {
		      piVar7 = local_4;
		      iVar3 = *local_4;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		            puVar4 = (undefined4 *)(iVar3 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x8233a843;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8233a88b:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8233ab48;
		      }
		code_r0x8233a843:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      piVar7 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8233a88b;
		      if (iVar3 == 0) {
		        iVar3 = 5;
		        goto code_r0x8233ab95;
		      }
		      iVar3 = *local_4;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar9) {
		            puVar4 = (undefined4 *)(iVar3 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x8233a936;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8233aa99:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8233ab48;
		      }
		code_r0x8233a936:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8233aa99;
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8233ab48;
		      }
		      piVar7 = *(int **)(*(int *)(iVar6 + 0xc) + 0x10);
		      iVar3 = *piVar7;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		          if (Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo == *piVar9) {
		            puVar4 = (undefined4 *)(iVar3 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x8233aa53;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                          Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8233aaad:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8233ab48;
		      }
		code_r0x8233aa53:
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iiii(*puVar4,piVar7,uVar5,puVar4[1]);
		      iVar3 = Method_System_Collections_Generic_List_IDailyQuest__Add__;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8233aaad;
		    } while (iVar6 == 0);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar2 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		      *(int *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = iVar6;
		      goto code_r0x8233a79b;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,iVar6,
		               *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar3 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8233ab48:
		  iVar3 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		    local_c = *piVar7;
		    iVar3 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x8233ab95:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = *local_8;
		      if (piVar7 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *piVar7;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar8 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8233ac10;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar8 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x8233ac10:
		        (**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		      }
		      if (local_c != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_c);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar3 != 0) {
		        if (iVar3 == 1) {
		          return;
		        }
		        if (iVar3 == 2) {
		          return;
		        }
		        if (iVar3 == 3) {
		          return;
		        }
		        if (iVar3 == 4) {
		          return;
		        }
		        if (iVar3 != 5) {
		          return;
		        }
		      }
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      *(int *)(iVar3 + 0x28) = iVar2;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar2 = *(int *)(iVar2 + 0x20);
		      if (iVar2 == 0) {
		        return;
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		      return;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x2e,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003629 RID: 13865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003629")]
		[Address(RVA = "0x8636", Offset = "0x8636", VA = "0x8636")]
		private void RequestQuests()
		{
		/* --- GHIDRA: RequestQuests ---
		void Gameplay_Competition_Control_CompetitionController__RequestQuests
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x28);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600362A RID: 13866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362A")]
		[Address(RVA = "0x8637", Offset = "0x8637", VA = "0x8637")]
		private void HandleQuestsUpdated()
		{
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362B")]
		[Address(RVA = "0x8638", Offset = "0x8638", VA = "0x8638")]
		private void HandleActiveQuestsCountChanged()
		{
		/* --- GHIDRA: HandleActiveQuestsCountChanged ---
		void Gameplay_Competition_Control_CompetitionController__HandleActiveQuestsCountChanged
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if ((*(char *)((int)param1 + 9) == '\0') &&
		     (iVar1 = param1[8], param1[8] = iVar1 + -1, iVar1 + -1 < 1)) {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    Gameplay_Competition_Control_CompetitionController__ValidateInit(param1,param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 8);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600362C RID: 13868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362C")]
		[Address(RVA = "0x8639", Offset = "0x8639", VA = "0x8639")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_Competition_Control_CompetitionController__ValidateInit(int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int param1_00;
		  uint *puVar6;
		  int iVar7;
		  int *piVar8;
		  undefined4 uVar9;
		  
		  if (DAT_ram_00a63acd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCompetitionRatingChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCompetitionStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_ChangedFromTo_OwnerRating__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionController_HandleActiveQuestsCountChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionController_HandleDictionariesChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionController_HandleOwnedRatingChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_Control_CompetitionController_HandleQuestsChanged__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_Control_CompetitionController_HandleQuestsUpdated__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionController_HandleRatingChangedEventService__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionController_HandleStateChangedEventService__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a63acd = '\x01';
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = *(int *)(iVar4 + 0x30);
		  uVar5 = unnamed_function_1417(Core_ChangedFromTo_OwnerRating__TypeInfo);
		  UnityEngine_UIElements_ChangeEvent___Il2CppFullySharedGenericType___set_previousValue
		            (uVar5,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleOwnedRatingChangedEvent__
		             ,0);
		  if (DAT_ram_00a63aba == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_ChangedFromTo_OwnerRating__TypeInfo);
		    DAT_ram_00a63aba = '\x01';
		  }
		  iVar7 = *(int *)(iVar4 + 8);
		  do {
		    iVar3 = 0;
		    param1_00 = UnityEngine_UI_Image__set_sprite(iVar7,uVar5,0);
		    uVar9 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		    if ((param1_00 != 0) &&
		       (iVar3 = func_ii_1082(param1_00,Core_ChangedFromTo_OwnerRating__TypeInfo), iVar3 == 0)) {
		      System_Activator__CreateInstance(param1_00,uVar9);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = func_ii_4329(iVar4 + 8,iVar3,iVar7);
		    bVar1 = iVar3 != iVar7;
		    iVar7 = iVar3;
		  } while (bVar1);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar8 = *(int **)(*(int *)(iVar4 + 0xc) + 8);
		  uVar2 = 0;
		  uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar5,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleDictionariesChangedEvent__
		             ,0);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		        puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8233af1c;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar8,Core_Dict_IDictProvider_TypeInfo,0);
		code_r0x8233af1c:
		  (**(code **)((ulonglong)*puVar6 * 4))(piVar8,uVar5,puVar6[1]);
		  iVar4 = param1[7];
		  uVar2 = 0;
		  uVar5 = unnamed_function_1417(System_Action_ProtoCompetitionStateChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleStateChangedEventService__
		             ,0);
		  ServicesNamespace_CompetitionService__get_ServiceId(iVar4,uVar5,0);
		  iVar4 = param1[6];
		  uVar5 = unnamed_function_1417(System_Action_ProtoCompetitionRatingChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleRatingChangedEventService__
		             ,0);
		  ServicesNamespace_RatingService__remove_GreatRatingSetChangedEvent(iVar4,uVar5,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar8 = *(int **)(*(int *)(iVar4 + 0xc) + 0x10);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x8233b012;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar8,Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo,1);
		code_r0x8233b012:
		  iVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar8,puVar6[1]);
		  uVar9 = *(undefined4 *)(iVar7 + 0x14);
		  uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar5,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleQuestsChanged__,0);
		  piVar8 = (int *)UnityEngine_UI_Image__set_sprite(uVar9,uVar5,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar8 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar8) ||
		          (*(int **)(iVar7 + 0x14) = piVar8, *piVar8 != iVar4)) {
		    System_Activator__CreateInstance(piVar8,iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = 0;
		  piVar8 = *(int **)(*(int *)(iVar4 + 0xc) + 0x10);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x8233b113;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar8,Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo,1);
		code_r0x8233b113:
		  iVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar8,puVar6[1]);
		  uVar9 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar5,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleQuestsUpdated__,0);
		  piVar8 = (int *)UnityEngine_UI_Image__set_sprite(uVar9,uVar5,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar8 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar8) ||
		          (*(int **)(iVar7 + 0x1c) = piVar8, *piVar8 != iVar4)) {
		    System_Activator__CreateInstance(piVar8,iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = 0;
		  piVar8 = *(int **)(*(int *)(iVar4 + 0xc) + 0x10);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x8233b214;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar8,Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo,1);
		code_r0x8233b214:
		  iVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar8,puVar6[1]);
		  uVar9 = *(undefined4 *)(iVar7 + 0x18);
		  uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar5,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleActiveQuestsCountChanged__
		             ,0);
		  piVar8 = (int *)UnityEngine_UI_Image__set_sprite(uVar9,uVar5,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar8 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x18) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar8) && (*(int **)(iVar7 + 0x18) = piVar8, *piVar8 == iVar4)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar8,iVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600362D RID: 13869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362D")]
		[Address(RVA = "0x863A", Offset = "0x863A", VA = "0x863A")]
		private void StartListen()
		{
		/* --- GHIDRA: StartListen ---
		void Gameplay_Competition_Control_CompetitionController__StartListen(int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int param1_00;
		  uint *puVar6;
		  int iVar7;
		  int *piVar8;
		  undefined4 uVar9;
		  
		  if (DAT_ram_00a63ace == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCompetitionRatingChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCompetitionStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_ChangedFromTo_OwnerRating__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionController_HandleActiveQuestsCountChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionController_HandleDictionariesChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionController_HandleOwnedRatingChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_Control_CompetitionController_HandleQuestsChanged__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_Control_CompetitionController_HandleQuestsUpdated__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionController_HandleRatingChangedEventService__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionController_HandleStateChangedEventService__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a63ace = '\x01';
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = *(int *)(iVar4 + 0x30);
		  uVar5 = unnamed_function_1417(Core_ChangedFromTo_OwnerRating__TypeInfo);
		  UnityEngine_UIElements_ChangeEvent___Il2CppFullySharedGenericType___set_previousValue
		            (uVar5,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleOwnedRatingChangedEvent__
		             ,0);
		  if (DAT_ram_00a63abb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_ChangedFromTo_OwnerRating__TypeInfo);
		    DAT_ram_00a63abb = '\x01';
		  }
		  iVar7 = *(int *)(iVar4 + 8);
		  do {
		    iVar3 = 0;
		    param1_00 = func_ii_7048(iVar7,uVar5,0);
		    uVar9 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		    if ((param1_00 != 0) &&
		       (iVar3 = func_ii_1082(param1_00,Core_ChangedFromTo_OwnerRating__TypeInfo), iVar3 == 0)) {
		      System_Activator__CreateInstance(param1_00,uVar9);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = func_ii_4329(iVar4 + 8,iVar3,iVar7);
		    bVar1 = iVar3 != iVar7;
		    iVar7 = iVar3;
		  } while (bVar1);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar8 = *(int **)(*(int *)(iVar4 + 0xc) + 8);
		  uVar2 = 0;
		  uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar5,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleDictionariesChangedEvent__
		             ,0);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x8233a226;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar8,Core_Dict_IDictProvider_TypeInfo,1);
		code_r0x8233a226:
		  (**(code **)((ulonglong)*puVar6 * 4))(piVar8,uVar5,puVar6[1]);
		  iVar4 = param1[7];
		  uVar2 = 0;
		  uVar5 = unnamed_function_1417(System_Action_ProtoCompetitionStateChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleStateChangedEventService__
		             ,0);
		  ServicesNamespace_CompetitionService__add_CompetitionStateChangedEvent(iVar4,uVar5,0);
		  iVar4 = param1[6];
		  uVar5 = unnamed_function_1417(System_Action_ProtoCompetitionRatingChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleRatingChangedEventService__
		             ,0);
		  ServicesNamespace_RatingService__add_CompetitionRatingChangedEvent(iVar4,uVar5,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar8 = *(int **)(*(int *)(iVar4 + 0xc) + 0x10);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x8233a31c;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar8,Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo,1);
		code_r0x8233a31c:
		  iVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar8,puVar6[1]);
		  uVar9 = *(undefined4 *)(iVar7 + 0x14);
		  uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar5,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleQuestsChanged__,0);
		  piVar8 = (int *)func_ii_7048(uVar9,uVar5,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar8 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar8) ||
		          (*(int **)(iVar7 + 0x14) = piVar8, *piVar8 != iVar4)) {
		    System_Activator__CreateInstance(piVar8,iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = 0;
		  piVar8 = *(int **)(*(int *)(iVar4 + 0xc) + 0x10);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x8233a41d;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar8,Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo,1);
		code_r0x8233a41d:
		  iVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar8,puVar6[1]);
		  uVar9 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar5,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleQuestsUpdated__,0);
		  piVar8 = (int *)func_ii_7048(uVar9,uVar5,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar8 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar8) ||
		          (*(int **)(iVar7 + 0x1c) = piVar8, *piVar8 != iVar4)) {
		    System_Activator__CreateInstance(piVar8,iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = 0;
		  piVar8 = *(int **)(*(int *)(iVar4 + 0xc) + 0x10);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x8233a51e;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar8,Gameplay_DailyQuests_IDailyQuestProvider_TypeInfo,1);
		code_r0x8233a51e:
		  iVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar8,puVar6[1]);
		  uVar9 = *(undefined4 *)(iVar7 + 0x18);
		  uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar5,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleActiveQuestsCountChanged__
		             ,0);
		  piVar8 = (int *)func_ii_7048(uVar9,uVar5,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar8 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x18) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar8) && (*(int **)(iVar7 + 0x18) = piVar8, *piVar8 == iVar4)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar8,iVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600362E RID: 13870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362E")]
		[Address(RVA = "0x863B", Offset = "0x863B", VA = "0x863B")]
		private void StopListen()
		{
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362F")]
		[Address(RVA = "0x863C", Offset = "0x863C", VA = "0x863C")]
		private void HandleQuestsChanged()
		{
		/* --- GHIDRA: HandleQuestsChanged ---
		void Gameplay_Competition_Control_CompetitionController__HandleQuestsChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Competition_Control_CompetitionController__HandleRun(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003630 RID: 13872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003630")]
		[Address(RVA = "0x863D", Offset = "0x863D", VA = "0x863D")]
		private void HandleDictionariesChangedEvent()
		{
		/* --- GHIDRA: HandleDictionariesChangedEvent ---
		void Gameplay_Competition_Control_CompetitionController__HandleDictionariesChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63acf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_CompetitionController_HandleGetOwnerRatingService__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a63acf = '\x01';
		  }
		  uVar1 = ServicesNamespace_RatingService__GetVoteRTRating(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleGetOwnerRatingService__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003631 RID: 13873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003631")]
		[Address(RVA = "0x863E", Offset = "0x863E", VA = "0x863E")]
		private void RequestOwnerRatingService()
		{
		/* --- GHIDRA: RequestOwnerRatingService ---
		void Gameplay_Competition_Control_CompetitionController__RequestOwnerRatingService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a63ad0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGetCompetitionRatingCounterAns_TypeInfo);
		    DAT_ram_00a63ad0 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar3 = *(int **)(param2 + 0x20);
		  if ((piVar3 != (int *)0x0) &&
		     (Protocol_Rating_ProtoGetCompetitionRatingCounterAns_TypeInfo != *piVar3)) {
		    System_Activator__CreateInstance
		              (piVar3,Protocol_Rating_ProtoGetCompetitionRatingCounterAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = *(int *)(iVar2 + 0x30);
		  uVar1 = piVar3[3];
		  if (DAT_ram_00a63abd == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_OwnerRating_TypeInfo);
		    DAT_ram_00a63abd = '\x01';
		  }
		  if (*(ulonglong *)(iVar2 + 0x10) != (ulonglong)uVar1) {
		    piVar3 = (int *)unnamed_function_1419(iVar2);
		    if (piVar3 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar3 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Competition_Model_OwnerRating_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar3 + 100) +
		                   (uint)*(byte *)(Gameplay_Competition_Model_OwnerRating_TypeInfo + 0xb8) * 4 + -4)
		          != Gameplay_Competition_Model_OwnerRating_TypeInfo)) {
		        System_Activator__CreateInstance(piVar3,Gameplay_Competition_Model_OwnerRating_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    *(ulonglong *)(iVar2 + 0x10) = (ulonglong)uVar1;
		    iVar4 = *(int *)(iVar2 + 8);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),piVar3,iVar2,*(undefined4 *)(iVar4 + 0x14));
		    }
		  }
		  if ((*(char *)((int)param1 + 9) == '\0') &&
		     (iVar2 = param1[8], param1[8] = iVar2 + -1, iVar2 + -1 < 1)) {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    Gameplay_Competition_Control_CompetitionController__ValidateInit(param1,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 8);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003632 RID: 13874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003632")]
		[Address(RVA = "0x863F", Offset = "0x863F", VA = "0x863F")]
		private void HandleGetOwnerRatingService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetOwnerRatingService ---
		void Gameplay_Competition_Control_CompetitionController__HandleGetOwnerRatingService
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63ad1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_Control_CompetitionController_HandleGetStateService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a63ad1 = '\x01';
		  }
		  uVar1 = ServicesNamespace_CompetitionService__ServerEventHandler(*(undefined4 *)(param1 + 0x1c),0)
		  ;
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Competition_Control_CompetitionController_HandleGetStateService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003633 RID: 13875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003633")]
		[Address(RVA = "0x8640", Offset = "0x8640", VA = "0x8640")]
		private void RequestStateService()
		{
		/* --- GHIDRA: RequestStateService ---
		void Gameplay_Competition_Control_CompetitionController__RequestStateService
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a63ad2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Competition_ProtoGetCompetitionStateAns_TypeInfo);
		    DAT_ram_00a63ad2 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Competition_ProtoGetCompetitionStateAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Competition_ProtoGetCompetitionStateAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Competition_Control_CompetitionController__HandleStateChangedEventService
		            (param1,param1_00[3],param1_00);
		  return;
		}
		*/

		}

		// Token: 0x06003634 RID: 13876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003634")]
		[Address(RVA = "0x8641", Offset = "0x8641", VA = "0x8641")]
		private void HandleGetStateService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetStateService ---
		void Gameplay_Competition_Control_CompetitionController__HandleGetStateService
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,param3,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003635 RID: 13877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003635")]
		[Address(RVA = "0x8642", Offset = "0x8642", VA = "0x8642")]
		private void HandleOwnedRatingChangedEvent(OwnerRating from, OwnerRating to)
		{
		/* --- GHIDRA: HandleOwnedRatingChangedEvent ---
		void Gameplay_Competition_Control_CompetitionController__HandleOwnedRatingChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  Gameplay_Competition_Model_OwnerRating__SetValue
		            (*(undefined4 *)(iVar1 + 0x30),*(undefined8 *)(param2 + 0x10),
		             *(undefined4 *)(param2 + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06003636 RID: 13878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003636")]
		[Address(RVA = "0x8643", Offset = "0x8643", VA = "0x8643")]
		private void HandleRatingChangedEventService(ProtoCompetitionRatingChangedEvt msg)
		{
		/* --- GHIDRA: HandleRatingChangedEventService ---
		void Gameplay_Competition_Control_CompetitionController__HandleRatingChangedEventService
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Gameplay_Competition_Control_CompetitionController__HandleStateChangedEventService
		            (param1,*(undefined4 *)(param2 + 0xc),param2);
		  return;
		}
		*/

		}

		// Token: 0x06003637 RID: 13879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003637")]
		[Address(RVA = "0x8644", Offset = "0x8644", VA = "0x8644")]
		private void HandleStateChangedEventService(ProtoCompetitionStateChangedEvt msg)
		{
		/* --- GHIDRA: HandleStateChangedEventService ---
		void Gameplay_Competition_Control_CompetitionController__HandleStateChangedEventService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  bool bVar2;
		  ulonglong uVar3;
		  ulonglong uVar4;
		  undefined4 in_register_20000004;
		  int iVar5;
		  uint *puVar6;
		  int iVar7;
		  undefined4 uVar8;
		  float param2_00;
		  undefined4 uVar9;
		  int iVar10;
		  int *param1_00;
		  undefined8 uVar11;
		  uint uVar12;
		  ulonglong local_10;
		  undefined4 local_4;
		  
		  uVar3 = 0;
		  uVar4 = 0;
		  if (DAT_ram_00a63ad3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_CompetitionData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_EventState__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_EventState___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_EventState__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a63ad3 = '\x01';
		  }
		  local_4 = 0;
		  iVar10 = *(int *)(param2 + 0x10);
		  uVar11 = CONCAT44(in_register_20000004,param1);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (uVar11,*(undefined4 *)(*param1 + 0x104));
		  iVar5 = *(int *)(iVar5 + 0x2c);
		  uVar9 = (undefined4)((ulonglong)uVar11 >> 0x20);
		  if (iVar10 == 0) {
		    uVar11 = CONCAT44(uVar9,param1);
		    iVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                       (uVar11,*(undefined4 *)(*param1 + 0x104));
		    uVar9 = (undefined4)((ulonglong)uVar11 >> 0x20);
		    *(undefined4 *)(iVar10 + 0x2c) = 0;
		    bVar1 = iVar5 != 0;
		  }
		  else {
		    if (iVar5 != 0) {
		      local_10 = 0;
		      System_Data_SqlTypes_SqlInt32___ctor
		                (&local_10,*(undefined4 *)(*(int *)(iVar5 + 0xc) + 0x10),
		                 Method_System_Nullable_uint___ctor__);
		      uVar3 = local_10;
		    }
		    iVar10 = *(int *)(param2 + 0x10);
		    uVar11 = CONCAT44(uVar9,param1);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (uVar11,*(undefined4 *)(*param1 + 0x104));
		    uVar9 = (undefined4)((ulonglong)uVar11 >> 0x20);
		    if (*(int *)(iVar5 + 0x2c) != 0) {
		      local_10 = 0;
		      System_Data_SqlTypes_SqlInt32___ctor
		                (&local_10,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x2c) + 0xc) + 0xc),
		                 Method_System_Nullable_EventState___ctor__);
		      uVar4 = local_10;
		    }
		    iVar5 = *(int *)(param2 + 0xc);
		    bVar2 = (uVar3 & 0xff) == 0 || iVar10 != (int)(uVar3 >> 0x20);
		    if (bVar2) {
		      uVar11 = CONCAT44(uVar9,param1);
		      iVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                         (uVar11,*(undefined4 *)(*param1 + 0x104));
		      uVar9 = (undefined4)((ulonglong)uVar11 >> 0x20);
		      uVar12 = 0;
		      param1_00 = *(int **)(*(int *)(iVar10 + 0xc) + 8);
		      iVar10 = *param1_00;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8)) {
		            puVar6 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8 + 4) * 8 + iVar10 + 0xd0
		                             );
		            goto code_r0x8233b685;
		          }
		          uVar12 = uVar12 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		      }
		      puVar6 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8233b685:
		      uVar11 = CONCAT44(uVar9,param1_00);
		      uVar8 = (**(code **)((ulonglong)*puVar6 * 4))(uVar11,puVar6[1]);
		      uVar9 = (undefined4)((ulonglong)uVar11 >> 0x20);
		      iVar10 = Core_Extensions_Dict_DictExt__TryGetAnnouncementsDic
		                         (uVar8,*(undefined4 *)(param2 + 0x10),&local_4,0);
		      if (iVar10 == 0) {
		        local_10 = CONCAT44(local_10._4_4_,*(undefined4 *)(param2 + 0x10));
		        uVar9 = func_ii_1081(DAT_ram_00a66958,&local_10);
		        uVar8 = unnamed_function_2232(&StringLiteral_5624);
		        uVar9 = func_ii_4419(uVar8,uVar9,0);
		        uVar8 = unnamed_function_2232(&System_Exception_TypeInfo);
		        uVar8 = unnamed_function_1417(uVar8);
		        System_String__Concat(uVar8,uVar9,0);
		        uVar9 = unnamed_function_2232
		                          (&Method_Gameplay_Competition_Control_CompetitionController_SetInfo__);
		        func_ii_1050(uVar8,uVar9);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar11 = CONCAT44(uVar9,param1);
		      iVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                         (uVar11,*(undefined4 *)(*param1 + 0x104));
		      uVar8 = local_4;
		      uVar9 = (undefined4)((ulonglong)uVar11 >> 0x20);
		      iVar7 = unnamed_function_1417(Gameplay_Competition_Model_CompetitionData_TypeInfo);
		      *(int *)(iVar7 + 0xc) = param2;
		      *(undefined4 *)(iVar7 + 8) = uVar8;
		      *(int *)(iVar10 + 0x2c) = iVar7;
		    }
		    bVar1 = (uVar4 & 0xff) == 0 || iVar5 != (int)(uVar4 >> 0x20);
		    if (bVar1) {
		      uVar11 = CONCAT44(uVar9,param1);
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (uVar11,*(undefined4 *)(*param1 + 0x104));
		      uVar9 = (undefined4)((ulonglong)uVar11 >> 0x20);
		      *(int *)(*(int *)(iVar5 + 0x2c) + 0xc) = param2;
		    }
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (CONCAT44(uVar9,param1),*(undefined4 *)(*param1 + 0x104));
		    uVar8 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar8,0.0,0);
		    uVar11 = *(undefined8 *)(param2 + 0x18);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = Utils_StringUtils___cctor(uVar11,0);
		    uVar9 = (undefined4)((ulonglong)uVar11 >> 0x20);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar8,param2_00,0);
		    *(undefined4 *)(iVar5 + 0x20) = uVar8;
		    bVar1 = bVar1 || bVar2;
		  }
		  Gameplay_Competition_Control_CompetitionController__HandleRun(param1,param1);
		  if ((*(char *)((int)param1 + 9) == '\0') &&
		     (iVar5 = param1[8], param1[8] = iVar5 + -1, iVar5 + -1 < 1)) {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    Gameplay_Competition_Control_CompetitionController__ValidateInit(param1,param1);
		    uVar11 = CONCAT44(uVar9,param1);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (uVar11,*(undefined4 *)(*param1 + 0x114));
		    iVar5 = *(int *)(iVar5 + 8);
		    uVar11 = CONCAT44((int)((ulonglong)uVar11 >> 0x20),*(undefined4 *)(iVar5 + 0x20));
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))(uVar11,*(undefined4 *)(iVar5 + 0x14));
		    uVar9 = (undefined4)((ulonglong)uVar11 >> 0x20);
		  }
		  if (bVar1) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (CONCAT44(uVar9,param1),*(undefined4 *)(*param1 + 0x114));
		    iVar5 = *(int *)(iVar5 + 0x14);
		    if (iVar5 != 0) {
		      iVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x104));
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(iVar10 + 0x2c),
		                 *(undefined4 *)(iVar5 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003638 RID: 13880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003638")]
		[Address(RVA = "0x8645", Offset = "0x8645", VA = "0x8645")]
		private void SetInfo([NotNull] CompetitionInfo info)
		{
		/* --- GHIDRA: SetInfo ---
		void Gameplay_Competition_Control_CompetitionController__SetInfo
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a63ad4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionEpView___ctor__
		              );
		    DAT_ram_00a63ad4 = '\x01';
		  }
		  MVC_AbstractController_object__object___set_Model
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractCozyViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionEpView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04001DD6 RID: 7638
		[Token(Token = "0x4001DD6")]
		[FieldOffset(Offset = "0x18")]
		private readonly RatingService _ratingService;

		// Token: 0x04001DD7 RID: 7639
		[Token(Token = "0x4001DD7")]
		[FieldOffset(Offset = "0x1C")]
		private readonly CompetitionService _competitionService;

		// Token: 0x04001DD8 RID: 7640
		[Token(Token = "0x4001DD8")]
		[FieldOffset(Offset = "0x20")]
		private int _initialStepsCount;
	}
}
