using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Medals.Model;
using Il2CppDummyDll;
using Protocol.Main;
using Utils;

namespace Core.Data
{
	// Token: 0x020010BE RID: 4286
	[Token(Token = "0x20010BE")]
	public class MedalData
	{
		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x060063FD RID: 25597 RVA: 0x00012EA0 File Offset: 0x000110A0
		[Token(Token = "0x17001417")]
		public uint CurrentRank
		{
			[Token(Token = "0x60063FD")]
			[Address(RVA = "0xAFFA", Offset = "0xAFFA", VA = "0xAFFA")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x060063FE RID: 25598 RVA: 0x00012EB8 File Offset: 0x000110B8
		[Token(Token = "0x17001418")]
		public uint NextRank
		{
			[Token(Token = "0x60063FE")]
			[Address(RVA = "0xAFFB", Offset = "0xAFFB", VA = "0xAFFB")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x060063FF RID: 25599 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006400 RID: 25600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001419")]
		public MedalDicGroup MedalDicGroup
		{
			[Token(Token = "0x60063FF")]
			[Address(RVA = "0xAFFC", Offset = "0xAFFC", VA = "0xAFFC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006400")]
			[Address(RVA = "0xAFFD", Offset = "0xAFFD", VA = "0xAFFD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06006401 RID: 25601 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006402 RID: 25602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700141A")]
		public SortedList<uint, MedalInfo> MedalInfos
		{
			[Token(Token = "0x6006401")]
			[Address(RVA = "0xAFFE", Offset = "0xAFFE", VA = "0xAFFE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006402")]
			[Address(RVA = "0xAFFF", Offset = "0xAFFF", VA = "0xAFFF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06006403 RID: 25603 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006404 RID: 25604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700141B")]
		public BackTime Backtime
		{
			[Token(Token = "0x6006403")]
			[Address(RVA = "0xB000", Offset = "0xB000", VA = "0xB000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006404")]
			[Address(RVA = "0xB001", Offset = "0xB001", VA = "0xB001")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006405")]
		[Address(RVA = "0xB002", Offset = "0xB002", VA = "0xB002")]
		private MedalData()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Data_MedalData___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  int *piVar3;
		  uint *puVar4;
		  undefined4 *puVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a607c7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    DAT_ram_00a607c7 = '\x01';
		  }
		  iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(param1 + 0x18),0);
		  if (iVar2 == 0) {
		    return *(undefined4 *)(param1 + 0x18);
		  }
		  uVar1 = 0;
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_00,0);
		  piVar3 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_Generic_IReadOnlyDictionary_TKey_TValue__get_Keys
		                            (*(undefined4 *)(*(int *)(param1 + 8) + 8),
		                             Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__
		                            );
		  iVar2 = *piVar3;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81ce4302;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar3,
		                                System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo,0);
		code_r0x81ce4302:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar3 = local_4;
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar5 = (undefined4 *)(iVar2 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x81ce43d2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x81ce45b9:
		      DAT_ram_009d3e38 = (uint *)0x0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81ce45c1;
		    }
		code_r0x81ce43d2:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    iVar2 = import::env::invoke_iii(*puVar5,piVar3,puVar5[1]);
		    piVar3 = local_4;
		    if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x81ce45b9;
		    if (iVar2 == 0) {
		      iVar7 = 5;
		      iVar2 = 0;
		      puVar4 = DAT_ram_009d3e38;
		      goto code_r0x81ce460e;
		    }
		    iVar2 = *local_4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo == *piVar8) {
		          puVar5 = (undefined4 *)(iVar2 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x81ce44ac;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo,0);
		    if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x81ce4591:
		      DAT_ram_009d3e38 = (uint *)0x0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81ce45c1;
		    }
		code_r0x81ce44ac:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    iVar2 = import::env::invoke_iii(*puVar5,piVar3,puVar5[1]);
		    if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x81ce4591;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    uVar6 = import::env::invoke_iii
		                      (s___Scripting__UnityEngine__Render_ram_000036af + 0x38,
		                       *(undefined4 *)(iVar2 + 0x10),0);
		    iVar2 = (int)DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    if (iVar2 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81ce45c1;
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    uVar6 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2d9,uVar6,0)
		    ;
		    iVar2 = (int)DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    if (iVar2 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81ce45c1;
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    import::env::invoke_iiii
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar6,0);
		    iVar2 = (int)DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		  } while (iVar2 != 1);
		  uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81ce45c1:
		  iVar2 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar7) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar6);
		    iVar2 = *piVar3;
		    iVar7 = 0;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    local_c = iVar2;
		    import::env::invoke_v(0x123);
		    puVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    if (puVar4 != (uint *)0x1) {
		code_r0x81ce460e:
		      piVar3 = local_4;
		      DAT_ram_009d3e38 = (uint *)0x0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar9 = *local_4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		              puVar4 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81ce4686;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81ce4686:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar3,puVar4[1]);
		      }
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar7 != 0) {
		        if (iVar7 == 1) {
		          return puVar4;
		        }
		        if (iVar7 == 2) {
		          return puVar4;
		        }
		        if (iVar7 == 3) {
		          return puVar4;
		        }
		        if (iVar7 == 4) {
		          return puVar4;
		        }
		        if (iVar7 != 5) {
		          return puVar4;
		        }
		      }
		      uVar6 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                        (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		      *(undefined4 *)(param1 + 0x18) = uVar6;
		      return uVar6;
		    }
		    uVar6 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = (uint *)0x0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_000036af + 0x39,&local_c);
		  iVar2 = (int)DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = (uint *)0x0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06006406 RID: 25606 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700141C")]
		public string FilterTitles
		{
			[Token(Token = "0x6006406")]
			[Address(RVA = "0xB003", Offset = "0xB003", VA = "0xB003")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006407 RID: 25607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006407")]
		[Address(RVA = "0x1C02", Offset = "0x1C02", VA = "0x1C02")]
		public void AddMedalInfo(MedalInfo medalInfo)
		{
		}

		// Token: 0x06006408 RID: 25608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006408")]
		[Address(RVA = "0xB004", Offset = "0xB004", VA = "0xB004")]
		private void ValidateState()
		{
		/* --- GHIDRA: ValidateState ---
		undefined4 Core_Data_MedalData__ValidateState(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a607cb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Item__);
		    DAT_ram_00a607cb = '\x01';
		  }
		  iVar1 = System_Collections_Generic_SortedList_uint__object___Clear
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 8),*(undefined4 *)(param1 + 0x10),
		                     Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = System_Collections_Generic_SortedList_uint__object___get_Count
		                      (*(undefined4 *)(*(int *)(param1 + 8) + 8),*(undefined4 *)(param1 + 0x10),
		                       Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Item__
		                      );
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06006409 RID: 25609 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700141D")]
		public MedalDicWrapper FirstRankMedal
		{
			[Token(Token = "0x6006409")]
			[Address(RVA = "0x223F", Offset = "0x223F", VA = "0x223F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x0600640A RID: 25610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700141E")]
		public MedalDicWrapper CurrentMedal
		{
			[Token(Token = "0x600640A")]
			[Address(RVA = "0xB005", Offset = "0xB005", VA = "0xB005")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x0600640B RID: 25611 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700141F")]
		public MedalDicWrapper NextMedal
		{
			[Token(Token = "0x600640B")]
			[Address(RVA = "0xB006", Offset = "0xB006", VA = "0xB006")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x0600640C RID: 25612 RVA: 0x00012ED0 File Offset: 0x000110D0
		[Token(Token = "0x17001420")]
		public uint SortOrder
		{
			[Token(Token = "0x600640C")]
			[Address(RVA = "0x1C2A", Offset = "0x1C2A", VA = "0x1C2A")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600640D RID: 25613 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600640D")]
		[Address(RVA = "0x1BF7", Offset = "0x1BF7", VA = "0x1BF7")]
		public static MedalData Create(MedalDicGroup medalDicGroup)
		{
			return null;
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600640E")]
		[Address(RVA = "0xB007", Offset = "0xB007", VA = "0xB007")]
		public static MedalData CreateEmpty()
		{
			return null;
		}

		// Token: 0x0600640F RID: 25615 RVA: 0x00012EE8 File Offset: 0x000110E8
		[Token(Token = "0x600640F")]
		[Address(RVA = "0x1C10", Offset = "0x1C10", VA = "0x1C10")]
		public bool IsMedalAchieved(uint rankId)
		{
		/* --- GHIDRA: IsMedalAchieved ---
		void Core_Data_MedalData__IsMedalAchieved(int param1,float param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a5b897 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Materials_GrayscaleUI_TypeInfo);
		    DAT_ram_00a5b897 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x94);
		  if (param1_00 == 0) {
		    param1_00 = unnamed_function_1417(Core_Materials_GrayscaleUI_TypeInfo);
		    UnityEngine_Purchasing_Default_WinProductDescription__set_platformSpecificID(param1_00,param1,0)
		    ;
		    *(int *)(param1 + 0x94) = param1_00;
		  }
		  Core_Materials_GrayscaleUI___ctor(param1_00,param2,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006410 RID: 25616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006410")]
		[Address(RVA = "0x1C16", Offset = "0x1C16", VA = "0x1C16")]
		public void RemoveMedalById(uint medalId)
		{
		}

		// Token: 0x04003579 RID: 13689
		[Token(Token = "0x4003579")]
		[FieldOffset(Offset = "0x10")]
		private uint _currentRank;

		// Token: 0x0400357A RID: 13690
		[Token(Token = "0x400357A")]
		[FieldOffset(Offset = "0x14")]
		private uint _nextRank;

		// Token: 0x0400357B RID: 13691
		[Token(Token = "0x400357B")]
		[FieldOffset(Offset = "0x18")]
		private string _filterTitles;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Backtime ---
		void Core_Data_MedalData__set_Backtime(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a607c6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_SortedList_uint__MedalInfo__TypeInfo);
		    DAT_ram_00a607c6 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_SortedList_uint__MedalInfo__TypeInfo)
		  ;
		  System_Collections_Generic_SortedList_object__object___set_Capacity
		            (param1_00,Method_System_Collections_Generic_SortedList_uint__MedalInfo___ctor__);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  return;
		}
		*/


		/* --- GHIDRA: get_FilterTitles ---
		void Core_Data_MedalData__get_FilterTitles(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a607c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_uint___);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalInfo__get_Keys__);
		    DAT_ram_00a607c9 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  piVar2 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_IDictionary_get_Item
		                            (*(undefined4 *)(param1 + 0xc),
		                             Method_System_Collections_Generic_SortedList_uint__MedalInfo__get_Keys__
		                            );
		  iVar8 = *piVar2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_uint__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81ce492f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_IEnumerable_uint__TypeInfo,0);
		code_r0x81ce492f:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  iVar8 = 0;
		  do {
		    iVar7 = iVar8;
		    piVar2 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x81ce4a13;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81ce4bc1:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81ce4bc9;
		    }
		code_r0x81ce4a13:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		    piVar2 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81ce4bc1;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      goto code_r0x81ce4c12;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x81ce4aed;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81ce4ba3:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81ce4bc9;
		    }
		code_r0x81ce4aed:
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii(*puVar4,piVar2,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81ce4ba3;
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_Math_TypeInfo);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81ce4bc9;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar8 = System_Math__Min(iVar7,uVar5,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar6 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81ce4bc9:
		  iVar8 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar6) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar8 = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar8;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x81ce4c12:
		      piVar2 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81ce4c8a;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81ce4c8a:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      }
		      if (iVar8 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(param1 + 0x10) = iVar7;
		      iVar8 = 0;
		      piVar2 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_IDictionary_get_Item
		                                (*(undefined4 *)(*(int *)(param1 + 8) + 8),
		                                 Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Keys__
		                                );
		      if (iVar7 == 0) {
		        uVar1 = 0;
		        iVar8 = *piVar2;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_Collections_Generic_IList_uint__TypeInfo ==
		                *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81ce4d69;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_IList_uint__TypeInfo,0);
		code_r0x81ce4d69:
		        uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,0,puVar3[1]);
		        *(undefined4 *)(param1 + 0x14) = uVar5;
		        return;
		      }
		      iVar6 = System_Linq_Enumerable__Last_object_
		                        (piVar2,Method_System_Linq_Enumerable_Last_uint___);
		      if (iVar6 != iVar7) {
		        do {
		          piVar2 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_IDictionary_get_Item
		                                    (*(undefined4 *)(*(int *)(param1 + 8) + 8),
		                                     Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Keys__
		                                    );
		          iVar7 = *piVar2;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		              if (System_Collections_Generic_ICollection_uint__TypeInfo == *piVar9) {
		                puVar3 = (uint *)(iVar7 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x81ce4e1a;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		          }
		          puVar3 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_ICollection_uint__TypeInfo
		                                        ,0);
		code_r0x81ce4e1a:
		          iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		          if (iVar7 <= iVar8) {
		            return;
		          }
		          piVar2 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_IDictionary_get_Item
		                                    (*(undefined4 *)(*(int *)(param1 + 8) + 8),
		                                     Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Keys__
		                                    );
		          iVar7 = *piVar2;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		              if (System_Collections_Generic_IList_uint__TypeInfo == *piVar9) {
		                puVar3 = (uint *)(iVar7 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x81ce4eaf;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		          }
		          puVar3 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_IList_uint__TypeInfo,0);
		code_r0x81ce4eaf:
		          iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,iVar8,puVar3[1]);
		          if (iVar7 == *(int *)(param1 + 0x10)) goto code_r0x81ce4ec4;
		          iVar8 = iVar8 + 1;
		        } while( true );
		      }
		      goto code_r0x81ce4f7f;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_000036af + 0x3a,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
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
		code_r0x81ce4ec4:
		  uVar1 = 0;
		  piVar2 = (int *)System_Collections_Generic_SortedList_uint__object___System_Collections_IDictionary_get_Item
		                            (*(undefined4 *)(*(int *)(param1 + 8) + 8),
		                             Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Keys__
		                            );
		  iVar7 = *piVar2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_uint__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81ce4f4e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_IList_uint__TypeInfo,0);
		code_r0x81ce4f4e:
		  iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,iVar8 + 1,puVar3[1]);
		code_r0x81ce4f7f:
		  *(int *)(param1 + 0x14) = iVar8;
		  return;
		}
		*/


		/* --- GHIDRA: get_FirstRankMedal ---
		undefined4 Core_Data_MedalData__get_FirstRankMedal(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad72 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_BattleBonusMedal__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_BattleBonusMedal__get_Item__);
		    DAT_ram_00a5ad72 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x2cc) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x2cc),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_BattleBonusMedal__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: get_CurrentMedal ---
		undefined4 Core_Data_MedalData__get_CurrentMedal(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a607cc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Item__);
		    DAT_ram_00a607cc = '\x01';
		  }
		  iVar1 = System_Collections_Generic_SortedList_uint__object___Clear
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 8),*(undefined4 *)(param1 + 0x14),
		                     Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = System_Collections_Generic_SortedList_uint__object___get_Count
		                      (*(undefined4 *)(*(int *)(param1 + 8) + 8),*(undefined4 *)(param1 + 0x14),
		                       Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Item__
		                      );
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_NextMedal ---
		int Core_Data_MedalData__get_NextMedal(undefined4 param1)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a607cf == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_MedalData_TypeInfo);
		    DAT_ram_00a607cf = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Data_MedalData_TypeInfo);
		  if (DAT_ram_00a607c6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_SortedList_uint__MedalInfo__TypeInfo);
		    DAT_ram_00a607c6 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_SortedList_uint__MedalInfo__TypeInfo)
		  ;
		  System_Collections_Generic_SortedList_object__object___set_Capacity
		            (param1_00,Method_System_Collections_Generic_SortedList_uint__MedalInfo___ctor__);
		  *(undefined4 *)(iVar1 + 0xc) = param1_00;
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_SortOrder ---
		int * Core_Data_MedalData__get_SortOrder(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
