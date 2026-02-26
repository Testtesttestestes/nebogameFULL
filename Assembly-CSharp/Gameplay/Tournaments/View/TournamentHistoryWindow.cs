using System;
using System.Collections.Generic;
using Gameplay.Tournaments.Controller;
using Il2CppDummyDll;
using Protocol.Tournaments;
using TMPro;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004A8 RID: 1192
	[Token(Token = "0x20004A8")]
	public class TournamentHistoryWindow : ClosableBaseWindow<TournamentHistoryWindow.TournamentHistoryWindowArgs>
	{
		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F6")]
		public override string WindowId
		{
			[Token(Token = "0x6001C2A")]
			[Address(RVA = "0x6DA9", Offset = "0x6DA9", VA = "0x6DA9", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F7")]
		public TextMeshProUGUI TournamentStatus
		{
			[Token(Token = "0x6001C2B")]
			[Address(RVA = "0x6DAA", Offset = "0x6DAA", VA = "0x6DAA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F8")]
		public Button NextButton
		{
			[Token(Token = "0x6001C2C")]
			[Address(RVA = "0x6DAB", Offset = "0x6DAB", VA = "0x6DAB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F9")]
		public Button PrevButton
		{
			[Token(Token = "0x6001C2D")]
			[Address(RVA = "0x6DAC", Offset = "0x6DAC", VA = "0x6DAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004FA")]
		public TournamentHistoryInfoBox InfoBox
		{
			[Token(Token = "0x6001C2E")]
			[Address(RVA = "0x6DAD", Offset = "0x6DAD", VA = "0x6DAD")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004FB")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x6001C2F")]
			[Address(RVA = "0x6DAE", Offset = "0x6DAE", VA = "0x6DAE")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004FC")]
		public Button RulesButton
		{
			[Token(Token = "0x6001C30")]
			[Address(RVA = "0x6DAF", Offset = "0x6DAF", VA = "0x6DAF")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004FD")]
		public GameObject WinImage
		{
			[Token(Token = "0x6001C31")]
			[Address(RVA = "0x6DB0", Offset = "0x6DB0", VA = "0x6DB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004FE")]
		public GameObject LoseImage
		{
			[Token(Token = "0x6001C32")]
			[Address(RVA = "0x6DB1", Offset = "0x6DB1", VA = "0x6DB1")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C33")]
		[Address(RVA = "0x6DB2", Offset = "0x6DB2", VA = "0x6DB2")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Tournaments_View_TournamentHistoryWindow__OnDestroy
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a584f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_TournamentHistoryWindow_TournamentHistoryWindowArgs__OnShow__
		              );
		    DAT_ram_00a584f5 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_TournamentHistoryWindow_TournamentHistoryWindowArgs__OnShow__
		              );
		  Gameplay_Tournaments_View_TournamentHistoryWindow__Init(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C34")]
		[Address(RVA = "0x6DB3", Offset = "0x6DB3", VA = "0x6DB3", Slot = "22")]
		protected override void OnShow(TournamentHistoryWindow.TournamentHistoryWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		/* WARNING: Removing unreachable block (ram,0x80efc106) */
		
		void Gameplay_Tournaments_View_TournamentHistoryWindow__OnShow
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  uint *puVar6;
		  int iVar7;
		  int *piVar8;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  int *piVar9;
		  undefined8 local_58;
		  undefined4 local_50;
		  undefined8 local_48;
		  undefined4 local_40;
		  longlong local_38;
		  longlong local_30;
		  int local_24;
		  int **local_20;
		  int *local_1c;
		  int local_18;
		  int *local_14;
		  longlong local_10;
		  int *local_8;
		  
		  if (DAT_ram_00a584f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_Fighter___);
		    Mono_Security_ASN1__get_Item(&System_Func_Fighter__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_TnmBattle__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_TournamentBattleInfoListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TnmBattle__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_View_TournamentHistoryWindow___c__DisplayClass33_0__Init_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_View_TournamentHistoryWindow___c__DisplayClass33_0__Init_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_View_TournamentHistoryWindow___c__DisplayClass33_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_ValueTuple_Fighter__Fighter___ctor__);
		    DAT_ram_00a584f6 = '\x01';
		  }
		  local_18 = 0;
		  local_1c = (int *)0x0;
		  local_14 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x44),0);
		  local_8 = &local_18;
		  local_10 = ZEXT48(&local_14) << 0x20;
		  do {
		    piVar8 = local_14;
		    iVar7 = *local_14;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80efbc11;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80efbe54:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80efbe5c;
		    }
		code_r0x80efbc11:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar8,puVar2[1]);
		    piVar8 = local_14;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80efbe54;
		    if (iVar7 == 0) goto code_r0x80efbea5;
		    iVar7 = *local_14;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(piVar9[1] * 8 + iVar7 + 200);
		          goto code_r0x80efbcee;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80efbe36:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80efbe5c;
		    }
		code_r0x80efbcee:
		    DAT_ram_009d3e38 = 0;
		    piVar8 = (int *)import::env::invoke_iii(*puVar2,piVar8,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80efbe36;
		    if (piVar8 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar8 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar8 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar8,
		                   UnityEngine_Transform_TypeInfo);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80efbe5c;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar8,0);
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
		code_r0x80efbe5c:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    puVar2 = (undefined4 *)import::env::__cxa_begin_catch(uVar3);
		    DAT_ram_009d3e38 = 0;
		    local_10 = CONCAT44(local_10._4_4_,*puVar2);
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x80efbea5:
		      DAT_ram_009d3e38 = 0;
		      local_18 = func_ii_1082(local_14,System_IDisposable_TypeInfo);
		      piVar8 = (int *)*local_8;
		      if (piVar8 != (int *)0x0) {
		        iVar7 = *piVar8;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80efbf35;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar8,System_IDisposable_TypeInfo,0);
		code_r0x80efbf35:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar8,puVar6[1]);
		      }
		      if ((int)local_10 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint((int)local_10);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      local_1c = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                  (*(undefined4 *)(param3 + 0xc),
		                                   Method_Google_Protobuf_Collections_RepeatedField_TnmBattle__GetEnumerator__
		                                  );
		      local_24 = 0;
		      local_20 = &local_1c;
		      do {
		        piVar8 = local_1c;
		        iVar7 = *local_1c;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		              puVar2 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x80efc06e;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_1c,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80efc75d:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80efc765;
		        }
		code_r0x80efc06e:
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii(*puVar2,piVar8,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80efc75d;
		        if (iVar7 == 0) {
		          iVar7 = 0;
		          goto code_r0x80efc7ae;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           Gameplay_Tournaments_View_TournamentHistoryWindow___c__DisplayClass33_0_TypeInfo
		                          );
		        piVar8 = local_1c;
		        if (DAT_ram_009d3e38 == 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80efc765;
		        }
		        iVar4 = *local_1c;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_TnmBattle__TypeInfo == *piVar9) {
		              puVar2 = (undefined4 *)(iVar4 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x80efc1a1;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_1c,
		                            System_Collections_Generic_IEnumerator_TnmBattle__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80efc6db:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80efc765;
		        }
		code_r0x80efc1a1:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii(*puVar2,piVar8,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80efc6db;
		        *(undefined4 *)(iVar7 + 8) = uVar3;
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Func_Fighter__bool__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80efc6e5:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80efc765;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar3,iVar7,
		                   Method_Gameplay_Tournaments_View_TournamentHistoryWindow___c__DisplayClass33_0__Init_b__0__
		                   ,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80efc6e5;
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x179,param2,uVar3,
		                           Method_System_Linq_Enumerable_First_Fighter___);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80efc765;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Func_Fighter__bool__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80efc6f9:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80efc765;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar5,iVar7,
		                   Method_Gameplay_Tournaments_View_TournamentHistoryWindow___c__DisplayClass33_0__Init_b__1__
		                   ,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80efc6f9;
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x179,param2,uVar5,
		                           Method_System_Linq_Enumerable_First_Fighter___);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80efc765;
		        }
		        param3_00 = *(undefined4 *)(param1 + 0x44);
		        param2_00 = *(undefined4 *)(param1 + 0x48);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80efc765;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        piVar8 = (int *)import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00
		                                   ,param3_00,
		                                   Method_UnityEngine_Object_Instantiate_TournamentBattleInfoListElement___
		                                  );
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80efc765;
		        }
		        local_30 = 0;
		        DAT_ram_009d3e38 = 0;
		        System_Text_Formatting_StringView__get_IsEmpty
		                  (&local_30,uVar3,uVar5,Method_System_ValueTuple_Fighter__Fighter___ctor__);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80efc721:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80efc765;
		        }
		        local_10 = local_30;
		        DAT_ram_009d3e38 = 0;
		        local_38 = local_30;
		        import::env::invoke_viii
		                  (*(undefined4 *)(*piVar8 + 0xe8),piVar8,&local_38,*(undefined4 *)(*piVar8 + 0xec))
		        ;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80efc721;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x17a,piVar8[7],0,0);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80efc765;
		        }
		        iVar4 = piVar8[4];
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,
		                   *(undefined4 *)(iVar4 + 0x34),1,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80efc735:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80efc765;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x17b,
		                           *(undefined4 *)(iVar4 + 0x34),0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80efc735;
		        local_8 = (int *)0x3f800000;
		        local_40 = 0x3f800000;
		        local_10 = 0x3f8000003f800000;
		        DAT_ram_009d3e38 = 0;
		        local_48 = 0x3f8000003f800000;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x25a,uVar3,&local_48,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80efc735;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x17c,piVar8[4],
		                   *(undefined4 *)(*(int *)(iVar7 + 8) + 0x20),0);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80efc765;
		        }
		        iVar4 = piVar8[5];
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,
		                   *(undefined4 *)(iVar4 + 0x34),1,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80efc749:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80efc765;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x17b,
		                           *(undefined4 *)(iVar4 + 0x34),0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80efc749;
		        local_8 = (int *)0x3f800000;
		        local_50 = 0x3f800000;
		        local_10 = -0x407fffffc0800000;
		        DAT_ram_009d3e38 = 0;
		        local_58 = 0xbf8000003f800000;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x25a,uVar3,&local_58,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80efc749;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x17c,piVar8[5],
		                   *(undefined4 *)(*(int *)(iVar7 + 8) + 0x24),0);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar7 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80efc765:
		      iVar7 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar4) {
		        piVar8 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar7 = *piVar8;
		        DAT_ram_009d3e38 = 0;
		        local_24 = iVar7;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x80efc7ae:
		          piVar8 = local_1c;
		          DAT_ram_009d3e38 = 0;
		          if (local_1c != (int *)0x0) {
		            uVar1 = 0;
		            iVar4 = *local_1c;
		            if (*(ushort *)(iVar4 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		                  puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80efc826;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		            }
		            puVar6 = (uint *)func_ii_1080(local_1c,System_IDisposable_TypeInfo,0);
		code_r0x80efc826:
		            (**(code **)((ulonglong)*puVar6 * 4))(piVar8,puVar6[1]);
		          }
		          if (iVar7 == 0) {
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x17d,&local_24);
		      goto joined_r0x80efc875;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x178,&local_10);
		joined_r0x80efc875:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C35")]
		[Address(RVA = "0x6DB4", Offset = "0x6DB4", VA = "0x6DB4")]
		public void Init(IList<Fighter> fightersList, TnmRound round)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Tournaments_View_TournamentHistoryWindow__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *param1_00;
		  undefined4 param4;
		  int iVar2;
		  
		  if (DAT_ram_00a584f7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_TournamentHistoryWindow_TournamentHistoryWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_Controller_TournamentHistoryViewMediator_TypeInfo);
		    DAT_ram_00a584f7 = '\x01';
		  }
		  if (*(char *)(param1 + 0x68) == '\0') {
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_TournamentHistoryWindow_TournamentHistoryWindowArgs__get_WindowArgs__
		                        );
		    iVar2 = **(int **)(iVar1 + 0x18);
		    param2_00 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                          (*(int **)(iVar1 + 0x18),*(undefined4 *)(iVar2 + 0x104));
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_TournamentHistoryWindow_TournamentHistoryWindowArgs__get_WindowArgs__
		                        );
		    iVar2 = **(int **)(iVar1 + 0x18);
		    param3 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                       (*(int **)(iVar1 + 0x18),*(undefined4 *)(iVar2 + 0x114));
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_TournamentHistoryWindow_TournamentHistoryWindowArgs__get_WindowArgs__
		                        );
		    param4 = *(undefined4 *)(iVar1 + 0x18);
		    param1_00 = (int *)unnamed_function_1417
		                                 (
		                                 Gameplay_Tournaments_Controller_TournamentHistoryViewMediator_TypeInfo
		                                 );
		    if (DAT_ram_00a58524 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentHistoryWindow___ctor__
		                );
		      DAT_ram_00a58524 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (param1_00,param2_00,param3,param4,
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentHistoryWindow___ctor__
		              );
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		              (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		    *(undefined1 *)(param1 + 0x68) = 1;
		    *(int **)(param1 + 100) = param1_00;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C36")]
		[Address(RVA = "0x6DB5", Offset = "0x6DB5", VA = "0x6DB5")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C37")]
		[Address(RVA = "0x6DB6", Offset = "0x6DB6", VA = "0x6DB6")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Tournaments_View_TournamentHistoryWindow__DestroyMVC
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a584f8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_TournamentHistoryWindow_TournamentHistoryWindowArgs___ctor__
		              );
		    DAT_ram_00a584f8 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_TournamentHistoryWindow_TournamentHistoryWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C38")]
		[Address(RVA = "0x6DB7", Offset = "0x6DB7", VA = "0x6DB7")]
		public TournamentHistoryWindow()
		{
		}

		// Token: 0x04000F38 RID: 3896
		[Token(Token = "0x4000F38")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Tournaments/TournamentHistoryWindow";

		// Token: 0x04000F39 RID: 3897
		[Token(Token = "0x4000F39")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TournamentHistoryInfoBox _infoBox;

		// Token: 0x04000F3A RID: 3898
		[Token(Token = "0x4000F3A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x04000F3B RID: 3899
		[Token(Token = "0x4000F3B")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private RectTransform _scrollContentParent;

		// Token: 0x04000F3C RID: 3900
		[Token(Token = "0x4000F3C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TournamentBattleInfoListElement _listElementPrefab;

		// Token: 0x04000F3D RID: 3901
		[Token(Token = "0x4000F3D")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _rulesButton;

		// Token: 0x04000F3E RID: 3902
		[Token(Token = "0x4000F3E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _nextButton;

		// Token: 0x04000F3F RID: 3903
		[Token(Token = "0x4000F3F")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Button _prevButton;

		// Token: 0x04000F40 RID: 3904
		[Token(Token = "0x4000F40")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _tournamentStatus;

		// Token: 0x04000F41 RID: 3905
		[Token(Token = "0x4000F41")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameObject _winImage;

		// Token: 0x04000F42 RID: 3906
		[Token(Token = "0x4000F42")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _loseImage;

		// Token: 0x04000F43 RID: 3907
		[Token(Token = "0x4000F43")]
		[FieldOffset(Offset = "0x64")]
		private TournamentHistoryViewMediator _mediator;

		// Token: 0x04000F44 RID: 3908
		[Token(Token = "0x4000F44")]
		[FieldOffset(Offset = "0x68")]
		private bool _mvcSetUp;

		// Token: 0x020004A9 RID: 1193
		[Token(Token = "0x20004A9")]
		public class TournamentHistoryWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001C39 RID: 7225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001C39")]
			[Address(RVA = "0x6DB8", Offset = "0x6DB8", VA = "0x6DB8")]
			public TournamentHistoryWindowArgs()
			{
			}

			// Token: 0x04000F45 RID: 3909
			[Token(Token = "0x4000F45")]
			[FieldOffset(Offset = "0x18")]
			public TournamentsController Controller;
		}
	}
}
