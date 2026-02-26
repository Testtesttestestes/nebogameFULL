using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Counters;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Monsters
{
	// Token: 0x02000728 RID: 1832
	[Token(Token = "0x2000728")]
	public class MonsterView : MonoBehaviour
	{
		// Token: 0x14000160 RID: 352
		// (add) Token: 0x06002BC8 RID: 11208 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002BC9 RID: 11209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000160")]
		public event Action<MonsterData> ClickEvent
		{
			[Token(Token = "0x6002BC8")]
			[Address(RVA = "0x7C59", Offset = "0x7C59", VA = "0x7C59")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002BC9")]
			[Address(RVA = "0x7C5A", Offset = "0x7C5A", VA = "0x7C5A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BCA")]
		[Address(RVA = "0x7C5B", Offset = "0x7C5B", VA = "0x7C5B")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterView__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a5a278 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterView_AprOnClickEvent__
		              );
		    DAT_ram_00a5a278 = '\x01';
		  }
		  param1_01 = *(int *)(param1 + 0x18);
		  *(undefined4 *)(param1_01 + 0x58) = 1;
		  param1_00 = unnamed_function_1417(System_Action_AprView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterView_AprOnClickEvent__
		             ,0);
		  Gameplay_Aprs_View_AprInfoWindowArgs___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BCB")]
		[Address(RVA = "0x7C5C", Offset = "0x7C5C", VA = "0x7C5C")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterView__Awake
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x20),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BCC")]
		[Address(RVA = "0x7C5D", Offset = "0x7C5D", VA = "0x7C5D")]
		private void AprOnClickEvent(AprView obj)
		{
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BCE RID: 11214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000857")]
		public MonsterData Data
		{
			[Token(Token = "0x6002BCD")]
			[Address(RVA = "0x7C5E", Offset = "0x7C5E", VA = "0x7C5E")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BCE")]
			[Address(RVA = "0x7C5F", Offset = "0x7C5F", VA = "0x7C5F")]
			set
			{
			}
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BCF")]
		[Address(RVA = "0x7C60", Offset = "0x7C60", VA = "0x7C60")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD0")]
		[Address(RVA = "0x7C61", Offset = "0x7C61", VA = "0x7C61")]
		public MonsterView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterView___ctor
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param3;
		  uint uVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int param2_00;
		  int iVar6;
		  int *piVar7;
		  uint *puVar8;
		  int iVar9;
		  int *piVar10;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a279 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_MonsterData__get_Content__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_MonsterData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_MonsterView___);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonstersStageContentGroupView_HandleClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a5a279 = '\x01';
		  }
		  local_8 = 0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x14),0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		code_r0x811f12d5:
		  piVar7 = local_4;
		  iVar9 = *local_4;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		        puVar3 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		        goto code_r0x811f136d;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_IEnumerator_TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x811f13b1:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x811f1760;
		  }
		code_r0x811f136d:
		  DAT_ram_009d3e38 = 0;
		  iVar9 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		  piVar7 = local_4;
		  if (DAT_ram_009d3e38 == 1) goto code_r0x811f13b1;
		  if (iVar9 == 0) goto code_r0x811f17a9;
		  iVar9 = *local_4;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		        puVar3 = (undefined4 *)(piVar10[1] * 8 + iVar9 + 200);
		        goto code_r0x811f1454;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_IEnumerator_TypeInfo,1);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x811f1758:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x811f1760;
		  }
		code_r0x811f1454:
		  DAT_ram_009d3e38 = 0;
		  piVar7 = (int *)import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x811f1758;
		  if (piVar7 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar7 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		       || (*(int *)(*(int *)(*piVar7 + 100) +
		                    (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		           UnityEngine_Transform_TypeInfo)) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar7,
		                 UnityEngine_Transform_TypeInfo);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 != 1) {
		code_r0x811f18a6:
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811f1760:
		      iVar9 = global_1;
		      iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar6) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		        local_14 = *piVar7;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
		code_r0x811f17a9:
		          DAT_ram_009d3e38 = 0;
		          local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		          piVar7 = (int *)*local_c;
		          if (piVar7 != (int *)0x0) {
		            iVar9 = *piVar7;
		            if (*(ushort *)(iVar9 + 0xb6) != 0) {
		              uVar2 = 0;
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		                  puVar8 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x811f1839;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		            }
		            puVar8 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x811f1839:
		            (**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		          }
		          if (local_14 == 0) {
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
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x27f,&local_14);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
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
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar7,0);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x811f1760;
		  }
		  DAT_ram_009d3e38 = 0;
		  iVar6 = import::env::invoke_iii
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x202,uVar4,
		                     Method_UnityEngine_GameObject_GetComponent_MonsterView___);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x811f1760;
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::invoke_ii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                     System_Action_MonsterData__TypeInfo);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x811f1730:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x811f1760;
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_viiii
		            (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		             Method_Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonstersStageContentGroupView_HandleClickEvent__
		             ,0);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x811f1730;
		  if (DAT_ram_00a5a276 == '\0') {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vi(0x7ff,&System_Action_MonsterData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811f1730;
		    DAT_ram_00a5a276 = '\x01';
		  }
		  iVar9 = *(int *)(iVar6 + 0x1c);
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar9,uVar4,0);
		    param3 = System_Action_MonsterData__TypeInfo;
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811f1726:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811f1760;
		    }
		    if (iVar5 == 0) {
		      param2_00 = 0;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      param2_00 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar5,
		                             System_Action_MonsterData__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811f1726;
		      if (param2_00 == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar5,param3);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) goto code_r0x811f18a6;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811f1760;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar5 = func_ii_4329(iVar6 + 0x1c,param2_00,iVar9);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811f1726;
		    bVar1 = iVar9 != iVar5;
		    iVar9 = iVar5;
		  } while (bVar1);
		  goto code_r0x811f12d5;
		}
		*/

		}

		// Token: 0x040017FD RID: 6141
		[Token(Token = "0x40017FD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040017FE RID: 6142
		[Token(Token = "0x40017FE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private LevelCounter _level;

		// Token: 0x040017FF RID: 6143
		[Token(Token = "0x40017FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AprView _apr;

		// Token: 0x04001801 RID: 6145
		[Token(Token = "0x4001801")]
		[FieldOffset(Offset = "0x20")]
		private MonsterData _data;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a276 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MonsterData__TypeInfo);
		    DAT_ram_00a5a276 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MonsterData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MonsterData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterView__remove_ClickEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a277 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterView_AprOnClickEvent__
		              );
		    DAT_ram_00a5a277 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  param1_01 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_AprView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterView_AprOnClickEvent__
		             ,0);
		  Gameplay_Aprs_View_AprView__add_ClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Data ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterView__get_Data
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if ((*(int *)(param1 + 0x20) != param2) && (*(int *)(param1 + 0x20) = param2, param2 != 0)) {
		    piVar2 = *(int **)(param1 + 0x10);
		    uVar1 = Core_Data_MonsterData__get_KickPrice(param2,0);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		    param1_00 = *(undefined4 *)(param1 + 0x14);
		    uVar1 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl(*(undefined4 *)(param1 + 0x20),0);
		    UI_Elements_Counters_CounterAutoHide___ctor(param1_00,uVar1,0);
		    iVar3 = **(int **)(param1 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x138) * 4))
		              (*(int **)(param1 + 0x18),*(undefined4 *)(*(int *)(param1 + 0x20) + 0xc),
		               *(undefined4 *)(iVar3 + 0x13c));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterView__set_Data
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (*(int *)(param1 + 0x20) != 0) {
		    piVar2 = *(int **)(param1 + 0x10);
		    uVar1 = Core_Data_MonsterData__get_KickPrice(*(int *)(param1 + 0x20),0);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		    param1_00 = *(undefined4 *)(param1 + 0x14);
		    uVar1 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl(*(undefined4 *)(param1 + 0x20),0);
		    UI_Elements_Counters_CounterAutoHide___ctor(param1_00,uVar1,0);
		    iVar3 = **(int **)(param1 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x138) * 4))
		              (*(int **)(param1 + 0x18),*(undefined4 *)(*(int *)(param1 + 0x20) + 0xc),
		               *(undefined4 *)(iVar3 + 0x13c));
		  }
		  return;
		}
		*/

}
