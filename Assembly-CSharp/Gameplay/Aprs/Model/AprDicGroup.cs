using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Aprs.Model
{
	// Token: 0x02000D62 RID: 3426
	[Token(Token = "0x2000D62")]
	public class AprDicGroup
	{
		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x060053FC RID: 21500 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001114")]
		public SortedList<uint, MedalDicWrapper> MedalsByCollectionRank
		{
			[Token(Token = "0x60053FC")]
			[Address(RVA = "0xA1B4", Offset = "0xA1B4", VA = "0xA1B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x060053FD RID: 21501 RVA: 0x0000F288 File Offset: 0x0000D488
		[Token(Token = "0x17001115")]
		public uint CategoryId
		{
			[Token(Token = "0x60053FD")]
			[Address(RVA = "0xA1B5", Offset = "0xA1B5", VA = "0xA1B5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x060053FE RID: 21502 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		// (set) Token: 0x060053FF RID: 21503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001116")]
		public uint CollectionId
		{
			[Token(Token = "0x60053FE")]
			[Address(RVA = "0xA1B6", Offset = "0xA1B6", VA = "0xA1B6")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60053FF")]
			[Address(RVA = "0xA1B7", Offset = "0xA1B7", VA = "0xA1B7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06005400 RID: 21504 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		// (set) Token: 0x06005401 RID: 21505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001117")]
		public bool IsVisible
		{
			[Token(Token = "0x6005400")]
			[Address(RVA = "0xA1B8", Offset = "0xA1B8", VA = "0xA1B8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005401")]
			[Address(RVA = "0xA1B9", Offset = "0xA1B9", VA = "0xA1B9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005402 RID: 21506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005402")]
		[Address(RVA = "0xA1BA", Offset = "0xA1BA", VA = "0xA1BA")]
		public void AddMedal(MedalDicWrapper medal, MedalCategoryDic categoryDic, MedalTypeDic typeDic)
		{
		/* --- GHIDRA: AddMedal ---
		undefined4 Gameplay_Aprs_Model_AprDicGroup__AddMedal(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5943a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDicWrapper__get_Item__);
		    DAT_ram_00a5943a = '\x01';
		  }
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1 + 0xc),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__MedalDicWrapper__get_Item__)
		  ;
		  return uVar1;
		}
		*/

		}

		// Token: 0x06005403 RID: 21507 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005403")]
		[Address(RVA = "0xA1BB", Offset = "0xA1BB", VA = "0xA1BB")]
		public MedalDicWrapper GetMedalDicById(uint medalId)
		{
			return null;
		}

		// Token: 0x06005404 RID: 21508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005404")]
		[Address(RVA = "0x1E3B", Offset = "0x1E3B", VA = "0x1E3B")]
		public AprDicGroup()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Aprs_Model_AprDicGroup___ctor
		               (int param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param3_00;
		  undefined4 local_4;
		  
		  uVar1 = System_Collections_Generic_SortedList_int__object___Insert
		                    (*(undefined4 *)(param1 + 8),0,*(undefined4 *)(param1 + 0x10),param2,
		                     *(undefined4 *)(param1 + 0x18),
		                     *(undefined4 *)(*(int *)(*(int *)(param4 + 0x10) + 0x60) + 0x2c));
		  if ((int)uVar1 < 0) {
		    System_Array__BinarySearch_uint_
		              (param1,uVar1 ^ 0xffffffff,param2,param3,
		               *(undefined4 *)(*(int *)(*(int *)(param4 + 0x10) + 0x60) + 0x34));
		    return;
		  }
		  local_4 = param2;
		  uVar2 = func_ii_1081(*(undefined4 *)(*(int *)(*(int *)(param4 + 0x10) + 0x60) + 0x28),&local_4);
		  uVar3 = unnamed_function_2232(&StringLiteral_3097);
		  uVar2 = func_ii_11463(uVar3,uVar2,0);
		  uVar3 = unnamed_function_2232(&System_ArgumentException_TypeInfo);
		  uVar3 = unnamed_function_1417(uVar3);
		  param3_00 = unnamed_function_2232(&StringLiteral_24954);
		  System_IO_EndOfStreamException___ctor(uVar3,uVar2,param3_00,0);
		  func_ii_1050(uVar3,param4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04002D7E RID: 11646
		[Token(Token = "0x4002D7E")]
		[FieldOffset(Offset = "0x8")]
		private SortedList<uint, MedalDicWrapper> _medalsByCollectionRank;

		// Token: 0x04002D7F RID: 11647
		[Token(Token = "0x4002D7F")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<uint, MedalDicWrapper> _medalsById;

		// Token: 0x04002D80 RID: 11648
		[Token(Token = "0x4002D80")]
		[FieldOffset(Offset = "0x10")]
		private MedalCategoryDic _medalCategoryDic;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsVisible ---
		void Gameplay_Aprs_Model_AprDicGroup__set_IsVisible
		               (int param1,int param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined1 uVar1;
		  
		  if (DAT_ram_00a59439 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDicWrapper__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__Add__);
		    DAT_ram_00a59439 = '\x01';
		  }
		  Gameplay_Aprs_Model_AprDicGroup___ctor
		            (*(undefined4 *)(param1 + 8),*(undefined4 *)(*(int *)(param2 + 0x10) + 0x38),param2,
		             Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__Add__);
		  System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		            (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(*(int *)(param2 + 0x10) + 0xc),param2,
		             Method_System_Collections_Generic_Dictionary_uint__MedalDicWrapper__Add__);
		  *(undefined4 *)(param1 + 0x14) = *(undefined4 *)(*(int *)(param2 + 0x10) + 0x34);
		  uVar1 = *(undefined1 *)(param3 + 0x10);
		  *(int *)(param1 + 0x10) = param3;
		  *(undefined1 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

}
