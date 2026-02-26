using System;
using Gameplay.Clans.Office.Events.ClanWars;
using Gameplay.Clans.Office.Model.ClanWars;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Office.Controller.ClanWars
{
	// Token: 0x02000A81 RID: 2689
	[Token(Token = "0x2000A81")]
	public class ClanWarsHistoryController : AbstractController<ClanWarsHistoryModel, ClanWarsHistoryEvents>
	{
		// Token: 0x06004039 RID: 16441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004039")]
		[Address(RVA = "0x8EF3", Offset = "0x8EF3", VA = "0x8EF3")]
		public ClanWarsHistoryController(ClanWarsHistoryModel model, ClanWarsHistoryEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a576fd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController_ClanWarDeclaredEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a576fd = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x240);
		        goto code_r0x80dce099;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x30);
		code_r0x80dce099:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = *(int *)(iVar4 + 0x14);
		  param1_01 = *(undefined4 *)(iVar5 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController_ClanWarDeclaredEventHandler__
		             ,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(param1_01,param1_00,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x18) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar5 + 0x18) = piVar3, *piVar3 == iVar4)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600403A RID: 16442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403A")]
		[Address(RVA = "0x8EF4", Offset = "0x8EF4", VA = "0x8EF4", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController__HandleRun
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a576fe == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController_ClanWarDeclaredEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a576fe = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x240);
		        goto code_r0x80dce1e5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x30);
		code_r0x80dce1e5:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = *(int *)(iVar4 + 0x14);
		  param1_01 = *(undefined4 *)(iVar5 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController_ClanWarDeclaredEventHandler__
		             ,0);
		  piVar3 = (int *)func_ii_7048(param1_01,param1_00,0);
		  iVar4 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x18) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(iVar5 + 0x18) = piVar3, *piVar3 == iVar4)) {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600403B RID: 16443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403B")]
		[Address(RVA = "0x8EF5", Offset = "0x8EF5", VA = "0x8EF5", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController__HandleStop
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *piVar3;
		  uint *puVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  undefined4 param2_00;
		  int *piVar8;
		  int iVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a576ff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_SelectMany_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs___ClanWarHistoryListElement_ClanWarHistoryListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs___IEnumerable_ClanWarHistoryListElement_ClanWarHistoryListElementArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController___c__ClanWarDeclaredEventHandler_b__4_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController___c_TypeInfo);
		    DAT_ram_00a576ff = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar6 = *(undefined4 *)(iVar2 + 0x14);
		  if (*(int *)(Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController___c_TypeInfo +
		              0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController___c_TypeInfo)
		    ;
		  }
		  puVar7 = *(undefined4 **)
		            (Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController___c_TypeInfo + 0x5c
		            );
		  iVar2 = puVar7[1];
		  if (iVar2 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController___c_TypeInfo +
		                0x74) == 0) {
		      func_ii_306000(
		                    Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController___c_TypeInfo
		                    );
		      puVar7 = *(undefined4 **)
		                (Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController___c_TypeInfo +
		                0x5c);
		    }
		    param2_00 = *puVar7;
		    iVar2 = unnamed_function_1417
		                      (
		                      System_Func_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs___IEnumerable_ClanWarHistoryListElement_ClanWarHistoryListElementArgs___TypeInfo
		                      );
		    System_Linq_Enumerable__Where_object_
		              (iVar2,param2_00,
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController___c__ClanWarDeclaredEventHandler_b__4_0__
		               ,0);
		    *(int *)(*(int *)(
		                     Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController___c_TypeInfo
		                     + 0x5c) + 4) = iVar2;
		  }
		  uVar1 = 0;
		  piVar3 = (int *)System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                            (uVar6,iVar2,
		                             Method_System_Linq_Enumerable_SelectMany_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs___ClanWarHistoryListElement_ClanWarHistoryListElementArgs___
		                            );
		  iVar2 = *piVar3;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dce3e5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar3,
		                                System_Collections_Generic_IEnumerable_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		                                ,0);
		code_r0x80dce3e5:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar3 = local_4;
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar7 = (undefined4 *)(iVar2 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80dce4b2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80dce5f3:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dce5fb;
		    }
		code_r0x80dce4b2:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(*puVar7,piVar3,puVar7[1]);
		    piVar3 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dce5f3;
		    if (iVar2 == 0) {
		      iVar5 = 5;
		      iVar2 = 0;
		      goto code_r0x80dce648;
		    }
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		            == *piVar8) {
		          puVar7 = (undefined4 *)(iVar2 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80dce58c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x80dce58c:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(*puVar7,piVar3,puVar7[1]);
		    if (DAT_ram_009d3e38 == 1) break;
		    *(undefined4 *)(*(int *)(iVar2 + 0x20) + 0x38) = 0xffffffeb;
		  } while( true );
		  DAT_ram_009d3e38 = 0;
		  uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dce5fb:
		  iVar2 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar5) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar6);
		    iVar2 = *piVar3;
		    iVar5 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar2;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x80dce648:
		      piVar3 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar9 = *local_4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		              puVar4 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80dce6c0;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80dce6c0:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		      }
		      if (iVar2 == 0) {
		        if ((iVar5 == 0) ||
		           ((((iVar5 != 1 && (iVar5 != 2)) && (iVar5 != 3)) && ((iVar5 != 4 && (iVar5 == 5)))))) {
		          iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x114));
		          iVar2 = *(int *)(iVar2 + 0x1c);
		          if (iVar2 != 0) {
		            (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                      (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		          }
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar6 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x352,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(uVar6);
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

		// Token: 0x0600403C RID: 16444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403C")]
		[Address(RVA = "0x8EF6", Offset = "0x8EF6", VA = "0x8EF6")]
		private void ClanWarDeclaredEventHandler()
		{
		/* --- GHIDRA: ClanWarDeclaredEventHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController__ClanWarDeclaredEventHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57700 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController_GetWarsHistoryResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57700 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ClanWarsService__GetActiveWarInfo
		                        (*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController_GetWarsHistoryResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x0600403D RID: 16445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403D")]
		[Address(RVA = "0x8EF7", Offset = "0x8EF7", VA = "0x8EF7")]
		public void RequestWarsHistory(uint linesCount, uint previousWarId)
		{
		/* --- GHIDRA: RequestWarsHistory ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController__RequestWarsHistory
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a57701 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoGetWarsHistoryAns_TypeInfo);
		    DAT_ram_00a57701 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_ClanWar_ProtoGetWarsHistoryAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_ClanWar_ProtoGetWarsHistoryAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel__CreateHistoryList
		            (param1_00,param1_01[3],0);
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

		// Token: 0x0600403E RID: 16446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403E")]
		[Address(RVA = "0x8EF8", Offset = "0x8EF8", VA = "0x8EF8")]
		private void GetWarsHistoryResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetWarsHistoryResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController__GetWarsHistoryResultHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57702 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController_GetFirstWarsHistoryResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57702 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ClanWarsService__GetActiveWarInfo
		                        (*(undefined4 *)(param1 + 0x18),param2,0,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController_GetFirstWarsHistoryResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x0600403F RID: 16447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600403F")]
		[Address(RVA = "0x8EF9", Offset = "0x8EF9", VA = "0x8EF9")]
		public void RequestFirstWarsHistory(uint linesCount)
		{
		/* --- GHIDRA: RequestFirstWarsHistory ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController__RequestFirstWarsHistory
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a57703 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanWar_ProtoGetWarsHistoryAns_TypeInfo);
		    DAT_ram_00a57703 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_ClanWar_ProtoGetWarsHistoryAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_ClanWar_ProtoGetWarsHistoryAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel__GetLastPage(param1_00,param1_01[3],0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004040 RID: 16448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004040")]
		[Address(RVA = "0x8EFA", Offset = "0x8EFA", VA = "0x8EFA")]
		private void GetFirstWarsHistoryResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetFirstWarsHistoryResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController__GetFirstWarsHistoryResultHandler
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57704 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController___c_TypeInfo);
		    DAT_ram_00a57704 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController___c_TypeInfo
		                    );
		  **(undefined4 **)
		    (Gameplay_Clans_Office_Controller_ClanWars_ClanWarsHistoryController___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040023D0 RID: 9168
		[Token(Token = "0x40023D0")]
		[FieldOffset(Offset = "0x18")]
		private ClanWarsService _clanWarsService;
	}
}
