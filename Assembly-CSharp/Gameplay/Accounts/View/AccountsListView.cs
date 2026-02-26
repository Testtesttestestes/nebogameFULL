using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Accounts.Model.Data;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace Gameplay.Accounts.View
{
	// Token: 0x02000DCA RID: 3530
	[Token(Token = "0x2000DCA")]
	public class AccountsListView : MonoBehaviour
	{
		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x06005617 RID: 22039 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700117E")]
		public BankPromotionView PromotionView
		{
			[Token(Token = "0x6005617")]
			[Address(RVA = "0xA3B6", Offset = "0xA3B6", VA = "0xA3B6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x06005618 RID: 22040 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700117F")]
		public MonoPointerClickHandler PromotionClickHandler
		{
			[Token(Token = "0x6005618")]
			[Address(RVA = "0xA3B7", Offset = "0xA3B7", VA = "0xA3B7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x06005619 RID: 22041 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001180")]
		public List<AccountsListItemView> ItemViews
		{
			[Token(Token = "0x6005619")]
			[Address(RVA = "0xA3B8", Offset = "0xA3B8", VA = "0xA3B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x14000204 RID: 516
		// (add) Token: 0x0600561A RID: 22042 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600561B RID: 22043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000204")]
		public event Action<IAccountDataDecorator> ClickOnItem
		{
			[Token(Token = "0x600561A")]
			[Address(RVA = "0xA3B9", Offset = "0xA3B9", VA = "0xA3B9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600561B")]
			[Address(RVA = "0xA3BA", Offset = "0xA3BA", VA = "0xA3BA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600561C RID: 22044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600561C")]
		[Address(RVA = "0xA3BB", Offset = "0xA3BB", VA = "0xA3BB")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Accounts_View_AccountsListView__OnDestroy(int param1,int *param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int param2_00;
		  int iVar6;
		  int param2_01;
		  undefined4 uVar7;
		  int iVar8;
		  int *piVar9;
		  int *piVar10;
		  int iVar11;
		  int local_10;
		  int **local_c;
		  int *local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58890 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_View_AccountsListView_HandleItemSelectEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AccountsListItemView__Add__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_AccountsListItemView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58890 = '\x01';
		  }
		  iVar11 = *param2;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_IAccountDataDecorator__TypeInfo ==
		          *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f38b9d;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_IAccountDataDecorator__TypeInfo
		                                ,0);
		code_r0x80f38b9d:
		  local_8 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  local_10 = 0;
		  local_c = &local_8;
		code_r0x80f38be3:
		  do {
		    piVar9 = local_8;
		    iVar11 = *local_8;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar4 = (undefined4 *)(iVar11 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80f38c77;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f391b0:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f391ea;
		    }
		code_r0x80f38c77:
		    DAT_ram_009d3e38 = 0;
		    iVar11 = import::env::invoke_iii(*puVar4,piVar9,puVar4[1]);
		    piVar9 = local_8;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f391b0;
		    if (iVar11 == 0) goto code_r0x80f39233;
		    iVar11 = *local_8;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_IEnumerator_IAccountDataDecorator__TypeInfo == *piVar10) {
		          puVar4 = (undefined4 *)(iVar11 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80f38d52;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                        System_Collections_Generic_IEnumerator_IAccountDataDecorator__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f391e2:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f391ea;
		    }
		code_r0x80f38d52:
		    DAT_ram_009d3e38 = 0;
		    iVar11 = import::env::invoke_iii(*puVar4,piVar9,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f391e2;
		    iVar8 = DAT_ram_009d3e38;
		    if (DAT_ram_00a58892 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (0x7ff,&
		                       Method_System_Collections_Generic_Dictionary_Type__AccountsListItemView__TryGetValue__
		                );
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_00a58892 = '\x01';
		        iVar8 = DAT_ram_009d3e38;
		        goto code_r0x80f38dd4;
		      }
		code_r0x80f391d8:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f391ea;
		    }
		code_r0x80f38dd4:
		    DAT_ram_009d3e38 = 0;
		    local_4 = 0;
		    uVar7 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1aa,param1,iVar8);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f391d8;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0xbb,iVar11,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f391d8;
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x49,uVar7,uVar5,&local_4,
		                       Method_System_Collections_Generic_Dictionary_Type__AccountsListItemView__TryGetValue__
		                      );
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f391d8;
		    puVar4 = &local_4;
		    if (iVar8 == 0) {
		      puVar4 = (undefined4 *)(param1 + 0x10);
		    }
		    uVar7 = *puVar4;
		    uVar5 = *(undefined4 *)(param1 + 0x18);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f391ea;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar7,uVar5,
		                           Method_UnityEngine_Object_Instantiate_AccountsListItemView___);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f391ea;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_IAccountDataDecorator__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f391ba:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f391ea;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar7,param1,
		               Method_Gameplay_Accounts_View_AccountsListView_HandleItemSelectEvent__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f391ba;
		    if (DAT_ram_00a58886 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_IAccountDataDecorator__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f391ba;
		      DAT_ram_00a58886 = '\x01';
		    }
		    iVar8 = *(int *)(param2_00 + 0x30);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 5,iVar8,uVar7,0);
		      uVar5 = System_Action_IAccountDataDecorator__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3919c:
		        DAT_ram_009d3e38 = 0;
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f391ea;
		      }
		      if (iVar6 == 0) {
		        param2_01 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        param2_01 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar6,
		                               System_Action_IAccountDataDecorator__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f3919c;
		        if (param2_01 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar6,uVar5);
		          iVar11 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar11 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f391ea;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar6 = func_ii_4329(param2_00 + 0x30,param2_01,iVar8);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f3919c;
		      bVar1 = iVar8 != iVar6;
		      iVar8 = iVar6;
		    } while (bVar1);
		    if (*(int *)(param2_00 + 0x34) != iVar11) {
		      *(int *)(param2_00 + 0x34) = iVar11;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1ab,param2_00,iVar6);
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f391ea;
		      }
		    }
		    iVar11 = Method_System_Collections_Generic_List_AccountsListItemView__Add__;
		    iVar8 = *(int *)(param1 + 0x24);
		    *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		    uVar2 = *(uint *)(iVar8 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		      *(uint *)(iVar8 + 0xc) = uVar2 + 1;
		      *(int *)(*(int *)(iVar8 + 8) + uVar2 * 4 + 0x10) = param2_00;
		      goto code_r0x80f38be3;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,param2_00,
		               *(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar11 != 1);
		  uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f391ea:
		  iVar11 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar11 == iVar8) {
		    piVar9 = (int *)import::env::__cxa_begin_catch(uVar7);
		    local_10 = *piVar9;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 != 1) {
		code_r0x80f39233:
		      DAT_ram_009d3e38 = 0;
		      piVar9 = *local_c;
		      if (piVar9 != (int *)0x0) {
		        uVar2 = 0;
		        iVar11 = *piVar9;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8)) {
		              puVar3 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x80f392ae;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar9,System_IDisposable_TypeInfo,0);
		code_r0x80f392ae:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar9,puVar3[1]);
		      }
		      if (local_10 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_10);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar7 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1ac,&local_10);
		  iVar11 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar11 == 1) {
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

		// Token: 0x0600561D RID: 22045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600561D")]
		[Address(RVA = "0xA3BC", Offset = "0xA3BC", VA = "0xA3BC")]
		public void SetItems(IEnumerable<IAccountDataDecorator> items)
		{
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600561E")]
		[Address(RVA = "0xA3BD", Offset = "0xA3BD", VA = "0xA3BD")]
		private void HandleItemSelectEvent(IAccountDataDecorator accountDataDecorator)
		{
		/* --- GHIDRA: HandleItemSelectEvent ---
		undefined4
		Gameplay_Accounts_View_AccountsListView__HandleItemSelectEvent
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int iVar1;
		  undefined4 *puVar2;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58892 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Type__AccountsListItemView__TryGetValue__
		              );
		    DAT_ram_00a58892 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = func_ii_7472(param1,auStack_10);
		  param2_00 = unnamed_function_143827(param2);
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (param1_00,param2_00,&local_4,
		                     Method_System_Collections_Generic_Dictionary_Type__AccountsListItemView__TryGetValue__
		                    );
		  puVar2 = &local_4;
		  if (iVar1 == 0) {
		    puVar2 = (undefined4 *)(param1 + 0x10);
		  }
		  return *puVar2;
		}
		*/

		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x0600561F RID: 22047 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001181")]
		public Dictionary<Type, AccountsListItemView> MapOfListItemPrefabs
		{
			[Token(Token = "0x600561F")]
			[Address(RVA = "0x1D31", Offset = "0x1D31", VA = "0x1D31")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005620")]
		[Address(RVA = "0xA3BE", Offset = "0xA3BE", VA = "0xA3BE")]
		public AccountsListItemView GetListITemPrefab(IAccountDataDecorator account)
		{
		/* --- GHIDRA: GetListITemPrefab ---
		void Gameplay_Accounts_View_AccountsListView__GetListITemPrefab(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58893 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AccountsListItemView___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AccountsListItemView__TypeInfo);
		    DAT_ram_00a58893 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_AccountsListItemView__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,10,Method_System_Collections_Generic_List_AccountsListItemView___ctor__);
		  *(undefined4 *)(param1 + 0x24) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005621 RID: 22049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005621")]
		[Address(RVA = "0xA3BF", Offset = "0xA3BF", VA = "0xA3BF")]
		public AccountsListView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Accounts_View_AccountsListView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58894 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12554);
		    DAT_ram_00a58894 = '\x01';
		  }
		  return StringLiteral_12554;
		}
		*/

		}

		// Token: 0x04002EB0 RID: 11952
		[Token(Token = "0x4002EB0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AccountsListItemView _defaultListItemPrefab;

		// Token: 0x04002EB1 RID: 11953
		[Token(Token = "0x4002EB1")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private AccountsListItemView _clanListItemPrefab;

		// Token: 0x04002EB2 RID: 11954
		[Token(Token = "0x4002EB2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemsContainer;

		// Token: 0x04002EB3 RID: 11955
		[Token(Token = "0x4002EB3")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BankPromotionView _promotion;

		// Token: 0x04002EB4 RID: 11956
		[Token(Token = "0x4002EB4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MonoPointerClickHandler _promotionClickHandler;

		// Token: 0x04002EB7 RID: 11959
		[Token(Token = "0x4002EB7")]
		[FieldOffset(Offset = "0x2C")]
		private Dictionary<Type, AccountsListItemView> _mapOfListItemPrefabs;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ItemViews ---
		void Gameplay_Accounts_View_AccountsListView__get_ItemViews
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5888d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAccountDataDecorator__TypeInfo);
		    DAT_ram_00a5888d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IAccountDataDecorator__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAccountDataDecorator__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
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


		/* --- GHIDRA: add_ClickOnItem ---
		void Gameplay_Accounts_View_AccountsListView__add_ClickOnItem
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5888e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAccountDataDecorator__TypeInfo);
		    DAT_ram_00a5888e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IAccountDataDecorator__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAccountDataDecorator__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ClickOnItem ---
		void Gameplay_Accounts_View_AccountsListView__remove_ClickOnItem(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param3;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int param2_00;
		  undefined4 uVar5;
		  int *piVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5888f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_View_AccountsListView_HandleItemSelectEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AccountsListItemView__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AccountsListItemView__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AccountsListItemView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AccountsListItemView__GetEnumerator__);
		    DAT_ram_00a5888f = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x24),
		             Method_System_Collections_Generic_List_AccountsListItemView__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_AccountsListItemView__MoveNext__
		                      );
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f389e0:
		      iVar2 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 == iVar3) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		        iVar3 = *piVar6;
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
		        uVar5 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1a9,&local_18);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 != 1) {
		        import::env::__resumeException(uVar5);
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
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar2 = local_8._4_4_;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_IAccountDataDecorator__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f389d8:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f389e0;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar5,param1,
		               Method_Gameplay_Accounts_View_AccountsListView_HandleItemSelectEvent__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f389d8;
		    if (DAT_ram_00a58887 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_IAccountDataDecorator__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f389d8;
		      DAT_ram_00a58887 = '\x01';
		    }
		    iVar3 = *(int *)(iVar2 + 0x30);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar3,uVar5,0);
		      param3 = System_Action_IAccountDataDecorator__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f389c4:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f389e0;
		      }
		      if (iVar4 == 0) {
		        param2_00 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        param2_00 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar4,
		                               System_Action_IAccountDataDecorator__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f389c4;
		        if (param2_00 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar4,param3);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f389e0;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = func_ii_4329(iVar2 + 0x30,param2_00,iVar3);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f389c4;
		      bVar1 = iVar3 != iVar4;
		      iVar3 = iVar4;
		    } while (bVar1);
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_MapOfListItemPrefabs ---
		void Gameplay_Accounts_View_AccountsListView__get_MapOfListItemPrefabs(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5888a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_AccountsListItemView_States__set_CurrentState__);
		    DAT_ram_00a5888a = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 0x34);
		  if (piVar5 != (int *)0x0) {
		    uVar1 = 0;
		    piVar6 = *(int **)(param1 + 0x1c);
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f380c2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo
		                                  ,0);
		code_r0x80f380c2:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    iVar7 = *piVar6;
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		              (piVar6,uVar3,*(undefined4 *)(iVar7 + 0x2d4));
		    uVar1 = 0;
		    uVar3 = *(undefined4 *)(param1 + 0x20);
		    piVar5 = *(int **)(param1 + 0x34);
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		          goto code_r0x80f3815c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo
		                                  ,1);
		code_r0x80f3815c:
		    uVar1 = 0;
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar4 = Core_Extensions_Dict_AccountDicExt__GetClarificationDescription(uVar4,0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar3,uVar4,0);
		    piVar5 = *(int **)(param1 + 0x34);
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		          goto code_r0x80f381ed;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo
		                                  ,2);
		code_r0x80f381ed:
		    iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    if (iVar7 == 0) {
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (param1,2,
		                 Method_UI_MonoBehaviourWithStates_AccountsListItemView_States__set_CurrentState__);
		    }
		    else {
		      uVar1 = 0;
		      piVar5 = *(int **)(param1 + 0x34);
		      iVar7 = *piVar5;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (Core_Data_Accounts_IAccountData_TypeInfo ==
		              *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		            goto code_r0x80f38274;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f38274:
		      uVar1 = 0;
		      uVar3 = 2;
		      iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      if (iVar7 == 0) {
		        uVar3 = 1;
		      }
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (param1,uVar3,
		                 Method_UI_MonoBehaviourWithStates_AccountsListItemView_States__set_CurrentState__);
		      uVar3 = *(undefined4 *)(param1 + 0x24);
		      piVar5 = *(int **)(param1 + 0x34);
		      iVar7 = *piVar5;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (Core_Data_Accounts_IAccountData_TypeInfo ==
		              *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 200);
		            goto code_r0x80f38311;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Data_Accounts_IAccountData_TypeInfo,1);
		code_r0x80f38311:
		      uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      UI_Elements_RightPanel_TitleWithLevel__set_Level(uVar3,uVar4,0);
		    }
		    uVar1 = 0;
		    uVar3 = *(undefined4 *)(param1 + 0x28);
		    piVar5 = *(int **)(param1 + 0x34);
		    iVar7 = *piVar5;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe8);
		          goto code_r0x80f383b7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo
		                                  ,5);
		code_r0x80f383b7:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar4 = func_ii_7483(uVar4,0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar3,uVar4,0);
		  }
		  return;
		}
		*/

}
