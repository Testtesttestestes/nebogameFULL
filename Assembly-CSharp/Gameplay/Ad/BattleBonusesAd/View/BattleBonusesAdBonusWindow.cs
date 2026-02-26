using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Ad.BattleBonusesAd.View
{
	// Token: 0x02000DB9 RID: 3513
	[Token(Token = "0x2000DB9")]
	public class BattleBonusesAdBonusWindow : BaseDialogWindow<BattleBonusesAdBonusWindow.BattleBonusesAdBonusWindowArgs>
	{
		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x060055C1 RID: 21953 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700116E")]
		public override string WindowId
		{
			[Token(Token = "0x60055C1")]
			[Address(RVA = "0xA361", Offset = "0xA361", VA = "0xA361", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060055C2 RID: 21954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C2")]
		[Address(RVA = "0xA362", Offset = "0xA362", VA = "0xA362", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		void Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdBonusWindow__HandleContent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58861 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BattleBonusesAdBonusWindow_BattleBonusesAdBonusWindowArgs___ctor__
		              );
		    DAT_ram_00a58861 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BattleBonusesAdBonusWindow_BattleBonusesAdBonusWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C3")]
		[Address(RVA = "0xA363", Offset = "0xA363", VA = "0xA363")]
		public BattleBonusesAdBonusWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdBonusWindow___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58862 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BattleBonusesAdBonusWindow_BattleBonusesAdBonusWindowArgs___ctor__
		              );
		    DAT_ram_00a58862 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BattleBonusesAdBonusWindow_BattleBonusesAdBonusWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002E74 RID: 11892
		[Token(Token = "0x4002E74")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Ad/BattleBonusesAdBonusWindow";

		// Token: 0x04002E75 RID: 11893
		[Token(Token = "0x4002E75")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BattleBonusesBonusRenderer _bonusRendererPrefab;

		// Token: 0x04002E76 RID: 11894
		[Token(Token = "0x4002E76")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Transform _bonusesContainer;

		// Token: 0x02000DBA RID: 3514
		[Token(Token = "0x2000DBA")]
		public class BattleBonusesAdBonusWindowArgs : BaseDialogWindow<BattleBonusesAdBonusWindow.BattleBonusesAdBonusWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x060055C4 RID: 21956 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60055C4")]
			[Address(RVA = "0xA364", Offset = "0xA364", VA = "0xA364")]
			public BattleBonusesAdBonusWindowArgs()
			{
			}

			// Token: 0x04002E77 RID: 11895
			[Token(Token = "0x4002E77")]
			[FieldOffset(Offset = "0x2C")]
			public IEnumerable<MedalData> BonusMedalsData;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdBonusWindow__get_WindowId
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 param3;
		  undefined4 param2_00;
		  int *piVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58860 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BattleBonusesAdBonusWindow_BattleBonusesAdBonusWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_BattleBonusesAdBonusWindow_BattleBonusesAdBonusWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_MedalData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MedalData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_BattleBonusesBonusRenderer___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58860 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BattleBonusesAdBonusWindow_BattleBonusesAdBonusWindowArgs__HandleContent__
		            );
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_BattleBonusesAdBonusWindow_BattleBonusesAdBonusWindowArgs__get_WindowArgs__
		                      );
		  if (*(int *)(iVar2 + 0x2c) == 0) {
		    return;
		  }
		  uVar1 = 0;
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_BattleBonusesAdBonusWindow_BattleBonusesAdBonusWindowArgs__get_WindowArgs__
		                      );
		  piVar7 = *(int **)(iVar2 + 0x2c);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_MedalData__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f35c44;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,System_Collections_Generic_IEnumerable_MedalData__TypeInfo,0)
		  ;
		code_r0x80f35c44:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar7 = local_4;
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar4 = (undefined4 *)(iVar2 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80f35d14;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f35f25:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f35f2d;
		    }
		code_r0x80f35d14:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f35f25;
		    if (iVar2 == 0) {
		      iVar2 = 0;
		      goto code_r0x80f35f76;
		    }
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_MedalData__TypeInfo == *piVar8) {
		          puVar4 = (undefined4 *)(iVar2 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80f35dee;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_MedalData__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f35efd:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f35f2d;
		    }
		code_r0x80f35dee:
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f35efd;
		    param3 = *(undefined4 *)(param1 + 0x54);
		    param2_00 = *(undefined4 *)(param1 + 0x50);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f35f2d;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    piVar7 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00,
		                               param3,
		                               Method_UnityEngine_Object_Instantiate_BattleBonusesBonusRenderer___);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f35f2d;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*piVar7 + 0x138),piVar7,uVar5,*(undefined4 *)(*piVar7 + 0x13c));
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar2 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f35f2d:
		  iVar2 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar2 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar2;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80f35f76:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f35fee;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f35fee:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		      }
		      if (iVar2 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1a8,&local_c);
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
		*/

}
