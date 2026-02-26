using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Chat;
using Utils;

namespace Gameplay.Chat.Model.Data
{
	// Token: 0x02000B10 RID: 2832
	[Token(Token = "0x2000B10")]
	public class ChatBanData : IDisposable
	{
		// Token: 0x0600444E RID: 17486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444E")]
		[Address(RVA = "0x92FE", Offset = "0x92FE", VA = "0x92FE", Slot = "1")]
		protected override void Finalize()
		{
		/* --- GHIDRA: Finalize ---
		void Gameplay_Chat_Model_Data_ChatBanData__Finalize(int param1,int param2,undefined4 param3)
		
		{
		  float param2_00;
		  undefined4 param1_00;
		  undefined8 param1_01;
		  
		  if (DAT_ram_00a57b4e == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a57b4e = '\x01';
		  }
		  *(int *)(param1 + 0xc) = param2;
		  param1_01 = *(undefined8 *)(param2 + 0x10);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331(param1_01,0);
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x0600444F RID: 17487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600444F")]
		[Address(RVA = "0x92FF", Offset = "0x92FF", VA = "0x92FF")]
		public ChatBanData(ChatUserInfo.Types.BanInfo banInfo)
		{
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06004450 RID: 17488 RVA: 0x0000CE10 File Offset: 0x0000B010
		// (set) Token: 0x06004451 RID: 17489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D75")]
		public float FixTime
		{
			[Token(Token = "0x6004450")]
			[Address(RVA = "0x9300", Offset = "0x9300", VA = "0x9300")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004451")]
			[Address(RVA = "0x9301", Offset = "0x9301", VA = "0x9301")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06004452 RID: 17490 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004453 RID: 17491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D76")]
		public ChatUserInfo.Types.BanInfo BanInfo
		{
			[Token(Token = "0x6004452")]
			[Address(RVA = "0x9302", Offset = "0x9302", VA = "0x9302")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004453")]
			[Address(RVA = "0x9303", Offset = "0x9303", VA = "0x9303")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06004454 RID: 17492 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004455 RID: 17493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D77")]
		public BackTime Backtime
		{
			[Token(Token = "0x6004454")]
			[Address(RVA = "0x9304", Offset = "0x9304", VA = "0x9304")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004455")]
			[Address(RVA = "0x9305", Offset = "0x9305", VA = "0x9305")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004456")]
		[Address(RVA = "0x9306", Offset = "0x9306", VA = "0x9306", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
