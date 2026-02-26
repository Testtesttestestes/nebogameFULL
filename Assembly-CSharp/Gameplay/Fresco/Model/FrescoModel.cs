using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Bank.Model;
using Gameplay.Fresco.View.Groups;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Fresco;

namespace Gameplay.Fresco.Model
{
	// Token: 0x02000803 RID: 2051
	[Token(Token = "0x2000803")]
	public class FrescoModel : AbstractModel
	{
		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003015 RID: 12309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096A")]
		public RepeatedField<Protocol.Fresco.Fresco> Frescoes
		{
			[Token(Token = "0x6003014")]
			[Address(RVA = "0x8079", Offset = "0x8079", VA = "0x8079")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003015")]
			[Address(RVA = "0x807A", Offset = "0x807A", VA = "0x807A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06003016 RID: 12310 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003017 RID: 12311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096B")]
		public Protocol.Fresco.Fresco CurrentFresco
		{
			[Token(Token = "0x6003016")]
			[Address(RVA = "0x807B", Offset = "0x807B", VA = "0x807B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003017")]
			[Address(RVA = "0x807C", Offset = "0x807C", VA = "0x807C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003019 RID: 12313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096C")]
		public Protocol.Fresco.Fresco CurrentLobbyFresco
		{
			[Token(Token = "0x6003018")]
			[Address(RVA = "0x807D", Offset = "0x807D", VA = "0x807D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003019")]
			[Address(RVA = "0x807E", Offset = "0x807E", VA = "0x807E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x00009B40 File Offset: 0x00007D40
		[Token(Token = "0x1700096D")]
		public int CurrentFrescoIndex
		{
			[Token(Token = "0x600301A")]
			[Address(RVA = "0x807F", Offset = "0x807F", VA = "0x807F")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x0600301B RID: 12315 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600301C RID: 12316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096E")]
		public Protocol.Dic.Fresco.Types.FrescoDic CurrentFrescoDic
		{
			[Token(Token = "0x600301B")]
			[Address(RVA = "0x8080", Offset = "0x8080", VA = "0x8080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600301C")]
			[Address(RVA = "0x8081", Offset = "0x8081", VA = "0x8081")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x0600301D RID: 12317 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600301E RID: 12318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700096F")]
		public Protocol.Dic.Fresco.Types.FrescoDic CurrentLobbyFrescoDic
		{
			[Token(Token = "0x600301D")]
			[Address(RVA = "0x8082", Offset = "0x8082", VA = "0x8082")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600301E")]
			[Address(RVA = "0x8083", Offset = "0x8083", VA = "0x8083")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x0600301F RID: 12319 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003020 RID: 12320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000970")]
		public SortedDictionary<Protocol.Fresco.Fresco, Protocol.Dic.Fresco.Types.FrescoDic> CurrentGroup
		{
			[Token(Token = "0x600301F")]
			[Address(RVA = "0x8084", Offset = "0x8084", VA = "0x8084")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003020")]
			[Address(RVA = "0x8085", Offset = "0x8085", VA = "0x8085")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06003021 RID: 12321 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003022 RID: 12322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000971")]
		public uint[] SelectedCellsIndex
		{
			[Token(Token = "0x6003021")]
			[Address(RVA = "0x8086", Offset = "0x8086", VA = "0x8086")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003022")]
			[Address(RVA = "0x8087", Offset = "0x8087", VA = "0x8087")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06003023 RID: 12323 RVA: 0x00009B58 File Offset: 0x00007D58
		[Token(Token = "0x17000972")]
		public bool HasSelectedCells
		{
			[Token(Token = "0x6003023")]
			[Address(RVA = "0x8088", Offset = "0x8088", VA = "0x8088")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06003024 RID: 12324 RVA: 0x00009B70 File Offset: 0x00007D70
		[Token(Token = "0x17000973")]
		public bool CanSelectUniversalFragment
		{
			[Token(Token = "0x6003024")]
			[Address(RVA = "0x8089", Offset = "0x8089", VA = "0x8089")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x00009B88 File Offset: 0x00007D88
		[Token(Token = "0x17000974")]
		public int EmptyCellsCount
		{
			[Token(Token = "0x6003025")]
			[Address(RVA = "0x808A", Offset = "0x808A", VA = "0x808A")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06003026 RID: 12326 RVA: 0x00009BA0 File Offset: 0x00007DA0
		// (set) Token: 0x06003027 RID: 12327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000975")]
		public uint UniversalFragmentsCount
		{
			[Token(Token = "0x6003026")]
			[Address(RVA = "0x808B", Offset = "0x808B", VA = "0x808B")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6003027")]
			[Address(RVA = "0x808C", Offset = "0x808C", VA = "0x808C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06003028 RID: 12328 RVA: 0x00009BB8 File Offset: 0x00007DB8
		[Token(Token = "0x17000976")]
		public bool CanInstallUniversalFragment
		{
			[Token(Token = "0x6003028")]
			[Address(RVA = "0x808D", Offset = "0x808D", VA = "0x808D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06003029 RID: 12329 RVA: 0x00009BD0 File Offset: 0x00007DD0
		[Token(Token = "0x17000977")]
		public bool CanInstallAllUniversalFragments
		{
			[Token(Token = "0x6003029")]
			[Address(RVA = "0x808E", Offset = "0x808E", VA = "0x808E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x0600302A RID: 12330 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600302B RID: 12331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000978")]
		public List<FrescoGroupListElementArgs> FrescoData
		{
			[Token(Token = "0x600302A")]
			[Address(RVA = "0x808F", Offset = "0x808F", VA = "0x808F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600302B")]
			[Address(RVA = "0x8090", Offset = "0x8090", VA = "0x8090")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x0600302C RID: 12332 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000979")]
		public Dictionary<ulong, List<FrescoGroupListElementArgs>> OtherFrescoData
		{
			[Token(Token = "0x600302C")]
			[Address(RVA = "0x8091", Offset = "0x8091", VA = "0x8091")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x0600302D RID: 12333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700097A")]
		public Protocol.Dic.Fresco.Types.Cell KeyCell
		{
			[Token(Token = "0x600302D")]
			[Address(RVA = "0x8092", Offset = "0x8092", VA = "0x8092")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x0600302E RID: 12334 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700097B")]
		public FrescoCell KeyFrescoCell
		{
			[Token(Token = "0x600302E")]
			[Address(RVA = "0x8093", Offset = "0x8093", VA = "0x8093")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700097C")]
		public Protocol.Dic.Fresco.Types.Cell KeyDicFrescoCell
		{
			[Token(Token = "0x600302F")]
			[Address(RVA = "0x8094", Offset = "0x8094", VA = "0x8094")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06003030 RID: 12336 RVA: 0x00009BE8 File Offset: 0x00007DE8
		[Token(Token = "0x1700097D")]
		public bool HasKeyCell
		{
			[Token(Token = "0x6003030")]
			[Address(RVA = "0x8095", Offset = "0x8095", VA = "0x8095")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06003031 RID: 12337 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003032 RID: 12338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700097E")]
		public UserData Owner
		{
			[Token(Token = "0x6003031")]
			[Address(RVA = "0x8096", Offset = "0x8096", VA = "0x8096")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003032")]
			[Address(RVA = "0x8097", Offset = "0x8097", VA = "0x8097")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06003033 RID: 12339 RVA: 0x00009C00 File Offset: 0x00007E00
		[Token(Token = "0x1700097F")]
		public bool IsOwn
		{
			[Token(Token = "0x6003033")]
			[Address(RVA = "0x8098", Offset = "0x8098", VA = "0x8098")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x00009C18 File Offset: 0x00007E18
		[Token(Token = "0x6003034")]
		[Address(RVA = "0x8099", Offset = "0x8099", VA = "0x8099")]
		public bool HasAvailableCells(bool includeKeyObject)
		{
		/* --- GHIDRA: HasAvailableCells ---
		undefined4
		Gameplay_Fresco_Model_FrescoModel__HasAvailableCells(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5758b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_FrescoCell__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_FrescoCell___);
		    Mono_Security_ASN1__get_Item(&System_Func_FrescoCell__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_FrescoCell__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__GetAllAvailableCellsIndex_b__68_1__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Model_FrescoModel___c__DisplayClass68_0__GetAllAvailableCellsIndex_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Model_FrescoModel___c__DisplayClass68_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		    DAT_ram_00a5758b = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_Fresco_Model_FrescoModel___c__DisplayClass68_0_TypeInfo);
		  *(undefined1 *)(iVar1 + 8) = (undefined1)param2;
		  if (*(int *)(param1 + 0x14) == 0) {
		    uVar4 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0x18);
		    uVar4 = unnamed_function_1417(System_Func_FrescoCell__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar4,iVar1,
		               Method_Gameplay_Fresco_Model_FrescoModel___c__DisplayClass68_0__GetAllAvailableCellsIndex_b__0__
		               ,0);
		    uVar4 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (uVar2,uVar4,Method_System_Linq_Enumerable_Where_FrescoCell___);
		    if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		    }
		    puVar3 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		    iVar1 = puVar3[6];
		    if (iVar1 == 0) {
		      if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		        puVar3 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		      }
		      uVar2 = *puVar3;
		      iVar1 = unnamed_function_1417(System_Func_FrescoCell__uint__TypeInfo);
		      System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                (iVar1,uVar2,
		                 Method_Gameplay_Fresco_Model_FrescoModel___c__GetAllAvailableCellsIndex_b__68_1__,0
		                );
		      *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 0x18) = iVar1;
		    }
		    uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (uVar4,iVar1,Method_System_Linq_Enumerable_Select_FrescoCell__uint___);
		    uVar4 = System_Linq_Enumerable__OrderBy_uint__uint_
		                      (uVar4,Method_System_Linq_Enumerable_ToArray_uint___);
		  }
		  return uVar4;
		}
		*/

			return default(bool);
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003035")]
		[Address(RVA = "0x809A", Offset = "0x809A", VA = "0x809A")]
		public uint[] GetAllAvailableCellsIndex(bool includeKeyObject)
		{
		/* --- GHIDRA: GetAllAvailableCellsIndex ---
		void Gameplay_Fresco_Model_FrescoModel__GetAllAvailableCellsIndex
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5758c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__List_FrescoGroupListElementArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_ulong__List_FrescoGroupListElementArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BankOptionData__TypeInfo);
		    DAT_ram_00a5758c = '\x01';
		  }
		  iVar3 = Method_System_Array_Empty_uint___;
		  iVar2 = *(int *)(Method_System_Array_Empty_uint___ + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_uint___);
		    iVar2 = *(int *)(iVar3 + 0x1c);
		  }
		  iVar2 = *(int *)(iVar2 + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  if (*(int *)(iVar2 + 0x74) == 0) {
		    func_ii_306000(iVar2);
		  }
		  iVar3 = *(int *)(*(int *)(iVar3 + 0x1c) + 8);
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar3 = func_ii_1079(iVar3);
		  }
		  *(undefined4 *)(param1 + 0x28) = **(undefined4 **)(iVar3 + 0x5c);
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_ulong__List_FrescoGroupListElementArgs___TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_ulong__List_FrescoGroupListElementArgs____ctor__
		            );
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_BankOptionData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_BankOptionData___ctor__);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 0x38) = *(undefined4 *)(param1 + 8);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003036")]
		[Address(RVA = "0x809B", Offset = "0x809B", VA = "0x809B")]
		public FrescoModel(UserData user, Dependencies dependencies)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Fresco_Model_FrescoModel___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int param2_01;
		  byte local_10;
		  longlong local_8;
		  
		  if (DAT_ram_00a5758d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Fresco___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Fresco__FindIndex__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&System_Predicate_Fresco__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_Fresco__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__DisplayClass70_0__UpdateFresco_b__0__)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Model_FrescoModel___c__DisplayClass70_0_TypeInfo);
		    DAT_ram_00a5758d = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Fresco_Model_FrescoModel___c__DisplayClass70_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = System_Linq_Enumerable__Select_object__object_
		                        (*(undefined4 *)(param1 + 0x10),
		                         Method_System_Linq_Enumerable_ToList_Fresco___);
		  param1_01 = unnamed_function_1417(System_Predicate_Fresco__TypeInfo);
		  func_ii_7297(param1_01,param2_00,
		               Method_Gameplay_Fresco_Model_FrescoModel___c__DisplayClass70_0__UpdateFresco_b__0__,0
		              );
		  param2_01 = System_Collections_Generic_List_UsageHint___FindAll
		                        (param1_00,param1_01,
		                         Method_System_Collections_Generic_List_Fresco__FindIndex__);
		  if (param2_01 != -1) {
		    Google_Protobuf_Collections_RepeatedField_object___get_IsReadOnly
		              (*(undefined4 *)(param1 + 0x10),param2_01,*(undefined4 *)(param2_00 + 8),
		               Method_Google_Protobuf_Collections_RepeatedField_Fresco__set_Item__);
		    if (*(int *)(param1 + 0x14) != 0) {
		      local_8 = 0;
		      _local_10 = 0;
		      Core_Log_Files_FileDownloadLogger__LogDownload
		                (&local_10,*(undefined8 *)(*(int *)(param1 + 0x14) + 0x10),
		                 Method_System_Nullable_ulong___ctor__);
		      if ((local_10 != 0) && (local_8 == *(longlong *)(*(int *)(param2_00 + 8) + 0x10))) {
		        *(int *)(param1 + 0x14) = *(int *)(param2_00 + 8);
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003037 RID: 12343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003037")]
		[Address(RVA = "0x809C", Offset = "0x809C", VA = "0x809C")]
		public void UpdateFresco(Protocol.Fresco.Fresco newFresco)
		{
		/* --- GHIDRA: UpdateFresco ---
		undefined4
		Gameplay_Fresco_Model_FrescoModel__UpdateFresco(int param1,undefined4 *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int iVar3;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5758e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Fresco___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Fresco__IndexOf__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Fresco__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Fresco__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_SortedDictionary_Fresco__Fresco_Types_FrescoDic__get_Keys__
		              );
		    DAT_ram_00a5758e = '\x01';
		  }
		  *param2 = 0;
		  uVar2 = System_Collections_Generic_SortedDictionary_object__object___get_Item
		                    (*(undefined4 *)(param1 + 0x24),
		                     Method_System_Collections_Generic_SortedDictionary_Fresco__Fresco_Types_FrescoDic__get_Keys__
		                    );
		  param1_00 = System_Linq_Enumerable__Select_object__object_
		                        (uVar2,Method_System_Linq_Enumerable_ToList_Fresco___);
		  iVar3 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (param1_00,*(undefined4 *)(param1 + 0x14),
		                     Method_System_Collections_Generic_List_Fresco__IndexOf__);
		  if ((-1 < iVar3) && (iVar3 < *(int *)(param1_00 + 0xc) + -1)) {
		    uVar1 = 1;
		    uVar2 = System_Linq_Enumerable__ToList_object_
		                      (param1_00,iVar3 + 1,Method_System_Collections_Generic_List_Fresco__get_Item__
		                      );
		    *param2 = uVar2;
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06003038 RID: 12344 RVA: 0x00009C30 File Offset: 0x00007E30
		[Token(Token = "0x6003038")]
		[Address(RVA = "0x809D", Offset = "0x809D", VA = "0x809D")]
		public bool TryGetNextFresco(out Protocol.Fresco.Fresco fresco)
		{
		/* --- GHIDRA: TryGetNextFresco ---
		uint Gameplay_Fresco_Model_FrescoModel__TryGetNextFresco
		               (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5758f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Fresco___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Fresco__IndexOf__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Fresco__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_SortedDictionary_Fresco__Fresco_Types_FrescoDic__get_Keys__
		              );
		    DAT_ram_00a5758f = '\x01';
		  }
		  *param2 = 0;
		  uVar1 = System_Collections_Generic_SortedDictionary_object__object___get_Item
		                    (*(undefined4 *)(param1 + 0x24),
		                     Method_System_Collections_Generic_SortedDictionary_Fresco__Fresco_Types_FrescoDic__get_Keys__
		                    );
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,Method_System_Linq_Enumerable_ToList_Fresco___);
		  iVar2 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (uVar1,*(undefined4 *)(param1 + 0x14),
		                     Method_System_Collections_Generic_List_Fresco__IndexOf__);
		  if (0 < iVar2) {
		    uVar1 = System_Linq_Enumerable__ToList_object_
		                      (uVar1,iVar2 + -1,Method_System_Collections_Generic_List_Fresco__get_Item__);
		    *param2 = uVar1;
		  }
		  return (uint)(0 < iVar2);
		}
		*/

			return default(bool);
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x00009C48 File Offset: 0x00007E48
		[Token(Token = "0x6003039")]
		[Address(RVA = "0x809E", Offset = "0x809E", VA = "0x809E")]
		public bool TryGetPrevFresco(out Protocol.Fresco.Fresco fresco)
		{
		/* --- GHIDRA: TryGetPrevFresco ---
		void Gameplay_Fresco_Model_FrescoModel__TryGetPrevFresco
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  int param3_00;
		  
		  if (DAT_ram_00a57590 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData__Clear__);
		    DAT_ram_00a57590 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  param3_00 = *(int *)(param1_00 + 0xc);
		  *(undefined4 *)(param1_00 + 0xc) = 0;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  if (0 < param3_00) {
		    func_ii_2064(*(undefined4 *)(param1_00 + 8),0,param3_00,0);
		    param1_00 = *(int *)(param1 + 0x3c);
		  }
		  func_ii_6335(param1_00,param2,Method_System_Collections_Generic_List_BankOptionData__AddRange__);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600303A")]
		[Address(RVA = "0x809F", Offset = "0x809F", VA = "0x809F")]
		public void SetOptions(IList<BankOptionData> options)
		{
		/* --- GHIDRA: SetOptions ---
		undefined4
		Gameplay_Fresco_Model_FrescoModel__SetOptions(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57591 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_Fresco_Types_Cell___);
		    Mono_Security_ASN1__get_Item(&System_Func_Fresco_Types_Cell__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Model_FrescoModel___c__DisplayClass74_0__GetArtikulIdByIndex_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Model_FrescoModel___c__DisplayClass74_0_TypeInfo);
		    DAT_ram_00a57591 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_Fresco_Model_FrescoModel___c__DisplayClass74_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0x34);
		  param1_00 = unnamed_function_1417(System_Func_Fresco_Types_Cell__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,iVar1,
		             Method_Gameplay_Fresco_Model_FrescoModel___c__DisplayClass74_0__GetArtikulIdByIndex_b__0__
		             ,0);
		  iVar1 = func_ii_7423(param1_01,param1_00,Method_System_Linq_Enumerable_First_Fresco_Types_Cell___)
		  ;
		  return *(undefined4 *)(iVar1 + 0x10);
		}
		*/

		}

		// Token: 0x0600303B RID: 12347 RVA: 0x00009C60 File Offset: 0x00007E60
		[Token(Token = "0x600303B")]
		[Address(RVA = "0x80A0", Offset = "0x80A0", VA = "0x80A0")]
		public uint GetArtikulIdByIndex(uint index)
		{
		/* --- GHIDRA: GetArtikulIdByIndex ---
		void Gameplay_Fresco_Model_FrescoModel__GetArtikulIdByIndex
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57592 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__List_FrescoGroupListElementArgs___set_Item__
		              );
		    DAT_ram_00a57592 = '\x01';
		  }
		  Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollArtifacts___ctor
		            (*(undefined4 *)(param1 + 0x34),param2,param3,
		             Method_System_Collections_Generic_Dictionary_ulong__List_FrescoGroupListElementArgs___set_Item__
		            );
		  return;
		}
		*/

			return 0U;
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600303C")]
		[Address(RVA = "0x80A1", Offset = "0x80A1", VA = "0x80A1")]
		public void SetOtherFrescoData(ulong userId, List<FrescoGroupListElementArgs> frescoData)
		{
		/* --- GHIDRA: SetOtherFrescoData ---
		void Gameplay_Fresco_Model_FrescoModel__SetOtherFrescoData
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57593 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_FrescoGroupListElementArgs___)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Func_FrescoGroupListElementArgs__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Model_FrescoModel___c__DisplayClass76_0__SetCurrentFresco_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Model_FrescoModel___c__DisplayClass76_0_TypeInfo);
		    DAT_ram_00a57593 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_Fresco_Model_FrescoModel___c__DisplayClass76_0_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = param2;
		  *(undefined4 *)(param1 + 0x14) = param2;
		  param1_00 = *(int **)(*(int *)(param1 + 0xc) + 8);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80dac7d7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80dac7d7:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,CONCAT44(in_register_20000014,puVar3[1]));
		  uVar4 = Core_Extensions_Dict_DictExt__GetFrescoGroupDic
		                    (uVar4,*(undefined8 *)(*(int *)(iVar2 + 8) + 0x10),0);
		  *(undefined4 *)(param1 + 0x1c) = uVar4;
		  param1_01 = *(undefined4 *)(param1 + 0x30);
		  uVar4 = unnamed_function_1417(System_Func_FrescoGroupListElementArgs__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar4,iVar2,
		             Method_Gameplay_Fresco_Model_FrescoModel___c__DisplayClass76_0__SetCurrentFresco_b__0__
		             ,0);
		  iVar2 = func_ii_7423(param1_01,uVar4,
		                       Method_System_Linq_Enumerable_First_FrescoGroupListElementArgs___);
		  *(undefined4 *)(param1 + 0x24) = *(undefined4 *)(iVar2 + 0x18);
		  return;
		}
		*/

		}

		// Token: 0x0600303D RID: 12349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600303D")]
		[Address(RVA = "0x80A2", Offset = "0x80A2", VA = "0x80A2")]
		public void SetCurrentFresco(Protocol.Fresco.Fresco fresco)
		{
		/* --- GHIDRA: SetCurrentFresco ---
		void Gameplay_Fresco_Model_FrescoModel__SetCurrentFresco(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57594 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57594 = '\x01';
		  }
		  *(int *)(param1 + 0x18) = param2;
		  param1_00 = *(int **)(*(int *)(param1 + 0xc) + 8);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80dac8d6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80dac8d6:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,CONCAT44(in_register_20000014,puVar2[1]));
		  uVar3 = Core_Extensions_Dict_DictExt__GetFrescoGroupDic(uVar3,*(undefined8 *)(param2 + 0x10),0);
		  *(undefined4 *)(param1 + 0x20) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x0600303E RID: 12350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600303E")]
		[Address(RVA = "0x80A3", Offset = "0x80A3", VA = "0x80A3")]
		public void SetCurrentLobbyFresco(Protocol.Fresco.Fresco fresco)
		{
		/* --- GHIDRA: SetCurrentLobbyFresco ---
		uint Gameplay_Fresco_Model_FrescoModel__SetCurrentLobbyFresco
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  int iVar8;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57595 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Aggregate_FrescoGroupListElementArgs___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Aggregate_GdEventData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_FirstOrDefault_KeyValuePair_Fresco__Fresco_Types_FrescoDic____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderByDescending_KeyValuePair_Fresco__Fresco_Types_FrescoDic___uint___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderBy_KeyValuePair_Fresco__Fresco_Types_FrescoDic___uint___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ThenBy_KeyValuePair_Fresco__Fresco_Types_FrescoDic___uint___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToList_FrescoGroupListElementArgs___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_GdEventData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_FrescoGroupListElementArgs___)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_GdEventData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Where_KeyValuePair_Fresco__Fresco_Types_FrescoDic____)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_FrescoGroupListElementArgs__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_FrescoGroupListElementArgs__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_FrescoGroupListElementArgs__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_FrescoGroupListElementArgs__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_KeyValuePair_Fresco__Fresco_Types_FrescoDic___uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_GdEventData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_KeyValuePair_Fresco__Fresco_Types_FrescoDic___bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_GdEventData__GdEventData__GdEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_FrescoGroupListElementArgs__FrescoGroupListElementArgs__FrescoGroupListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_ulong__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_Fresco__Fresco_Types_FrescoDic__get_Key__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_FrescoGroupListElementArgs___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_GdEventData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FrescoGroupListElementArgs__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_10__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_11__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_12__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_3__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_4__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_5__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_6__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_7__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_8__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_9__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Model_FrescoModel___c__DisplayClass78_0__TryGetFrescoForLobby_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Model_FrescoModel___c__DisplayClass78_0__TryGetFrescoForLobby_b__2__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Model_FrescoModel___c__DisplayClass78_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		    DAT_ram_00a57595 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar2 = unnamed_function_1417(Gameplay_Fresco_Model_FrescoModel___c__DisplayClass78_0_TypeInfo);
		  *param2 = 0;
		  uVar3 = unnamed_function_1417(System_Collections_Generic_HashSet_ulong__TypeInfo);
		  System_Collections_Generic_HashSet_uint___get_Count
		            (uVar3,Method_System_Collections_Generic_HashSet_ulong___ctor__);
		  *(undefined4 *)(iVar2 + 8) = uVar3;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1 + 0x30),
		             Method_System_Collections_Generic_List_FrescoGroupListElementArgs__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_FrescoGroupListElementArgs__MoveNext__
		                      );
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dacbaa;
		    }
		    if (iVar4 == 0) goto code_r0x80dacc00;
		    DAT_ram_009d3e38 = 0;
		    unnamed_function_184070
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x312,*(undefined4 *)(iVar2 + 8),
		               *(undefined8 *)(*(int *)(local_8._4_4_ + 0x14) + 0x20),
		               Method_System_Collections_Generic_HashSet_ulong__Add__);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dacbaa:
		  iVar8 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar4 = *piVar5;
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
		code_r0x80dacc00:
		      DAT_ram_009d3e38 = 0;
		      piVar5 = *(int **)(*(int *)(param1 + 0xc) + 0x18);
		      iVar8 = *piVar5;
		      iVar8 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x100) * 4))
		                        (piVar5,*(undefined4 *)(iVar8 + 0x104));
		      uVar6 = *(undefined4 *)(*(int *)(iVar8 + 0xc) + 0xc);
		      uVar1 = 0;
		      uVar3 = unnamed_function_1417(System_Func_GdEventData__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (uVar3,iVar2,
		                 Method_Gameplay_Fresco_Model_FrescoModel___c__DisplayClass78_0__TryGetFrescoForLobby_b__0__
		                 ,0);
		      uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                        (uVar6,uVar3,Method_System_Linq_Enumerable_Where_GdEventData___);
		      uVar3 = System_Linq_Enumerable__Select_object__object_
		                        (uVar3,Method_System_Linq_Enumerable_ToList_GdEventData___);
		      iVar8 = Sirenix_Utilities_LinqExtensions__IsNullOrEmpty_object_
		                        (uVar3,Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_GdEventData___)
		      ;
		      if (iVar8 == 0) {
		        if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		        }
		        puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		        iVar8 = puVar7[7];
		        if (iVar8 == 0) {
		          if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		            puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		          }
		          uVar6 = *puVar7;
		          iVar8 = unnamed_function_1417(System_Func_GdEventData__GdEventData__GdEventData__TypeInfo)
		          ;
		          System_Threading_Tasks_Task_object___get_Factory
		                    (iVar8,uVar6,
		                     Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_1__,0)
		          ;
		          *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 0x1c) = iVar8;
		        }
		        uVar1 = 0;
		        iVar8 = UnityEngine_UIElements_EnumField__ProcessPointerDown_object_
		                          (uVar3,iVar8,Method_System_Linq_Enumerable_Aggregate_GdEventData___);
		        *(int *)(iVar2 + 0xc) = iVar8;
		        if (iVar8 != 0) {
		          uVar6 = *(undefined4 *)(param1 + 0x30);
		          uVar3 = unnamed_function_1417(System_Func_FrescoGroupListElementArgs__bool__TypeInfo);
		          System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                    (uVar3,iVar2,
		                     Method_Gameplay_Fresco_Model_FrescoModel___c__DisplayClass78_0__TryGetFrescoForLobby_b__2__
		                     ,0);
		          uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                            (uVar6,uVar3,
		                             Method_System_Linq_Enumerable_Where_FrescoGroupListElementArgs___);
		          uVar3 = System_Linq_Enumerable__Select_object__object_
		                            (uVar3,
		                             Method_System_Linq_Enumerable_ToList_FrescoGroupListElementArgs___);
		          iVar2 = Sirenix_Utilities_LinqExtensions__IsNullOrEmpty_object_
		                            (uVar3,
		                             Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_FrescoGroupListElementArgs___
		                            );
		          if (iVar2 == 0) {
		            if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		            }
		            puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		            iVar2 = puVar7[8];
		            if (iVar2 == 0) {
		              if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		                puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		              }
		              uVar6 = *puVar7;
		              iVar2 = unnamed_function_1417
		                                (
		                                System_Func_FrescoGroupListElementArgs__FrescoGroupListElementArgs__FrescoGroupListElementArgs__TypeInfo
		                                );
		              System_Threading_Tasks_Task_object___get_Factory
		                        (iVar2,uVar6,
		                         Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_3__
		                         ,0);
		              *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 0x20) =
		                   iVar2;
		            }
		            iVar2 = UnityEngine_UIElements_EnumField__ProcessPointerDown_object_
		                              (uVar3,iVar2,
		                               Method_System_Linq_Enumerable_Aggregate_FrescoGroupListElementArgs___
		                              );
		            uVar3 = *(undefined4 *)(iVar2 + 0x18);
		            if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		            }
		            puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		            iVar8 = puVar7[9];
		            if (iVar8 == 0) {
		              if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		                puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		              }
		              uVar6 = *puVar7;
		              iVar8 = unnamed_function_1417
		                                (
		                                System_Func_KeyValuePair_Fresco__Fresco_Types_FrescoDic___bool__TypeInfo
		                                );
		              func_ii_6399(iVar8,uVar6,
		                           Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_4__
		                           ,0);
		              *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 0x24) =
		                   iVar8;
		            }
		            uVar3 = System_Linq_Enumerable__UnionIterator___Il2CppFullySharedGenericType_
		                              (uVar3,iVar8,
		                               Method_System_Linq_Enumerable_Where_KeyValuePair_Fresco__Fresco_Types_FrescoDic____
		                              );
		            if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		              func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		            }
		            puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		            iVar8 = puVar7[10];
		            if (iVar8 == 0) {
		              if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		                puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		              }
		              uVar6 = *puVar7;
		              iVar8 = unnamed_function_1417
		                                (
		                                System_Func_KeyValuePair_Fresco__Fresco_Types_FrescoDic___uint__TypeInfo
		                                );
		              System_Func_KeyValuePair_object__object___float___Invoke
		                        (iVar8,uVar6,
		                         Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_5__
		                         ,0);
		              *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 0x28) =
		                   iVar8;
		            }
		            uVar3 = System_Linq_Enumerable__OrderBy___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                              (uVar3,iVar8,
		                               Method_System_Linq_Enumerable_OrderByDescending_KeyValuePair_Fresco__Fresco_Types_FrescoDic___uint___
		                              );
		            System_Linq_Enumerable__First___Il2CppFullySharedGenericType_
		                      (&local_20,uVar3,
		                       Method_System_Linq_Enumerable_FirstOrDefault_KeyValuePair_Fresco__Fresco_Types_FrescoDic____
		                      );
		            *param2 = local_20;
		            uVar1 = 1;
		            if (local_20 == 0) {
		              uVar3 = *(undefined4 *)(iVar2 + 0x18);
		              if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		              }
		              puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		              iVar8 = puVar7[0xb];
		              if (iVar8 == 0) {
		                if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                  func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		                  puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		                }
		                uVar6 = *puVar7;
		                iVar8 = unnamed_function_1417
		                                  (
		                                  System_Func_KeyValuePair_Fresco__Fresco_Types_FrescoDic___bool__TypeInfo
		                                  );
		                func_ii_6399(iVar8,uVar6,
		                             Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_6__
		                             ,0);
		                *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 0x2c) =
		                     iVar8;
		              }
		              uVar3 = System_Linq_Enumerable__UnionIterator___Il2CppFullySharedGenericType_
		                                (uVar3,iVar8,
		                                 Method_System_Linq_Enumerable_Where_KeyValuePair_Fresco__Fresco_Types_FrescoDic____
		                                );
		              if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		              }
		              puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		              iVar8 = puVar7[0xc];
		              if (iVar8 == 0) {
		                if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                  func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		                  puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		                }
		                uVar6 = *puVar7;
		                iVar8 = unnamed_function_1417
		                                  (
		                                  System_Func_KeyValuePair_Fresco__Fresco_Types_FrescoDic___uint__TypeInfo
		                                  );
		                System_Func_KeyValuePair_object__object___float___Invoke
		                          (iVar8,uVar6,
		                           Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_7__
		                           ,0);
		                *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 0x30) =
		                     iVar8;
		              }
		              uVar3 = System_Linq_Enumerable__OrderBy___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                                (uVar3,iVar8,
		                                 Method_System_Linq_Enumerable_OrderByDescending_KeyValuePair_Fresco__Fresco_Types_FrescoDic___uint___
		                                );
		              System_Linq_Enumerable__First___Il2CppFullySharedGenericType_
		                        (&local_20,uVar3,
		                         Method_System_Linq_Enumerable_FirstOrDefault_KeyValuePair_Fresco__Fresco_Types_FrescoDic____
		                        );
		              *param2 = local_20;
		              uVar1 = 1;
		              if (local_20 == 0) {
		                uVar3 = *(undefined4 *)(iVar2 + 0x18);
		                if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                  func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		                }
		                puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		                iVar8 = puVar7[0xd];
		                if (iVar8 == 0) {
		                  if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                    func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		                    puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c)
		                    ;
		                  }
		                  uVar6 = *puVar7;
		                  iVar8 = unnamed_function_1417
		                                    (
		                                    System_Func_KeyValuePair_Fresco__Fresco_Types_FrescoDic___bool__TypeInfo
		                                    );
		                  func_ii_6399(iVar8,uVar6,
		                               Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_8__
		                               ,0);
		                  *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 0x34) =
		                       iVar8;
		                }
		                uVar3 = System_Linq_Enumerable__UnionIterator___Il2CppFullySharedGenericType_
		                                  (uVar3,iVar8,
		                                   Method_System_Linq_Enumerable_Where_KeyValuePair_Fresco__Fresco_Types_FrescoDic____
		                                  );
		                if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                  func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		                }
		                puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		                iVar8 = puVar7[0xe];
		                if (iVar8 == 0) {
		                  if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                    func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		                    puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c)
		                    ;
		                  }
		                  uVar6 = *puVar7;
		                  iVar8 = unnamed_function_1417
		                                    (
		                                    System_Func_KeyValuePair_Fresco__Fresco_Types_FrescoDic___uint__TypeInfo
		                                    );
		                  System_Func_KeyValuePair_object__object___float___Invoke
		                            (iVar8,uVar6,
		                             Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_9__
		                             ,0);
		                  *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 0x38) =
		                       iVar8;
		                }
		                uVar3 = System_Linq_Enumerable__OrderBy___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                                  (uVar3,iVar8,
		                                   Method_System_Linq_Enumerable_OrderByDescending_KeyValuePair_Fresco__Fresco_Types_FrescoDic___uint___
		                                  );
		                if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                  func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		                }
		                puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		                iVar8 = puVar7[0xf];
		                if (iVar8 == 0) {
		                  if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                    func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		                    puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c)
		                    ;
		                  }
		                  uVar6 = *puVar7;
		                  iVar8 = unnamed_function_1417
		                                    (
		                                    System_Func_KeyValuePair_Fresco__Fresco_Types_FrescoDic___uint__TypeInfo
		                                    );
		                  System_Func_KeyValuePair_object__object___float___Invoke
		                            (iVar8,uVar6,
		                             Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_10__
		                             ,0);
		                  *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 0x3c) =
		                       iVar8;
		                }
		                uVar3 = System_Linq_Enumerable__ThenBy_MarkToMarkAdjustmentRecord__uint_
		                                  (uVar3,iVar8,
		                                   Method_System_Linq_Enumerable_ThenBy_KeyValuePair_Fresco__Fresco_Types_FrescoDic___uint___
		                                  );
		                System_Linq_Enumerable__First___Il2CppFullySharedGenericType_
		                          (&local_20,uVar3,
		                           Method_System_Linq_Enumerable_FirstOrDefault_KeyValuePair_Fresco__Fresco_Types_FrescoDic____
		                          );
		                *param2 = local_20;
		                if (local_20 == 0) {
		                  uVar3 = *(undefined4 *)(iVar2 + 0x18);
		                  if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                    func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		                  }
		                  puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		                  iVar2 = puVar7[0x10];
		                  if (iVar2 == 0) {
		                    if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                      func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		                      puVar7 = *(undefined4 **)
		                                (Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		                    }
		                    uVar6 = *puVar7;
		                    iVar2 = unnamed_function_1417
		                                      (
		                                      System_Func_KeyValuePair_Fresco__Fresco_Types_FrescoDic___bool__TypeInfo
		                                      );
		                    func_ii_6399(iVar2,uVar6,
		                                 Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_11__
		                                 ,0);
		                    *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 0x40)
		                         = iVar2;
		                  }
		                  uVar3 = System_Linq_Enumerable__UnionIterator___Il2CppFullySharedGenericType_
		                                    (uVar3,iVar2,
		                                     Method_System_Linq_Enumerable_Where_KeyValuePair_Fresco__Fresco_Types_FrescoDic____
		                                    );
		                  if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                    func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		                  }
		                  puVar7 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		                  iVar2 = puVar7[0x11];
		                  if (iVar2 == 0) {
		                    if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		                      func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		                      puVar7 = *(undefined4 **)
		                                (Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		                    }
		                    uVar6 = *puVar7;
		                    iVar2 = unnamed_function_1417
		                                      (
		                                      System_Func_KeyValuePair_Fresco__Fresco_Types_FrescoDic___uint__TypeInfo
		                                      );
		                    System_Func_KeyValuePair_object__object___float___Invoke
		                              (iVar2,uVar6,
		                               Method_Gameplay_Fresco_Model_FrescoModel___c__TryGetFrescoForLobby_b__78_12__
		                               ,0);
		                    *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 0x44)
		                         = iVar2;
		                  }
		                  uVar3 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                                    (uVar3,iVar2,
		                                     Method_System_Linq_Enumerable_OrderBy_KeyValuePair_Fresco__Fresco_Types_FrescoDic___uint___
		                                    );
		                  System_Linq_Enumerable__First___Il2CppFullySharedGenericType_
		                            (&local_20,uVar3,
		                             Method_System_Linq_Enumerable_FirstOrDefault_KeyValuePair_Fresco__Fresco_Types_FrescoDic____
		                            );
		                  *param2 = local_20;
		                  uVar1 = (uint)(local_20 != 0);
		                }
		              }
		            }
		          }
		        }
		      }
		      return uVar1;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x313,&local_20);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
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

		// Token: 0x0600303F RID: 12351 RVA: 0x00009C78 File Offset: 0x00007E78
		[Token(Token = "0x600303F")]
		[Address(RVA = "0x80A4", Offset = "0x80A4", VA = "0x80A4")]
		public bool TryGetFrescoForLobby(out Protocol.Fresco.Fresco fresco)
		{
		/* --- GHIDRA: TryGetFrescoForLobby ---
		void Gameplay_Fresco_Model_FrescoModel__TryGetFrescoForLobby(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57596 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		    DAT_ram_00a57596 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x04001A5C RID: 6748
		[Token(Token = "0x4001A5C")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dependencies Dependencies;

		// Token: 0x04001A68 RID: 6760
		[Token(Token = "0x4001A68")]
		[FieldOffset(Offset = "0x3C")]
		public readonly List<BankOptionData> Options;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CurrentLobbyFresco ---
		undefined4 Gameplay_Fresco_Model_FrescoModel__set_CurrentLobbyFresco(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57586 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Fresco___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Fresco__IndexOf__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_SortedDictionary_Fresco__Fresco_Types_FrescoDic__get_Keys__
		              );
		    DAT_ram_00a57586 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_SortedDictionary_object__object___get_Item
		                    (*(undefined4 *)(param1 + 0x24),
		                     Method_System_Collections_Generic_SortedDictionary_Fresco__Fresco_Types_FrescoDic__get_Keys__
		                    );
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,Method_System_Linq_Enumerable_ToList_Fresco___);
		  uVar1 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (uVar1,*(undefined4 *)(param1 + 0x14),
		                     Method_System_Collections_Generic_List_Fresco__IndexOf__);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: set_SelectedCellsIndex ---
		uint Gameplay_Fresco_Model_FrescoModel__set_SelectedCellsIndex(int param1,undefined4 param2)
		
		{
		  return (uint)(*(int *)(*(int *)(param1 + 0x28) + 0xc) != 0);
		}
		*/


		/* --- GHIDRA: get_HasSelectedCells ---
		uint Gameplay_Fresco_Model_FrescoModel__get_HasSelectedCells(int param1,undefined4 param2)
		
		{
		  return (uint)((longlong)*(int *)(*(int *)(param1 + 0x28) + 0xc) <
		               (longlong)(ulonglong)*(uint *)(param1 + 0x2c));
		}
		*/


		/* --- GHIDRA: get_CanSelectUniversalFragment ---
		int Gameplay_Fresco_Model_FrescoModel__get_CanSelectUniversalFragment(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57587 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_Fresco_Types_Cell___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_FrescoCell___);
		    Mono_Security_ASN1__get_Item(&System_Func_FrescoCell__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Fresco_Types_Cell__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__get_EmptyCellsCount_b__36_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__get_EmptyCellsCount_b__36_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		    DAT_ram_00a57587 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0x34);
		  if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[1];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_Fresco_Types_Cell__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar3,uVar5,
		               Method_Gameplay_Fresco_Model_FrescoModel___c__get_EmptyCellsCount_b__36_0__,0);
		    *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 4) = iVar3;
		  }
		  iVar3 = System_Linq_Enumerable__Count_KeyValuePair_uint__object__
		                    (uVar1,iVar3,Method_System_Linq_Enumerable_Count_Fresco_Types_Cell___);
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0x18);
		  if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar2[2];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar2;
		    iVar4 = unnamed_function_1417(System_Func_FrescoCell__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar4,uVar5,
		               Method_Gameplay_Fresco_Model_FrescoModel___c__get_EmptyCellsCount_b__36_1__,0);
		    *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 8) = iVar4;
		  }
		  iVar4 = System_Linq_Enumerable__Count_KeyValuePair_uint__object__
		                    (uVar1,iVar4,Method_System_Linq_Enumerable_Count_FrescoCell___);
		  return iVar3 - iVar4;
		}
		*/


		/* --- GHIDRA: set_UniversalFragmentsCount ---
		uint Gameplay_Fresco_Model_FrescoModel__set_UniversalFragmentsCount(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x2c) != 0) {
		    iVar1 = Gameplay_Fresco_Model_FrescoModel__get_CanSelectUniversalFragment(param1,param1);
		    return (uint)(0 < iVar1);
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: get_CanInstallUniversalFragment ---
		uint Gameplay_Fresco_Model_FrescoModel__get_CanInstallUniversalFragment
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  uVar2 = *(uint *)(param1 + 0x2c);
		  iVar1 = Gameplay_Fresco_Model_FrescoModel__get_CanSelectUniversalFragment(param1,param1);
		  if ((longlong)(ulonglong)uVar2 < (longlong)iVar1) {
		    uVar2 = 0;
		  }
		  else {
		    iVar1 = Gameplay_Fresco_Model_FrescoModel__get_CanSelectUniversalFragment(param1,param1);
		    uVar2 = (uint)(*(int *)(*(int *)(param1 + 0x28) + 0xc) < iVar1);
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_OtherFrescoData ---
		undefined4 Gameplay_Fresco_Model_FrescoModel__get_OtherFrescoData(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57588 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_Fresco_Types_Cell___)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Func_Fresco_Types_Cell__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__get_KeyCell_b__53_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		    DAT_ram_00a57588 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0x34);
		  if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[3];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_Fresco_Types_Cell__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_00,param2_00,
		               Method_Gameplay_Fresco_Model_FrescoModel___c__get_KeyCell_b__53_0__,0);
		    *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 0xc) = param1_00;
		  }
		  uVar1 = System_Func_object__bool____ctor
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_FirstOrDefault_Fresco_Types_Cell___);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_KeyCell ---
		undefined4 Gameplay_Fresco_Model_FrescoModel__get_KeyCell(int param1,undefined4 param2)
		
		{
		  undefined4 *puVar1;
		  int param1_00;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57589 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_FrescoCell___);
		    Mono_Security_ASN1__get_Item(&System_Func_FrescoCell__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__get_KeyFrescoCell_b__55_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		    DAT_ram_00a57589 = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0x18);
		    if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		    }
		    puVar1 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		    param1_00 = puVar1[4];
		    if (param1_00 == 0) {
		      if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		        puVar1 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar1;
		      param1_00 = unnamed_function_1417(System_Func_FrescoCell__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (param1_00,param2_00,
		                 Method_Gameplay_Fresco_Model_FrescoModel___c__get_KeyFrescoCell_b__55_0__,0);
		      *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 0x10) = param1_00;
		    }
		    uVar2 = System_Func_object__bool____ctor
		                      (uVar2,param1_00,Method_System_Linq_Enumerable_FirstOrDefault_FrescoCell___);
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_KeyFrescoCell ---
		undefined4 Gameplay_Fresco_Model_FrescoModel__get_KeyFrescoCell(int param1,undefined4 param2)
		
		{
		  undefined4 *puVar1;
		  int param1_00;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5758a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_Fresco_Types_Cell___)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Func_Fresco_Types_Cell__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Model_FrescoModel___c__get_KeyDicFrescoCell_b__57_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		    DAT_ram_00a5758a = '\x01';
		  }
		  if (*(int *)(param1 + 0x1c) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0x34);
		    if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		    }
		    puVar1 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		    param1_00 = puVar1[5];
		    if (param1_00 == 0) {
		      if (*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo);
		        puVar1 = *(undefined4 **)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar1;
		      param1_00 = unnamed_function_1417(System_Func_Fresco_Types_Cell__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (param1_00,param2_00,
		                 Method_Gameplay_Fresco_Model_FrescoModel___c__get_KeyDicFrescoCell_b__57_0__,0);
		      *(int *)(*(int *)(Gameplay_Fresco_Model_FrescoModel___c_TypeInfo + 0x5c) + 0x14) = param1_00;
		    }
		    uVar2 = System_Func_object__bool____ctor
		                      (uVar2,param1_00,
		                       Method_System_Linq_Enumerable_FirstOrDefault_Fresco_Types_Cell___);
		  }
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_KeyDicFrescoCell ---
		uint Gameplay_Fresco_Model_FrescoModel__get_KeyDicFrescoCell(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = Gameplay_Fresco_Model_FrescoModel__get_OtherFrescoData(param1,param1);
		  return (uint)(iVar1 != 0);
		}
		*/


		/* --- GHIDRA: set_Owner ---
		uint Gameplay_Fresco_Model_FrescoModel__set_Owner(int param1,undefined4 param2)
		
		{
		  return (uint)(*(int *)(param1 + 8) == *(int *)(param1 + 0x38));
		}
		*/


		/* --- GHIDRA: get_IsOwn ---
		uint Gameplay_Fresco_Model_FrescoModel__get_IsOwn
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = Gameplay_Fresco_Model_FrescoModel__HasAvailableCells(param1,param2,param2);
		  return (uint)(*(int *)(iVar1 + 0xc) != 0);
		}
		*/

}
