using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Discounts.Model;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Dic;
using Protocol.Main;

namespace Gameplay.Aprs.Model
{
	// Token: 0x02000D65 RID: 3429
	[Token(Token = "0x2000D65")]
	public class AprsModel : AbstractModel
	{
		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x0600540F RID: 21519 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005410 RID: 21520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700111A")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x600540F")]
			[Address(RVA = "0xA1C6", Offset = "0xA1C6", VA = "0xA1C6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005410")]
			[Address(RVA = "0xA1C7", Offset = "0xA1C7", VA = "0xA1C7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06005411 RID: 21521 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005412 RID: 21522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700111B")]
		public IGame Game
		{
			[Token(Token = "0x6005411")]
			[Address(RVA = "0xA1C8", Offset = "0xA1C8", VA = "0xA1C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005412")]
			[Address(RVA = "0xA1C9", Offset = "0xA1C9", VA = "0xA1C9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06005413 RID: 21523 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005414 RID: 21524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700111C")]
		public UserData LoggedUser
		{
			[Token(Token = "0x6005413")]
			[Address(RVA = "0xA1CA", Offset = "0xA1CA", VA = "0xA1CA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005414")]
			[Address(RVA = "0xA1CB", Offset = "0xA1CB", VA = "0xA1CB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06005415 RID: 21525 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700111D")]
		public AprDicGroupStorage AprDicGroupStorage
		{
			[Token(Token = "0x6005415")]
			[Address(RVA = "0xA1CC", Offset = "0xA1CC", VA = "0xA1CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06005416 RID: 21526 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005417 RID: 21527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700111E")]
		public Dictionary<uint, AprData> AprDataByMedalId
		{
			[Token(Token = "0x6005416")]
			[Address(RVA = "0xA1CD", Offset = "0xA1CD", VA = "0xA1CD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005417")]
			[Address(RVA = "0xA1CE", Offset = "0xA1CE", VA = "0xA1CE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06005418 RID: 21528 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005419 RID: 21529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700111F")]
		public List<MedalCategoryDic> VisibleCategories
		{
			[Token(Token = "0x6005418")]
			[Address(RVA = "0xA1CF", Offset = "0xA1CF", VA = "0xA1CF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005419")]
			[Address(RVA = "0xA1D0", Offset = "0xA1D0", VA = "0xA1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x0600541A RID: 21530 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600541B RID: 21531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001120")]
		public Dictionary<uint, List<AprData>> VisibleAprs
		{
			[Token(Token = "0x600541A")]
			[Address(RVA = "0xA1D1", Offset = "0xA1D1", VA = "0xA1D1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600541B")]
			[Address(RVA = "0xA1D2", Offset = "0xA1D2", VA = "0xA1D2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x0600541C RID: 21532 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600541D RID: 21533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001121")]
		public List<AprData> AllVisibleAprs
		{
			[Token(Token = "0x600541C")]
			[Address(RVA = "0xA1D3", Offset = "0xA1D3", VA = "0xA1D3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600541D")]
			[Address(RVA = "0xA1D4", Offset = "0xA1D4", VA = "0xA1D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x0600541E RID: 21534 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600541F RID: 21535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001122")]
		[CanBeNull]
		public IDiscountHandler DiscountHandler
		{
			[Token(Token = "0x600541E")]
			[Address(RVA = "0xA1D5", Offset = "0xA1D5", VA = "0xA1D5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600541F")]
			[Address(RVA = "0xA1D6", Offset = "0xA1D6", VA = "0xA1D6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06005420 RID: 21536 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		// (set) Token: 0x06005421 RID: 21537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001123")]
		public int BuyProcessCount
		{
			[Token(Token = "0x6005420")]
			[Address(RVA = "0xA1D7", Offset = "0xA1D7", VA = "0xA1D7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005421")]
			[Address(RVA = "0xA1D8", Offset = "0xA1D8", VA = "0xA1D8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005422")]
		[Address(RVA = "0xA1D9", Offset = "0xA1D9", VA = "0xA1D9", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Aprs_Model_AprsModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x18) = param6;
		  *(undefined4 *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 0xc) = param5;
		  *(undefined4 *)(param1 + 0x10) = param4;
		  return;
		}
		*/

		}

		// Token: 0x06005423 RID: 21539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005423")]
		[Address(RVA = "0xA1DA", Offset = "0xA1DA", VA = "0xA1DA")]
		public AprsModel(UserData user, UserData loggedUser, IGame game, IDictProvider dictProvider, AprDicGroupStorage aprDicGroupStorage)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Aprs_Model_AprsModel___ctor(int param1,int param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59440 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__AprData__GetEnumerator__
		              );
		    DAT_ram_00a59440 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  *param3 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_uint__AprData__get_Values__);
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__AprData__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__AprData__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar1 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar3) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar4;
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
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2aa,&local_18);
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
		  } while ((*(int *)(local_8._4_4_ + 0x1c) == 0) ||
		          (*(int *)(*(int *)(*(int *)(local_8._4_4_ + 0x1c) + 0x10) + 0xc) != param2));
		  *param3 = local_8._4_4_;
		  return iVar3;
		}
		*/

		}

		// Token: 0x06005424 RID: 21540 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		[Token(Token = "0x6005424")]
		[Address(RVA = "0xA1DB", Offset = "0xA1DB", VA = "0xA1DB")]
		public bool TryGetAprDataByAprId(uint aprId, out AprData data)
		{
		/* --- GHIDRA: TryGetAprDataByAprId ---
		void Gameplay_Aprs_Model_AprsModel__TryGetAprDataByAprId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  uint *puVar9;
		  int iVar10;
		  undefined4 *puVar11;
		  undefined4 uVar12;
		  undefined4 param3_00;
		  int *piVar13;
		  int local_54;
		  int **local_50;
		  int local_4c;
		  int **ppiStack_48;
		  undefined8 local_44;
		  int *local_3c;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  int *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59442 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprData___ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprData____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprData___set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__List_AprData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__AprData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_AprData__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_MedalCategoryDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_AprData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_MedalCategoryDic___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AprData___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalCategoryDic__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AprDicGroup__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AprData___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AprDicGroup__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalCategoryDic__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AprDicGroup__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AprData___get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalCategoryDic__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_Func_MedalCategoryDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_AprData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MedalInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_AprData___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalCategoryDic__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalCategoryDic__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AprDicGroup__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalCategoryDic___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AprData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MedalCategoryDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_Model_AprsModel___c__SetMedals_b__43_0__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_Model_AprsModel___c__SetMedals_b__43_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Model_AprsModel___c_TypeInfo);
		    DAT_ram_00a59442 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0;
		  local_38 = 0;
		  local_3c = (int *)0x0;
		  uVar3 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__List_AprData___TypeInfo)
		  ;
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar3,Method_System_Collections_Generic_Dictionary_uint__List_AprData____ctor__);
		  uVar4 = unnamed_function_1417(System_Collections_Generic_List_MedalCategoryDic__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar4,Method_System_Collections_Generic_List_MedalCategoryDic___ctor__);
		  *(undefined4 *)(param1 + 0x20) = uVar4;
		  uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__List_AprData___TypeInfo)
		  ;
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar4,Method_System_Collections_Generic_Dictionary_uint__List_AprData____ctor__);
		  *(undefined4 *)(param1 + 0x24) = uVar4;
		  uVar4 = unnamed_function_1417(System_Collections_Generic_List_AprData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar4,Method_System_Collections_Generic_List_AprData___ctor__);
		  *(undefined4 *)(param1 + 0x28) = uVar4;
		  uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__AprData__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar4,Method_System_Collections_Generic_Dictionary_uint__AprData___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar4;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_4c,*(undefined4 *)(*(int *)(param1 + 0x18) + 0xc),
		             Method_System_Collections_Generic_List_AprDicGroup__GetEnumerator__);
		  local_8 = local_44;
		  local_4c = 0;
		  ppiStack_48 = (int **)&local_10;
		code_r0x8100419e:
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_AprDicGroup__MoveNext__);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x81004961;
		      }
		      if (iVar5 == 0) {
		        iVar5 = 8;
		        iVar10 = local_4c;
		        goto code_r0x810049ac;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar7 = local_8._4_4_;
		      uVar8 = import::env::invoke_iiiiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2b7,local_8._4_4_,
		                         *(undefined4 *)(param1 + 8),*(undefined4 *)(param1 + 0x14),
		                         *(undefined4 *)(param1 + 0xc),*(undefined4 *)(param1 + 0xc));
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x81004961;
		      }
		      DAT_ram_009d3e38 = 0;
		      piVar6 = (int *)import::env::invoke_iii
		                                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x71,
		                                 *(undefined4 *)(iVar7 + 8),
		                                 Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__
		                                );
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x81004961;
		      }
		      iVar10 = *piVar6;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		          if (System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo == *piVar13) {
		            puVar11 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		            goto code_r0x81004303;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar11 = (undefined4 *)
		                import::env::invoke_iiii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                           System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81004370:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x81004961;
		      }
		code_r0x81004303:
		      DAT_ram_009d3e38 = 0;
		      piVar6 = (int *)import::env::invoke_iii(*puVar11,piVar6,puVar11[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81004370;
		      local_54 = 0;
		      local_50 = &local_14;
		      local_14 = piVar6;
		      do {
		        piVar6 = local_14;
		        iVar10 = *local_14;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		              puVar11 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x8100441f;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar11 = (undefined4 *)
		                  import::env::invoke_iiii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                             System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) break;
		code_r0x8100441f:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar11,piVar6,puVar11[1]);
		        piVar6 = local_14;
		        if (DAT_ram_009d3e38 == 1) break;
		        if (iVar10 == 0) {
		          iVar5 = 6;
		          goto code_r0x810045e4;
		        }
		        iVar10 = *local_14;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo == *piVar13) {
		              puVar11 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x810044f9;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar11 = (undefined4 *)
		                  import::env::invoke_iiii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                             System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) break;
		code_r0x810044f9:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar11,piVar6,puVar11[1]);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,
		                   *(undefined4 *)(param1 + 0x1c),*(undefined4 *)(*(int *)(iVar10 + 0x10) + 0xc),
		                   uVar8,Method_System_Collections_Generic_Dictionary_uint__AprData__set_Item__);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar10 != iVar5) {
		code_r0x81004726:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2b8,&local_54);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 != 1) goto code_r0x81004961;
		        goto code_r0x81005720;
		      }
		      piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		      local_54 = *piVar6;
		      iVar5 = 0;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_v(0x123);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x81004726;
		      }
		code_r0x810045e4:
		      piVar6 = *local_50;
		      if (piVar6 != (int *)0x0) {
		        iVar10 = *piVar6;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (System_IDisposable_TypeInfo == *piVar13) {
		              puVar11 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x81004684;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar11 = (undefined4 *)
		                  import::env::invoke_iiii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                             System_IDisposable_TypeInfo,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x81004684:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii(*puVar11,piVar6,puVar11[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x810046c0;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x81004961;
		      }
		code_r0x810046c0:
		      if (local_54 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_54);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x81004961;
		      }
		      if ((iVar5 != 0) &&
		         ((((iVar10 = local_4c, iVar5 == 1 || (iVar5 == 2)) || (iVar5 == 3)) ||
		          (((iVar5 == 4 || (iVar5 == 5)) || (iVar5 != 6)))))) goto code_r0x810049ac;
		    } while (*(char *)(iVar7 + 0x18) == '\0');
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,uVar3,
		                       *(undefined4 *)(*(int *)(iVar7 + 0x10) + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__List_AprData___ContainsKey__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x81004961;
		    }
		    if (iVar5 == 0) {
		      uVar12 = *(undefined4 *)(*(int *)(iVar7 + 0x10) + 0xc);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Collections_Generic_List_AprData__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,uVar4,
		                   Method_System_Collections_Generic_List_AprData___ctor__);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar3,uVar12,uVar4,
		                     Method_System_Collections_Generic_Dictionary_uint__List_AprData___set_Item__);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x81004853;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x81004961;
		    }
		code_r0x81004853:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar3,
		                       *(undefined4 *)(*(int *)(iVar7 + 0x10) + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Item__)
		    ;
		    iVar5 = DAT_ram_009d3e38;
		    iVar10 = Method_System_Collections_Generic_List_AprData__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x81004961;
		    }
		    *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		    uVar2 = *(uint *)(iVar7 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		      *(uint *)(iVar7 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(iVar7 + 8) + uVar2 * 4 + 0x10) = uVar8;
		      goto code_r0x8100419e;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar7,uVar8,
		               *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar10 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar10 = global_1;
		code_r0x81004961:
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar10) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar10 = *piVar6;
		    iVar5 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_4c = iVar10;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x810049ac:
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar5 != 0) &&
		         (((iVar5 == 1 || (iVar5 == 2)) ||
		          ((iVar5 == 3 ||
		           ((((iVar5 == 4 || (iVar5 == 5)) || (iVar5 == 6)) || ((iVar5 == 7 || (iVar5 != 8))))))))))
		      {
		        return;
		      }
		      iVar10 = unnamed_function_1417(System_Collections_Generic_List_MedalCategoryDic__TypeInfo);
		      GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                (iVar10,Method_System_Collections_Generic_List_MedalCategoryDic___ctor__);
		      uVar4 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                        (uVar3,
		                         Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Keys__
		                        );
		      System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                (&local_4c,uVar4,
		                 Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_AprData___GetEnumerator__
		                );
		      local_20 = local_44;
		      local_28 = CONCAT44(ppiStack_48,local_4c);
		      local_4c = 0;
		      ppiStack_48 = (int **)&local_28;
		code_r0x81004a7d:
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ad,&local_28,
		                           Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AprData___MoveNext__
		                          );
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81004c83;
		        }
		        if (iVar7 == 0) {
		          iVar7 = 0xb;
		          iVar5 = local_4c;
		          goto code_r0x81004cd0;
		        }
		        uVar4 = local_20._4_4_;
		        piVar6 = *(int **)(param1 + 0xc);
		        iVar5 = *piVar6;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar13) {
		              puVar11 = (undefined4 *)(piVar13[1] * 8 + iVar5 + 0xd0);
		              goto code_r0x81004b5a;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar11 = (undefined4 *)
		                  import::env::invoke_iiii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                             Core_Dict_IDictProvider_TypeInfo,2);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81004c5d:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81004c83;
		        }
		code_r0x81004b5a:
		        DAT_ram_009d3e38 = 0;
		        uVar8 = import::env::invoke_iii(*puVar11,piVar6,puVar11[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81004c5d;
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x69,uVar8,uVar4,0);
		        iVar7 = DAT_ram_009d3e38;
		        iVar5 = Method_System_Collections_Generic_List_MedalCategoryDic__Add__;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81004c83;
		        }
		        *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		        uVar2 = *(uint *)(iVar10 + 0xc);
		        if (uVar2 < *(uint *)(*(int *)(iVar10 + 8) + 0xc)) {
		          *(uint *)(iVar10 + 0xc) = uVar2 + 1;
		          *(undefined4 *)(*(int *)(iVar10 + 8) + uVar2 * 4 + 0x10) = uVar4;
		          goto code_r0x81004a7d;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar10,uVar4,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar5 != 1);
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81004c83:
		      iVar5 = global_1;
		      iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar5 == iVar7) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar5 = *piVar6;
		        iVar7 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_4c = iVar5;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		code_r0x81004cd0:
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar7 != 0) {
		            if (iVar7 == 1) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 2) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 3) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 4) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 5) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 6) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 7) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 8) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 9) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 10) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 != 0xb) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		          }
		          if (*(int *)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Aprs_Model_AprsModel___c_TypeInfo);
		          }
		          puVar11 = *(undefined4 **)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x5c);
		          iVar5 = puVar11[1];
		          if (iVar5 == 0) {
		            if (*(int *)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Gameplay_Aprs_Model_AprsModel___c_TypeInfo);
		              puVar11 = *(undefined4 **)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x5c);
		            }
		            uVar4 = *puVar11;
		            iVar5 = unnamed_function_1417(System_Func_MedalCategoryDic__uint__TypeInfo);
		            System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                      (iVar5,uVar4,Method_Gameplay_Aprs_Model_AprsModel___c__SetMedals_b__43_0__,0);
		            *(int *)(*(int *)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x5c) + 4) = iVar5;
		          }
		          uVar4 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                            (iVar10,iVar5,
		                             Method_System_Linq_Enumerable_OrderBy_MedalCategoryDic__uint___);
		          uVar4 = System_Linq_Enumerable__Select_object__object_
		                            (uVar4,Method_System_Linq_Enumerable_ToList_MedalCategoryDic___);
		          *(undefined4 *)(param1 + 0x20) = uVar4;
		          uVar4 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                            (uVar3,
		                             Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Keys__
		                            );
		          System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                    (&local_4c,uVar4,
		                     Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_AprData___GetEnumerator__
		                    );
		          local_20 = local_44;
		          local_28 = CONCAT44(ppiStack_48,local_4c);
		          local_4c = 0;
		          ppiStack_48 = (int **)&local_28;
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar5 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ad,&local_28,
		                               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AprData___MoveNext__
		                              );
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x810050bc;
		            }
		            if (iVar5 == 0) goto code_r0x81005112;
		            uVar12 = *(undefined4 *)(param1 + 0x24);
		            DAT_ram_009d3e38 = 0;
		            uVar4 = local_20._4_4_;
		            uVar8 = import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar3,
		                               local_20._4_4_,
		                               Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Item__
		                              );
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x810050b4:
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x810050bc;
		            }
		            if (*(int *)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                         Gameplay_Aprs_Model_AprsModel___c_TypeInfo);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x810050b4;
		            }
		            puVar11 = *(undefined4 **)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x5c);
		            iVar10 = puVar11[2];
		            if (iVar10 == 0) {
		              if (*(int *)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x74) == 0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                           Gameplay_Aprs_Model_AprsModel___c_TypeInfo);
		                iVar10 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar10 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x810050bc;
		                }
		                puVar11 = *(undefined4 **)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x5c);
		              }
		              param3_00 = *puVar11;
		              DAT_ram_009d3e38 = 0;
		              iVar10 = import::env::invoke_ii
		                                 (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                  System_Func_AprData__uint__TypeInfo);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x76,iVar10,param3_00,
		                           Method_Gameplay_Aprs_Model_AprsModel___c__SetMedals_b__43_1__,0);
		                if (DAT_ram_009d3e38 != 1) {
		                  *(int *)(*(int *)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x5c) + 8) = iVar10
		                  ;
		                  goto code_r0x81004fbe;
		                }
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x810050bc;
		            }
		code_r0x81004fbe:
		            DAT_ram_009d3e38 = 0;
		            uVar8 = import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x77,uVar8,iVar10,
		                               Method_System_Linq_Enumerable_OrderBy_AprData__uint___);
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x810050bc;
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar8 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x229,uVar8,
		                               Method_System_Linq_Enumerable_ToList_AprData___);
		            if (DAT_ram_009d3e38 == 1) break;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar12,uVar4,uVar8,
		                       Method_System_Collections_Generic_Dictionary_uint__List_AprData___set_Item__)
		            ;
		          } while (DAT_ram_009d3e38 != 1);
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810050bc:
		          iVar10 = global_1;
		          iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar10 == iVar5) {
		            piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		            iVar5 = *piVar6;
		            DAT_ram_009d3e38 = 0;
		            local_4c = iVar5;
		            import::env::invoke_v(0x123);
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 != 1) {
		              if (iVar5 != 0) {
		                System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		                do {
		                  halt_trap();
		                } while( true );
		              }
		code_r0x81005112:
		              DAT_ram_009d3e38 = 0;
		              System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                        (&local_4c,*(undefined4 *)(param1 + 0x20),
		                         Method_System_Collections_Generic_List_MedalCategoryDic__GetEnumerator__);
		              local_30 = local_44;
		              local_38 = CONCAT44(ppiStack_48,local_4c);
		              local_4c = 0;
		              ppiStack_48 = (int **)&local_38;
		              do {
		                DAT_ram_009d3e38 = 0;
		                iVar5 = import::env::invoke_iii
		                                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_38,
		                                   Method_System_Collections_Generic_List_Enumerator_MedalCategoryDic__MoveNext__
		                                  );
		                iVar10 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar10 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x81005276;
		                }
		                if (iVar5 == 0) goto code_r0x810052cc;
		                uVar4 = *(undefined4 *)(param1 + 0x28);
		                DAT_ram_009d3e38 = 0;
		                uVar3 = import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                                   *(undefined4 *)(param1 + 0x24),
		                                   *(undefined4 *)(local_30._4_4_ + 0xc),
		                                   Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Item__
		                                  );
		                if (DAT_ram_009d3e38 == 1) break;
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xf8,uVar4,uVar3,
		                           Method_System_Collections_Generic_List_AprData__AddRange__);
		              } while (DAT_ram_009d3e38 != 1);
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81005276:
		              iVar10 = global_1;
		              iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		              if (iVar10 == iVar5) {
		                piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		                iVar5 = *piVar6;
		                DAT_ram_009d3e38 = 0;
		                local_4c = iVar5;
		                import::env::invoke_v(0x123);
		                iVar10 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar10 != 1) {
		                  if (iVar5 != 0) {
		                    System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		                    do {
		                      halt_trap();
		                    } while( true );
		                  }
		code_r0x810052cc:
		                  DAT_ram_009d3e38 = 0;
		                  local_3c = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                              (param2,
		                                               Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__GetEnumerator__
		                                              );
		                  local_4c = 0;
		                  ppiStack_48 = &local_3c;
		                  do {
		                    do {
		                      piVar6 = local_3c;
		                      iVar10 = *local_3c;
		                      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		                        uVar2 = 0;
		                        do {
		                          piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		                          if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		                            puVar11 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		                            goto code_r0x81005396;
		                          }
		                          uVar2 = uVar2 + 1;
		                        } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		                      }
		                      DAT_ram_009d3e38 = 0;
		                      puVar11 = (undefined4 *)
		                                import::env::invoke_iiii
		                                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                           local_3c,System_Collections_IEnumerator_TypeInfo,0);
		                      if (DAT_ram_009d3e38 == 1) {
		code_r0x810053da:
		                        DAT_ram_009d3e38 = 0;
		                        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        goto code_r0x810055b7;
		                      }
		code_r0x81005396:
		                      DAT_ram_009d3e38 = 0;
		                      iVar10 = import::env::invoke_iii(*puVar11,piVar6,puVar11[1]);
		                      piVar6 = local_3c;
		                      if (DAT_ram_009d3e38 == 1) goto code_r0x810053da;
		                      if (iVar10 == 0) goto code_r0x81005600;
		                      iVar10 = *local_3c;
		                      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		                        uVar2 = 0;
		                        do {
		                          piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		                          if (System_Collections_Generic_IEnumerator_MedalInfo__TypeInfo == *piVar13
		                             ) {
		                            puVar11 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		                            goto code_r0x8100547f;
		                          }
		                          uVar2 = uVar2 + 1;
		                        } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		                      }
		                      DAT_ram_009d3e38 = 0;
		                      puVar11 = (undefined4 *)
		                                import::env::invoke_iiii
		                                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                           local_3c,
		                                           System_Collections_Generic_IEnumerator_MedalInfo__TypeInfo
		                                           ,0);
		                      if (DAT_ram_009d3e38 == 1) {
		code_r0x81005591:
		                        DAT_ram_009d3e38 = 0;
		                        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        goto code_r0x810055b7;
		                      }
		code_r0x8100547f:
		                      DAT_ram_009d3e38 = 0;
		                      iVar10 = import::env::invoke_iii(*puVar11,piVar6,puVar11[1]);
		                      if (DAT_ram_009d3e38 == 1) goto code_r0x81005591;
		                      DAT_ram_009d3e38 = 0;
		                      iVar7 = import::env::invoke_iiii
		                                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,
		                                         *(undefined4 *)(param1 + 0x1c),
		                                         *(undefined4 *)(iVar10 + 0xc),
		                                         Method_System_Collections_Generic_Dictionary_uint__AprData__ContainsKey__
		                                        );
		                      iVar5 = DAT_ram_009d3e38;
		                      DAT_ram_009d3e38 = 0;
		                      if (iVar5 == 1) {
		                        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        goto code_r0x810055b7;
		                      }
		                    } while (iVar7 == 0);
		                    DAT_ram_009d3e38 = 0;
		                    uVar3 = import::env::invoke_iiii
		                                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                                       *(undefined4 *)(param1 + 0x1c),*(undefined4 *)(iVar10 + 0xc),
		                                       Method_System_Collections_Generic_Dictionary_uint__AprData__get_Item__
		                                      );
		                    iVar5 = DAT_ram_009d3e38;
		                    DAT_ram_009d3e38 = 0;
		                    if (iVar5 == 1) {
		                      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                      goto code_r0x810055b7;
		                    }
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_viiii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 700,uVar3,iVar10,
		                               *(undefined4 *)(param1 + 0xc),iVar10);
		                    iVar10 = DAT_ram_009d3e38;
		                    DAT_ram_009d3e38 = 0;
		                  } while (iVar10 != 1);
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810055b7:
		                  iVar10 = global_1;
		                  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		                  if (iVar10 == iVar5) {
		                    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		                    local_4c = *piVar6;
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_v(0x123);
		                    iVar10 = DAT_ram_009d3e38;
		                    DAT_ram_009d3e38 = 0;
		                    if (iVar10 != 1) {
		code_r0x81005600:
		                      DAT_ram_009d3e38 = 0;
		                      piVar6 = *ppiStack_48;
		                      if (piVar6 != (int *)0x0) {
		                        uVar2 = 0;
		                        iVar10 = *piVar6;
		                        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		                          do {
		                            if (System_IDisposable_TypeInfo ==
		                                *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		                              puVar9 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) +
		                                                                  uVar2 * 8 + 4) * 8 + 0xc0);
		                              goto code_r0x8100567b;
		                            }
		                            uVar2 = uVar2 + 1;
		                          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		                        }
		                        puVar9 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x8100567b:
		                        (**(code **)((ulonglong)*puVar9 * 4))(piVar6,puVar9[1]);
		                      }
		                      if (local_4c == 0) {
		                        return;
		                      }
		                      System_Data_DataSet__ValidateLocaleConstraint(local_4c);
		                      do {
		                        halt_trap();
		                      } while( true );
		                    }
		                    uVar4 = import::env::__cxa_find_matching_catch_2();
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_ii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2bd,&local_4c);
		                  goto joined_r0x810056d0;
		                }
		                uVar4 = import::env::__cxa_find_matching_catch_2();
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_ii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2be,&local_4c);
		              goto joined_r0x810056d0;
		            }
		            uVar4 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 699,&local_4c);
		          goto joined_r0x810056d0;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2ba,&local_4c);
		      goto joined_r0x810056d0;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2b9,&local_4c);
		joined_r0x810056d0:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x81005720:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: TryGetAprDataByAprId ---
		void Gameplay_Aprs_Model_AprsModel__TryGetAprDataByAprId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  uint *puVar9;
		  int iVar10;
		  undefined4 *puVar11;
		  undefined4 uVar12;
		  undefined4 param3_00;
		  int *piVar13;
		  int local_54;
		  int **local_50;
		  int local_4c;
		  int **ppiStack_48;
		  undefined8 local_44;
		  int *local_3c;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  int *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59442 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprData___ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprData____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_AprData___set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprData__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__List_AprData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__AprData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_AprData__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_MedalCategoryDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_AprData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_MedalCategoryDic___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AprData___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalCategoryDic__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AprDicGroup__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AprData___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AprDicGroup__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalCategoryDic__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AprDicGroup__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AprData___get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalCategoryDic__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_Func_MedalCategoryDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_AprData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MedalInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_AprData___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalCategoryDic__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalCategoryDic__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AprDicGroup__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalCategoryDic___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AprData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MedalCategoryDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_Model_AprsModel___c__SetMedals_b__43_0__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Aprs_Model_AprsModel___c__SetMedals_b__43_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Model_AprsModel___c_TypeInfo);
		    DAT_ram_00a59442 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0;
		  local_38 = 0;
		  local_3c = (int *)0x0;
		  uVar3 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__List_AprData___TypeInfo)
		  ;
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar3,Method_System_Collections_Generic_Dictionary_uint__List_AprData____ctor__);
		  uVar4 = unnamed_function_1417(System_Collections_Generic_List_MedalCategoryDic__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar4,Method_System_Collections_Generic_List_MedalCategoryDic___ctor__);
		  *(undefined4 *)(param1 + 0x20) = uVar4;
		  uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__List_AprData___TypeInfo)
		  ;
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar4,Method_System_Collections_Generic_Dictionary_uint__List_AprData____ctor__);
		  *(undefined4 *)(param1 + 0x24) = uVar4;
		  uVar4 = unnamed_function_1417(System_Collections_Generic_List_AprData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar4,Method_System_Collections_Generic_List_AprData___ctor__);
		  *(undefined4 *)(param1 + 0x28) = uVar4;
		  uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__AprData__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar4,Method_System_Collections_Generic_Dictionary_uint__AprData___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar4;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_4c,*(undefined4 *)(*(int *)(param1 + 0x18) + 0xc),
		             Method_System_Collections_Generic_List_AprDicGroup__GetEnumerator__);
		  local_8 = local_44;
		  local_4c = 0;
		  ppiStack_48 = (int **)&local_10;
		code_r0x8100419e:
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_AprDicGroup__MoveNext__);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x81004961;
		      }
		      if (iVar5 == 0) {
		        iVar5 = 8;
		        iVar10 = local_4c;
		        goto code_r0x810049ac;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar7 = local_8._4_4_;
		      uVar8 = import::env::invoke_iiiiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2b7,local_8._4_4_,
		                         *(undefined4 *)(param1 + 8),*(undefined4 *)(param1 + 0x14),
		                         *(undefined4 *)(param1 + 0xc),*(undefined4 *)(param1 + 0xc));
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x81004961;
		      }
		      DAT_ram_009d3e38 = 0;
		      piVar6 = (int *)import::env::invoke_iii
		                                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x71,
		                                 *(undefined4 *)(iVar7 + 8),
		                                 Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Values__
		                                );
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x81004961;
		      }
		      iVar10 = *piVar6;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		          if (System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo == *piVar13) {
		            puVar11 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		            goto code_r0x81004303;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar11 = (undefined4 *)
		                import::env::invoke_iiii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                           System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81004370:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x81004961;
		      }
		code_r0x81004303:
		      DAT_ram_009d3e38 = 0;
		      piVar6 = (int *)import::env::invoke_iii(*puVar11,piVar6,puVar11[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81004370;
		      local_54 = 0;
		      local_50 = &local_14;
		      local_14 = piVar6;
		      do {
		        piVar6 = local_14;
		        iVar10 = *local_14;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		              puVar11 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x8100441f;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar11 = (undefined4 *)
		                  import::env::invoke_iiii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                             System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) break;
		code_r0x8100441f:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar11,piVar6,puVar11[1]);
		        piVar6 = local_14;
		        if (DAT_ram_009d3e38 == 1) break;
		        if (iVar10 == 0) {
		          iVar5 = 6;
		          goto code_r0x810045e4;
		        }
		        iVar10 = *local_14;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo == *piVar13) {
		              puVar11 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x810044f9;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar11 = (undefined4 *)
		                  import::env::invoke_iiii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                             System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) break;
		code_r0x810044f9:
		        DAT_ram_009d3e38 = 0;
		        iVar10 = import::env::invoke_iii(*puVar11,piVar6,puVar11[1]);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,
		                   *(undefined4 *)(param1 + 0x1c),*(undefined4 *)(*(int *)(iVar10 + 0x10) + 0xc),
		                   uVar8,Method_System_Collections_Generic_Dictionary_uint__AprData__set_Item__);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar10 != iVar5) {
		code_r0x81004726:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2b8,&local_54);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 != 1) goto code_r0x81004961;
		        goto code_r0x81005720;
		      }
		      piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		      local_54 = *piVar6;
		      iVar5 = 0;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_v(0x123);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x81004726;
		      }
		code_r0x810045e4:
		      piVar6 = *local_50;
		      if (piVar6 != (int *)0x0) {
		        iVar10 = *piVar6;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (System_IDisposable_TypeInfo == *piVar13) {
		              puVar11 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x81004684;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar11 = (undefined4 *)
		                  import::env::invoke_iiii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                             System_IDisposable_TypeInfo,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x81004684:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii(*puVar11,piVar6,puVar11[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x810046c0;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x81004961;
		      }
		code_r0x810046c0:
		      if (local_54 != 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_54);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar10 = global_1;
		        goto code_r0x81004961;
		      }
		      if ((iVar5 != 0) &&
		         ((((iVar10 = local_4c, iVar5 == 1 || (iVar5 == 2)) || (iVar5 == 3)) ||
		          (((iVar5 == 4 || (iVar5 == 5)) || (iVar5 != 6)))))) goto code_r0x810049ac;
		    } while (*(char *)(iVar7 + 0x18) == '\0');
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,uVar3,
		                       *(undefined4 *)(*(int *)(iVar7 + 0x10) + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__List_AprData___ContainsKey__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x81004961;
		    }
		    if (iVar5 == 0) {
		      uVar12 = *(undefined4 *)(*(int *)(iVar7 + 0x10) + 0xc);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Collections_Generic_List_AprData__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,uVar4,
		                   Method_System_Collections_Generic_List_AprData___ctor__);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar3,uVar12,uVar4,
		                     Method_System_Collections_Generic_Dictionary_uint__List_AprData___set_Item__);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x81004853;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x81004961;
		    }
		code_r0x81004853:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar3,
		                       *(undefined4 *)(*(int *)(iVar7 + 0x10) + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Item__)
		    ;
		    iVar5 = DAT_ram_009d3e38;
		    iVar10 = Method_System_Collections_Generic_List_AprData__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x81004961;
		    }
		    *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		    uVar2 = *(uint *)(iVar7 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		      *(uint *)(iVar7 + 0xc) = uVar2 + 1;
		      *(undefined4 *)(*(int *)(iVar7 + 8) + uVar2 * 4 + 0x10) = uVar8;
		      goto code_r0x8100419e;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar7,uVar8,
		               *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar10 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar10 = global_1;
		code_r0x81004961:
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar10) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar10 = *piVar6;
		    iVar5 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_4c = iVar10;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x810049ac:
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar5 != 0) &&
		         (((iVar5 == 1 || (iVar5 == 2)) ||
		          ((iVar5 == 3 ||
		           ((((iVar5 == 4 || (iVar5 == 5)) || (iVar5 == 6)) || ((iVar5 == 7 || (iVar5 != 8))))))))))
		      {
		        return;
		      }
		      iVar10 = unnamed_function_1417(System_Collections_Generic_List_MedalCategoryDic__TypeInfo);
		      GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                (iVar10,Method_System_Collections_Generic_List_MedalCategoryDic___ctor__);
		      uVar4 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                        (uVar3,
		                         Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Keys__
		                        );
		      System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                (&local_4c,uVar4,
		                 Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_AprData___GetEnumerator__
		                );
		      local_20 = local_44;
		      local_28 = CONCAT44(ppiStack_48,local_4c);
		      local_4c = 0;
		      ppiStack_48 = (int **)&local_28;
		code_r0x81004a7d:
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ad,&local_28,
		                           Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AprData___MoveNext__
		                          );
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81004c83;
		        }
		        if (iVar7 == 0) {
		          iVar7 = 0xb;
		          iVar5 = local_4c;
		          goto code_r0x81004cd0;
		        }
		        uVar4 = local_20._4_4_;
		        piVar6 = *(int **)(param1 + 0xc);
		        iVar5 = *piVar6;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar13) {
		              puVar11 = (undefined4 *)(piVar13[1] * 8 + iVar5 + 0xd0);
		              goto code_r0x81004b5a;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar11 = (undefined4 *)
		                  import::env::invoke_iiii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                             Core_Dict_IDictProvider_TypeInfo,2);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81004c5d:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81004c83;
		        }
		code_r0x81004b5a:
		        DAT_ram_009d3e38 = 0;
		        uVar8 = import::env::invoke_iii(*puVar11,piVar6,puVar11[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81004c5d;
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x69,uVar8,uVar4,0);
		        iVar7 = DAT_ram_009d3e38;
		        iVar5 = Method_System_Collections_Generic_List_MedalCategoryDic__Add__;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81004c83;
		        }
		        *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		        uVar2 = *(uint *)(iVar10 + 0xc);
		        if (uVar2 < *(uint *)(*(int *)(iVar10 + 8) + 0xc)) {
		          *(uint *)(iVar10 + 0xc) = uVar2 + 1;
		          *(undefined4 *)(*(int *)(iVar10 + 8) + uVar2 * 4 + 0x10) = uVar4;
		          goto code_r0x81004a7d;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar10,uVar4,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar5 != 1);
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81004c83:
		      iVar5 = global_1;
		      iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar5 == iVar7) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar5 = *piVar6;
		        iVar7 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_4c = iVar5;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		code_r0x81004cd0:
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar7 != 0) {
		            if (iVar7 == 1) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 2) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 3) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 4) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 5) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 6) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 7) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 8) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 9) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 == 10) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            if (iVar7 != 0xb) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		          }
		          if (*(int *)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Aprs_Model_AprsModel___c_TypeInfo);
		          }
		          puVar11 = *(undefined4 **)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x5c);
		          iVar5 = puVar11[1];
		          if (iVar5 == 0) {
		            if (*(int *)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Gameplay_Aprs_Model_AprsModel___c_TypeInfo);
		              puVar11 = *(undefined4 **)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x5c);
		            }
		            uVar4 = *puVar11;
		            iVar5 = unnamed_function_1417(System_Func_MedalCategoryDic__uint__TypeInfo);
		            System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                      (iVar5,uVar4,Method_Gameplay_Aprs_Model_AprsModel___c__SetMedals_b__43_0__,0);
		            *(int *)(*(int *)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x5c) + 4) = iVar5;
		          }
		          uVar4 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                            (iVar10,iVar5,
		                             Method_System_Linq_Enumerable_OrderBy_MedalCategoryDic__uint___);
		          uVar4 = System_Linq_Enumerable__Select_object__object_
		                            (uVar4,Method_System_Linq_Enumerable_ToList_MedalCategoryDic___);
		          *(undefined4 *)(param1 + 0x20) = uVar4;
		          uVar4 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                            (uVar3,
		                             Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Keys__
		                            );
		          System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		                    (&local_4c,uVar4,
		                     Method_System_Collections_Generic_Dictionary_KeyCollection_uint__List_AprData___GetEnumerator__
		                    );
		          local_20 = local_44;
		          local_28 = CONCAT44(ppiStack_48,local_4c);
		          local_4c = 0;
		          ppiStack_48 = (int **)&local_28;
		          do {
		            DAT_ram_009d3e38 = 0;
		            iVar5 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3ad,&local_28,
		                               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_uint__List_AprData___MoveNext__
		                              );
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x810050bc;
		            }
		            if (iVar5 == 0) goto code_r0x81005112;
		            uVar12 = *(undefined4 *)(param1 + 0x24);
		            DAT_ram_009d3e38 = 0;
		            uVar4 = local_20._4_4_;
		            uVar8 = import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar3,
		                               local_20._4_4_,
		                               Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Item__
		                              );
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x810050b4:
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x810050bc;
		            }
		            if (*(int *)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x74) == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                         Gameplay_Aprs_Model_AprsModel___c_TypeInfo);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x810050b4;
		            }
		            puVar11 = *(undefined4 **)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x5c);
		            iVar10 = puVar11[2];
		            if (iVar10 == 0) {
		              if (*(int *)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x74) == 0) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                           Gameplay_Aprs_Model_AprsModel___c_TypeInfo);
		                iVar10 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar10 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x810050bc;
		                }
		                puVar11 = *(undefined4 **)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x5c);
		              }
		              param3_00 = *puVar11;
		              DAT_ram_009d3e38 = 0;
		              iVar10 = import::env::invoke_ii
		                                 (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                  System_Func_AprData__uint__TypeInfo);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x76,iVar10,param3_00,
		                           Method_Gameplay_Aprs_Model_AprsModel___c__SetMedals_b__43_1__,0);
		                if (DAT_ram_009d3e38 != 1) {
		                  *(int *)(*(int *)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x5c) + 8) = iVar10
		                  ;
		                  goto code_r0x81004fbe;
		                }
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x810050bc;
		            }
		code_r0x81004fbe:
		            DAT_ram_009d3e38 = 0;
		            uVar8 = import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x77,uVar8,iVar10,
		                               Method_System_Linq_Enumerable_OrderBy_AprData__uint___);
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 == 1) {
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x810050bc;
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar8 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x229,uVar8,
		                               Method_System_Linq_Enumerable_ToList_AprData___);
		            if (DAT_ram_009d3e38 == 1) break;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar12,uVar4,uVar8,
		                       Method_System_Collections_Generic_Dictionary_uint__List_AprData___set_Item__)
		            ;
		          } while (DAT_ram_009d3e38 != 1);
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810050bc:
		          iVar10 = global_1;
		          iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar10 == iVar5) {
		            piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		            iVar5 = *piVar6;
		            DAT_ram_009d3e38 = 0;
		            local_4c = iVar5;
		            import::env::invoke_v(0x123);
		            iVar10 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar10 != 1) {
		              if (iVar5 != 0) {
		                System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		                do {
		                  halt_trap();
		                } while( true );
		              }
		code_r0x81005112:
		              DAT_ram_009d3e38 = 0;
		              System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                        (&local_4c,*(undefined4 *)(param1 + 0x20),
		                         Method_System_Collections_Generic_List_MedalCategoryDic__GetEnumerator__);
		              local_30 = local_44;
		              local_38 = CONCAT44(ppiStack_48,local_4c);
		              local_4c = 0;
		              ppiStack_48 = (int **)&local_38;
		              do {
		                DAT_ram_009d3e38 = 0;
		                iVar5 = import::env::invoke_iii
		                                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_38,
		                                   Method_System_Collections_Generic_List_Enumerator_MedalCategoryDic__MoveNext__
		                                  );
		                iVar10 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar10 == 1) {
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x81005276;
		                }
		                if (iVar5 == 0) goto code_r0x810052cc;
		                uVar4 = *(undefined4 *)(param1 + 0x28);
		                DAT_ram_009d3e38 = 0;
		                uVar3 = import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                                   *(undefined4 *)(param1 + 0x24),
		                                   *(undefined4 *)(local_30._4_4_ + 0xc),
		                                   Method_System_Collections_Generic_Dictionary_uint__List_AprData___get_Item__
		                                  );
		                if (DAT_ram_009d3e38 == 1) break;
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xf8,uVar4,uVar3,
		                           Method_System_Collections_Generic_List_AprData__AddRange__);
		              } while (DAT_ram_009d3e38 != 1);
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81005276:
		              iVar10 = global_1;
		              iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		              if (iVar10 == iVar5) {
		                piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		                iVar5 = *piVar6;
		                DAT_ram_009d3e38 = 0;
		                local_4c = iVar5;
		                import::env::invoke_v(0x123);
		                iVar10 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar10 != 1) {
		                  if (iVar5 != 0) {
		                    System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		                    do {
		                      halt_trap();
		                    } while( true );
		                  }
		code_r0x810052cc:
		                  DAT_ram_009d3e38 = 0;
		                  local_3c = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                              (param2,
		                                               Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__GetEnumerator__
		                                              );
		                  local_4c = 0;
		                  ppiStack_48 = &local_3c;
		                  do {
		                    do {
		                      piVar6 = local_3c;
		                      iVar10 = *local_3c;
		                      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		                        uVar2 = 0;
		                        do {
		                          piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		                          if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		                            puVar11 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		                            goto code_r0x81005396;
		                          }
		                          uVar2 = uVar2 + 1;
		                        } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		                      }
		                      DAT_ram_009d3e38 = 0;
		                      puVar11 = (undefined4 *)
		                                import::env::invoke_iiii
		                                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                           local_3c,System_Collections_IEnumerator_TypeInfo,0);
		                      if (DAT_ram_009d3e38 == 1) {
		code_r0x810053da:
		                        DAT_ram_009d3e38 = 0;
		                        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        goto code_r0x810055b7;
		                      }
		code_r0x81005396:
		                      DAT_ram_009d3e38 = 0;
		                      iVar10 = import::env::invoke_iii(*puVar11,piVar6,puVar11[1]);
		                      piVar6 = local_3c;
		                      if (DAT_ram_009d3e38 == 1) goto code_r0x810053da;
		                      if (iVar10 == 0) goto code_r0x81005600;
		                      iVar10 = *local_3c;
		                      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		                        uVar2 = 0;
		                        do {
		                          piVar13 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		                          if (System_Collections_Generic_IEnumerator_MedalInfo__TypeInfo == *piVar13
		                             ) {
		                            puVar11 = (undefined4 *)(iVar10 + piVar13[1] * 8 + 0xc0);
		                            goto code_r0x8100547f;
		                          }
		                          uVar2 = uVar2 + 1;
		                        } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		                      }
		                      DAT_ram_009d3e38 = 0;
		                      puVar11 = (undefined4 *)
		                                import::env::invoke_iiii
		                                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                           local_3c,
		                                           System_Collections_Generic_IEnumerator_MedalInfo__TypeInfo
		                                           ,0);
		                      if (DAT_ram_009d3e38 == 1) {
		code_r0x81005591:
		                        DAT_ram_009d3e38 = 0;
		                        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        goto code_r0x810055b7;
		                      }
		code_r0x8100547f:
		                      DAT_ram_009d3e38 = 0;
		                      iVar10 = import::env::invoke_iii(*puVar11,piVar6,puVar11[1]);
		                      if (DAT_ram_009d3e38 == 1) goto code_r0x81005591;
		                      DAT_ram_009d3e38 = 0;
		                      iVar7 = import::env::invoke_iiii
		                                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,
		                                         *(undefined4 *)(param1 + 0x1c),
		                                         *(undefined4 *)(iVar10 + 0xc),
		                                         Method_System_Collections_Generic_Dictionary_uint__AprData__ContainsKey__
		                                        );
		                      iVar5 = DAT_ram_009d3e38;
		                      DAT_ram_009d3e38 = 0;
		                      if (iVar5 == 1) {
		                        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        goto code_r0x810055b7;
		                      }
		                    } while (iVar7 == 0);
		                    DAT_ram_009d3e38 = 0;
		                    uVar3 = import::env::invoke_iiii
		                                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                                       *(undefined4 *)(param1 + 0x1c),*(undefined4 *)(iVar10 + 0xc),
		                                       Method_System_Collections_Generic_Dictionary_uint__AprData__get_Item__
		                                      );
		                    iVar5 = DAT_ram_009d3e38;
		                    DAT_ram_009d3e38 = 0;
		                    if (iVar5 == 1) {
		                      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                      goto code_r0x810055b7;
		                    }
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_viiii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 700,uVar3,iVar10,
		                               *(undefined4 *)(param1 + 0xc),iVar10);
		                    iVar10 = DAT_ram_009d3e38;
		                    DAT_ram_009d3e38 = 0;
		                  } while (iVar10 != 1);
		                  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810055b7:
		                  iVar10 = global_1;
		                  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		                  if (iVar10 == iVar5) {
		                    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		                    local_4c = *piVar6;
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_v(0x123);
		                    iVar10 = DAT_ram_009d3e38;
		                    DAT_ram_009d3e38 = 0;
		                    if (iVar10 != 1) {
		code_r0x81005600:
		                      DAT_ram_009d3e38 = 0;
		                      piVar6 = *ppiStack_48;
		                      if (piVar6 != (int *)0x0) {
		                        uVar2 = 0;
		                        iVar10 = *piVar6;
		                        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		                          do {
		                            if (System_IDisposable_TypeInfo ==
		                                *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		                              puVar9 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) +
		                                                                  uVar2 * 8 + 4) * 8 + 0xc0);
		                              goto code_r0x8100567b;
		                            }
		                            uVar2 = uVar2 + 1;
		                          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		                        }
		                        puVar9 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x8100567b:
		                        (**(code **)((ulonglong)*puVar9 * 4))(piVar6,puVar9[1]);
		                      }
		                      if (local_4c == 0) {
		                        return;
		                      }
		                      System_Data_DataSet__ValidateLocaleConstraint(local_4c);
		                      do {
		                        halt_trap();
		                      } while( true );
		                    }
		                    uVar4 = import::env::__cxa_find_matching_catch_2();
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_ii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2bd,&local_4c);
		                  goto joined_r0x810056d0;
		                }
		                uVar4 = import::env::__cxa_find_matching_catch_2();
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_ii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2be,&local_4c);
		              goto joined_r0x810056d0;
		            }
		            uVar4 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 699,&local_4c);
		          goto joined_r0x810056d0;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2ba,&local_4c);
		      goto joined_r0x810056d0;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2b9,&local_4c);
		joined_r0x810056d0:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x81005720:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06005425 RID: 21541 RVA: 0x0000F300 File Offset: 0x0000D500
		[Token(Token = "0x6005425")]
		[Address(RVA = "0xA1DC", Offset = "0xA1DC", VA = "0xA1DC")]
		public bool TryGetAprDataByAprId(uint medalId, uint aprId, out AprData data)
		{
			return default(bool);
		}

		// Token: 0x06005426 RID: 21542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005426")]
		[Address(RVA = "0xA1DD", Offset = "0xA1DD", VA = "0xA1DD")]
		public void SetMedals(RepeatedField<MedalInfo> medalInfos)
		{
		/* --- GHIDRA: SetMedals ---
		void Gameplay_Aprs_Model_AprsModel__SetMedals(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59443 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Model_AprsModel___c_TypeInfo);
		    DAT_ram_00a59443 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Aprs_Model_AprsModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Aprs_Model_AprsModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002D8A RID: 11658
		[Token(Token = "0x4002D8A")]
		[FieldOffset(Offset = "0x18")]
		private AprDicGroupStorage _aprDicGroupStorage;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_BuyProcessCount ---
		void Gameplay_Aprs_Model_AprsModel__set_BuyProcessCount(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x2c) = 0;
		  *(undefined4 *)(param1 + 0x14) = 0;
		  *(undefined8 *)(param1 + 0xc) = 0;
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/

}
