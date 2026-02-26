using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Accounts.View.Banners;
using Gameplay.Isles.User;
using Gameplay.Shop;
using Il2CppDummyDll;
using TMPro;
using UI.Elements;
using UnityEngine;

namespace UI.Windows.Buildings.ShopWindow
{
	// Token: 0x020002B8 RID: 696
	[Token(Token = "0x20002B8")]
	public class ShopWindow : BaseBuildingWindow<ShopWindow.ShopWindowArgs>
	{
		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600105B RID: 4187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000264")]
		public override string WindowId
		{
			[Token(Token = "0x600105B")]
			[Address(RVA = "0x6259", Offset = "0x6259", VA = "0x6259", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000265")]
		public List<ShopItem> Items
		{
			[Token(Token = "0x600105C")]
			[Address(RVA = "0x625A", Offset = "0x625A", VA = "0x625A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000266")]
		public List<ShopItem> GoldItems
		{
			[Token(Token = "0x600105D")]
			[Address(RVA = "0x625B", Offset = "0x625B", VA = "0x625B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x14000102 RID: 258
		// (add) Token: 0x0600105E RID: 4190 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600105F RID: 4191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000102")]
		public event Action<int, ShopItem> SelectSlotEvent
		{
			[Token(Token = "0x600105E")]
			[Address(RVA = "0x625C", Offset = "0x625C", VA = "0x625C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600105F")]
			[Address(RVA = "0x625D", Offset = "0x625D", VA = "0x625D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001060")]
		[Address(RVA = "0x625E", Offset = "0x625E", VA = "0x625E", Slot = "22")]
		protected override void OnShow(ShopWindow.ShopWindowArgs args)
		{
		/* --- GHIDRA: <Init>g__SpawnShopItemInstance|25_0 ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow___Init_g__SpawnShopItemInstance_25_0
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a58a8c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseIsleBuildingWindowArgs_UserIsle___ctor__);
		    DAT_ram_00a58a8c = '\x01';
		  }
		  Core_GameResources_BaseGameResourcesFabric_object__object___get_TotalResourceCount
		            (param1,param2,param3,
		             Method_UI_Windows_Buildings_BaseIsleBuildingWindowArgs_UserIsle___ctor__);
		  return;
		}
		*/

		/* --- GHIDRA: OnShow ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58abb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ShopItem__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingWindow_ShopWindow_ShopWindowArgs__UserIsle__OnClose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ShopItem__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ShopItem__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ShopItem__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ShopItem__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_ShopWindow_ShopWindow_OnShopItemClick__);
		    DAT_ram_00a58abb = '\x01';
		  }
		  UI_Windows_Buildings_BaseBuildingWindow_object____Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Windows_Buildings_BaseBuildingWindow_ShopWindow_ShopWindowArgs__UserIsle__OnClose__
		            );
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1 + 0x58),
		             Method_System_Collections_Generic_List_ShopItem__GetEnumerator__);
		  local_8 = local_18;
		  local_10 = CONCAT44(puStack_1c,local_20);
		  local_20 = 0;
		  puStack_1c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_ShopItem__MoveNext__);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f708d1;
		    }
		    if (iVar1 == 0) goto code_r0x80f70927;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_ShopItem__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		               Method_UI_Windows_Buildings_ShopWindow_ShopWindow_OnShopItemClick__,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x237,uVar2,uVar4,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f708d1:
		  iVar5 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80f70927:
		      DAT_ram_009d3e38 = 0;
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_20,*(undefined4 *)(param1 + 0x5c),
		                 Method_System_Collections_Generic_List_ShopItem__GetEnumerator__);
		      local_8 = local_18;
		      local_10 = CONCAT44(puStack_1c,local_20);
		      local_20 = 0;
		      puStack_1c = &local_10;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar1 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                           Method_System_Collections_Generic_List_Enumerator_ShopItem__MoveNext__);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f70aa6;
		        }
		        if (iVar1 == 0) goto code_r0x80f70afc;
		        DAT_ram_009d3e38 = 0;
		        uVar2 = local_8._4_4_;
		        uVar4 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Action_ShopItem__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		                   Method_UI_Windows_Buildings_ShopWindow_ShopWindow_OnShopItemClick__,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x237,uVar2,uVar4,0);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f70aa6:
		      iVar5 = global_1;
		      iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar5 == iVar1) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar1 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar1;
		        import::env::invoke_v(0x123);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 != 1) {
		          if (iVar1 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80f70afc:
		          DAT_ram_009d3e38 = 0;
		          iVar5 = **(int **)(param1 + 100);
		          (**(code **)((ulonglong)*(uint *)(iVar5 + 0x130) * 4))
		                    (*(int **)(param1 + 100),*(undefined4 *)(iVar5 + 0x134));
		          iVar5 = Gameplay_Shop_ShopModel__set_Artifacts(*(undefined4 *)(param1 + 0x70),0);
		          if (iVar5 == 0) {
		            MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x68),0);
		            iVar5 = **(int **)(param1 + 0x68);
		            (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe8) * 4))
		                      (*(int **)(param1 + 0x68),*(undefined4 *)(iVar5 + 0xec));
		            iVar5 = **(int **)(param1 + 0x70);
		            (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe8) * 4))
		                      (*(int **)(param1 + 0x70),*(undefined4 *)(iVar5 + 0xec));
		          }
		          *(undefined8 *)(param1 + 100) = 0;
		          *(undefined8 *)(param1 + 0x6c) = 0;
		          return;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x239,&local_20);
		      goto joined_r0x80f70bb6;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x238,&local_20);
		joined_r0x80f70bb6:
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

		// Token: 0x06001061 RID: 4193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001061")]
		[Address(RVA = "0x625F", Offset = "0x625F", VA = "0x625F", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__OnClose(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x60);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0x3c),param2,
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001062")]
		[Address(RVA = "0x6260", Offset = "0x6260", VA = "0x6260")]
		private void OnShopItemClick(ShopItem item)
		{
		/* --- GHIDRA: OnShopItemClick ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__OnShopItemClick
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param2_00;
		  uint uVar3;
		  int iVar4;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a58abc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ShopItem__Add__);
		    DAT_ram_00a58abc = '\x01';
		  }
		  if (0 < param2) {
		    iVar4 = 0;
		    do {
		      uVar2 = UI_Windows_Buildings_ShopWindow_ShopWindow___ctor(param1,param2_00);
		      UI_Elements_ShopItem__OnDestroy(uVar2,iVar4,0);
		      func_ii_7619(uVar2,0,0);
		      iVar1 = Method_System_Collections_Generic_List_ShopItem__Add__;
		      param2_00 = *(int *)(param1 + 0x58);
		      *(int *)(param2_00 + 0x10) = *(int *)(param2_00 + 0x10) + 1;
		      uVar3 = *(uint *)(param2_00 + 0xc);
		      if (uVar3 < *(uint *)(*(int *)(param2_00 + 8) + 0xc)) {
		        *(uint *)(param2_00 + 0xc) = uVar3 + 1;
		        *(undefined4 *)(*(int *)(param2_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param2_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      }
		      iVar4 = iVar4 + 1;
		    } while (iVar4 != param2);
		  }
		  iVar4 = param2 + param3;
		  if (param2 < iVar4) {
		    do {
		      uVar2 = UI_Windows_Buildings_ShopWindow_ShopWindow___ctor(param1,param2_00);
		      UI_Elements_ShopItem__OnDestroy(uVar2,param2,0);
		      func_ii_7619(uVar2,1,0);
		      iVar1 = Method_System_Collections_Generic_List_ShopItem__Add__;
		      param2_00 = *(int *)(param1 + 0x5c);
		      *(int *)(param2_00 + 0x10) = *(int *)(param2_00 + 0x10) + 1;
		      uVar3 = *(uint *)(param2_00 + 0xc);
		      if (uVar3 < *(uint *)(*(int *)(param2_00 + 8) + 0xc)) {
		        *(uint *)(param2_00 + 0xc) = uVar3 + 1;
		        *(undefined4 *)(*(int *)(param2_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param2_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      }
		      param2 = param2 + 1;
		    } while (param2 != iVar4);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001063")]
		[Address(RVA = "0x6261", Offset = "0x6261", VA = "0x6261")]
		public void Init(int normalSlotsCount, int nebomarketSlotsCount)
		{
		/* --- GHIDRA: Init ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__Init
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a58abd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_ShopArtifactDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_ShopArtifactDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ShopItem__get_Item__);
		    DAT_ram_00a58abd = '\x01';
		  }
		  iVar8 = *param3;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_ShopArtifactDataDecorator__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f70f5e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,
		                                System_Collections_Generic_IEnumerable_ShopArtifactDataDecorator__TypeInfo
		                                ,0);
		code_r0x80f70f5e:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80f7102d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f7122a:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f71232;
		    }
		code_r0x80f7102d:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f7122a;
		    if (iVar8 == 0) {
		      iVar6 = 0;
		      goto code_r0x80f7127b;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ShopArtifactDataDecorator__TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80f71107;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ShopArtifactDataDecorator__TypeInfo,0
		                       );
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f71202:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f71232;
		    }
		code_r0x80f71107:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f71202;
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22a,
		                           *(undefined4 *)(param1 + 0x58),iVar6,
		                           Method_System_Collections_Generic_List_ShopItem__get_Item__);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f71232;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x23a,param2_00,uVar4,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f71232;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x23b,uVar4,param2,uVar4,param2_00,
		               1,uVar4);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) break;
		    iVar6 = iVar6 + 1;
		  } while( true );
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f71232:
		  iVar6 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar8) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar6 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x80f7127b:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar8 = *local_4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f712f3;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f712f3:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      }
		      if (iVar6 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x23c,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
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

		// Token: 0x06001064 RID: 4196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001064")]
		[Address(RVA = "0x6262", Offset = "0x6262", VA = "0x6262")]
		public void UpdateCommonItems(UserData loggedUser, IEnumerable<ShopArtifactDataDecorator> commonItems)
		{
		/* --- GHIDRA: UpdateCommonItems ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__UpdateCommonItems
		               (int param1,undefined4 param2,int *param3,int param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 param4_00;
		  undefined4 param2_00;
		  int *piVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a58abe == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_ShopArtifactDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_ShopArtifactDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ShopItem__get_Item__);
		    DAT_ram_00a58abe = '\x01';
		  }
		  uVar5 = 2;
		  if (param4 == 0) {
		    uVar5 = 1;
		  }
		  iVar8 = *param3;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_ShopArtifactDataDecorator__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f714bd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,
		                                System_Collections_Generic_IEnumerable_ShopArtifactDataDecorator__TypeInfo
		                                ,0);
		code_r0x80f714bd:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar4 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80f7158e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f717c5:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f717cd;
		    }
		code_r0x80f7158e:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar4,puVar3[1]);
		    piVar4 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f717c5;
		    if (iVar8 == 0) {
		      iVar6 = 0;
		      goto code_r0x80f71816;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ShopArtifactDataDecorator__TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80f71668;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ShopArtifactDataDecorator__TypeInfo,0
		                       );
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f71793:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f717cd;
		    }
		code_r0x80f71668:
		    DAT_ram_009d3e38 = 0;
		    param4_00 = import::env::invoke_iii(*puVar3,piVar4,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f71793;
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22a,
		                           *(undefined4 *)(param1 + 0x5c),iVar6,
		                           Method_System_Collections_Generic_List_ShopItem__get_Item__);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f717cd;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x23b,param2_00,param2,param4_00,
		               param2_00,param4,param2_00);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f717cd;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x23d,param2_00,uVar5,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f717cd;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x23a,param2_00,param4_00,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) break;
		    iVar6 = iVar6 + 1;
		  } while( true );
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f717cd:
		  iVar6 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar8) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar6 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x80f71816:
		      piVar4 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar8 = *local_4;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f7188e;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f7188e:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		      }
		      if (iVar6 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x23e,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
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

		// Token: 0x06001065 RID: 4197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001065")]
		[Address(RVA = "0x6263", Offset = "0x6263", VA = "0x6263")]
		public void UpdateGoldItems(UserData loggedUser, IEnumerable<ShopArtifactDataDecorator> goldItems, bool hasTradeAccount)
		{
		/* --- GHIDRA: UpdateGoldItems ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__UpdateGoldItems
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x40);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x40),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001066")]
		[Address(RVA = "0x1DC2", Offset = "0x1DC2", VA = "0x1DC2")]
		private void HandleDataDecorator(UserData loggedUser, ShopArtifactDataDecorator item, ShopItem shopItem, SlotStates defaultState)
		{
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001067")]
		[Address(RVA = "0x6264", Offset = "0x6264", VA = "0x6264")]
		public void SetShopTip(string text)
		{
		/* --- GHIDRA: SetShopTip ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__SetShopTip
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x44);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x44),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001068")]
		[Address(RVA = "0x6265", Offset = "0x6265", VA = "0x6265")]
		public void SetItemsTip(string text)
		{
		/* --- GHIDRA: SetItemsTip ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__SetItemsTip
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x50),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001069")]
		[Address(RVA = "0x6266", Offset = "0x6266", VA = "0x6266")]
		public void SetLeftPanelActive(bool active)
		{
		/* --- GHIDRA: SetLeftPanelActive ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__SetLeftPanelActive
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint *param3_00;
		  undefined4 uVar1;
		  longlong lVar2;
		  longlong lVar3;
		  int *param1_00;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a58ac0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58ac0 = '\x01';
		  }
		  lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar5 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        param3_00 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x80f702e4;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  param3_00 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f702e4:
		  uVar1 = (**(code **)((ulonglong)*param3_00 * 4))(param1_00,param3_00[1]);
		  uVar1 = func_ii_7112(uVar1,0);
		  lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar1,0);
		  if (lVar3 != lVar2) {
		    UI_Windows_Buildings_ShopWindow_ShopWindow__SetupMyShop(param1,param2,param3_00);
		    return;
		  }
		  UI_Windows_Buildings_ShopWindow_ShopWindow__SetupMVC(param1,param3_00);
		  return;
		}
		*/

		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106A")]
		[Address(RVA = "0x6267", Offset = "0x6267", VA = "0x6267")]
		private void SetupMVC(UserData owner)
		{
		/* --- GHIDRA: SetupMVC ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 param2_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a58ac1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopViewMediator_TypeInfo);
		    DAT_ram_00a58ac1 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x108);
		        goto code_r0x80f70659;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,9);
		code_r0x80f70659:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  piVar4 = *(int **)(iVar5 + 0x18);
		  *(int **)(param1 + 0x68) = piVar4;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		                    (piVar4,*(undefined4 *)(*piVar4 + 0x104));
		  *(undefined4 *)(param1 + 0x70) = uVar3;
		  iVar5 = **(int **)(param1 + 0x68);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x110) * 4))
		                    (*(int **)(param1 + 0x68),*(undefined4 *)(iVar5 + 0x114));
		  *(undefined4 *)(param1 + 0x6c) = uVar3;
		  param2_00 = *(undefined4 *)(param1 + 0x70);
		  param4 = *(undefined4 *)(param1 + 0x68);
		  piVar4 = (int *)unnamed_function_1417(Gameplay_Shop_ShopViewMediator_TypeInfo);
		  Gameplay_Shop_ShopController___c__DisplayClass16_0___BuyArtifactFromAnotherShop_b__0
		            (piVar4,param2_00,uVar3,param4,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x160) * 4))
		            (piVar4,param1,*(undefined4 *)(*piVar4 + 0x164));
		  *(int **)(param1 + 100) = piVar4;
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x54),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  Gameplay_Shop_ShopController__OnArtifactMoved(*(undefined4 *)(param1 + 0x68),0);
		  return;
		}
		*/

		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106B")]
		[Address(RVA = "0x6268", Offset = "0x6268", VA = "0x6268")]
		private void SetupMyShop()
		{
		/* --- GHIDRA: SetupMyShop ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__SetupMyShop
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 param5;
		  
		  if (DAT_ram_00a58ac2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_ShopWindow_ShopWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopViewMediator_TypeInfo);
		    DAT_ram_00a58ac2 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80f703ff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f703ff:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x80f704ab;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f704ab:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  iVar7 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ShopWindow_ShopWindowArgs__get_WindowArgs__);
		  param5 = *(undefined4 *)(iVar7 + 0x18);
		  uVar5 = unnamed_function_1417(Gameplay_Shop_ShopModel_TypeInfo);
		  Gameplay_Shop_ShopModel__get_IsMyShop(uVar5,uVar3,uVar4,param2,param5,0);
		  *(undefined4 *)(param1 + 0x70) = uVar5;
		  uVar3 = unnamed_function_1417(Gameplay_Shop_ShopEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x6c) = uVar3;
		  uVar5 = *(undefined4 *)(param1 + 0x70);
		  uVar4 = unnamed_function_1417(Gameplay_Shop_ShopController_TypeInfo);
		  Gameplay_Shop_ShopController__set_ItemsRequested(uVar4,uVar5,uVar3,0);
		  *(undefined4 *)(param1 + 0x68) = uVar4;
		  uVar3 = *(undefined4 *)(param1 + 0x70);
		  uVar5 = *(undefined4 *)(param1 + 0x6c);
		  piVar6 = (int *)unnamed_function_1417(Gameplay_Shop_ShopViewMediator_TypeInfo);
		  Gameplay_Shop_ShopController___c__DisplayClass16_0___BuyArtifactFromAnotherShop_b__0
		            (piVar6,uVar3,uVar5,uVar4,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x160) * 4))
		            (piVar6,param1,*(undefined4 *)(*piVar6 + 0x164));
		  *(int **)(param1 + 100) = piVar6;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x68),0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x54),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106C")]
		[Address(RVA = "0x6269", Offset = "0x6269", VA = "0x6269")]
		private void SetupOtherShop(UserData owner)
		{
		/* --- GHIDRA: SetupOtherShop ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__SetupOtherShop(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 100);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 100),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = Gameplay_Shop_ShopModel__set_Artifacts(*(undefined4 *)(param1 + 0x70),0);
		  if (iVar1 == 0) {
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x68),0);
		    iVar1 = **(int **)(param1 + 0x68);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x68),*(undefined4 *)(iVar1 + 0xec));
		    iVar1 = **(int **)(param1 + 0x70);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x70),*(undefined4 *)(iVar1 + 0xec));
		  }
		  *(undefined8 *)(param1 + 100) = 0;
		  *(undefined8 *)(param1 + 0x6c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106D")]
		[Address(RVA = "0x626A", Offset = "0x626A", VA = "0x626A")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__DestroyMVC(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58ac3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingWindow_ShopWindow_ShopWindowArgs___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ShopItem___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ShopItem__TypeInfo);
		    DAT_ram_00a58ac3 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_ShopItem__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_ShopItem___ctor__);
		  *(undefined4 *)(param1 + 0x58) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_ShopItem__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_ShopItem___ctor__);
		  *(undefined4 *)(param1 + 0x5c) = uVar1;
		  UI_Windows_Buildings_BaseBuildingWindow_object____Il2CppFullySharedGenericType___OnShow
		            (param1,
		             Method_UI_Windows_Buildings_BaseBuildingWindow_ShopWindow_ShopWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600106E RID: 4206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106E")]
		[Address(RVA = "0x626B", Offset = "0x626B", VA = "0x626B")]
		public ShopWindow()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_Windows_Buildings_ShopWindow_ShopWindow___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58ac4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ShopItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ShopItem___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_ShopWindow_ShopWindow_OnShopItemClick__);
		    DAT_ram_00a58ac4 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x48);
		  uVar2 = *(undefined4 *)(param1 + 0x4c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = func_ii_6805(uVar2,uVar1,Method_UnityEngine_Object_Instantiate_ShopItem___);
		  uVar2 = unnamed_function_1417(System_Action_ShopItem__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_UI_Windows_Buildings_ShopWindow_ShopWindow_OnShopItemClick__,0);
		  UI_Elements_MultilineTextList___ctor(uVar1,uVar2,0);
		  UI_Elements_ShopItem__get_SlotState(uVar1,0,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600106F")]
		[Address(RVA = "0x626C", Offset = "0x626C", VA = "0x626C")]
		[CompilerGenerated]
		private ShopItem <Init>g__SpawnShopItemInstance|25_0()
		{
			return null;
		}

		// Token: 0x0400085D RID: 2141
		[Token(Token = "0x400085D")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/ShopPopupWindow";

		// Token: 0x0400085E RID: 2142
		[Token(Token = "0x400085E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _shopTip;

		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x400085F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TextMeshProUGUI _itemsTip;

		// Token: 0x04000860 RID: 2144
		[Token(Token = "0x4000860")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _shopTable;

		// Token: 0x04000861 RID: 2145
		[Token(Token = "0x4000861")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ShopItem _shopItemPrefab;

		// Token: 0x04000862 RID: 2146
		[Token(Token = "0x4000862")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _leftPanel;

		// Token: 0x04000863 RID: 2147
		[Token(Token = "0x4000863")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TradeAccountBannerView _tradeAccount;

		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0x64")]
		private ShopViewMediator _mediator;

		// Token: 0x04000868 RID: 2152
		[Token(Token = "0x4000868")]
		[FieldOffset(Offset = "0x68")]
		private ShopController _controller;

		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000869")]
		[FieldOffset(Offset = "0x6C")]
		private ShopEvents _events;

		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x400086A")]
		[FieldOffset(Offset = "0x70")]
		private ShopModel _model;

		// Token: 0x020002B9 RID: 697
		[Token(Token = "0x20002B9")]
		public class ShopWindowArgs : BaseBuildingWindowArgs
		{
			// Token: 0x06001070 RID: 4208 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001070")]
			[Address(RVA = "0x626D", Offset = "0x626D", VA = "0x626D")]
			public ShopWindowArgs(UserIsle isle, uint buildingTypeId)
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GoldItems ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__get_GoldItems
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58ab8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__ShopItem__TypeInfo);
		    DAT_ram_00a58ab8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x60);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_int__ShopItem__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__ShopItem__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x60,iVar2,param1_00);
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


		/* --- GHIDRA: add_SelectSlotEvent ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__add_SelectSlotEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58ab9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__ShopItem__TypeInfo);
		    DAT_ram_00a58ab9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x60);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_int__ShopItem__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__ShopItem__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x60,iVar2,param1_00);
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


		/* --- GHIDRA: remove_SelectSlotEvent ---
		void UI_Windows_Buildings_ShopWindow_ShopWindow__remove_SelectSlotEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58aba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_Buildings_BaseBuildingWindow_ShopWindow_ShopWindowArgs__UserIsle__OnShow__
		              );
		    DAT_ram_00a58aba = '\x01';
		  }
		  UI_Windows_Buildings_BaseBuildingWindow_object__object___OnClose
		            (param1,param2,
		             Method_UI_Windows_Buildings_BaseBuildingWindow_ShopWindow_ShopWindowArgs__UserIsle__OnShow__
		            );
		  UI_Windows_Buildings_ShopWindow_ShopWindow__SetLeftPanelActive
		            (param1,*(undefined4 *)(*(int *)(*(int *)(param2 + 0x18) + 0x10) + 8),param2);
		  return;
		}
		*/

}
