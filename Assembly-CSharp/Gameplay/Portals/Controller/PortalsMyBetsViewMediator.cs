using System;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Gameplay.Portals.View.MyBetsTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005DC RID: 1500
	[Token(Token = "0x20005DC")]
	public class PortalsMyBetsViewMediator : AbstractViewMediator<PortalsMyBetsModel, PortalsEvents, PortalsMyBetsController, PortalsMyBetsView>, IHideableMediator
	{
		// Token: 0x06002431 RID: 9265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002431")]
		[Address(RVA = "0x7580", Offset = "0x7580", VA = "0x7580")]
		public PortalsMyBetsViewMediator(PortalsMyBetsModel model, PortalsEvents events, PortalsMyBetsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Controller_PortalsMyBetsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58160 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsMyBetsModel__PortalsEvents__PortalsMyBetsController__PortalsMyBetsView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsMyBetsViewMediator_ShowBets__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsMyBetsViewMediator_ShowHistory__);
		    DAT_ram_00a58160 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x4c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsMyBetsViewMediator_ShowHistory__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x4c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x4c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Portals_Controller_PortalsMyBetsViewMediator_ShowBets__,
		               0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x3c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x3c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x4c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsMyBetsViewMediator_ShowHistory__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x4c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x4c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_Portals_Controller_PortalsMyBetsViewMediator_ShowBets__,
		               0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x3c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x3c) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170006D1 RID: 1745
		// (set) Token: 0x06002432 RID: 9266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D1")]
		public override PortalsEvents Events
		{
			[Token(Token = "0x6002432")]
			[Address(RVA = "0x7581", Offset = "0x7581", VA = "0x7581", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (set) Token: 0x06002433 RID: 9267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D2")]
		public override PortalsMyBetsView View
		{
			[Token(Token = "0x6002433")]
			[Address(RVA = "0x7582", Offset = "0x7582", VA = "0x7582", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002434")]
		[Address(RVA = "0x7583", Offset = "0x7583", VA = "0x7583", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_Portals_Controller_PortalsMyBetsViewMediator__Hide(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  int iVar3;
		  uint uVar4;
		  int iVar5;
		  uint uVar6;
		  uint uVar7;
		  
		  iVar5 = 0;
		  uVar6 = 0;
		  uVar4 = 0;
		  if (DAT_ram_00a58162 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsMyBetsModel__PortalsEvents__PortalsMyBetsController__PortalsMyBetsView__Dispose__
		              );
		    DAT_ram_00a58162 = '\x01';
		  }
		  if (DAT_ram_00a58163 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsMyBetsModel__PortalsEvents__PortalsMyBetsController__PortalsMyBetsView__get_Model__
		              );
		    DAT_ram_00a58163 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 8) + 0x4c);
		  uVar2 = *(uint *)(iVar1 + 0xc);
		  if (0 < (int)uVar2) {
		    if (3 < uVar2) {
		      iVar3 = iVar1 + 0x10;
		      do {
		        uVar7 = iVar5 * 4;
		        *(undefined4 *)(*(int *)(iVar3 + uVar7) + 0x24) = 0;
		        *(undefined4 *)(*(int *)(iVar3 + (uVar7 | 4)) + 0x24) = 0;
		        *(undefined4 *)(*(int *)(iVar3 + (uVar7 | 8)) + 0x24) = 0;
		        *(undefined4 *)(*(int *)(iVar3 + (uVar7 | 0xc)) + 0x24) = 0;
		        iVar5 = iVar5 + 4;
		        uVar4 = uVar4 + 4;
		      } while (uVar4 != (uVar2 & 0xfffffffc));
		    }
		    if ((uVar2 & 3) != 0) {
		      do {
		        *(undefined4 *)(*(int *)(iVar1 + iVar5 * 4 + 0x10) + 0x24) = 0;
		        iVar5 = iVar5 + 1;
		        uVar6 = uVar6 + 1;
		      } while (uVar6 != (uVar2 & 3));
		    }
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_PortalsMyBetsModel__PortalsEvents__PortalsMyBetsController__PortalsMyBetsView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002435 RID: 9269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002435")]
		[Address(RVA = "0x7584", Offset = "0x7584", VA = "0x7584", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Portals_Controller_PortalsMyBetsViewMediator__Dispose(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  uint uVar3;
		  int iVar4;
		  uint uVar5;
		  uint uVar6;
		  uint uVar7;
		  
		  uVar6 = 0;
		  uVar5 = 0;
		  if (DAT_ram_00a58163 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsMyBetsModel__PortalsEvents__PortalsMyBetsController__PortalsMyBetsView__get_Model__
		              );
		    DAT_ram_00a58163 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 8) + 0x4c);
		  uVar3 = *(uint *)(iVar2 + 0xc);
		  if (0 < (int)uVar3) {
		    iVar1 = 0;
		    if (3 < uVar3) {
		      iVar4 = iVar2 + 0x10;
		      do {
		        uVar7 = iVar1 * 4;
		        *(undefined4 *)(*(int *)(iVar4 + uVar7) + 0x24) = 0;
		        *(undefined4 *)(*(int *)(iVar4 + (uVar7 | 4)) + 0x24) = 0;
		        *(undefined4 *)(*(int *)(iVar4 + (uVar7 | 8)) + 0x24) = 0;
		        *(undefined4 *)(*(int *)(iVar4 + (uVar7 | 0xc)) + 0x24) = 0;
		        iVar1 = iVar1 + 4;
		        uVar5 = uVar5 + 4;
		      } while (uVar5 != (uVar3 & 0xfffffffc));
		    }
		    if ((uVar3 & 3) != 0) {
		      do {
		        *(undefined4 *)(*(int *)(iVar2 + iVar1 * 4 + 0x10) + 0x24) = 0;
		        iVar1 = iVar1 + 1;
		        uVar6 = uVar6 + 1;
		      } while (uVar6 != (uVar3 & 3));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002436 RID: 9270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002436")]
		[Address(RVA = "0x7585", Offset = "0x7585", VA = "0x7585")]
		private void Unsubscribe()
		{
		/* --- GHIDRA: Unsubscribe ---
		void Gameplay_Portals_Controller_PortalsMyBetsViewMediator__Unsubscribe
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Portals_Controller_PortalsMyBetsController___ctor(uVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002437 RID: 9271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002437")]
		[Address(RVA = "0x7586", Offset = "0x7586", VA = "0x7586")]
		private void Init()
		{
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002438")]
		[Address(RVA = "0x7587", Offset = "0x7587", VA = "0x7587")]
		private void RequestHistory()
		{
		/* --- GHIDRA: RequestHistory ---
		void Gameplay_Portals_Controller_PortalsMyBetsViewMediator__RequestHistory
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Portals_Controller_PortalsMyBetsViewMediator__ShowHistory(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002439")]
		[Address(RVA = "0x7588", Offset = "0x7588", VA = "0x7588")]
		private void ShowHistory()
		{
		/* --- GHIDRA: ShowHistory ---
		void Gameplay_Portals_Controller_PortalsMyBetsViewMediator__ShowHistory
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  uint *puVar7;
		  int iVar8;
		  undefined4 param2_00;
		  int *piVar9;
		  undefined4 uVar10;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58164 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsMyBetsModel__PortalsEvents__PortalsMyBetsController__PortalsMyBetsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_StageInPortalsMyBetsListElement_StageInPortalsMyBetsListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsMyBetsView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_StageInPortalsMyBetsListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsMyBetsViewMediator_HandleClick__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a58164 = '\x01';
		  }
		  local_8 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(iVar2 + 0x28),0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar2 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80eaa6ba;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80eaa8fd:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eaa905;
		    }
		code_r0x80eaa6ba:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80eaa8fd;
		    if (iVar2 == 0) goto code_r0x80eaa94e;
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(piVar9[1] * 8 + iVar2 + 200);
		          goto code_r0x80eaa797;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80eaa8df:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80eaa905;
		    }
		code_r0x80eaa797:
		    DAT_ram_009d3e38 = 0;
		    piVar6 = (int *)import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80eaa8df;
		    if (piVar6 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar6 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar6 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar6,
		                   UnityEngine_Transform_TypeInfo);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80eaa905;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar6,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar4,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80eaa905:
		  iVar2 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    local_14 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		code_r0x80eaa94e:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar6 = (int *)*local_c;
		      if (piVar6 != (int *)0x0) {
		        iVar2 = *piVar6;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		              puVar7 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80eaa9de;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x80eaa9de:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		      }
		      if (local_14 == 0) {
		        iVar2 = 0;
		        iVar5 = *(int *)(param1[2] + 0x4c);
		        if (0 < *(int *)(iVar5 + 0xc)) {
		          do {
		            iVar8 = *(int *)(iVar5 + iVar2 * 4 + 0x10);
		            uVar4 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		            func_ii_6877(uVar4,param1,
		                         Method_Gameplay_Portals_Controller_PortalsMyBetsViewMediator_HandleClick__,
		                         0);
		            *(undefined4 *)(iVar8 + 0x24) = uVar4;
		            iVar2 = iVar2 + 1;
		          } while (iVar2 < *(int *)(iVar5 + 0xc));
		        }
		        iVar2 = 0;
		        uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        uVar10 = 3;
		        iVar8 = Sirenix_Utilities_LinqExtensions__IsNullOrEmpty_object_
		                          (iVar5,
		                           Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_StageInPortalsMyBetsListElement_StageInPortalsMyBetsListElementArgs___
		                          );
		        if (iVar8 == 0) {
		          uVar10 = 1;
		        }
		        Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                  (uVar4,uVar10,
		                   Method_UI_MonoBehaviourWithStates_PortalsMyBetsView_State__set_CurrentState__);
		        if (0 < *(int *)(iVar5 + 0xc)) {
		          do {
		            uVar4 = *(undefined4 *)(iVar5 + iVar2 * 4 + 0x10);
		            iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x15c));
		            uVar10 = *(undefined4 *)(iVar8 + 0x2c);
		            iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x15c));
		            param2_00 = *(undefined4 *)(iVar8 + 0x28);
		            if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		              func_ii_306000(UnityEngine_Object_TypeInfo);
		            }
		            uVar10 = func_ii_6805(uVar10,param2_00,
		                                  Method_UnityEngine_Object_Instantiate_StageInPortalsMyBetsListElement___
		                                 );
		            Gameplay_Portals_View_MyBetsTab_PortalsMyBetsView___ctor(uVar10,uVar4,iVar5);
		            iVar2 = iVar2 + 1;
		          } while (iVar2 < *(int *)(iVar5 + 0xc));
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_14);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x114,&local_14);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600243A RID: 9274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243A")]
		[Address(RVA = "0x7589", Offset = "0x7589", VA = "0x7589")]
		private void UpdateHistoryList()
		{
		/* --- GHIDRA: UpdateHistoryList ---
		void Gameplay_Portals_Controller_PortalsMyBetsViewMediator__UpdateHistoryList
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Portals_Controller_PortalsMyBetsController__OnUpdateBetsHistory(param1_00,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243B")]
		[Address(RVA = "0x758A", Offset = "0x758A", VA = "0x758A")]
		private void HandleClick(ulong betId)
		{
		/* --- GHIDRA: HandleClick ---
		void Gameplay_Portals_Controller_PortalsMyBetsViewMediator__HandleClick
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58165 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsMyBetsModel__PortalsEvents__PortalsMyBetsController__PortalsMyBetsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28579);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20503);
		    DAT_ram_00a58165 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar4 = *(int **)(iVar1 + 0x20);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_12155,1,0,1,0,0,0,0);
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_8 = *(undefined8 *)(*(int *)(param1[2] + 0x54) + 0x10);
		  uVar3 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar3 = func_ii_4419(StringLiteral_28579,uVar3,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_20503,uVar3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar1 + 0x10) = local_10;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar1,0);
		  iVar1 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  Gameplay_Portals_Controller_PortalsMyBetsViewMediator__ShowBets(param1,&local_10);
		  return;
		}
		*/

		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243C")]
		[Address(RVA = "0x758B", Offset = "0x758B", VA = "0x758B")]
		private void ShowBets()
		{
		/* --- GHIDRA: ShowBets ---
		void Gameplay_Portals_Controller_PortalsMyBetsViewMediator__ShowBets(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58166 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsMyBetsModel__PortalsEvents__PortalsMyBetsController__PortalsMyBetsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsMyBetsView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInPortalsTotalizatorViewsHolder__get_IsInitialized__
		              );
		    DAT_ram_00a58166 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar1 + 0x1c) + 0x50) != '\0') {
		    uVar2 = *(undefined4 *)(param1[2] + 0x50);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1_00,2,
		               Method_UI_MonoBehaviourWithStates_PortalsMyBetsView_State__set_CurrentState__);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = **(int **)(iVar1 + 0x1c);
		    (**(code **)((ulonglong)
		                 *(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar3 + 0x10) * 4))
		              (*(int **)(iVar1 + 0x1c),uVar2,
		               *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243D")]
		[Address(RVA = "0x758C", Offset = "0x758C", VA = "0x758C")]
		private void UpdateOSAView()
		{
		/* --- GHIDRA: UpdateOSAView ---
		void Gameplay_Portals_Controller_PortalsMyBetsViewMediator__UpdateOSAView
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Portals_Controller_PortalsMyBetsController___ctor(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600243E RID: 9278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243E")]
		[Address(RVA = "0x758D", Offset = "0x758D", VA = "0x758D")]
		private void AllBetsButtonClickHandler()
		{
		/* --- GHIDRA: AllBetsButtonClickHandler ---
		void Gameplay_Portals_Controller_PortalsMyBetsViewMediator__AllBetsButtonClickHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58167 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_PortalsRatingModel__PortalsEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_RatingService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58167 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_PortalsRatingModel__PortalsEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_RatingService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Portals_Controller_PortalsMyBetsViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58161 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsMyBetsModel__PortalsEvents__PortalsMyBetsController__PortalsMyBetsView__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsMyBetsViewMediator_AllBetsButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58161 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Portals_Controller_PortalsMyBetsViewMediator_AllBetsButtonClickHandler__
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
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x24) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Portals_Controller_PortalsMyBetsViewMediator_AllBetsButtonClickHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    Gameplay_Portals_Controller_PortalsMyBetsController___ctor(uVar1,param1);
		  }
		  return;
		}
		*/

}
