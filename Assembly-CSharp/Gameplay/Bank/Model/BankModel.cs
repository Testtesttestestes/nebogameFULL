using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Services;
using UnityEngine;

namespace Gameplay.Bank.Model
{
	// Token: 0x02000C53 RID: 3155
	[Token(Token = "0x2000C53")]
	public class BankModel : AbstractModel
	{
		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06004CD5 RID: 19669 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004CD6 RID: 19670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F80")]
		public List<BankTabData> AvailableBankTabs
		{
			[Token(Token = "0x6004CD5")]
			[Address(RVA = "0x9B12", Offset = "0x9B12", VA = "0x9B12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CD6")]
			[Address(RVA = "0x9B13", Offset = "0x9B13", VA = "0x9B13")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004CD8 RID: 19672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F81")]
		public List<PromotionsDic> ActivePromotions
		{
			[Token(Token = "0x6004CD7")]
			[Address(RVA = "0x9B14", Offset = "0x9B14", VA = "0x9B14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CD8")]
			[Address(RVA = "0x9B15", Offset = "0x9B15", VA = "0x9B15")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06004CD9 RID: 19673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F82")]
		public IOptionValidator OptionValidator
		{
			[Token(Token = "0x6004CD9")]
			[Address(RVA = "0x9B16", Offset = "0x9B16", VA = "0x9B16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06004CDA RID: 19674 RVA: 0x0000E118 File Offset: 0x0000C318
		// (set) Token: 0x06004CDB RID: 19675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F83")]
		public Vector2 LastPosition
		{
			[Token(Token = "0x6004CDA")]
			[Address(RVA = "0x9B17", Offset = "0x9B17", VA = "0x9B17")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6004CDB")]
			[Address(RVA = "0x9B18", Offset = "0x9B18", VA = "0x9B18")]
			set
			{
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06004CDC RID: 19676 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004CDD RID: 19677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F84")]
		public IGame Game
		{
			[Token(Token = "0x6004CDC")]
			[Address(RVA = "0x9B19", Offset = "0x9B19", VA = "0x9B19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CDD")]
			[Address(RVA = "0x9B1A", Offset = "0x9B1A", VA = "0x9B1A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06004CDE RID: 19678 RVA: 0x0000E130 File Offset: 0x0000C330
		// (set) Token: 0x06004CDF RID: 19679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F85")]
		public int EpNotificationCount
		{
			[Token(Token = "0x6004CDE")]
			[Address(RVA = "0x9B1B", Offset = "0x9B1B", VA = "0x9B1B")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004CDF")]
			[Address(RVA = "0x9B1C", Offset = "0x9B1C", VA = "0x9B1C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06004CE0 RID: 19680 RVA: 0x0000E148 File Offset: 0x0000C348
		// (set) Token: 0x06004CE1 RID: 19681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F86")]
		public int LastSelectedTabIndex
		{
			[Token(Token = "0x6004CE0")]
			[Address(RVA = "0x9B1D", Offset = "0x9B1D", VA = "0x9B1D")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004CE1")]
			[Address(RVA = "0x9B1E", Offset = "0x9B1E", VA = "0x9B1E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004CE2 RID: 19682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE2")]
		[Address(RVA = "0x9B1F", Offset = "0x9B1F", VA = "0x9B1F", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Bank_Model_BankModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *param2_00;
		  int iVar3;
		  
		  if (DAT_ram_00a597b6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BankOptionData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Vector2___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_int__Vector2__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankTabData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BankTabData__TypeInfo);
		    DAT_ram_00a597b6 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_BankTabData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_BankTabData___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_int__Vector2__TypeInfo);
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_int__Vector2___ctor__);
		  *(undefined4 *)(param1 + 0x20) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__BankOptionData__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,Method_System_Collections_Generic_Dictionary_uint__BankOptionData___ctor__);
		  *(undefined4 *)(param1 + 0x24) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(int **)(param1 + 0x1c) = param4;
		  iVar3 = *param4;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param2_00 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x268);
		        goto code_r0x8106a96c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param2_00 = (uint *)func_ii_1080(param4,Core_Gameplay_IGame_TypeInfo,0x35);
		code_r0x8106a96c:
		  iVar3 = (**(code **)((ulonglong)*param2_00 * 4))(param4,param2_00[1]);
		  *(undefined4 *)(param1 + 0x18) = *(undefined4 *)(iVar3 + 0x14);
		  Gameplay_Bank_Model_BankModel__ResetScrollPositions(param1,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE3")]
		[Address(RVA = "0x9B20", Offset = "0x9B20", VA = "0x9B20")]
		public BankModel(UserData user, IDictProvider dictProvider, IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_Model_BankModel___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a597b7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Vector2__Clear__);
		    DAT_ram_00a597b7 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x20),
		             Method_System_Collections_Generic_Dictionary_int__Vector2__Clear__);
		  return;
		}
		*/

		}

		// Token: 0x06004CE4 RID: 19684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE4")]
		[Address(RVA = "0x9B21", Offset = "0x9B21", VA = "0x9B21")]
		public void ResetScrollPositions()
		{
		/* --- GHIDRA: ResetScrollPositions ---
		/* WARNING: Removing unreachable block (ram,0x8106afe0) */
		/* WARNING: Removing unreachable block (ram,0x8106ad21) */
		
		void Gameplay_Bank_Model_BankModel__ResetScrollPositions(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 *puVar8;
		  int iVar9;
		  undefined4 param2_00;
		  int *piVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a597b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankTabData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_OptionTypesDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_PaymentTabsDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_OptionTypesDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_PaymentTabsDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_PaymentTabsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_PaymentTabsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankTabData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Bank_Model_BankModel___c__Init_b__33_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Model_BankModel___c__DisplayClass33_0__Init_b__1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankModel___c__DisplayClass33_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankModel___c_TypeInfo);
		    DAT_ram_00a597b8 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  piVar5 = *(int **)(param1 + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x8106aa9d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8106aa9d:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar7 = *(undefined4 *)(iVar6 + 0x1ac);
		  if (*(int *)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Bank_Model_BankModel___c_TypeInfo);
		  }
		  puVar8 = *(undefined4 **)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x5c);
		  iVar6 = puVar8[1];
		  if (iVar6 == 0) {
		    if (*(int *)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Bank_Model_BankModel___c_TypeInfo);
		      puVar8 = *(undefined4 **)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar8;
		    iVar6 = unnamed_function_1417(System_Func_PaymentTabsDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar6,uVar3,Method_Gameplay_Bank_Model_BankModel___c__Init_b__33_0__,0);
		    *(int *)(*(int *)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x5c) + 4) = iVar6;
		  }
		  uVar1 = 0;
		  piVar5 = (int *)System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                            (uVar7,iVar6,
		                             Method_System_Linq_Enumerable_OrderBy_PaymentTabsDic__uint___);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_PaymentTabsDic__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8106abb5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,
		                                System_Collections_Generic_IEnumerable_PaymentTabsDic__TypeInfo,0);
		code_r0x8106abb5:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x8106abf2:
		  do {
		    piVar5 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar8 = (undefined4 *)(iVar6 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x8106ac86;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar8 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8106b0c6:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106b0ce;
		    }
		code_r0x8106ac86:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar8,piVar5,puVar8[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8106b0c6;
		    if (iVar6 == 0) goto code_r0x8106b117;
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Bank_Model_BankModel___c__DisplayClass33_0_TypeInfo);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106b0ce;
		    }
		    iVar4 = *local_4;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_PaymentTabsDic__TypeInfo == *piVar10) {
		          puVar8 = (undefined4 *)(iVar4 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x8106adbc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar8 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_PaymentTabsDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8106b094:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106b0ce;
		    }
		code_r0x8106adbc:
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_iii(*puVar8,piVar5,puVar8[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8106b094;
		    *(undefined4 *)(iVar6 + 8) = uVar7;
		    iVar4 = *(int *)(param1 + 0x10);
		    piVar5 = *(int **)(param1 + 0xc);
		    iVar9 = *piVar5;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (Core_Dict_IDictProvider_TypeInfo == *piVar10) {
		          puVar8 = (undefined4 *)(piVar10[1] * 8 + iVar9 + 0xd0);
		          goto code_r0x8106aea0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar8 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Core_Dict_IDictProvider_TypeInfo,2);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8106b09e:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106b0ce;
		    }
		code_r0x8106aea0:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar8,piVar5,puVar8[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8106b09e;
		    param2_00 = *(undefined4 *)(iVar9 + 0x23c);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Func_OptionTypesDic__bool__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8106b0a8:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106b0ce;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar3,iVar6,
		               Method_Gameplay_Bank_Model_BankModel___c__DisplayClass33_0__Init_b__1__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8106b0a8;
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21c,param2_00,uVar3,
		                       Method_System_Linq_Enumerable_FirstOrDefault_OptionTypesDic___);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106b0ce;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Bank_Model_BankTabData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    *(int *)(iVar6 + 0x10) = iVar9;
		    *(undefined4 *)(iVar6 + 0xc) = uVar7;
		    *(undefined4 *)(iVar6 + 8) = *(undefined4 *)(iVar9 + 0xc);
		    iVar9 = Method_System_Collections_Generic_List_BankTabData__Add__;
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar4 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		      *(uint *)(iVar4 + 0xc) = uVar1 + 1;
		      *(int *)(*(int *)(iVar4 + 8) + uVar1 * 4 + 0x10) = iVar6;
		      goto code_r0x8106abf2;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,iVar6,
		               *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8106b0ce:
		  iVar6 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar7);
		    local_c = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x8106b117:
		      DAT_ram_009d3e38 = 0;
		      piVar5 = *local_8;
		      if (piVar5 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *piVar5;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8106b192;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x8106b192:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      }
		      if (local_c != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_c);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      return;
		    }
		    uVar7 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(0x1f00,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
		    import::env::__resumeException(uVar7);
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

		// Token: 0x06004CE5 RID: 19685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE5")]
		[Address(RVA = "0x9B22", Offset = "0x9B22", VA = "0x9B22")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		undefined4 Gameplay_Bank_Model_BankModel__Init(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a597b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Item__
		              );
		    DAT_ram_00a597b9 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_Int32Enum__uint___Clear
		                    (*(undefined4 *)(param1 + 0x28),param2,
		                     Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = GAFInternal_Reader_GAFReader__OpenTag
		                      (*(undefined4 *)(param1 + 0x28),param2,
		                       Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Item__
		                      );
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06004CE6 RID: 19686 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004CE6")]
		[Address(RVA = "0x9B23", Offset = "0x9B23", VA = "0x9B23")]
		public List<BankOptionData> GetOptionsByType(OptionTypesDic.Types.OptionType optionType)
		{
		/* --- GHIDRA: GetOptionsByType ---
		void Gameplay_Bank_Model_BankModel__GetOptionsByType(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000004;
		  longlong lVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 *puVar5;
		  float param3_00;
		  undefined4 uVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  undefined4 uVar10;
		  undefined4 param2_00;
		  undefined4 uVar11;
		  ulonglong param1_00;
		  int *piVar12;
		  int iVar13;
		  uint uVar14;
		  int local_2c;
		  int **local_28;
		  undefined8 local_24;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a597ba == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Keys__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderByDescending_BankOptionData__int___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderByDescending_BankOptionData__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ThenBy_BankOptionData__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_BankOptionData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_OptionTypesDic_Types_OptionType__List_BankOptionData___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_OptionTypesDic_Types_OptionType__List_BankOptionData___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_BankOptionData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_BankOptionData__int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_OptionRewards__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_OptionRewards__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_OptionTypesDic_Types_OptionType__List_BankOptionData___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Model_BankModel___c__SetOptionRewards_b__35_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Model_BankModel___c__SetOptionRewards_b__35_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_Model_BankModel___c__SetOptionRewards_b__35_2__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankModel___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25864);
		    DAT_ram_00a597ba = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  uVar3 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar3,
		             Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData____ctor__
		            );
		  *(undefined4 *)(param1 + 0x28) = uVar3;
		  uVar3 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar3,
		             Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData____ctor__
		            );
		  iVar13 = *param2;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_OptionRewards__TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8106b49d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_OptionRewards__TypeInfo,0);
		code_r0x8106b49d:
		  lVar2 = CONCAT44(in_register_20000004,param2);
		  local_4 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(lVar2,puVar4[1]);
		  local_2c = 0;
		  local_28 = &local_4;
		code_r0x8106b4e2:
		  do {
		    piVar8 = local_4;
		    uVar1 = (uint)((ulonglong)lVar2 >> 0x20);
		    iVar13 = *local_4;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      uVar14 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		          puVar5 = (undefined4 *)(iVar13 + piVar12[1] * 8 + 0xc0);
		          goto code_r0x8106b57b;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8106bb6c:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106bb7e;
		    }
		code_r0x8106b57b:
		    DAT_ram_009d3e38 = 0;
		    iVar13 = import::env::invoke_iii(*puVar5,piVar8,puVar5[1]);
		    piVar8 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8106bb6c;
		    if (iVar13 == 0) goto code_r0x8106bbc7;
		    iVar13 = *local_4;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      uVar14 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8);
		        if (System_Collections_Generic_IEnumerator_OptionRewards__TypeInfo == *piVar12) {
		          puVar5 = (undefined4 *)(iVar13 + piVar12[1] * 8 + 0xc0);
		          goto code_r0x8106b66c;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_OptionRewards__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8106b774:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106bb7e;
		    }
		code_r0x8106b66c:
		    DAT_ram_009d3e38 = 0;
		    iVar13 = import::env::invoke_iii(*puVar5,piVar8,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8106b774;
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x314,param1,
		                       *(undefined4 *)(iVar13 + 0xc),&local_8,iVar13);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106bb7e;
		    }
		    if (iVar9 != 0) {
		      if (*(int *)(local_8 + 0x3c) != iVar13) {
		        *(int *)(local_8 + 0x3c) = iVar13;
		        iVar7 = *(int *)(local_8 + 8);
		        if (iVar7 != 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (*(undefined4 *)(iVar7 + 0xc),*(undefined4 *)(iVar7 + 0x20),
		                     *(undefined4 *)(iVar7 + 0x14));
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8106bb7e;
		          }
		        }
		      }
		      iVar7 = local_8;
		      *(undefined4 *)(local_8 + 0x40) = *(undefined4 *)(iVar13 + 0x18);
		      uVar14 = *(uint *)(iVar13 + 0x14);
		      if (uVar14 != 0) {
		        if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Utils_TimeUtils_TypeInfo);
		          iVar13 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar13 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8106bb7e;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        param1_00 = (ulonglong)uVar14;
		        param3_00 = unnamed_function_184074(param1_00);
		        iVar13 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        uVar1 = (uint)(param1_00 >> 0x20);
		        if (iVar13 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::invoke_ii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                             Utils_BackTime_TypeInfo);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vifi
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x11e,uVar6,param3_00,0);
		            if (DAT_ram_009d3e38 != 1) goto code_r0x8106b95e;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        goto code_r0x8106bb7e;
		      }
		      uVar6 = 0;
		code_r0x8106b95e:
		      *(undefined4 *)(iVar7 + 0x58) = uVar6;
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x13d,uVar3,
		                         *(undefined4 *)(local_8 + 0x2c),
		                         Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___ContainsKey__
		                        );
		      iVar13 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar13 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8106bb7e;
		      }
		      if (iVar7 == 0) {
		        uVar10 = *(undefined4 *)(local_8 + 0x2c);
		        DAT_ram_009d3e38 = 0;
		        uVar6 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Collections_Generic_List_BankOptionData__TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,uVar6,
		                     Method_System_Collections_Generic_List_BankOptionData___ctor__);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x13e,uVar3,uVar10,uVar6,
		                       Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___set_Item__
		                      );
		            if (DAT_ram_009d3e38 != 1) goto code_r0x8106ba89;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8106bb7e;
		      }
		code_r0x8106ba89:
		      DAT_ram_009d3e38 = 0;
		      lVar2 = (ulonglong)uVar1 << 0x20;
		      iVar9 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,uVar3,
		                         *(undefined4 *)(local_8 + 0x2c),
		                         Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Item__
		                        );
		      iVar7 = DAT_ram_009d3e38;
		      iVar13 = Method_System_Collections_Generic_List_BankOptionData__Add__;
		      DAT_ram_009d3e38 = 0;
		      uVar1 = (uint)((ulonglong)lVar2 >> 0x20);
		      if (iVar7 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8106bb7e;
		      }
		      *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		      uVar14 = *(uint *)(iVar9 + 0xc);
		      if (uVar14 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		        *(uint *)(iVar9 + 0xc) = uVar14 + 1;
		        *(int *)(*(int *)(iVar9 + 8) + uVar14 * 4 + 0x10) = local_8;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        lVar2 = (ulonglong)uVar1 << 0x20;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar9,local_8,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar13 + 0x10) + 0x60) + 0x38));
		        iVar13 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar13 == 1) {
		          uVar1 = (uint)((ulonglong)lVar2 >> 0x20);
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8106bb7e;
		        }
		      }
		      goto code_r0x8106b4e2;
		    }
		    local_1c = *(undefined4 *)(iVar13 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66958,
		                       &local_1c);
		    iVar13 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar13 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106bb7e;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1c0,StringLiteral_25864,
		                       uVar6,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,OKG_Logs_Debug_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    lVar2 = (ulonglong)uVar1 << 0x20;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xc5,uVar6,0);
		    uVar1 = (uint)((ulonglong)lVar2 >> 0x20);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8106bb7e:
		  iVar13 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar13 == iVar7) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar6);
		    local_2c = *piVar8;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar13 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar13 != 1) {
		code_r0x8106bbc7:
		      DAT_ram_009d3e38 = 0;
		      piVar8 = *local_28;
		      if (piVar8 != (int *)0x0) {
		        uVar14 = 0;
		        iVar13 = *piVar8;
		        if (*(ushort *)(iVar13 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		              puVar4 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x8106bc42;
		            }
		            uVar14 = uVar14 + 1;
		          } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar8,System_IDisposable_TypeInfo,0);
		code_r0x8106bc42:
		        (**(code **)((ulonglong)*puVar4 * 4))(CONCAT44(uVar1,piVar8),puVar4[1]);
		      }
		      if (local_2c != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_2c);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar13 = System_Collections_Generic_Dictionary_Int32Enum__uint___Clear
		                         (uVar3,3,
		                          Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___ContainsKey__
		                         );
		      if (iVar13 != 0) {
		        uVar6 = GAFInternal_Reader_GAFReader__OpenTag
		                          (uVar3,3,
		                           Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Item__
		                          );
		        if (*(int *)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Gameplay_Bank_Model_BankModel___c_TypeInfo);
		        }
		        puVar5 = *(undefined4 **)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x5c);
		        iVar13 = puVar5[2];
		        if (iVar13 == 0) {
		          if (*(int *)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Bank_Model_BankModel___c_TypeInfo);
		            puVar5 = *(undefined4 **)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x5c);
		          }
		          uVar10 = *puVar5;
		          iVar13 = unnamed_function_1417(System_Func_BankOptionData__uint__TypeInfo);
		          System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                    (iVar13,uVar10,
		                     Method_Gameplay_Bank_Model_BankModel___c__SetOptionRewards_b__35_0__,0);
		          *(int *)(*(int *)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x5c) + 8) = iVar13;
		        }
		        iVar7 = 0;
		        uVar6 = System_Linq_Enumerable__OrderBy___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                          (uVar6,iVar13,
		                           Method_System_Linq_Enumerable_OrderByDescending_BankOptionData__uint___);
		        iVar13 = System_Linq_Enumerable__Select_object__object_
		                           (uVar6,Method_System_Linq_Enumerable_ToList_BankOptionData___);
		        if (0 < *(int *)(iVar13 + 0xc)) {
		          do {
		            iVar9 = System_Linq_Enumerable__ToList_object_
		                              (iVar13,iVar7,
		                               Method_System_Collections_Generic_List_BankOptionData__get_Item__);
		            if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		              func_ii_306000(System_Math_TypeInfo);
		            }
		            uVar6 = UnityEngine_Mathf__Max(0,3 - iVar7,0);
		            *(undefined4 *)(iVar9 + 100) = uVar6;
		            iVar7 = iVar7 + 1;
		          } while (iVar7 < *(int *)(iVar13 + 0xc));
		        }
		      }
		      uVar6 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                        (uVar3,
		                         Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Keys__
		                        );
		      System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                (&local_2c,uVar6,
		                 Method_System_Collections_Generic_Dictionary_KeyCollection_OptionTypesDic_Types_OptionType__List_BankOptionData___GetEnumerator__
		                );
		      local_10 = local_24;
		      local_18 = CONCAT44(local_28,local_2c);
		      local_2c = 0;
		      local_28 = (int **)&local_18;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x96,&local_18,
		                           Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_OptionTypesDic_Types_OptionType__List_BankOptionData___MoveNext__
		                          );
		        iVar13 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar13 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8106c202;
		        }
		        if (iVar7 == 0) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        param2_00 = *(undefined4 *)(param1 + 0x28);
		        DAT_ram_009d3e38 = 0;
		        uVar6 = local_10._4_4_;
		        uVar10 = import::env::invoke_iiii
		                           (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,uVar3,
		                            local_10._4_4_,
		                            Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Item__
		                           );
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x8106c1fa:
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8106c202;
		        }
		        if (*(int *)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Gameplay_Bank_Model_BankModel___c_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x8106c1fa;
		        }
		        puVar5 = *(undefined4 **)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x5c);
		        iVar13 = puVar5[3];
		        if (iVar13 == 0) {
		          if (*(int *)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       Gameplay_Bank_Model_BankModel___c_TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              puVar5 = *(undefined4 **)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x5c);
		              goto code_r0x8106bf22;
		            }
		code_r0x8106c065:
		            DAT_ram_009d3e38 = 0;
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		code_r0x8106bf22:
		            uVar11 = *puVar5;
		            DAT_ram_009d3e38 = 0;
		            iVar13 = import::env::invoke_ii
		                               (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                System_Func_BankOptionData__int__TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x37b,iVar13,uVar11,
		                         Method_Gameplay_Bank_Model_BankModel___c__SetOptionRewards_b__35_1__,0);
		              if (DAT_ram_009d3e38 != 1) {
		                *(int *)(*(int *)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x5c) + 0xc) = iVar13
		                ;
		                goto code_r0x8106bfa4;
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          goto code_r0x8106c202;
		        }
		code_r0x8106bfa4:
		        DAT_ram_009d3e38 = 0;
		        uVar10 = import::env::invoke_iiii
		                           (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x37c,uVar10,iVar13,
		                            Method_System_Linq_Enumerable_OrderByDescending_BankOptionData__int___);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x8106c079:
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8106c202;
		        }
		        if (*(int *)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Gameplay_Bank_Model_BankModel___c_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x8106c079;
		        }
		        puVar5 = *(undefined4 **)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x5c);
		        iVar13 = puVar5[4];
		        if (iVar13 == 0) {
		          if (*(int *)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       Gameplay_Bank_Model_BankModel___c_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x8106c065;
		            puVar5 = *(undefined4 **)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x5c);
		          }
		          uVar11 = *puVar5;
		          DAT_ram_009d3e38 = 0;
		          iVar13 = import::env::invoke_ii
		                             (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                              System_Func_BankOptionData__uint__TypeInfo);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x76,iVar13,uVar11,
		                       Method_Gameplay_Bank_Model_BankModel___c__SetOptionRewards_b__35_2__,0);
		            if (DAT_ram_009d3e38 != 1) {
		              *(int *)(*(int *)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x5c) + 0x10) = iVar13;
		              goto code_r0x8106c115;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8106c202;
		        }
		code_r0x8106c115:
		        DAT_ram_009d3e38 = 0;
		        uVar10 = import::env::invoke_iiii
		                           (s_struct_Uniforms___color__array<v_ram_00001f04,uVar10,iVar13,
		                            Method_System_Linq_Enumerable_ThenBy_BankOptionData__uint___);
		        iVar13 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar13 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8106c202;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar10 = import::env::invoke_iii
		                           (s_struct_Uniforms___color__array<v_ram_00000aff + 0x229,uVar10,
		                            Method_System_Linq_Enumerable_ToList_BankOptionData___);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x13e,param2_00,uVar6,uVar10,
		                   Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___set_Item__
		                  );
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8106c202:
		      iVar13 = global_1;
		      iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar13 == iVar7) {
		        piVar8 = (int *)import::env::__cxa_begin_catch(uVar6);
		        iVar7 = *piVar8;
		        DAT_ram_009d3e38 = 0;
		        local_2c = iVar7;
		        import::env::invoke_v(0x123);
		        iVar13 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar13 != 1) {
		          if (iVar7 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar6 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 1,&local_2c);
		      goto joined_r0x8106c294;
		    }
		    uVar6 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x37a,&local_2c);
		joined_r0x8106c294:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar6);
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

			return null;
		}

		// Token: 0x06004CE7 RID: 19687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE7")]
		[Address(RVA = "0x9B24", Offset = "0x9B24", VA = "0x9B24")]
		public void SetOptionRewards(IList<OptionRewards> optionRewards)
		{
		/* --- GHIDRA: SetOptionRewards ---
		void Gameplay_Bank_Model_BankModel__SetOptionRewards(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  int *piVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a597bb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PromotionsDic__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PromotionsDic___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_PromotionsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__);
		    DAT_ram_00a597bb = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_PromotionsDic__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_PromotionsDic___ctor__);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (param2,
		                              Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x8106e480:
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x8106e514;
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
		code_r0x8106e7eb:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106e7f3;
		    }
		code_r0x8106e514:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8106e7eb;
		    if (iVar7 == 0) goto code_r0x8106e83c;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x8106e5f1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8106e7cd:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106e7f3;
		    }
		code_r0x8106e5f1:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8106e7cd;
		    iVar7 = *(int *)(param1 + 0x14);
		    piVar5 = *(int **)(param1 + 0xc);
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		        if (Core_Dict_IDictProvider_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(piVar8[1] * 8 + iVar4 + 0xd0);
		          goto code_r0x8106e6ce;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Core_Dict_IDictProvider_TypeInfo,2);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8106e7d7:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106e7f3;
		    }
		code_r0x8106e6ce:
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8106e7d7;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1c2,param2_00,uVar2,0);
		    iVar4 = Method_System_Collections_Generic_List_PromotionsDic__Add__;
		    if (DAT_ram_009d3e38 == 1) break;
		    *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar7 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		      *(uint *)(iVar7 + 0xc) = uVar1 + 1;
		      *(undefined4 *)(*(int *)(iVar7 + 8) + uVar1 * 4 + 0x10) = uVar2;
		      goto code_r0x8106e480;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar7,uVar2,
		               *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8106e7f3:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    local_c = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x8106e83c:
		      DAT_ram_009d3e38 = 0;
		      piVar5 = *local_8;
		      if (piVar5 != (int *)0x0) {
		        uVar1 = 0;
		        iVar7 = *piVar5;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8106e8b7;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x8106e8b7:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_c == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 4,&local_c);
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

		// Token: 0x06004CE8 RID: 19688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE8")]
		[Address(RVA = "0x9B25", Offset = "0x9B25", VA = "0x9B25")]
		public void SetActivePromotions(RepeatedField<uint> promotionsIds)
		{
		/* --- GHIDRA: SetActivePromotions ---
		/* WARNING: Removing unreachable block (ram,0x8106ec36) */
		/* WARNING: Removing unreachable block (ram,0x8106f0a1) */
		
		void Gameplay_Bank_Model_BankModel__SetActivePromotions
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int param1_00;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  uint *puVar7;
		  int iVar8;
		  int *piVar9;
		  int local_1c;
		  int **local_18;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int *local_8;
		  int local_4;
		  
		  if (DAT_ram_00a597bc == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankOptionArtikulContainerData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ProtoGetOptionArtikulsAns_Types_Container__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtikulData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionArtikulContainerData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionArtikulContainerData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtikulData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtikulData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_BankOptionArtikulContainerData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetOptionArtikulsAns_Types_Container__GetEnumerator__
		              );
		    DAT_ram_00a597bc = '\x01';
		  }
		  local_4 = 0;
		  local_8 = (int *)0x0;
		  local_c = (int *)0x0;
		  func_ii_6875(param1,param2,&local_4,param2);
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_BankOptionArtikulContainerData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_BankOptionArtikulContainerData___ctor__);
		  local_8 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param3 + 0xc),
		                              Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                             );
		  local_14 = 0;
		  local_10 = &local_8;
		code_r0x8106ea31:
		  do {
		    piVar5 = local_8;
		    iVar8 = *local_8;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x8106eac5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8106ed30:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106ed38;
		    }
		code_r0x8106eac5:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_8;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8106ed30;
		    if (iVar8 == 0) goto code_r0x8106ed81;
		    iVar8 = *local_8;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x8106eba2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                        System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8106ed08:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106ed38;
		    }
		code_r0x8106eba2:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8106ed08;
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Bank_Model_BankOptionArtikulContainerData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106ed38;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 5,uVar3,
		                       *(undefined4 *)(param1 + 0xc),0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106ed38;
		    }
		    *(undefined4 *)(iVar8 + 8) = uVar3;
		    iVar4 = Method_System_Collections_Generic_List_BankOptionArtikulContainerData__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar1 = *(uint *)(param1_00 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar1 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar1 * 4 + 0x10) = iVar8;
		      goto code_r0x8106ea31;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param1_00,iVar8,
		               *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8106ed38:
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
		code_r0x8106ed81:
		      DAT_ram_009d3e38 = 0;
		      piVar5 = *local_10;
		      if (piVar5 != (int *)0x0) {
		        uVar1 = 0;
		        iVar8 = *piVar5;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar7 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8106edfc;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x8106edfc:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar5,puVar7[1]);
		      }
		      if (local_14 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_14);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      local_c = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                 (*(undefined4 *)(param3 + 0x10),
		                                  Method_Google_Protobuf_Collections_RepeatedField_ProtoGetOptionArtikulsAns_Types_Container__GetEnumerator__
		                                 );
		      local_14 = 0;
		      local_10 = &local_c;
		code_r0x8106ee93:
		      do {
		        piVar5 = local_c;
		        iVar8 = *local_c;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		              puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x8106ef27;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x8106f6dc:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar8 = global_1;
		          goto code_r0x8106f6eb;
		        }
		code_r0x8106ef27:
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        piVar5 = local_c;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x8106f6dc;
		        if (iVar8 == 0) {
		          iVar8 = 10;
		          goto code_r0x8106f736;
		        }
		        iVar8 = *local_c;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_ProtoGetOptionArtikulsAns_Types_Container__TypeInfo
		                == *piVar9) {
		              puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x8106f00d;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_Generic_IEnumerator_ProtoGetOptionArtikulsAns_Types_Container__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x8106f1b1:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar8 = global_1;
		          goto code_r0x8106f6eb;
		        }
		code_r0x8106f00d:
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x8106f1b1;
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           Gameplay_Bank_Model_BankOptionArtikulContainerData_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar8 = global_1;
		          goto code_r0x8106f6eb;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 5,
		                           *(undefined4 *)(iVar8 + 0xc),*(undefined4 *)(param1 + 0xc),0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar8 = global_1;
		          goto code_r0x8106f6eb;
		        }
		        *(undefined4 *)(iVar4 + 8) = uVar3;
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Collections_Generic_List_ArtikulData__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x8106f1cf:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar8 = global_1;
		          goto code_r0x8106f6eb;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,uVar3,
		                   Method_System_Collections_Generic_List_ArtikulData___ctor__);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x8106f1cf;
		        *(undefined4 *)(iVar4 + 0xc) = uVar3;
		        DAT_ram_009d3e38 = 0;
		        piVar5 = (int *)import::env::invoke_iii
		                                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x55,
		                                   *(undefined4 *)(iVar8 + 0x10),
		                                   Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                                  );
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar8 = global_1;
		          goto code_r0x8106f6eb;
		        }
		        local_1c = 0;
		        local_18 = &local_8;
		        local_8 = piVar5;
		code_r0x8106f1e9:
		        do {
		          piVar5 = local_8;
		          iVar8 = *local_8;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		                puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x8106f27d;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                              System_Collections_IEnumerator_TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) break;
		code_r0x8106f27d:
		          DAT_ram_009d3e38 = 0;
		          iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		          piVar5 = local_8;
		          if (DAT_ram_009d3e38 == 1) break;
		          if (iVar8 == 0) {
		            iVar8 = 9;
		            goto code_r0x8106f4c1;
		          }
		          iVar8 = *local_8;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		              if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar9) {
		                puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x8106f357;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                              System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) break;
		code_r0x8106f357:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		          if (DAT_ram_009d3e38 == 1) break;
		          iVar6 = *(int *)(iVar4 + 0xc);
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 5,uVar3,
		                             *(undefined4 *)(param1 + 0xc),0);
		          iVar8 = Method_System_Collections_Generic_List_ArtikulData__Add__;
		          if (DAT_ram_009d3e38 == 1) break;
		          *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		          uVar1 = *(uint *)(iVar6 + 0xc);
		          if (uVar1 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		            *(uint *)(iVar6 + 0xc) = uVar1 + 1;
		            *(undefined4 *)(*(int *)(iVar6 + 8) + uVar1 * 4 + 0x10) = uVar3;
		            goto code_r0x8106f1e9;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar6,uVar3,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		        } while (DAT_ram_009d3e38 != 1);
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar8 = global_1;
		        iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar8 != iVar6) {
		code_r0x8106f69f:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 7,&local_1c);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) goto code_r0x8106f833;
		          goto code_r0x8106f6eb;
		        }
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        local_1c = *piVar5;
		        iVar8 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar8 = global_1;
		          goto code_r0x8106f69f;
		        }
		code_r0x8106f4c1:
		        piVar5 = *local_18;
		        if (piVar5 != (int *)0x0) {
		          iVar6 = *piVar5;
		          if (*(ushort *)(iVar6 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		              if (System_IDisposable_TypeInfo == *piVar9) {
		                puVar2 = (undefined4 *)(iVar6 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x8106f561;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                              System_IDisposable_TypeInfo,0);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x8106f561:
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii(*puVar2,piVar5,puVar2[1]);
		            if (DAT_ram_009d3e38 != 1) goto code_r0x8106f59d;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar8 = global_1;
		          goto code_r0x8106f6eb;
		        }
		code_r0x8106f59d:
		        iVar6 = Method_System_Collections_Generic_List_BankOptionArtikulContainerData__Add__;
		        if (local_1c != 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_1c);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar8 = global_1;
		          goto code_r0x8106f6eb;
		        }
		        if ((iVar8 != 0) &&
		           ((((((iVar8 == 1 || (iVar8 == 2)) || (iVar8 == 3)) || ((iVar8 == 4 || (iVar8 == 5)))) ||
		             ((iVar8 == 6 || ((iVar8 == 7 || (iVar8 == 8)))))) || (iVar8 != 9))))
		        goto code_r0x8106f736;
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar1 = *(uint *)(param1_00 + 0xc);
		        if (uVar1 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar1 + 1;
		          *(int *)(*(int *)(param1_00 + 8) + uVar1 * 4 + 0x10) = iVar4;
		          goto code_r0x8106ee93;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param1_00,iVar4,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar8 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar8 = global_1;
		code_r0x8106f6eb:
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar8) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        local_14 = *piVar5;
		        iVar8 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x8106f736:
		          DAT_ram_009d3e38 = 0;
		          piVar5 = *local_10;
		          if (piVar5 != (int *)0x0) {
		            uVar1 = 0;
		            iVar4 = *piVar5;
		            if (*(ushort *)(iVar4 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		                  puVar7 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x8106f7b1;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		            }
		            puVar7 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x8106f7b1:
		            (**(code **)((ulonglong)*puVar7 * 4))(piVar5,puVar7[1]);
		          }
		          if (local_14 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(local_14);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if ((iVar8 == 0) ||
		             (((((iVar8 != 1 && (iVar8 != 2)) && (iVar8 != 3)) &&
		               (((iVar8 != 4 && (iVar8 != 5)) && ((iVar8 != 6 && ((iVar8 != 7 && (iVar8 != 8))))))))
		              && ((iVar8 != 9 && (iVar8 == 10)))))) {
		            *(int *)(local_4 + 0x60) = param1_00;
		          }
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 8,&local_14);
		      goto joined_r0x8106f80c;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 6,&local_14);
		joined_r0x8106f80c:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x8106f833:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004CE9 RID: 19689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CE9")]
		[Address(RVA = "0x9B26", Offset = "0x9B26", VA = "0x9B26")]
		public void SetOptionArtikuls(uint optionId, ProtoGetOptionArtikulsAns msg)
		{
		/* --- GHIDRA: SetOptionArtikuls ---
		undefined4
		Gameplay_Bank_Model_BankModel__SetOptionArtikuls
		          (undefined4 param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  uVar2 = 0;
		  local_4 = 0;
		  iVar1 = System_UInt32__Parse(param2,&local_4,0);
		  if (iVar1 == 0) {
		    *param3 = 0;
		  }
		  else {
		    uVar2 = func_ii_6875(param1,local_4,param3,auStack_10);
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06004CEA RID: 19690 RVA: 0x0000E160 File Offset: 0x0000C360
		[Token(Token = "0x6004CEA")]
		[Address(RVA = "0x1ADC", Offset = "0x1ADC", VA = "0x1ADC")]
		public bool TryGetOption(uint optionId, out BankOptionData result)
		{
		/* --- GHIDRA: TryGetOption ---
		undefined4
		Gameplay_Bank_Model_BankModel__TryGetOption(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a597be == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a597be = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x8106f9cf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8106f9cf:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__TryGetColossusFragmentsOptionsDic(uVar3,param2,&local_4,0);
		  return uVar3;
		}
		*/

		/* --- GHIDRA: TryGetOption ---
		undefined4
		Gameplay_Bank_Model_BankModel__TryGetOption(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a597be == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a597be = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x8106f9cf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8106f9cf:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__TryGetColossusFragmentsOptionsDic(uVar3,param2,&local_4,0);
		  return uVar3;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004CEB RID: 19691 RVA: 0x0000E178 File Offset: 0x0000C378
		[Token(Token = "0x6004CEB")]
		[Address(RVA = "0x9B27", Offset = "0x9B27", VA = "0x9B27")]
		public bool TryGetOption(string optionIdString, out BankOptionData result)
		{
			return default(bool);
		}

		// Token: 0x06004CEC RID: 19692 RVA: 0x0000E190 File Offset: 0x0000C390
		[Token(Token = "0x6004CEC")]
		[Address(RVA = "0x9B28", Offset = "0x9B28", VA = "0x9B28")]
		public bool IsArtikulOptionActive(uint optionId)
		{
		/* --- GHIDRA: IsArtikulOptionActive ---
		int Gameplay_Bank_Model_BankModel__IsArtikulOptionActive
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a597bf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Values__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_BankOptionData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_OptionTypesDic_Types_OptionType__List_BankOptionData___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_OptionTypesDic_Types_OptionType__List_BankOptionData___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_OptionTypesDic_Types_OptionType__List_BankOptionData___GetEnumerator__
		              );
		    DAT_ram_00a597bf = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x28),
		                     Method_System_Collections_Generic_Dictionary_OptionTypesDic_Types_OptionType__List_BankOptionData___get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_OptionTypesDic_Types_OptionType__List_BankOptionData___GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa1,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_OptionTypesDic_Types_OptionType__List_BankOptionData___MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8106fb3c:
		      iVar1 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar3) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar3 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return 0;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 9,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
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
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return 0;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xf6,local_8._4_4_,param2,
		                       Method_System_Linq_Enumerable_Any_BankOptionData___);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8106fb3c;
		    }
		    if (iVar4 != 0) {
		      DAT_ram_009d3e38 = 0;
		      return iVar3;
		    }
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06004CED RID: 19693 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		[Token(Token = "0x6004CED")]
		[Address(RVA = "0x9B29", Offset = "0x9B29", VA = "0x9B29")]
		public bool AnyBankOption(Func<BankOptionData, bool> predicate)
		{
		/* --- GHIDRA: AnyBankOption ---
		void Gameplay_Bank_Model_BankModel__AnyBankOption(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a597c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankModel___c_TypeInfo);
		    DAT_ram_00a597c0 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Bank_Model_BankModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Bank_Model_BankModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x040029F9 RID: 10745
		[Token(Token = "0x40029F9")]
		[FieldOffset(Offset = "0xC")]
		public readonly IDictProvider DictProvider;

		// Token: 0x040029FE RID: 10750
		[Token(Token = "0x40029FE")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<int, Vector2> _tabScrollPositions;

		// Token: 0x040029FF RID: 10751
		[Token(Token = "0x40029FF")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<uint, BankOptionData> _optionsById;

		// Token: 0x04002A00 RID: 10752
		[Token(Token = "0x4002A00")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<OptionTypesDic.Types.OptionType, List<BankOptionData>> _optionsByType;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_OptionValidator ---
		void Gameplay_Bank_Model_BankModel__get_OptionValidator
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a597b3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Vector2__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Vector2__get_Item__);
		    DAT_ram_00a597b3 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Vector2___Clear
		                    (*(undefined4 *)(param2 + 0x20),*(undefined4 *)(param2 + 0x30),
		                     Method_System_Collections_Generic_Dictionary_int__Vector2__ContainsKey__);
		  if (iVar1 == 0) {
		    if (DAT_ram_00a65d40 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Vector2_TypeInfo);
		      DAT_ram_00a65d40 = '\x01';
		    }
		    *param1 = **(undefined8 **)(UnityEngine_Vector2_TypeInfo + 0x5c);
		  }
		  else {
		    Unity_Hierarchy_HierarchyFlattened__GetEnumerator
		              (&local_8,*(undefined4 *)(param2 + 0x20),*(undefined4 *)(param2 + 0x30),
		               Method_System_Collections_Generic_Dictionary_int__Vector2__get_Item__);
		    *param1 = local_8;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_LastPosition ---
		void Gameplay_Bank_Model_BankModel__get_LastPosition
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a597b4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Vector2__set_Item__);
		    DAT_ram_00a597b4 = '\x01';
		  }
		  local_10 = *param2;
		  local_8 = local_10;
		  System_Collections_Generic_Dictionary_int__Vector2___get_Values
		            (*(undefined4 *)(param1 + 0x20),*(undefined4 *)(param1 + 0x30),&local_10,
		             Method_System_Collections_Generic_Dictionary_int__Vector2__set_Item__);
		  return;
		}
		*/


		/* --- GHIDRA: set_LastSelectedTabIndex ---
		void Gameplay_Bank_Model_BankModel__set_LastSelectedTabIndex(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a597b5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Vector2__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BankOptionData__Clear__);
		    DAT_ram_00a597b5 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x24),
		             Method_System_Collections_Generic_Dictionary_uint__BankOptionData__Clear__);
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x20),
		             Method_System_Collections_Generic_Dictionary_int__Vector2__Clear__);
		  *(undefined4 *)(param1 + 0x28) = 0;
		  *(undefined4 *)(param1 + 0x10) = 0;
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/

}
