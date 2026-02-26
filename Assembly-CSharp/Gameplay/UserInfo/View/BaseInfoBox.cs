using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003EF RID: 1007
	[Token(Token = "0x20003EF")]
	public abstract class BaseInfoBox : MonoBehaviour
	{
		// Token: 0x06001791 RID: 6033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001791")]
		[Address(RVA = "0x694D", Offset = "0x694D", VA = "0x694D")]
		private void OnDisable()
		{
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001792")]
		[Address(RVA = "0x694E", Offset = "0x694E", VA = "0x694E")]
		private void OnEnable()
		{
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x000055E0 File Offset: 0x000037E0
		// (set) Token: 0x06001794 RID: 6036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000413")]
		public bool Visible
		{
			[Token(Token = "0x6001793")]
			[Address(RVA = "0x694F", Offset = "0x694F", VA = "0x694F")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001794")]
			[Address(RVA = "0x6950", Offset = "0x6950", VA = "0x6950")]
			set
			{
			}
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001795")]
		[Address(RVA = "0x6951", Offset = "0x6951", VA = "0x6951", Slot = "4")]
		protected virtual void HandleVisibleChanged()
		{
		/* --- GHIDRA: HandleVisibleChanged ---
		uint Gameplay_UserInfo_View_BaseInfoBox__HandleVisibleChanged(int *param1,undefined4 param2)
		
		{
		  byte bVar1;
		  
		  bVar1 = *(byte *)(param1 + 5);
		  *(byte *)(param1 + 5) = bVar1 ^ 1;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))(param1,*(undefined4 *)(*param1 + 0xe4));
		  return (uint)(bVar1 == 0);
		}
		*/

		}

		// Token: 0x06001796 RID: 6038 RVA: 0x000055F8 File Offset: 0x000037F8
		[Token(Token = "0x6001796")]
		[Address(RVA = "0x6952", Offset = "0x6952", VA = "0x6952")]
		public bool SwitchVisible()
		{
		/* --- GHIDRA: SwitchVisible ---
		void Gameplay_UserInfo_View_BaseInfoBox__SwitchVisible(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
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
		  
		  if (DAT_ram_00a598c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a598c7 = '\x01';
		  }
		  local_8 = 0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x10),0);
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
		          puVar2 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x81086574;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810867b7:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810867bf;
		    }
		code_r0x81086574:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810867b7;
		    if (iVar7 == 0) goto code_r0x81086808;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(piVar8[1] * 8 + iVar7 + 200);
		          goto code_r0x81086651;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81086799:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810867bf;
		    }
		code_r0x81086651:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81086799;
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
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810867bf;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
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
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810867bf:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_14 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x81086808:
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
		              goto code_r0x81086898;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x81086898:
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
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x24,&local_14);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001797")]
		[Address(RVA = "0x6953", Offset = "0x6953", VA = "0x6953")]
		public void RemoveAll()
		{
		}

		// Token: 0x06001798 RID: 6040
		[Token(Token = "0x6001798")]
		public abstract void UpdateInfo();

		// Token: 0x06001799 RID: 6041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001799")]
		[Address(RVA = "0x6954", Offset = "0x6954", VA = "0x6954")]
		protected BaseInfoBox()
		{
		}

		// Token: 0x04000C7C RID: 3196
		[Token(Token = "0x4000C7C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected Transform _content;

		// Token: 0x04000C7D RID: 3197
		[Token(Token = "0x4000C7D")]
		[FieldOffset(Offset = "0x14")]
		private bool _visible;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Visible ---
		void Gameplay_UserInfo_View_BaseInfoBox__get_Visible(int *param1,uint param2,undefined4 param3)
		
		{
		  if (param2 != *(byte *)(param1 + 5)) {
		    *(char *)(param1 + 5) = (char)param2;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))(param1,*(undefined4 *)(*param1 + 0xe4));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Visible ---
		void Gameplay_UserInfo_View_BaseInfoBox__set_Visible(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)*(byte *)(param1 + 5),0);
		  if ((char)param1[5] != '\0') {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))(param1,*(undefined4 *)(*param1 + 0xec));
		  }
		  return;
		}
		*/

}
