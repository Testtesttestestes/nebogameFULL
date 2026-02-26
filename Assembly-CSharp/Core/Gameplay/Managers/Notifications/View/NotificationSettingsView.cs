using System;
using System.Collections.Generic;
using Core.Gameplay.Managers.Notifications.Model;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Core.Gameplay.Managers.Notifications.View
{
	// Token: 0x020011A8 RID: 4520
	[Token(Token = "0x20011A8")]
	public class NotificationSettingsView : AbstractDataRenderer<List<NotificationCategoryData>>
	{
		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06006B6D RID: 27501 RVA: 0x00013D40 File Offset: 0x00011F40
		[Token(Token = "0x170015E6")]
		protected override bool ValidateDataImmediately
		{
			[Token(Token = "0x6006B6D")]
			[Address(RVA = "0xB66B", Offset = "0xB66B", VA = "0xB66B", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006B6E RID: 27502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B6E")]
		[Address(RVA = "0xB66C", Offset = "0xB66C", VA = "0xB66C", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Core_Gameplay_Managers_Notifications_View_NotificationSettingsView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a676 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_AbstractDataRenderer_List_NotificationCategoryData____ctor__);
		    DAT_ram_00a5a676 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_List_NotificationCategoryData____ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06006B6F RID: 27503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B6F")]
		[Address(RVA = "0xB66D", Offset = "0xB66D", VA = "0xB66D")]
		public NotificationSettingsView()
		{
		}

		// Token: 0x040038B6 RID: 14518
		[Token(Token = "0x40038B6")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private NotificationCategorySettingsView _categoryPrefab;

		// Token: 0x040038B7 RID: 14519
		[Token(Token = "0x40038B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _container;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ValidateDataImmediately ---
		void Core_Gameplay_Managers_Notifications_View_NotificationSettingsView__get_ValidateDataImmediately
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  int *piVar8;
		  uint uVar9;
		  int local_24;
		  int **local_20;
		  int *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a675 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_NotificationCategoryData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_NotificationCategoryData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_NotificationCategoryData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_NotificationCategoryData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_NotificationCategorySettingsView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a5a675 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(param1[10],0);
		  local_1c = &local_8;
		  local_24 = 0;
		  local_20 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x8124ef59;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8124f19c:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8124f1a4;
		    }
		code_r0x8124ef59:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8124f19c;
		    if (iVar7 == 0) goto code_r0x8124f1ed;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(piVar8[1] * 8 + iVar7 + 200);
		          goto code_r0x8124f036;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8124f17e:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8124f1a4;
		    }
		code_r0x8124f036:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8124f17e;
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
		        goto code_r0x8124f1a4;
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
		code_r0x8124f1a4:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_24 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x8124f1ed:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_1c;
		      if (piVar5 != (int *)0x0) {
		        iVar7 = *piVar5;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar9 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8124f27d;
		            }
		            uVar9 = uVar9 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x8124f27d:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_24 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_24);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      if (iVar7 == 0) {
		        return;
		      }
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_18,uVar3,
		                 Method_System_Collections_Generic_List_NotificationCategoryData__GetEnumerator__);
		      local_24 = 0;
		      local_20 = (int **)&local_18;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                           Method_System_Collections_Generic_List_Enumerator_NotificationCategoryData__MoveNext__
		                          );
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8124f46d;
		        }
		        if (iVar4 == 0) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        iVar7 = param1[10];
		        iVar4 = param1[9];
		        uVar3 = local_10._4_4_;
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8124f46d;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        piVar5 = (int *)import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,iVar4,
		                                   iVar7,
		                                   Method_UnityEngine_Object_Instantiate_NotificationCategorySettingsView___
		                                  );
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8124f46d;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(*piVar5 + 0x138),piVar5,uVar3,*(undefined4 *)(*piVar5 + 0x13c));
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar7 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8124f46d:
		      iVar7 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar4 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_24 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          if (iVar4 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x314,&local_24);
		      goto joined_r0x8124f4fe;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x313,&local_24);
		joined_r0x8124f4fe:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
