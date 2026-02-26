using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Common;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View
{
	// Token: 0x02000517 RID: 1303
	[Token(Token = "0x2000517")]
	public class RewardsDisplay : MonoBehaviour
	{
		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001F08 RID: 7944 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005A2")]
		public Button TakeButton
		{
			[Token(Token = "0x6001F08")]
			[Address(RVA = "0x706F", Offset = "0x706F", VA = "0x706F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005A3")]
		public CounterAutoHide RedCounter
		{
			[Token(Token = "0x6001F09")]
			[Address(RVA = "0x7070", Offset = "0x7070", VA = "0x7070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F0A")]
		[Address(RVA = "0x7071", Offset = "0x7071", VA = "0x7071")]
		public void DisplayRewards(IEnumerable<RewardInfo> resources)
		{
		/* --- GHIDRA: DisplayRewards ---
		void Gameplay_SmallGames_View_RewardsDisplay__DisplayRewards(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58662 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SmallGamesResourceRenderer___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_SmallGamesResourceRenderer__TypeInfo);
		    DAT_ram_00a58662 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_SmallGamesResourceRenderer__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_SmallGamesResourceRenderer___ctor__);
		  *(undefined4 *)(param1 + 0x20) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F0B")]
		[Address(RVA = "0x7072", Offset = "0x7072", VA = "0x7072")]
		public RewardsDisplay()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SmallGames_View_RewardsDisplay___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58663 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_SmallGames_View_RewardsDisplay___c_TypeInfo);
		    DAT_ram_00a58663 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_SmallGames_View_RewardsDisplay___c_TypeInfo);
		  **(undefined4 **)(Gameplay_SmallGames_View_RewardsDisplay___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040010CA RID: 4298
		[Token(Token = "0x40010CA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _takeButton;

		// Token: 0x040010CB RID: 4299
		[Token(Token = "0x40010CB")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SmallGamesResourceRenderer _resourceRendererPrefab;

		// Token: 0x040010CC RID: 4300
		[Token(Token = "0x40010CC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _contentParent;

		// Token: 0x040010CD RID: 4301
		[Token(Token = "0x40010CD")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CounterAutoHide _redCounter;

		// Token: 0x040010CE RID: 4302
		[Token(Token = "0x40010CE")]
		[FieldOffset(Offset = "0x20")]
		private List<SmallGamesResourceRenderer> _spawnedLists;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RedCounter ---
		void Gameplay_SmallGames_View_RewardsDisplay__get_RedCounter
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  bool bVar2;
		  uint *puVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  int iVar8;
		  undefined4 uVar9;
		  undefined4 param2_00;
		  int param2_01;
		  int *piVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  bVar2 = false;
		  if (DAT_ram_00a58661 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SmallGamesResourceRenderer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_RewardInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SmallGamesResourceRenderer__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SmallGamesResourceRenderer__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SmallGamesResourceRenderer__ForEach__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_SmallGamesResourceRenderer___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_View_RewardsDisplay___c__DisplayRewards_b__9_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_SmallGames_View_RewardsDisplay___c_TypeInfo);
		    DAT_ram_00a58661 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  uVar5 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(Gameplay_SmallGames_View_RewardsDisplay___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_SmallGames_View_RewardsDisplay___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_SmallGames_View_RewardsDisplay___c_TypeInfo + 0x5c);
		  iVar7 = puVar6[1];
		  if (iVar7 == 0) {
		    if (*(int *)(Gameplay_SmallGames_View_RewardsDisplay___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_SmallGames_View_RewardsDisplay___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_SmallGames_View_RewardsDisplay___c_TypeInfo + 0x5c);
		    }
		    uVar9 = *puVar6;
		    iVar7 = unnamed_function_1417(System_Action_SmallGamesResourceRenderer__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (iVar7,uVar9,
		               Method_Gameplay_SmallGames_View_RewardsDisplay___c__DisplayRewards_b__9_0__,0);
		    *(int *)(*(int *)(Gameplay_SmallGames_View_RewardsDisplay___c_TypeInfo + 0x5c) + 4) = iVar7;
		  }
		  System_Collections_Generic_List_UsageHint___FindLastIndex
		            (uVar5,iVar7,
		             Method_System_Collections_Generic_List_SmallGamesResourceRenderer__ForEach__);
		  iVar7 = *(int *)(param1 + 0x20);
		  iVar8 = *(int *)(iVar7 + 0xc);
		  *(undefined4 *)(iVar7 + 0xc) = 0;
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  if (0 < iVar8) {
		    func_ii_2064(*(undefined4 *)(iVar7 + 8),0,iVar8,0);
		  }
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_RewardInfo__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f19c5a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_RewardInfo__TypeInfo,0
		                               );
		code_r0x80f19c5a:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar4 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar6 = (undefined4 *)(iVar7 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80f19d2d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f1a080:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f1a088;
		    }
		code_r0x80f19d2d:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar6,piVar4,puVar6[1]);
		    piVar4 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f1a080;
		    if (iVar7 == 0) goto code_r0x80f1a0d1;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo == *piVar10) {
		          puVar6 = (undefined4 *)(iVar7 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80f19e0a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f1a03a:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f1a088;
		    }
		code_r0x80f19e0a:
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(*puVar6,piVar4,puVar6[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f1a03a;
		    uVar9 = *(undefined4 *)(param1 + 0x18);
		    param2_00 = *(undefined4 *)(param1 + 0x14);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f1a088;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00,uVar9,
		                       Method_UnityEngine_Object_Instantiate_SmallGamesResourceRenderer___);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f1a088;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x18d,iVar8,uVar5,iVar8);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f1a088;
		    }
		    if (bVar2) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 4,*(undefined4 *)(iVar8 + 0x14),
		                 *(undefined4 *)(iVar8 + 0x18),0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f1a088;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30e,iVar8,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f1a06c:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f1a088;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x18e,uVar5,0);
		    iVar7 = Method_System_Collections_Generic_List_SmallGamesResourceRenderer__Add__;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f1a06c;
		    param2_01 = *(int *)(param1 + 0x20);
		    *(int *)(param2_01 + 0x10) = *(int *)(param2_01 + 0x10) + 1;
		    uVar1 = *(uint *)(param2_01 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(param2_01 + 8) + 0xc)) {
		      *(uint *)(param2_01 + 0xc) = uVar1 + 1;
		      *(int *)(*(int *)(param2_01 + 8) + uVar1 * 4 + 0x10) = iVar8;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param2_01,iVar8,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) break;
		    }
		    bVar2 = (bool)(bVar2 ^ 1);
		  } while( true );
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f1a088:
		  iVar7 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar8) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar5);
		    local_c = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x80f1a0d1:
		      DAT_ram_009d3e38 = 0;
		      piVar4 = *local_8;
		      if (piVar4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar7 = *piVar4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f1a14c;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x80f1a14c:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		      }
		      if (local_c == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 399,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
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
