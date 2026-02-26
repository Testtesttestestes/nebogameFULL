using System;
using System.Runtime.CompilerServices;
using Core.Dict;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Common;
using Protocol.Services;

namespace Gameplay.EndlessPaymentOptionsList.Model
{
	// Token: 0x02000843 RID: 2115
	[Token(Token = "0x2000843")]
	public class CardData
	{
		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x0000A1E8 File Offset: 0x000083E8
		// (set) Token: 0x060031BC RID: 12732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D1")]
		public bool IsComplete
		{
			[Token(Token = "0x60031BB")]
			[Address(RVA = "0x8212", Offset = "0x8212", VA = "0x8212")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60031BC")]
			[Address(RVA = "0x8213", Offset = "0x8213", VA = "0x8213")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031BD")]
		[Address(RVA = "0x8214", Offset = "0x8214", VA = "0x8214")]
		public CardData(bool permanentlyLock, EndlessPaymentOptionData option, EndlessPaymentOptionListData list, ProtoGetEndlessPaymentOptionsAns.Types.EndlessPaymentOptionInfo info, IDictProvider dictProvider)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_EndlessPaymentOptionsList_Model_CardData___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57643 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_RewardInfo___);
		    DAT_ram_00a57643 = '\x01';
		  }
		  uVar1 = func_ii_6295(*(undefined4 *)(*(int *)(param1 + 0x1c) + 0x14),
		                       Method_System_Linq_Enumerable_ToArray_RewardInfo___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060031BE RID: 12734 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60031BE")]
		[Address(RVA = "0x8215", Offset = "0x8215", VA = "0x8215")]
		public RewardInfo[] GetRewards()
		{
		/* --- GHIDRA: GetRewards ---
		void Gameplay_EndlessPaymentOptionsList_Model_CardData__GetRewards(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(*(int *)(param1 + 0x1c) + 0x10) = 1;
		  *(undefined1 *)(param1 + 0x20) = 1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031BF")]
		[Address(RVA = "0x8216", Offset = "0x8216", VA = "0x8216")]
		public void SetupPurchased()
		{
		/* --- GHIDRA: SetupPurchased ---
		void Gameplay_EndlessPaymentOptionsList_Model_CardData__SetupPurchased
		               (int param1,int param2,undefined4 param3)
		
		{
		  *(int *)(param1 + 0x1c) = param2;
		  if (*(char *)(param2 + 0x10) != '\0') {
		    *(undefined1 *)(param2 + 0x10) = 1;
		    *(undefined1 *)(param1 + 0x20) = 1;
		    return;
		  }
		  *(undefined1 *)(param1 + 0x20) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C0")]
		[Address(RVA = "0x8217", Offset = "0x8217", VA = "0x8217")]
		public void Update(ProtoGetEndlessPaymentOptionsAns.Types.EndlessPaymentOptionInfo info)
		{
		/* --- GHIDRA: Update ---
		undefined4 Gameplay_EndlessPaymentOptionsList_Model_CardData__Update(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined1 local_6;
		  undefined1 local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57644 == '\0') {
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19447);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12034);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11567);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9838);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5077);
		    DAT_ram_00a57644 = '\x01';
		  }
		  param1_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,5);
		  *(undefined4 *)(param1_00 + 0x10) = StringLiteral_5077;
		  local_4 = Com_TheFallenGames_OSA_Core_OSA_object__object___get_Parameters
		                      (*(undefined4 *)(param1 + 0x10),0);
		  uVar1 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar1 = func_ii_4419(StringLiteral_12034,uVar1,0);
		  *(undefined4 *)(param1_00 + 0x14) = uVar1;
		  local_5 = *(undefined1 *)(param1 + 0x20);
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_5);
		  uVar1 = func_ii_4419(StringLiteral_9838,uVar1,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  local_6 = *(undefined1 *)(*(int *)(param1 + 0x1c) + 0x10);
		  uVar1 = func_ii_1081(DAT_ram_00a66944,&local_6);
		  uVar1 = func_ii_4419(StringLiteral_19447,uVar1,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  uVar1 = func_ii_4419(StringLiteral_11567,*(undefined4 *)(param1 + 0xc),0);
		  *(undefined4 *)(param1_00 + 0x20) = uVar1;
		  uVar1 = System_Single__ToString(param1_00,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60031C1")]
		[Address(RVA = "0x8218", Offset = "0x8218", VA = "0x8218", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001B44 RID: 6980
		[Token(Token = "0x4001B44")]
		[FieldOffset(Offset = "0x8")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04001B45 RID: 6981
		[Token(Token = "0x4001B45")]
		[FieldOffset(Offset = "0xC")]
		public readonly CardData.CardNode Node;

		// Token: 0x04001B46 RID: 6982
		[Token(Token = "0x4001B46")]
		[FieldOffset(Offset = "0x10")]
		public readonly EndlessPaymentOptionData Option;

		// Token: 0x04001B47 RID: 6983
		[Token(Token = "0x4001B47")]
		[FieldOffset(Offset = "0x14")]
		public readonly EndlessPaymentOptionListData List;

		// Token: 0x04001B48 RID: 6984
		[Token(Token = "0x4001B48")]
		[FieldOffset(Offset = "0x18")]
		public readonly bool PermanentlyLock;

		// Token: 0x04001B49 RID: 6985
		[Token(Token = "0x4001B49")]
		[FieldOffset(Offset = "0x1C")]
		private ProtoGetEndlessPaymentOptionsAns.Types.EndlessPaymentOptionInfo _info;

		// Token: 0x02000844 RID: 2116
		[Token(Token = "0x2000844")]
		public class CardNode
		{
			// Token: 0x170009D2 RID: 2514
			// (get) Token: 0x060031C2 RID: 12738 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060031C3 RID: 12739 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009D2")]
			[CanBeNull]
			public CardData Prev
			{
				[Token(Token = "0x60031C2")]
				[Address(RVA = "0x8219", Offset = "0x8219", VA = "0x8219")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60031C3")]
				[Address(RVA = "0x821A", Offset = "0x821A", VA = "0x821A")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170009D3 RID: 2515
			// (get) Token: 0x060031C4 RID: 12740 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060031C5 RID: 12741 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009D3")]
			[CanBeNull]
			public CardData Next
			{
				[Token(Token = "0x60031C4")]
				[Address(RVA = "0x821B", Offset = "0x821B", VA = "0x821B")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60031C5")]
				[Address(RVA = "0x821C", Offset = "0x821C", VA = "0x821C")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060031C6 RID: 12742 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031C6")]
			[Address(RVA = "0x821D", Offset = "0x821D", VA = "0x821D")]
			public void Reset()
			{
			}

			// Token: 0x060031C7 RID: 12743 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60031C7")]
			[Address(RVA = "0x821E", Offset = "0x821E", VA = "0x821E", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x060031C8 RID: 12744 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031C8")]
			[Address(RVA = "0x821F", Offset = "0x821F", VA = "0x821F")]
			public CardNode()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsComplete ---
		void Gameplay_EndlessPaymentOptionsList_Model_CardData__set_IsComplete
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57642 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_EndlessPaymentOptionsList_Model_CardData_CardNode_TypeInfo);
		    DAT_ram_00a57642 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_EndlessPaymentOptionsList_Model_CardData_CardNode_TypeInfo)
		  ;
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  *(undefined4 *)(param1 + 0x1c) = param5;
		  *(undefined4 *)(param1 + 0x14) = param4;
		  *(undefined4 *)(param1 + 0x10) = param3;
		  *(undefined1 *)(param1 + 0x18) = (undefined1)param2;
		  *(undefined4 *)(param1 + 8) = param6;
		  return;
		}
		*/

}
