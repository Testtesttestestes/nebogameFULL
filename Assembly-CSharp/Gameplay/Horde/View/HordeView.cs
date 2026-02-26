using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Gameplay.Accounts.Model.Data;
using Gameplay.Horde.Controller;
using Gameplay.Horde.Model;
using Gameplay.Horde.Model.Data;
using Gameplay.Isles.User;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UI.Elements.RightPanel;
using UI.Elements.RightPanel.TitledList;
using UI.Elements.RightPanel.TitledList.Elements;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Horde.View
{
	// Token: 0x020006FD RID: 1789
	[Token(Token = "0x20006FD")]
	public class HordeView : MonoBehaviour
	{
		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x00008628 File Offset: 0x00006828
		// (set) Token: 0x06002AC5 RID: 10949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081C")]
		public bool AllowClose
		{
			[Token(Token = "0x6002AC4")]
			[Address(RVA = "0x7B5F", Offset = "0x7B5F", VA = "0x7B5F")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002AC5")]
			[Address(RVA = "0x7B60", Offset = "0x7B60", VA = "0x7B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002AC7 RID: 10951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081D")]
		public IMonsterSource MonsterSource
		{
			[Token(Token = "0x6002AC6")]
			[Address(RVA = "0x7B61", Offset = "0x7B61", VA = "0x7B61")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AC7")]
			[Address(RVA = "0x7B62", Offset = "0x7B62", VA = "0x7B62")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002AC9 RID: 10953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081E")]
		public IWindowWithCloseBackButtons MasterWindow
		{
			[Token(Token = "0x6002AC8")]
			[Address(RVA = "0x7B63", Offset = "0x7B63", VA = "0x7B63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AC9")]
			[Address(RVA = "0x7B64", Offset = "0x7B64", VA = "0x7B64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700081F")]
		public ButtonWithCost AttackButton
		{
			[Token(Token = "0x6002ACA")]
			[Address(RVA = "0x7B65", Offset = "0x7B65", VA = "0x7B65")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000820")]
		public ButtonWithCost KickButton
		{
			[Token(Token = "0x6002ACB")]
			[Address(RVA = "0x7B66", Offset = "0x7B66", VA = "0x7B66")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400015C RID: 348
		// (add) Token: 0x06002ACC RID: 10956 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002ACD RID: 10957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400015C")]
		public event Action<uint> RequestHordeInfoEvent
		{
			[Token(Token = "0x6002ACC")]
			[Address(RVA = "0x7B67", Offset = "0x7B67", VA = "0x7B67")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002ACD")]
			[Address(RVA = "0x7B68", Offset = "0x7B68", VA = "0x7B68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000821 RID: 2081
		// (set) Token: 0x06002ACE RID: 10958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000821")]
		public uint MainMonsterId
		{
			[Token(Token = "0x6002ACE")]
			[Address(RVA = "0x7B69", Offset = "0x7B69", VA = "0x7B69")]
			set
			{
			}
		}

		// Token: 0x17000822 RID: 2082
		// (set) Token: 0x06002ACF RID: 10959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000822")]
		public string Difficulty
		{
			[Token(Token = "0x6002ACF")]
			[Address(RVA = "0x7B6A", Offset = "0x7B6A", VA = "0x7B6A")]
			set
			{
			}
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD0")]
		[Address(RVA = "0x7B6B", Offset = "0x7B6B", VA = "0x7B6B")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Horde_View_HordeView__Awake(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 0x40) = 0;
		  if (*(char *)(param1 + 0x3c) != '\0') {
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x38),0);
		    iVar1 = **(int **)(param1 + 0x30);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x30),*(undefined4 *)(iVar1 + 0x134));
		    iVar1 = **(int **)(param1 + 0x38);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x38),*(undefined4 *)(iVar1 + 0xec));
		    iVar1 = **(int **)(param1 + 0x34);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x34),*(undefined4 *)(iVar1 + 0xec));
		    *(undefined1 *)(param1 + 0x3c) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD1")]
		[Address(RVA = "0x7B6C", Offset = "0x7B6C", VA = "0x7B6C")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Horde_View_HordeView__OnDestroy
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0x40) = param3;
		  *(undefined4 *)(param1 + 0x44) = param2;
		  Gameplay_Horde_View_HordeView__UpdateInfo(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD2")]
		[Address(RVA = "0x7B6D", Offset = "0x7B6D", VA = "0x7B6D")]
		public void InitMasterWindowStatus(IWindowWithCloseBackButtons masterWindow, IMonsterSource monsterSource)
		{
		/* --- GHIDRA: InitMasterWindowStatus ---
		int * Gameplay_Horde_View_HordeView__InitMasterWindowStatus
		                (int param1,int *param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  int iVar8;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *piVar9;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a1fb == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Horde_View_HordeMonsterAprView___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_HordeMonsterData__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_HordeMonsterData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameObject___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a5a1fb = '\x01';
		  }
		  local_8 = 0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x28),0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x811e64ff;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811e6742:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811e674a;
		    }
		code_r0x811e64ff:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811e6742;
		    if (iVar8 == 0) goto code_r0x811e6793;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(piVar9[1] * 8 + iVar8 + 200);
		          goto code_r0x811e65dc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811e6724:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811e674a;
		    }
		code_r0x811e65dc:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811e6724;
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar5 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                   UnityEngine_Transform_TypeInfo);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811e674a;
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
		code_r0x811e674a:
		  iVar8 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_14 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x811e6793:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_c;
		      if (piVar5 != (int *)0x0) {
		        iVar8 = *piVar5;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811e6823;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x811e6823:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_14 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_14);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar1 = 0;
		      iVar8 = *param2;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_ICollection_HordeMonsterData__TypeInfo ==
		              *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		            puVar6 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x811e68a7;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_ICollection_HordeMonsterData__TypeInfo
		                                    ,0);
		code_r0x811e68a7:
		      uVar1 = 0;
		      uVar3 = (**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		      piVar5 = (int *)Mono_Security_ASN1Convert__ToOid
		                                (Gameplay_Horde_View_HordeMonsterAprView___TypeInfo,uVar3);
		      iVar8 = *param2;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_IList_HordeMonsterData__TypeInfo ==
		              *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		            puVar6 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x811e693e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_IList_HordeMonsterData__TypeInfo,0);
		code_r0x811e693e:
		      uVar3 = (**(code **)((ulonglong)*puVar6 * 4))(param2,0,puVar6[1]);
		      iVar8 = Gameplay_Horde_View_HordeView__Init(param1,0,uVar3,(uint)(0 < param3),param4,puVar6);
		      if ((iVar8 != 0) && (iVar4 = func_ii_1082(iVar8,*(undefined4 *)(*piVar5 + 0x20)), iVar4 == 0))
		      {
		        uVar3 = func_ii_1083();
		        func_ii_1050(uVar3,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar5[4] = iVar8;
		      iVar8 = 1;
		      do {
		        iVar4 = *param2;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_ICollection_HordeMonsterData__TypeInfo == *piVar9) {
		              puVar6 = (uint *)(iVar4 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x811e6a24;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(param2,
		                                      System_Collections_Generic_ICollection_HordeMonsterData__TypeInfo
		                                      ,0);
		code_r0x811e6a24:
		        iVar4 = (**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		        if (iVar4 <= iVar8) {
		          return piVar5;
		        }
		        iVar4 = *param2;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IList_HordeMonsterData__TypeInfo == *piVar9) {
		              puVar6 = (uint *)(iVar4 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x811e6aa3;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(param2,
		                                      System_Collections_Generic_IList_HordeMonsterData__TypeInfo,0)
		        ;
		code_r0x811e6aa3:
		        uVar3 = (**(code **)((ulonglong)*puVar6 * 4))(param2,iVar8,puVar6[1]);
		        param2_00 = *(undefined4 *)(param1 + 0x28);
		        param1_00 = *(undefined4 *)(param1 + 0x14);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        func_ii_6805(param1_00,param2_00,Method_UnityEngine_Object_Instantiate_GameObject___);
		        iVar4 = Gameplay_Horde_View_HordeView__Init
		                          (param1,iVar8,uVar3,(uint)(iVar8 < param3),param4,uVar3);
		        if ((iVar4 != 0) &&
		           (iVar7 = func_ii_1082(iVar4,*(undefined4 *)(*piVar5 + 0x20)), iVar7 == 0)) {
		          uVar3 = func_ii_1083();
		          func_ii_1050(uVar3,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar5[iVar8 + 4] = iVar4;
		        iVar8 = iVar8 + 1;
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x275,&local_14);
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
		*/

		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002AD3")]
		[Address(RVA = "0x7B6E", Offset = "0x7B6E", VA = "0x7B6E")]
		public HordeMonsterAprView[] Init(IList<HordeMonsterData> hordeMonsters, int currentMonsterIndex, Action<HordeMonsterAprView> callback)
		{
		/* --- GHIDRA: Init ---
		undefined4
		Gameplay_Horde_View_HordeView__Init
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		          undefined4 param6)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a1fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_HordeMonsterAprView_HordeMonsterAprViewArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Horde_View_HordeMonsterAprView_HordeMonsterAprViewArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_HordeMonsterAprView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a1fc = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x28);
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = func_ii_6805(param1_01,uVar1,Method_UnityEngine_Object_Instantiate_HordeMonsterAprView___)
		  ;
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Horde_View_HordeMonsterAprView_HordeMonsterAprViewArgs_TypeInfo);
		  Unity_Collections_NativeArray_ReadOnly_Enumerator_Painter2D_Painter2DJobData___MoveNext
		            (param1_00,0);
		  *(undefined4 *)(param1_00 + 0x14) = param5;
		  *(undefined1 *)(param1_00 + 0x10) = (undefined1)param4;
		  *(undefined4 *)(param1_00 + 0xc) = param3;
		  *(undefined4 *)(param1_00 + 8) = param2;
		  UI_Elements_Buildings_SpellItemArgs___ctor
		            (uVar1,param1_00,
		             Method_UI_Elements_GenericList_GenericListElement_HordeMonsterAprView_HordeMonsterAprViewArgs__Init__
		            );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002AD4")]
		[Address(RVA = "0x7B6F", Offset = "0x7B6F", VA = "0x7B6F")]
		private HordeMonsterAprView SpawnMonsterApr(int index, HordeMonsterData monster, bool defeated, Action<HordeMonsterAprView> callback)
		{
		/* --- GHIDRA: SpawnMonsterApr ---
		void Gameplay_Horde_View_HordeView__SpawnMonsterApr
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,int param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a5a1fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a5a1fd = '\x01';
		  }
		  Core_Extensions_Dict_MonsterDictExt__GetTitle(*(undefined4 *)(param1 + 0x18),param2,0);
		  Core_Extensions_Dict_MonsterDictExt__GetTitle(*(undefined4 *)(param1 + 0x24),param3,0);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl(*(undefined4 *)(param5 + 8),0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Title(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(param1 + 0x2c);
		  uVar2 = UI_Wiki_WikiUriRouter__SetData
		                    (*(undefined4 *)(*(int *)(*(int *)(param5 + 8) + 0xc) + 0x10),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar5,uVar2,0);
		  uVar2 = Core_Data_MonsterData__GetDifficulty(*(undefined4 *)(param5 + 8),param6,0);
		  Gameplay_Horde_View_HordeView__set_MainMonsterId(param1,uVar2,param1);
		  uVar5 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb8);
		  uVar2 = Gameplay_Accounts_Model_Data_BattleAccount__GetMonsterAttackCost
		                    (param4,*(undefined4 *)(param5 + 0xc),0);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  UI_Price_Price__SetColor(uVar5,param6,uVar2,0);
		  uVar5 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xb8);
		  uVar2 = Gameplay_Accounts_Model_Data_BattleAccount__GetMonsterAttackCost
		                    (param4,*(undefined4 *)(*(int *)(param5 + 8) + 8),0);
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  UI_Price_Price__SetColor(uVar5,param6,uVar2,0);
		  uVar2 = *(undefined4 *)(param5 + 8);
		  uVar5 = *(undefined4 *)(param1 + 0x50);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x811e6daf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811e6daf:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar2 = Core_Data_MonsterData__get_Level(uVar2,param6,uVar4,0);
		  UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement__get_Rewards(uVar5,uVar2,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD5")]
		[Address(RVA = "0x7B70", Offset = "0x7B70", VA = "0x7B70")]
		public void UpdateInfo(string title, string description, BattleAccount account, HordeMonsterData monster, UserData user)
		{
		/* --- GHIDRA: UpdateInfo ---
		void Gameplay_Horde_View_HordeView__UpdateInfo(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 param1_00;
		  int *piVar7;
		  int iVar8;
		  int *piVar9;
		  int iVar10;
		  
		  if (DAT_ram_00a5a1fe == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Horde_Controller_HordeController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Horde_Events_HordeEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Horde_Model_HordeModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Horde_Controller_HordeViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_WorldService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a1fe = '\x01';
		  }
		  if (*(char *)(param1 + 0x3c) == '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar7;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		          goto code_r0x811e60b0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811e60b0:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar9;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x120);
		          goto code_r0x811e615c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x811e615c:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar9;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x1f8);
		          goto code_r0x811e6208;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x811e6208:
		    iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		    iVar10 = **(int **)(iVar8 + 0x14);
		    uVar5 = (**(code **)((ulonglong)*(uint *)(iVar10 + 0x100) * 4))
		                      (*(int **)(iVar8 + 0x14),*(undefined4 *)(iVar10 + 0x104));
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar9;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x140);
		          goto code_r0x811e62cd;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811e62cd:
		    uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		    uVar6 = func_ii_7112(uVar6,0);
		    param1_00 = unnamed_function_1417(Gameplay_Horde_Model_HordeModel_TypeInfo);
		    Gameplay_Horde_Model_HordeModel__set_CurrentMonsterIndex
		              (param1_00,piVar7,uVar3,uVar4,uVar5,uVar6,0);
		    *(undefined4 *)(param1 + 0x34) = param1_00;
		    uVar3 = unnamed_function_1417(Gameplay_Horde_Events_HordeEvents_TypeInfo);
		    if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		    }
		    uVar4 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                      (Method_Core_Net_ServiceFactory_GetService_WorldService___);
		    uVar6 = *(undefined4 *)(param1 + 0x34);
		    uVar5 = unnamed_function_1417(Gameplay_Horde_Controller_HordeController_TypeInfo);
		    Gameplay_Horde_Events_HordeEvents___ctor(uVar5,uVar4,uVar6,uVar3,0);
		    *(undefined4 *)(param1 + 0x38) = uVar5;
		    uVar4 = *(undefined4 *)(param1 + 0x34);
		    piVar7 = (int *)unnamed_function_1417(Gameplay_Horde_Controller_HordeViewMediator_TypeInfo);
		    Gameplay_Horde_Controller_HordeController__ExitHordeResultHandler(piVar7,uVar4,uVar3,uVar5,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x160) * 4))
		              (piVar7,param1,*(undefined4 *)(*piVar7 + 0x164));
		    *(int **)(param1 + 0x30) = piVar7;
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x38),0);
		    *(undefined1 *)(param1 + 0x3c) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD6")]
		[Address(RVA = "0x7B71", Offset = "0x7B71", VA = "0x7B71")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Horde_View_HordeView__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 0x3c) != '\0') {
		    MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x38),0);
		    iVar1 = **(int **)(param1 + 0x30);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x30),*(undefined4 *)(iVar1 + 0x134));
		    iVar1 = **(int **)(param1 + 0x38);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x38),*(undefined4 *)(iVar1 + 0xec));
		    iVar1 = **(int **)(param1 + 0x34);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		              (*(int **)(param1 + 0x34),*(undefined4 *)(iVar1 + 0xec));
		    *(undefined1 *)(param1 + 0x3c) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD7")]
		[Address(RVA = "0x7B72", Offset = "0x7B72", VA = "0x7B72")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD8")]
		[Address(RVA = "0x7B73", Offset = "0x7B73", VA = "0x7B73")]
		public HordeView()
		{
		}

		// Token: 0x0400175C RID: 5980
		[Token(Token = "0x400175C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private HordeMonsterAprView _monsterAprPrefab;

		// Token: 0x0400175D RID: 5981
		[Token(Token = "0x400175D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _separatorArrowPrefab;

		// Token: 0x0400175E RID: 5982
		[Token(Token = "0x400175E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TitleWithLevel _windowTitle;

		// Token: 0x0400175F RID: 5983
		[Token(Token = "0x400175F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ButtonWithCost _attackButton;

		// Token: 0x04001760 RID: 5984
		[Token(Token = "0x4001760")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ButtonWithCost _kickButton;

		// Token: 0x04001761 RID: 5985
		[Token(Token = "0x4001761")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TitledList _titledList;

		// Token: 0x04001762 RID: 5986
		[Token(Token = "0x4001762")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04001763 RID: 5987
		[Token(Token = "0x4001763")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameAssetViewRawImage _gameAssetView;

		// Token: 0x04001764 RID: 5988
		[Token(Token = "0x4001764")]
		[FieldOffset(Offset = "0x30")]
		private HordeViewMediator _mediator;

		// Token: 0x04001765 RID: 5989
		[Token(Token = "0x4001765")]
		[FieldOffset(Offset = "0x34")]
		private HordeModel _model;

		// Token: 0x04001766 RID: 5990
		[Token(Token = "0x4001766")]
		[FieldOffset(Offset = "0x38")]
		private HordeController _controller;

		// Token: 0x04001767 RID: 5991
		[Token(Token = "0x4001767")]
		[FieldOffset(Offset = "0x3C")]
		private bool _mvcSetUp;

		// Token: 0x0400176C RID: 5996
		[Token(Token = "0x400176C")]
		[FieldOffset(Offset = "0x4C")]
		private MonsterDifficultyTitledListElement _monsterDifficulty;

		// Token: 0x0400176D RID: 5997
		[Token(Token = "0x400176D")]
		[FieldOffset(Offset = "0x50")]
		private RewardsTitledListElement _rewards;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_KickButton ---
		void Gameplay_Horde_View_HordeView__get_KickButton(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a1f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    DAT_ram_00a5a1f7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x48);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_uint__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_uint__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x48,iVar2,param1_00);
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


		/* --- GHIDRA: add_RequestHordeInfoEvent ---
		void Gameplay_Horde_View_HordeView__add_RequestHordeInfoEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a1f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    DAT_ram_00a5a1f8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x48);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_uint__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_uint__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x48,iVar2,param1_00);
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


		/* --- GHIDRA: remove_RequestHordeInfoEvent ---
		void Gameplay_Horde_View_HordeView__remove_RequestHordeInfoEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x48);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_MainMonsterId ---
		void Gameplay_Horde_View_HordeView__set_MainMonsterId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a1f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10784);
		    DAT_ram_00a5a1f9 = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x4c),0);
		  if (iVar1 != 0) {
		    param1_00 = *(undefined4 *)(param1 + 0x4c);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_10784,1,0,1,0,0,0,0);
		    param3_00 = func_ii_7508(param2,1,0,1,0,0,0,0);
		    uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar2,StringLiteral_118,param3_00,0);
		    Core_Extensions_Dict_MonsterDictExt__GetTitle(param1_00,uVar2,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Difficulty ---
		void Gameplay_Horde_View_HordeView__set_Difficulty(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a5a1fa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyTitledListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyTitledListElement_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		    DAT_ram_00a5a1fa = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x24);
		  uVar2 = unnamed_function_1417(UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		  UI_Elements_RightPanel_TitledList_TitledList__set_Title(uVar4,uVar2,0);
		  uVar4 = *(undefined4 *)(param1 + 0x24);
		  uVar2 = unnamed_function_1417
		                    (
		                    UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyTitledListElementArgs_TypeInfo
		                    );
		  piVar3 = (int *)UI_Elements_RightPanel_TitledList_TitledList__Init(uVar4,uVar2,0);
		  iVar1 = UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyTitledListElement_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param1 + 0x4c) = 0;
		code_r0x811e5e28:
		    uVar4 = *(undefined4 *)(param1 + 0x24);
		    uVar2 = unnamed_function_1417
		                      (
		                      UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElementArgs_TypeInfo
		                      );
		    piVar3 = (int *)UI_Elements_RightPanel_TitledList_TitledList__Init(uVar4,uVar2,0);
		    iVar1 = UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement_TypeInfo;
		    if (piVar3 == (int *)0x0) {
		      *(undefined4 *)(param1 + 0x50) = 0;
		      return;
		    }
		    uVar5 = (uint)*(byte *)(
		                           UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement_TypeInfo
		                           + 0xb8);
		    if ((uVar5 <= *(byte *)(*piVar3 + 0xb8)) &&
		       (*(int *)(*(int *)(*piVar3 + 100) + (uVar5 - 1) * 4) ==
		        UI_Elements_RightPanel_TitledList_Elements_RewardsTitledListElement_TypeInfo)) {
		      *(int **)(param1 + 0x50) = piVar3;
		      if ((uVar5 <= *(byte *)(*piVar3 + 0xb8)) &&
		         (*(int *)(*(int *)(*piVar3 + 100) + (uVar5 - 1) * 4) == iVar1)) {
		        return;
		      }
		    }
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = (uint)*(byte *)(
		                         UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyTitledListElement_TypeInfo
		                         + 0xb8);
		  if ((uVar5 <= *(byte *)(*piVar3 + 0xb8)) &&
		     (*(int *)(*(int *)(*piVar3 + 100) + (uVar5 - 1) * 4) ==
		      UI_Elements_RightPanel_TitledList_Elements_MonsterDifficultyTitledListElement_TypeInfo)) {
		    *(int **)(param1 + 0x4c) = piVar3;
		    if ((uVar5 <= *(byte *)(*piVar3 + 0xb8)) &&
		       (*(int *)(*(int *)(*piVar3 + 100) + (uVar5 - 1) * 4) == iVar1)) goto code_r0x811e5e28;
		  }
		  System_Activator__CreateInstance(piVar3,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
