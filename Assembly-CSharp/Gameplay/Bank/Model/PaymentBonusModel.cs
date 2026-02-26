using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Services;
using Utils;

namespace Gameplay.Bank.Model
{
	// Token: 0x02000C5D RID: 3165
	[Token(Token = "0x2000C5D")]
	public class PaymentBonusModel : AbstractModel
	{
		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06004D4A RID: 19786 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D4B RID: 19787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FA7")]
		public BackTime CurrentBackime
		{
			[Token(Token = "0x6004D4A")]
			[Address(RVA = "0x9B83", Offset = "0x9B83", VA = "0x9B83")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D4B")]
			[Address(RVA = "0x9B84", Offset = "0x9B84", VA = "0x9B84")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06004D4C RID: 19788 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D4D RID: 19789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FA8")]
		public PaymentBonusesDic CurrentPaymentBonusesDic
		{
			[Token(Token = "0x6004D4C")]
			[Address(RVA = "0x9B85", Offset = "0x9B85", VA = "0x9B85")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D4D")]
			[Address(RVA = "0x9B86", Offset = "0x9B86", VA = "0x9B86")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06004D4E RID: 19790 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D4F RID: 19791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FA9")]
		public RepeatedField<RewardInfo> CurrentRewards
		{
			[Token(Token = "0x6004D4E")]
			[Address(RVA = "0x9B87", Offset = "0x9B87", VA = "0x9B87")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D4F")]
			[Address(RVA = "0x9B88", Offset = "0x9B88", VA = "0x9B88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06004D50 RID: 19792 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		[Token(Token = "0x17000FAA")]
		public bool IsBonusValid
		{
			[Token(Token = "0x6004D50")]
			[Address(RVA = "0x9B89", Offset = "0x9B89", VA = "0x9B89")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004D51 RID: 19793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D51")]
		[Address(RVA = "0x9B8A", Offset = "0x9B8A", VA = "0x9B8A")]
		public PaymentBonusModel(UserData user)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_Model_PaymentBonusModel___ctor(int param1,int param2,undefined4 param3)
		
		{
		  float param2_00;
		  undefined4 param1_00;
		  uint *puVar1;
		  undefined4 uVar2;
		  int *param1_01;
		  int iVar3;
		  ulonglong param1_02;
		  uint uVar4;
		  
		  if (DAT_ram_00a597d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a597d5 = '\x01';
		  }
		  param1_02 = (ulonglong)*(uint *)(param2 + 0x10);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331(param1_02,0);
		  uVar2 = (undefined4)(param1_02 >> 0x20);
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x8106fedf;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8106fedf:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(CONCAT44(uVar2,param1_01),puVar1[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetCurrenciesDic(uVar2,*(undefined4 *)(param2 + 0xc),0);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  *(undefined4 *)(param1 + 0x14) = *(undefined4 *)(param2 + 0x14);
		  return;
		}
		*/

		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D52")]
		[Address(RVA = "0x9B8B", Offset = "0x9B8B", VA = "0x9B8B")]
		public void SetCurrentBonus(ProtoGetPaymentBonusAns result)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CurrentRewards ---
		uint Gameplay_Bank_Model_PaymentBonusModel__set_CurrentRewards(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  
		  if (*(int *)(param1 + 0x10) != 0) {
		    fVar1 = func_ii_7103(*(undefined4 *)(param1 + 0xc),0);
		    return (uint)(0.0 < fVar1);
		  }
		  return 0;
		}
		*/

}
