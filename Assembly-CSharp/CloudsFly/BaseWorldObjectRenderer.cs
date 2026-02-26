using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012F3 RID: 4851
	[Token(Token = "0x20012F3")]
	public class BaseWorldObjectRenderer : MonoBehaviour, IWorldObjectRenderer
	{
		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06007376 RID: 29558 RVA: 0x00014BE0 File Offset: 0x00012DE0
		[Token(Token = "0x17001751")]
		public int SortingOrderDelta
		{
			[Token(Token = "0x6007376")]
			[Address(RVA = "0xBD63", Offset = "0xBD63", VA = "0xBD63")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06007377 RID: 29559 RVA: 0x00014BF8 File Offset: 0x00012DF8
		// (set) Token: 0x06007378 RID: 29560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001752")]
		public int SortingOrder
		{
			[Token(Token = "0x6007377")]
			[Address(RVA = "0xBD64", Offset = "0xBD64", VA = "0xBD64", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007378")]
			[Address(RVA = "0xBD65", Offset = "0xBD65", VA = "0xBD65", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06007379 RID: 29561 RVA: 0x00014C10 File Offset: 0x00012E10
		[Token(Token = "0x17001753")]
		public int SortingOrderWithDelta
		{
			[Token(Token = "0x6007379")]
			[Address(RVA = "0x1DEF", Offset = "0x1DEF", VA = "0x1DEF")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x0600737A RID: 29562 RVA: 0x00014C28 File Offset: 0x00012E28
		// (set) Token: 0x0600737B RID: 29563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001754")]
		public int SortingLayerId
		{
			[Token(Token = "0x600737A")]
			[Address(RVA = "0xBD66", Offset = "0xBD66", VA = "0xBD66", Slot = "6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600737B")]
			[Address(RVA = "0xBD67", Offset = "0xBD67", VA = "0xBD67", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600737C")]
		[Address(RVA = "0xBD68", Offset = "0xBD68", VA = "0xBD68")]
		private List<IWorldObjectRenderer> GetChildren()
		{
		/* --- GHIDRA: GetChildren ---
		void CloudsFly_BaseWorldObjectRenderer__GetChildren(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59672 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IWorldObjectRenderer__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IWorldObjectRenderer__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_IWorldObjectRenderer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&CloudsFly_IWorldObjectRenderer_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IWorldObjectRenderer__GetEnumerator__);
		    DAT_ram_00a59672 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (DAT_ram_00a59671 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentsInChildren_IWorldObjectRenderer___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_IWorldObjectRenderer___);
		    DAT_ram_00a59671 = '\x01';
		  }
		  iVar6 = param1[7];
		  if ((iVar6 == 0) || ((char)param1[8] != '\0')) {
		    uVar2 = UnityEngine_Component__GetComponents___Il2CppFullySharedGenericType_
		                      (param1,
		                       Method_UnityEngine_Component_GetComponentsInChildren_IWorldObjectRenderer___)
		    ;
		    iVar6 = System_Linq_Enumerable__Select_object__object_
		                      (uVar2,Method_System_Linq_Enumerable_ToList_IWorldObjectRenderer___);
		    param1[7] = iVar6;
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,iVar6,
		             Method_System_Collections_Generic_List_IWorldObjectRenderer__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    while( true ) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_IWorldObjectRenderer__MoveNext__
		                        );
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81046f02;
		      }
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      piVar5 = local_8._4_4_;
		      if (param1 != local_8._4_4_) break;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii
		                (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81046f02;
		      }
		    }
		    iVar6 = param1[5];
		    iVar3 = *local_8._4_4_;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		        if (CloudsFly_IWorldObjectRenderer_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar3 + 200);
		          goto code_r0x81046ea3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                        CloudsFly_IWorldObjectRenderer_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x81046ea3:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar5,iVar6,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81046f02:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x344,&local_18);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
		    import::env::__resumeException(uVar2);
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

			return null;
		}

		// Token: 0x0600737D RID: 29565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600737D")]
		[Address(RVA = "0xBD69", Offset = "0xBD69", VA = "0xBD69")]
		private void ValidateSortingOrder()
		{
		/* --- GHIDRA: ValidateSortingOrder ---
		void CloudsFly_BaseWorldObjectRenderer__ValidateSortingOrder(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59673 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IWorldObjectRenderer__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IWorldObjectRenderer__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_IWorldObjectRenderer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&CloudsFly_IWorldObjectRenderer_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IWorldObjectRenderer__GetEnumerator__);
		    DAT_ram_00a59673 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (DAT_ram_00a59671 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentsInChildren_IWorldObjectRenderer___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_IWorldObjectRenderer___);
		    DAT_ram_00a59671 = '\x01';
		  }
		  iVar6 = param1[7];
		  if ((iVar6 == 0) || ((char)param1[8] != '\0')) {
		    uVar2 = UnityEngine_Component__GetComponents___Il2CppFullySharedGenericType_
		                      (param1,
		                       Method_UnityEngine_Component_GetComponentsInChildren_IWorldObjectRenderer___)
		    ;
		    iVar6 = System_Linq_Enumerable__Select_object__object_
		                      (uVar2,Method_System_Linq_Enumerable_ToList_IWorldObjectRenderer___);
		    param1[7] = iVar6;
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,iVar6,
		             Method_System_Collections_Generic_List_IWorldObjectRenderer__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    while( true ) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_IWorldObjectRenderer__MoveNext__
		                        );
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81047351;
		      }
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      piVar5 = local_8._4_4_;
		      if (param1 != local_8._4_4_) break;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii
		                (*(undefined4 *)(*param1 + 0x108),param1,*(undefined4 *)(*param1 + 0x10c));
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81047351;
		      }
		    }
		    iVar6 = param1[6];
		    iVar3 = *local_8._4_4_;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		        if (CloudsFly_IWorldObjectRenderer_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar3 + 0xd8);
		          goto code_r0x810472f2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                        CloudsFly_IWorldObjectRenderer_TypeInfo,3);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x810472f2:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar5,iVar6,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81047351:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x345,&local_18);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
		    import::env::__resumeException(uVar2);
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

		// Token: 0x0600737E RID: 29566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600737E")]
		[Address(RVA = "0xBD6A", Offset = "0xBD6A", VA = "0xBD6A")]
		private void ValidateSortingLayerId()
		{
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600737F")]
		[Address(RVA = "0xBD6B", Offset = "0xBD6B", VA = "0xBD6B", Slot = "8")]
		protected virtual void ApplySortingOrder()
		{
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007380")]
		[Address(RVA = "0xBD6C", Offset = "0xBD6C", VA = "0xBD6C", Slot = "9")]
		protected virtual void ApplySortingLayerId()
		{
		}

		// Token: 0x06007381 RID: 29569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007381")]
		[Address(RVA = "0xBD6D", Offset = "0xBD6D", VA = "0xBD6D")]
		public BaseWorldObjectRenderer()
		{
		/* --- GHIDRA: .ctor ---
		void CloudsFly_BaseWorldObjectRenderer___ctor(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59674 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Clan_ClanIsle_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_CloudsFly_WorldObject_IsleCloudObjectArgs__get_Args__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5452);
		    DAT_ram_00a59674 = '\x01';
		  }
		  CloudsFly_BaseIsleWorldObject__OnInit(param1,param1);
		  param1_00 = *(int **)(param1[9] + 0x18);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Isles_Clan_ClanIsle_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Gameplay_Isles_Clan_ClanIsle_TypeInfo + 0xb8) * 4 + -4) !=
		        Gameplay_Isles_Clan_ClanIsle_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,Gameplay_Isles_Clan_ClanIsle_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_Isles_Clan_View_ClanIsleView__get_ColossusView(param1[0x11],param1_00,0);
		  Gameplay_Isles_Clan_View_ClanIsleGolemView__get_Bubble(param1[0x12],param1_00,0);
		  Gameplay_Isles_Base_View_BaseIsleView___ctor(param1[0xc],param1_00,param1_00[3],0);
		  local_8 = *(undefined8 *)(param1_00 + 6);
		  uVar1 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar1 = func_ii_4419(StringLiteral_5452,uVar1,0);
		  UnityEngine_Texture2D___ctor(param1,uVar1,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x128) * 4))(param1,*(undefined4 *)(*param1 + 300));
		  return;
		}
		*/

		}

		// Token: 0x04003C6D RID: 15469
		[Token(Token = "0x4003C6D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _sortingOrderDelta;

		// Token: 0x04003C6E RID: 15470
		[Token(Token = "0x4003C6E")]
		[FieldOffset(Offset = "0x14")]
		private int _sortingOrder;

		// Token: 0x04003C6F RID: 15471
		[Token(Token = "0x4003C6F")]
		[FieldOffset(Offset = "0x18")]
		private int _sortingLayerId;

		// Token: 0x04003C70 RID: 15472
		[Token(Token = "0x4003C70")]
		[FieldOffset(Offset = "0x1C")]
		private List<IWorldObjectRenderer> _children;

		// Token: 0x04003C71 RID: 15473
		[Token(Token = "0x4003C71")]
		[FieldOffset(Offset = "0x20")]
		private bool _childrenChanged;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SortingOrder ---
		void CloudsFly_BaseWorldObjectRenderer__get_SortingOrder
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x14) = param2;
		  CloudsFly_BaseWorldObjectRenderer__GetChildren(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: get_SortingOrderWithDelta ---
		void CloudsFly_BaseWorldObjectRenderer__get_SortingOrderWithDelta
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *param1_01;
		  
		  *(undefined4 *)(param1 + 0x30) = param2;
		  iVar3 = *(int *)(param1 + 0x14);
		  if (DAT_ram_00a63bc1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Animations_IGameAnimation_TypeInfo);
		    DAT_ram_00a63bc1 = '\x01';
		  }
		  *(undefined4 *)(iVar3 + 0x2c) = param2;
		  param1_01 = *(int **)(iVar3 + 0x3c);
		  if (param1_01 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_01;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Animations_IGameAnimation_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		        {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		          goto code_r0x8236a6c9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,Core_Animations_IGameAnimation_TypeInfo,10);
		code_r0x8236a6c9:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_01,param2,puVar2[1]);
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  if (DAT_ram_00a63bfc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		    DAT_ram_00a63bfc = '\x01';
		  }
		  if (*(int *)(iVar3 + 0x2c) == 0) {
		    param1_00 = func_ii_5677(iVar3,Method_UnityEngine_Component_GetComponent_SpriteRenderer___);
		    *(undefined4 *)(iVar3 + 0x2c) = param1_00;
		  }
		  else {
		    param1_00 = *(undefined4 *)(iVar3 + 0x2c);
		  }
		  AssetContent_Loaders_GameSpriteRendererLoader__get_SpriteRenderer
		            (param1_00,*(undefined4 *)(param1 + 0x30),0);
		  return;
		}
		*/


		/* --- GHIDRA: get_SortingLayerId ---
		void CloudsFly_BaseWorldObjectRenderer__get_SortingLayerId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x18) = param2;
		  CloudsFly_BaseWorldObjectRenderer__ValidateSortingOrder(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_SortingLayerId ---
		int CloudsFly_BaseWorldObjectRenderer__set_SortingLayerId(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a59671 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentsInChildren_IWorldObjectRenderer___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_IWorldObjectRenderer___);
		    DAT_ram_00a59671 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x1c);
		  if ((iVar1 == 0) || (*(char *)(param1 + 0x20) != '\0')) {
		    param1_00 = UnityEngine_Component__GetComponents___Il2CppFullySharedGenericType_
		                          (param1,
		                           Method_UnityEngine_Component_GetComponentsInChildren_IWorldObjectRenderer___
		                          );
		    iVar1 = System_Linq_Enumerable__Select_object__object_
		                      (param1_00,Method_System_Linq_Enumerable_ToList_IWorldObjectRenderer___);
		    *(int *)(param1 + 0x1c) = iVar1;
		  }
		  return iVar1;
		}
		*/

}
