using System;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Gameplay.Billing.BillingProvider;
using Il2CppDummyDll;

namespace Gameplay.Billing.Model
{
	// Token: 0x02000BE8 RID: 3048
	[Token(Token = "0x2000BE8")]
	public class HvBillingModel : AbstractBillingModel
	{
		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06004AD4 RID: 19156 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
		[Token(Token = "0x17000F1F")]
		public override bool IsPurchasesAvailable
		{
			[Token(Token = "0x6004AD4")]
			[Address(RVA = "0x9931", Offset = "0x9931", VA = "0x9931", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06004AD5 RID: 19157 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		[Token(Token = "0x17000F20")]
		public override bool IsBalanceSupported
		{
			[Token(Token = "0x6004AD5")]
			[Address(RVA = "0x9932", Offset = "0x9932", VA = "0x9932", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD6")]
		[Address(RVA = "0x9933", Offset = "0x9933", VA = "0x9933")]
		public HvBillingModel(IDictProvider dictProvider, IAuthTokenSource authTokenSource, IBillingProvider provider, IGame game, UserData user)
		{
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD7")]
		[Address(RVA = "0x9934", Offset = "0x9934", VA = "0x9934", Slot = "10")]
		protected override void HandleInit()
		{
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
		[Token(Token = "0x6004AD8")]
		[Address(RVA = "0x9935", Offset = "0x9935", VA = "0x9935", Slot = "9")]
		public override bool IsOptionValid(string id)
		{
		/* --- GHIDRA: IsOptionValid ---
		undefined4
		Gameplay_Billing_Model_HvBillingModel__IsOptionValid(int param1,int param2,undefined4 param3)
		
		{
		  float8 param2_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  float8 local_8;
		  
		  if (DAT_ram_00a60913 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankOptionData_ExtPriceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a60913 = '\x01';
		  }
		  local_8 = (float8)Core_Extensions_Dict_AssistantDictExt__GetDescriptionActive
		                              (*(undefined4 *)(param2 + 0x38),
		                               *(undefined4 *)(*(int *)(param1 + 0xc) + 0xc),0);
		  uVar1 = func_ii_7515(&local_8,0);
		  uVar2 = Core_Extensions_Dict_CultRatingKindDicExt__GetDescription(*(undefined4 *)(param1 + 0xc),0)
		  ;
		  uVar2 = Core_Extensions_StringExt__Replacer(uVar2,(double)local_8,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar1,StringLiteral_118,uVar2,0);
		  param2_00 = local_8;
		  uVar2 = unnamed_function_1417(Gameplay_Bank_Model_BankOptionData_ExtPriceData_TypeInfo);
		  Gameplay_Bank_Model_BankOptionData__Create(uVar2,(double)param2_00,(double)param2_00,uVar1,0);
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004AD9")]
		[Address(RVA = "0x9936", Offset = "0x9936", VA = "0x9936", Slot = "8")]
		public override BankOptionData.ExtPriceData GetExtPriceData(BankOptionData data)
		{
			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsBalanceSupported ---
		void Gameplay_Billing_Model_HvBillingModel__get_IsBalanceSupported
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60907 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_List_string____ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Queue_List_string___TypeInfo);
		    DAT_ram_00a60907 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Queue_List_string___TypeInfo);
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (param1_00,Method_System_Collections_Generic_Queue_List_string____ctor__);
		  *(undefined4 *)(param1 + 0x2c) = param1_00;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param6,0);
		  *(undefined4 *)(param1 + 0x30) = param4;
		  *(undefined4 *)(param1 + 0x28) = param3;
		  *(undefined4 *)(param1 + 0x34) = param2;
		  *(undefined4 *)(param1 + 0x10) = param5;
		  Gameplay_Billing_Model_AbstractBillingModel___ctor(param1,param1);
		  return;
		}
		*/

}
