using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers.Ad.Providers;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.SpecialOffers.Model
{
	// Token: 0x02000503 RID: 1283
	[Token(Token = "0x2000503")]
	public class OptionsOfferModel : AbstractModel
	{
		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000595")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6001EA0")]
			[Address(RVA = "0x7013", Offset = "0x7013", VA = "0x7013")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001EA2 RID: 7842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000596")]
		public IGame Game
		{
			[Token(Token = "0x6001EA1")]
			[Address(RVA = "0x7014", Offset = "0x7014", VA = "0x7014")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EA2")]
			[Address(RVA = "0x7015", Offset = "0x7015", VA = "0x7015")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000597")]
		public IOptionValidator OptionValidator
		{
			[Token(Token = "0x6001EA3")]
			[Address(RVA = "0x7016", Offset = "0x7016", VA = "0x7016")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000598")]
		public IAdPlacementManagerProvider AdPlacementManagerProvider
		{
			[Token(Token = "0x6001EA4")]
			[Address(RVA = "0x7017", Offset = "0x7017", VA = "0x7017")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001EA6 RID: 7846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000599")]
		public virtual List<BankOptionData> Offers
		{
			[Token(Token = "0x6001EA5")]
			[Address(RVA = "0x7018", Offset = "0x7018", VA = "0x7018", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EA6")]
			[Address(RVA = "0x7019", Offset = "0x7019", VA = "0x7019", Slot = "7")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0x701A", Offset = "0x701A", VA = "0x701A")]
		public OptionsOfferModel(UserData user, IList<uint> optionIds, IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SpecialOffers_Model_OptionsOfferModel___ctor
		               (int *param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  undefined4 *puVar4;
		  int param2_00;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  int local_10;
		  int **local_c;
		  undefined4 local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5862f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_IOptionValidator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BankOptionData__TypeInfo);
		    DAT_ram_00a5862f = '\x01';
		  }
		  local_8 = 0;
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_uint__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f1668b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_uint__TypeInfo,0);
		code_r0x80f1668b:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_BankOptionData__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,uVar3,Method_System_Collections_Generic_List_BankOptionData___ctor__);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		            (param1,param1_00,*(undefined4 *)(*param1 + 0xfc));
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_uint__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f16741;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_uint__TypeInfo,0);
		code_r0x80f16741:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_10 = 0;
		  local_c = &local_4;
		code_r0x80f16766:
		  do {
		    do {
		      do {
		        piVar6 = local_4;
		        iVar7 = *local_4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		              puVar4 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x80f1680c;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f16850:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f16b60;
		        }
		code_r0x80f1680c:
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		        piVar6 = local_4;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f16850;
		        if (iVar7 == 0) goto code_r0x80f16ba9;
		        iVar7 = *local_4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar8) {
		              puVar4 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x80f168f9;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f16974:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f16b60;
		        }
		code_r0x80f168f9:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f16974;
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iiiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x314,param3,uVar3,
		                           &local_8,0);
		        uVar3 = local_8;
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f16b60;
		        }
		      } while (iVar5 == 0);
		      piVar6 = (int *)param1[5];
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (Gameplay_Bank_Model_IOptionValidator_TypeInfo == *piVar8) {
		            puVar4 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		            goto code_r0x80f16a2a;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                          Gameplay_Bank_Model_IOptionValidator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f16b58:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f16b60;
		      }
		code_r0x80f16a2a:
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iiii(*puVar4,piVar6,uVar3,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f16b58;
		    } while (iVar7 == 0);
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0xf0),param1,*(undefined4 *)(*param1 + 0xf4));
		    iVar5 = DAT_ram_009d3e38;
		    iVar7 = Method_System_Collections_Generic_List_BankOptionData__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f16b60;
		    }
		    *(int *)(param2_00 + 0x10) = *(int *)(param2_00 + 0x10) + 1;
		    uVar1 = *(uint *)(param2_00 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(param2_00 + 8) + 0xc)) {
		      *(uint *)(param2_00 + 0xc) = uVar1 + 1;
		      *(undefined4 *)(*(int *)(param2_00 + 8) + uVar1 * 4 + 0x10) = local_8;
		      goto code_r0x80f16766;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param2_00,local_8,
		               *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f16b60:
		  iVar7 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_10 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x80f16ba9:
		      DAT_ram_009d3e38 = 0;
		      piVar6 = *local_c;
		      if (piVar6 != (int *)0x0) {
		        uVar1 = 0;
		        iVar7 = *piVar6;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f16c24;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x80f16c24:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (local_10 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_10);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x18c,&local_10);
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

		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA8")]
		[Address(RVA = "0x701B", Offset = "0x701B", VA = "0x701B", Slot = "8")]
		protected virtual void PopulateOptions(IList<uint> optionIds, BankModel bankModel)
		{
		/* --- GHIDRA: PopulateOptions ---
		void Gameplay_SpecialOffers_Model_OptionsOfferModel__PopulateOptions
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58630 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData__Remove__);
		    DAT_ram_00a58630 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xf4));
		  func_ii_4876(param1_00,param2,Method_System_Collections_Generic_List_BankOptionData__Remove__);
		  return;
		}
		*/

		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA9")]
		[Address(RVA = "0x701C", Offset = "0x701C", VA = "0x701C", Slot = "9")]
		public virtual void RemoveOption(BankOptionData data)
		{
		/* --- GHIDRA: RemoveOption ---
		undefined4
		Gameplay_SpecialOffers_Model_OptionsOfferModel__RemoveOption(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int param1_00;
		  
		  if (DAT_ram_00a58631 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_BankOptionData__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Take_BankOptionData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_BankOptionData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_BankOptionData___);
		    Mono_Security_ASN1__get_Item(&System_Func_BankOptionData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_BankOptionData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SpecialOffers_Model_SpecialOffersModel__get_Offers_b__4_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SpecialOffers_Model_SpecialOffersModel___c__get_Offers_b__4_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo);
		    DAT_ram_00a58631 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Func_BankOptionData__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param1,
		             Method_Gameplay_SpecialOffers_Model_SpecialOffersModel__get_Offers_b__4_0__,0);
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar2,uVar1,Method_System_Linq_Enumerable_Where_BankOptionData___);
		  if (*(int *)(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar3[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo + 0x5c)
		      ;
		    }
		    uVar2 = *puVar3;
		    param1_00 = unnamed_function_1417(System_Func_BankOptionData__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,uVar2,
		               Method_Gameplay_SpecialOffers_Model_SpecialOffersModel___c__get_Offers_b__4_1__,0);
		    *(int *)(*(int *)(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo + 0x5c) + 4) =
		         param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar1,param1_00,Method_System_Linq_Enumerable_OrderBy_BankOptionData__uint___);
		  uVar1 = System_Linq_Enumerable__Sum___Il2CppFullySharedGenericType_
		                    (uVar1,*(undefined4 *)(param1 + 0x28),
		                     Method_System_Linq_Enumerable_Take_BankOptionData___);
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,Method_System_Linq_Enumerable_ToList_BankOptionData___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x040010A3 RID: 4259
		[Token(Token = "0x40010A3")]
		[FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Offers ---
		void Gameplay_SpecialOffers_Model_OptionsOfferModel__set_Offers
		               (int *param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5862e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5862e = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  param1[4] = (int)param4;
		  iVar5 = *param4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 400);
		        goto code_r0x80f15351;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param4,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x80f15351:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param4,puVar2[1]);
		  uVar3 = *(undefined4 *)(iVar5 + 0x2c);
		  uVar1 = 0;
		  piVar4 = (int *)param1[4];
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80f153d5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f153d5:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  param1[3] = iVar5;
		  uVar1 = 0;
		  piVar4 = (int *)param1[4];
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x268);
		        goto code_r0x80f1545d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x35);
		code_r0x80f1545d:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  param1[5] = *(int *)(iVar5 + 0x14);
		  uVar1 = 0;
		  piVar4 = (int *)param1[4];
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x268);
		        goto code_r0x80f154e8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x35);
		code_r0x80f154e8:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  param1[6] = *(int *)(iVar5 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		            (param1,param3,uVar3,*(undefined4 *)(*param1 + 0x104));
		  return;
		}
		*/

}
