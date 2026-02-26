using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core;
using Core.Data.InfoRows;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Requirements
{
	// Token: 0x020001B7 RID: 439
	[Token(Token = "0x20001B7")]
	public class RequirementsView : MonoBehaviour, IAsyncLoadableContent
	{
		// Token: 0x140000E3 RID: 227
		// (add) Token: 0x06000BB0 RID: 2992 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000BB1 RID: 2993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E3")]
		public event Action<IAsyncLoadableContent> ReadyEvent
		{
			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0x5EC9", Offset = "0x5EC9", VA = "0x5EC9", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0x5ECA", Offset = "0x5ECA", VA = "0x5ECA", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000184")]
		public IInformationProvider Data
		{
			[Token(Token = "0x6000BB2")]
			[Address(RVA = "0x5ECB", Offset = "0x5ECB", VA = "0x5ECB")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB3")]
			[Address(RVA = "0x5ECC", Offset = "0x5ECC", VA = "0x5ECC")]
			set
			{
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00003C78 File Offset: 0x00001E78
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000185")]
		public bool IsReady
		{
			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0x5ECD", Offset = "0x5ECD", VA = "0x5ECD", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0x5ECE", Offset = "0x5ECE", VA = "0x5ECE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x5ECF", Offset = "0x5ECF", VA = "0x5ECF")]
		private void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_Requirements_RequirementsView__HandleDataChanged(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  int *piVar8;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a59a3f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a59a3f = '\x01';
		  }
		  local_8 = 0;
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(uVar2,0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x810b35ae;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810b37f1:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810b37f9;
		    }
		code_r0x810b35ae:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810b37f1;
		    if (iVar7 == 0) goto code_r0x810b3842;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(piVar8[1] * 8 + iVar7 + 200);
		          goto code_r0x810b368b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810b37d3:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810b37f9;
		    }
		code_r0x810b368b:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810b37d3;
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar5 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                   UnityEngine_Transform_TypeInfo);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810b37f9;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar5,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar2,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810b37f9:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    local_14 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x810b3842:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_c;
		      if (piVar5 != (int *)0x0) {
		        iVar7 = *piVar5;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x810b38d2;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x810b38d2:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_14 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_14);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x82,&local_14);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x1F83", Offset = "0x1F83", VA = "0x1F83")]
		private RequirementsView.RowPrefabConfig GetRowPrefab(InformationRowTypes type)
		{
		/* --- GHIDRA: GetRowPrefab ---
		void UI_Requirements_RequirementsView__GetRowPrefab(int *param1,int param2,undefined4 param3)
		
		{
		  if (param2 != param1[8]) {
		    param1[8] = param2;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))(param1,*(undefined4 *)(*param1 + 0xec));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x5ED0", Offset = "0x5ED0", VA = "0x5ED0", Slot = "7")]
		public virtual void RemoveAll()
		{
		/* --- GHIDRA: RemoveAll ---
		int UI_Requirements_RequirementsView__RemoveAll(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59a40 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Requirements_RequirementsView__DelayedCall_d__23_TypeInfo);
		    DAT_ram_00a59a40 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_Requirements_RequirementsView__DelayedCall_d__23_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x5ED1", Offset = "0x5ED1", VA = "0x5ED1")]
		private IEnumerator DelayedCall()
		{
		/* --- GHIDRA: DelayedCall ---
		void UI_Requirements_RequirementsView__DelayedCall(int param1,undefined4 param2)
		
		{
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  *(undefined4 *)(param1 + 0x10) = 0xff4d80b5;
		  local_c = 0x3f8000003f800000;
		  local_20 = 0x3f8000003f800000;
		  local_14 = 0x3f8000003f800000;
		  local_28 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_4,&local_28,0);
		  *(undefined4 *)(param1 + 0x20) = 0x100;
		  *(undefined8 *)(param1 + 0x18) = 0x200000001;
		  *(undefined4 *)(param1 + 0x14) = local_4;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x5ED2", Offset = "0x5ED2", VA = "0x5ED2")]
		public RequirementsView()
		{
		}

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected Color32 _titleColor;

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Color32 _textColor;

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected TextAnchor _containerContentAlign;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected HorizontalAlignmentOptions _contentHorizontalTextAlignment;

		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected VerticalAlignmentOptions _contentVerticalTextAlignment;

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected RequirementsView.RowPrefabConfig[] _prefabsByTypes;

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameObject _separatorPrefab;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0x2C")]
		private IInformationProvider _data;

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine _delayedCallRoutine;

		// Token: 0x020001B8 RID: 440
		[Token(Token = "0x20001B8")]
		[Serializable]
		public class RowPrefabConfig
		{
			// Token: 0x06000BBB RID: 3003 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x5ED3", Offset = "0x5ED3", VA = "0x5ED3")]
			public RowPrefabConfig()
			{
			}

			// Token: 0x04000575 RID: 1397
			[Token(Token = "0x4000575")]
			[FieldOffset(Offset = "0x8")]
			public InformationRowTypes Type;

			// Token: 0x04000576 RID: 1398
			[Token(Token = "0x4000576")]
			[FieldOffset(Offset = "0xC")]
			public TitleRowView Prefab;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ReadyEvent ---
		void UI_Requirements_RequirementsView__add_ReadyEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a59a3c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAsyncLoadableContent__TypeInfo);
		    DAT_ram_00a59a3c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IAsyncLoadableContent__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAsyncLoadableContent__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x34,iVar2,param1_00);
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


		/* --- GHIDRA: get_Data ---
		void UI_Requirements_RequirementsView__get_Data(int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x2c)) {
		    *(int *)(param1 + 0x2c) = param2;
		    UI_Requirements_RequirementsView__set_IsReady(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_IsReady ---
		void UI_Requirements_RequirementsView__set_IsReady(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  int *piVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59a3d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IInformationRow__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IInformationRow__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IInformationRow__get_Current__);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationRow_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IInformationRow__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameObject___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_TitleRowView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59a3d = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))(param1,*(undefined4 *)(*param1 + 0xfc));
		  piVar7 = (int *)param1[0xb];
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_InfoRows_IInformationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 200);
		        goto code_r0x810b2c84;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Data_InfoRows_IInformationProvider_TypeInfo,1);
		code_r0x810b2c84:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,uVar3,Method_System_Collections_Generic_List_IInformationRow__GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = &local_10;
		code_r0x810b2ced:
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_IInformationRow__MoveNext__
		                      );
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810b3297;
		    }
		    if (iVar4 == 0) goto code_r0x810b32ed;
		    piVar7 = local_8._4_4_;
		    if (local_8._4_4_ != (int *)0x0) break;
		    iVar8 = param1[10];
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30e,param1,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810b327b:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810b3297;
		    }
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) goto code_r0x810b327b;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,iVar8,uVar3,
		               Method_UnityEngine_Object_Instantiate_GameObject___);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810b3297:
		      iVar8 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar8 == iVar4) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar4 = *piVar7;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) {
		          if (iVar4 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x810b32ed:
		          DAT_ram_009d3e38 = 0;
		          if (param1[0xc] == 0) {
		            uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                              (param1,0);
		            iVar8 = UnityEngine_InputSystem_Users_InputUser__UnpairDevices(uVar3,0);
		            if (iVar8 == 0) {
		              *(undefined1 *)(param1 + 0xe) = 1;
		            }
		            else {
		              if (DAT_ram_00a59a40 == '\0') {
		                Mono_Security_ASN1__get_Item
		                          (&UI_Requirements_RequirementsView__DelayedCall_d__23_TypeInfo);
		                DAT_ram_00a59a40 = '\x01';
		              }
		              iVar8 = unnamed_function_1417
		                                (UI_Requirements_RequirementsView__DelayedCall_d__23_TypeInfo);
		              *(int **)(iVar8 + 0x10) = param1;
		              *(undefined4 *)(iVar8 + 8) = 0;
		              iVar8 = UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar8,0);
		              param1[0xc] = iVar8;
		            }
		          }
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x81,&local_20);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) {
		        import::env::__resumeException(uVar3);
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
		  iVar8 = *local_8._4_4_;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar6 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		      if (Core_Data_InfoRows_IInformationRow_TypeInfo == *piVar6) {
		        puVar5 = (undefined4 *)(iVar8 + piVar6[1] * 8 + 0xc0);
		        goto code_r0x810b2ddd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar5 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                      Core_Data_InfoRows_IInformationRow_TypeInfo,0);
		  if (DAT_ram_009d3e38 != 1) {
		code_r0x810b2ddd:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		    iVar8 = DAT_ram_009d3e38;
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x7f,param1,uVar3,iVar8);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810b3297;
		      }
		      uVar9 = *(undefined4 *)(iVar4 + 0xc);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30e,param1,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x810b305f:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810b3297;
		      }
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   UnityEngine_Object_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x810b305f;
		      }
		      DAT_ram_009d3e38 = 0;
		      piVar6 = (int *)import::env::invoke_iiii
		                                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar9,uVar3
		                                 ,Method_UnityEngine_Object_Instantiate_TitleRowView___);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810b3297;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x80,piVar6,piVar7,0);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810b3297;
		      }
		      iVar8 = *piVar7;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (Core_Data_InfoRows_IInformationRow_TypeInfo == *piVar10) {
		            puVar5 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x810b2fbc;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar5 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                          Core_Data_InfoRows_IInformationRow_TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x810b2fbc:
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		        if (DAT_ram_009d3e38 != 1) {
		          uVar3 = *(undefined4 *)(*piVar6 + 0xfc);
		          uVar9 = *(undefined4 *)(*piVar6 + 0xf8);
		          if (iVar8 == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii(uVar9,piVar6,param1 + 4,uVar3);
		            iVar8 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar8 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x810b3297;
		            }
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii(uVar9,piVar6,param1 + 5,uVar3);
		            iVar8 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar8 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x810b3297;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (*(undefined4 *)(*piVar6 + 0x108),piVar6,param1[7],
		                     *(undefined4 *)(*piVar6 + 0x10c));
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x810b3297;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (*(undefined4 *)(*piVar6 + 0x118),piVar6,param1[8],
		                     *(undefined4 *)(*piVar6 + 0x11c));
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x810b3297;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (*(undefined4 *)(*piVar6 + 0x120),piVar6,param1[6],
		                     *(undefined4 *)(*piVar6 + 0x124));
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x810b3297;
		          }
		          goto code_r0x810b2ced;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810b3297;
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x810b3297;
		}
		*/

}
