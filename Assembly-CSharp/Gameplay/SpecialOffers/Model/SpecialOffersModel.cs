using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using Protocol.Services;

namespace Gameplay.SpecialOffers.Model
{
	// Token: 0x02000504 RID: 1284
	[Token(Token = "0x2000504")]
	public class SpecialOffersModel : OptionsOfferModel
	{
		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059A")]
		public override List<BankOptionData> Offers
		{
			[Token(Token = "0x6001EAA")]
			[Address(RVA = "0x701D", Offset = "0x701D", VA = "0x701D", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EAB")]
			[Address(RVA = "0x701E", Offset = "0x701E", VA = "0x701E", Slot = "7")]
			protected set
			{
			}
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EAC")]
		[Address(RVA = "0x701F", Offset = "0x701F", VA = "0x701F")]
		public SpecialOffersModel(UserData user, IList<uint> optionIds, IGame game)
		{
		/* --- GHIDRA: <ConstructOption>g__CreateRewards|13_1 ---
		void Gameplay_SpecialOffers_Model_SpecialOffersModel___ConstructOption_g__CreateRewards_13_1
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5863a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo);
		    DAT_ram_00a5863a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <ConstructOption>g__AddRewards|13_0 ---
		void Gameplay_SpecialOffers_Model_SpecialOffersModel___ConstructOption_g__AddRewards_13_0
		               (undefined4 *param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58639 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Services_OptionRewards_TypeInfo);
		    DAT_ram_00a58639 = '\x01';
		  }
		  param1_01 = *param1;
		  param1_00 = unnamed_function_1417(Protocol_Services_OptionRewards_TypeInfo);
		  Protocol_Services_OptionRewards__pb__Google_Protobuf_IMessage_get_Descriptor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0xc) = *(undefined4 *)(param1[1] + 0xc);
		  Gameplay_Bank_Model_BankOptionData__get_OptionRewards(param1_01,param1_00,0);
		  return;
		}
		*/

		/* --- GHIDRA: <get_Offers>b__4_0 ---
		void Gameplay_SpecialOffers_Model_SpecialOffersModel___get_Offers_b__4_0
		               (int *param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58638 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__AddRange__);
		    DAT_ram_00a58638 = '\x01';
		  }
		  Google_Protobuf_Collections_RepeatedField_object___AddEntriesFrom
		            (*(undefined4 *)(*(int *)(*param1 + 0x3c) + 0x10),*(undefined4 *)(param1[1] + 0x10),
		             Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__AddRange__);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_SpecialOffers_Model_SpecialOffersModel___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58633 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionData__get_Count__);
		    DAT_ram_00a58633 = '\x01';
		  }
		  if ((char)param1[8] == '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xf4));
		    uVar2 = *(undefined4 *)(iVar1 + 0xc);
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_SpecialOffers_Model_SpecialOffersModel___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58633 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionData__get_Count__);
		    DAT_ram_00a58633 = '\x01';
		  }
		  if ((char)param1[8] == '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xf4));
		    uVar2 = *(undefined4 *)(iVar1 + 0xc);
		  }
		  else {
		    uVar2 = 0;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EAD")]
		[Address(RVA = "0x7020", Offset = "0x7020", VA = "0x7020")]
		public SpecialOffersModel(UserData user, IGame game)
		{
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x00006528 File Offset: 0x00004728
		[Token(Token = "0x1700059B")]
		public int UnseenOptionsCount
		{
			[Token(Token = "0x6001EAE")]
			[Address(RVA = "0x7021", Offset = "0x7021", VA = "0x7021")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EAF")]
		[Address(RVA = "0x7022", Offset = "0x7022", VA = "0x7022", Slot = "8")]
		protected override void PopulateOptions(IList<uint> optionIds, BankModel bankModel)
		{
		/* --- GHIDRA: PopulateOptions ---
		undefined4
		Gameplay_SpecialOffers_Model_SpecialOffersModel__PopulateOptions
		          (int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  float param2_00;
		  undefined8 param1_00;
		  undefined8 local_8;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a58636 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a58636 = '\x01';
		  }
		  local_8 = (ulonglong)param2 << 0x20;
		  iVar1 = func_ii_6875(*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param2 + 0xc),&local_8,0);
		  if (iVar1 != 0) {
		    if (DAT_ram_00a58639 == '\0') {
		      Mono_Security_ASN1__get_Item(&Protocol_Services_OptionRewards_TypeInfo);
		      DAT_ram_00a58639 = '\x01';
		    }
		    uVar2 = (int)local_8;
		    iVar1 = unnamed_function_1417(Protocol_Services_OptionRewards_TypeInfo);
		    Protocol_Services_OptionRewards__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    *(undefined4 *)(iVar1 + 0xc) = *(undefined4 *)(local_8._4_4_ + 0xc);
		    Gameplay_Bank_Model_BankOptionData__get_OptionRewards(uVar2,iVar1,0);
		    if (DAT_ram_00a58638 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__AddRange__);
		      DAT_ram_00a58638 = '\x01';
		    }
		    Google_Protobuf_Collections_RepeatedField_object___AddEntriesFrom
		              (*(undefined4 *)(*(int *)((int)local_8 + 0x3c) + 0x10),
		               *(undefined4 *)(local_8._4_4_ + 0x10),
		               Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__AddRange__);
		    iVar1 = (int)local_8;
		    uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,0.0,0);
		    param1_00 = *(undefined8 *)(local_8._4_4_ + 0x18);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = Utils_StringUtils___cctor(param1_00,0);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,param2_00,0);
		    *(undefined4 *)(iVar1 + 0x58) = uVar2;
		    uVar2 = (int)local_8;
		  }
		  return uVar2;
		}
		*/

		/* --- GHIDRA: PopulateOptions ---
		undefined4
		Gameplay_SpecialOffers_Model_SpecialOffersModel__PopulateOptions
		          (int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  float param2_00;
		  undefined8 param1_00;
		  undefined8 local_8;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a58636 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a58636 = '\x01';
		  }
		  local_8 = (ulonglong)param2 << 0x20;
		  iVar1 = func_ii_6875(*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param2 + 0xc),&local_8,0);
		  if (iVar1 != 0) {
		    if (DAT_ram_00a58639 == '\0') {
		      Mono_Security_ASN1__get_Item(&Protocol_Services_OptionRewards_TypeInfo);
		      DAT_ram_00a58639 = '\x01';
		    }
		    uVar2 = (int)local_8;
		    iVar1 = unnamed_function_1417(Protocol_Services_OptionRewards_TypeInfo);
		    Protocol_Services_OptionRewards__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    *(undefined4 *)(iVar1 + 0xc) = *(undefined4 *)(local_8._4_4_ + 0xc);
		    Gameplay_Bank_Model_BankOptionData__get_OptionRewards(uVar2,iVar1,0);
		    if (DAT_ram_00a58638 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__AddRange__);
		      DAT_ram_00a58638 = '\x01';
		    }
		    Google_Protobuf_Collections_RepeatedField_object___AddEntriesFrom
		              (*(undefined4 *)(*(int *)((int)local_8 + 0x3c) + 0x10),
		               *(undefined4 *)(local_8._4_4_ + 0x10),
		               Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__AddRange__);
		    iVar1 = (int)local_8;
		    uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,0.0,0);
		    param1_00 = *(undefined8 *)(local_8._4_4_ + 0x18);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = Utils_StringUtils___cctor(param1_00,0);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,param2_00,0);
		    *(undefined4 *)(iVar1 + 0x58) = uVar2;
		    uVar2 = (int)local_8;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB0")]
		[Address(RVA = "0x7023", Offset = "0x7023", VA = "0x7023", Slot = "9")]
		public override void RemoveOption(BankOptionData data)
		{
		/* --- GHIDRA: RemoveOption ---
		void Gameplay_SpecialOffers_Model_SpecialOffersModel__RemoveOption
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58635 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ProtoGetSpecialOfferAns_Types_SpecialOfferInfo__BankOptionData___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_BankOptionData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_BankOptionData___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ProtoGetSpecialOfferAns_Types_SpecialOfferInfo__BankOptionData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_BankOptionData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SpecialOffers_Model_SpecialOffersModel_ConstructOption__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Model_SpecialOffersModel___c__PopulateOptions_b__12_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo);
		    DAT_ram_00a58635 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_ProtoGetSpecialOfferAns_Types_SpecialOfferInfo__BankOptionData__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_SpecialOffers_Model_SpecialOffersModel_ConstructOption__,0
		            );
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ProtoGetSpecialOfferAns_Types_SpecialOfferInfo__BankOptionData___
		                    );
		  if (*(int *)(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[2];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo + 0x5c)
		      ;
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_BankOptionData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_00,param2_00,
		               Method_Gameplay_SpecialOffers_Model_SpecialOffersModel___c__PopulateOptions_b__12_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_SpecialOffers_Model_SpecialOffersModel___c_TypeInfo + 0x5c) + 8) =
		         param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,param1_00,Method_System_Linq_Enumerable_Where_BankOptionData___);
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,Method_System_Linq_Enumerable_ToList_BankOptionData___);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		            (param1,uVar1,*(undefined4 *)(*param1 + 0xfc));
		  return;
		}
		*/

		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB1")]
		[Address(RVA = "0x7024", Offset = "0x7024", VA = "0x7024")]
		public void PopulateOptions(IEnumerable<ProtoGetSpecialOfferAns.Types.SpecialOfferInfo> specialOffers)
		{
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001EB2")]
		[Address(RVA = "0x7025", Offset = "0x7025", VA = "0x7025")]
		private BankOptionData ConstructOption(ProtoGetSpecialOfferAns.Types.SpecialOfferInfo info)
		{
		/* --- GHIDRA: ConstructOption ---
		undefined4
		Gameplay_SpecialOffers_Model_SpecialOffersModel__ConstructOption
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  float fVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a58637 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_IOptionValidator_TypeInfo);
		    DAT_ram_00a58637 = '\x01';
		  }
		  fVar2 = func_ii_7103(*(undefined4 *)(param2 + 0x58),0);
		  if (0.0 < fVar2) {
		    param1_00 = *(int **)(param1 + 0x14);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Bank_Model_IOptionValidator_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f17368;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Gameplay_Bank_Model_IOptionValidator_TypeInfo,0);
		code_r0x80f17368:
		    uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,param2,puVar3[1]);
		  }
		  else {
		    uVar5 = 0;
		  }
		  return uVar5;
		}
		*/

			return null;
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB4")]
		[Address(RVA = "0x7027", Offset = "0x7027", VA = "0x7027")]
		[CompilerGenerated]
		internal static void <ConstructOption>g__AddRewards|13_0(ref SpecialOffersModel.<>c__DisplayClass13_0 A_0)
		{
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB5")]
		[Address(RVA = "0x7028", Offset = "0x7028", VA = "0x7028")]
		[CompilerGenerated]
		internal static void <ConstructOption>g__CreateRewards|13_1(ref SpecialOffersModel.<>c__DisplayClass13_0 A_0)
		{
		}

		// Token: 0x040010A8 RID: 4264
		[Token(Token = "0x40010A8")]
		[FieldOffset(Offset = "0x20")]
		public bool OptionsViewed;

		// Token: 0x040010A9 RID: 4265
		[Token(Token = "0x40010A9")]
		[FieldOffset(Offset = "0x24")]
		private BankModel _bankModel;

		// Token: 0x040010AA RID: 4266
		[Token(Token = "0x40010AA")]
		[FieldOffset(Offset = "0x28")]
		private readonly int _maxOffersCount;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Offers ---
		void Gameplay_SpecialOffers_Model_SpecialOffersModel__set_Offers
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58632 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_27342);
		    DAT_ram_00a58632 = '\x01';
		  }
		  Gameplay_SpecialOffers_Model_OptionsOfferModel__set_Offers(param1,param2,param3,param4,param4);
		  if (DAT_ram_00a5862d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a5862d = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80f16ee4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f16ee4:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar3,StringLiteral_27342,0);
		  *(undefined4 *)(param1 + 0x28) = uVar3;
		  return;
		}
		*/


		/* --- GHIDRA: get_UnseenOptionsCount ---
		void Gameplay_SpecialOffers_Model_SpecialOffersModel__get_UnseenOptionsCount
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0x24) = param3;
		  return;
		}
		*/

}
